using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design
{
    public partial class Class : Form
    {
        private frmDashBoard _dashboard;
        private int _classId;
        private string conString = "server=localhost;database=edutask;uid=edutask_app;pwd=Ralfh_Leo_Sheky_Cholo2025!";


        private List<(int id, string name)> positions = new List<(int, string)>();
        private int currentPositionIndex = 0;
        private int _maxStudents = 0;

        public Class(int classId, frmDashBoard dashboard)
        {
            InitializeComponent();
            _classId = classId;
            _dashboard = dashboard;

            lblUsername.Text = GetInfo.Username;

            panelVoting.Visible = false;
            panelResults.Visible = false;
            panelStatus.Visible = true;

            lblStatusMessage.Text = "Waiting for all students to join…";
            LoadPositions();
            LoadClassInfo();

            timerCheckStudents.Interval = 1000;
            timerCheckStudents.Tick += timerCheckStudents_Tick;
            timerCheckStudents.Start();

        }
        private bool panelIsExpanded = false;
        private int panelMaxWidth = 200;
        private int slideSpeed = 10;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Class_Load(object sender, EventArgs e)
        {
            LoadPositions();
            LoadClassInfo();
            SetupAnnouncementPosting();
            dgvCandidates.SelectionChanged += dgvCandidates_SelectionChanged;

            timerCheckStudents.Tick += timerCheckStudents_Tick;
            timerCheckStudents.Interval = 1000;
            timerCheckStudents.Start();

            timerCheckVotes.Tick += timerCheckVotes_Tick;
            timerCheckVotes.Interval = 1000;

            SetPlaceholderText();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (panelIsExpanded == false)
            {
                panel1.Visible = true;
                int distance = panelMaxWidth - panel1.Width;
                int dynamicSpeed = Math.Max(2, distance / 4);
                panel1.Width += dynamicSpeed;

                if (panel1.Width >= panelMaxWidth)
                {
                    panel1.Width = panelMaxWidth;
                    panelIsExpanded = true;
                    timer1.Stop();
                }
            }
            else
            {
                panel1.Width -= slideSpeed;

                if (panel1.Width <= 0)
                {
                    panel1.Width = 0;
                    panel1.Visible = false;
                    panelIsExpanded = false;
                    timer1.Stop();
                }
            }
        }


        private void LoadClassInfo()
        {
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                string query = @"SELECT c.class_name, c.class_code, c.max_students, u.username AS adviser
                         FROM classes c
                         LEFT JOIN users u ON c.adviser_id = u.user_id
                         WHERE c.class_id = @cid";

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@cid", _classId);
                    using (var rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            lblClassName.Text = rd.GetString("class_name");
                            lblClassCode.Text = rd.GetString("class_code");
                            lblAdviser.Text = rd.IsDBNull(rd.GetOrdinal("adviser")) ? "Student-created" : rd.GetString("adviser");
                            _maxStudents = rd.GetInt32("max_students");
                        }
                    }
                }
            }
        }


        private void LoadPositions()
        {

            positions = new List<(int id, string name)>
            {
                (1, "President"),
                (2, "Vice President"),
                (3, "Secretary"),
                (4, "Treasurer")
            };
        }

        private void timerCheckStudents_Tick(object sender, EventArgs e)
        {
            int joined = CountStudents();
            lblStatusMessage.Text = $"Waiting for all students to join ({joined}/{_maxStudents})…";

            if (joined >= _maxStudents)
            {
                timerCheckStudents.Stop();

                // Hide status and start election
                panelStatus.Visible = false;
                StartElection();
            }
        }



        private bool AllStudentsJoined()
        {
            return CountStudents() >= 1;
        }

        private void StartElection()
        {
            panelStatus.Visible = false;
            currentPositionIndex = GetCurrentPositionIndexFromVotes();
            BeginVotingRound();
        }

        private void BeginVotingRound()
        {
            if (currentPositionIndex >= positions.Count)
            {
                // Election complete
                panelVoting.Visible = false;
                panelResults.Visible = true;
                ShowAllElectedPositions();
                return;
            }

            var currentPosition = positions[currentPositionIndex];
            lblStatusMessage.Text = $"Voting for {currentPosition.name}";
            lblResultsTitle.Text = $"Results for {currentPosition.name}";
            lblInstruction.Text = $"Please select a candidate from the list below for {currentPosition.name}:";

            panelVoting.Visible = true;
            panelResults.Visible = false;
            panelStatus.Visible = false;

            LoadCandidates();
        }


        private void dgvCandidates_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvCandidates.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.White;
            }

            if (dgvCandidates.SelectedRows.Count > 0)
            {
                dgvCandidates.SelectedRows[0].DefaultCellStyle.BackColor = Color.LightBlue;
            }
        }





        private void LoadCandidates()
        {
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                string query = @"SELECT u.user_id, u.username
                                 FROM class_students cs
                                 JOIN users u ON cs.student_id = u.user_id
                                 WHERE cs.class_id = @cid";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@cid", _classId);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvCandidates.DataSource = dt;
                    dgvCandidates.Columns["user_id"].Visible = false;
                }
            }
        }


        private void btnSubmitVote_Click(object sender, EventArgs e)
        {
            if (dgvCandidates.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a candidate.");
                return;
            }

            var currentPosition = positions[currentPositionIndex];
            int positionId = currentPosition.id;
            int voterId = GetInfo.UserID;
            int candidateId = Convert.ToInt32(dgvCandidates.SelectedRows[0].Cells["user_id"].Value);
            MessageBox.Show("Successfully Voted!");

            // Check if the voter has already voted
            if (HasVoted(voterId, positionId))
            {
                MessageBox.Show("You have already voted for this position.");
                return;
            }

            // Save the vote
            SaveVote(voterId, positionId, candidateId);

            // Count the votes for this position
            int totalVotes = CountVotes(positionId);
            int totalStudents = CountStudents();

            lblStatusMessage.Text = $"Vote submitted! Waiting for other students... ({totalVotes}/{totalStudents} voted)";

            // If all votes are in, move to the next position
            if (totalVotes >= totalStudents)
            {
                // Show the results for the current position
                ShowResults(positionId);

                // Move to the next position
                currentPositionIndex++;

                // Check if there are more positions to vote for
                if (currentPositionIndex >= positions.Count)
                {
                    // If all positions are voted for, finish the election
                    FinishElection();
                }
                else
                {
                    // Otherwise, start the next voting round
                    BeginVotingRound();
                }
            }
        }
        private int GetCurrentPositionIndexFromVotes()
        {
            for (int i = 0; i < positions.Count; i++)
            {
                int votes = CountVotes(positions[i].id);
                if (votes < _maxStudents)
                    return i; // return the first incomplete position
            }
            return positions.Count; // all done
        }

        private bool HasVoted(int voterId, int positionId)
        {
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                string q = @"SELECT COUNT(*) FROM election_votes
                     WHERE class_id=@cid AND position_id=@pos AND student_id=@sid";
                using (MySqlCommand cmd = new MySqlCommand(q, con))
                {
                    cmd.Parameters.AddWithValue("@cid", _classId);
                    cmd.Parameters.AddWithValue("@pos", positionId);
                    cmd.Parameters.AddWithValue("@sid", voterId);
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }

        private void SaveVote(int voterId, int positionId, int candidateId)
        {
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                string q = @"INSERT INTO election_votes (class_id, position_id, student_id, candidate_id)
                     VALUES (@cid, @posid, @sid, @cand)";
                using (MySqlCommand cmd = new MySqlCommand(q, con))
                {
                    cmd.Parameters.AddWithValue("@cid", _classId);
                    cmd.Parameters.AddWithValue("@posid", positionId);
                    cmd.Parameters.AddWithValue("@sid", voterId);
                    cmd.Parameters.AddWithValue("@cand", candidateId);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving vote: " + ex.Message);
                    }
                }
            }
        }


        private int CountVotes(int positionId)
        {
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                string q = "SELECT COUNT(*) FROM election_votes WHERE class_id=@cid AND position_id=@pos";
                using (MySqlCommand cmd = new MySqlCommand(q, con))
                {
                    cmd.Parameters.AddWithValue("@cid", _classId);
                    cmd.Parameters.AddWithValue("@pos", positionId);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }


        private void ShowResults(int positionId)
        {
            panelVoting.Visible = false;
            panelResults.Visible = true;

            string positionName = positions.First(p => p.id == positionId).name;
            lblResultsTitle.Text = $"Results for {positionName}";

            int winnerId = 0;
            int voteCount = 0;

            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                string q = @"SELECT candidate_id, COUNT(*) AS votes
                 FROM election_votes
                 WHERE class_id=@cid AND position_id=@pos
                 GROUP BY candidate_id
                 ORDER BY votes DESC
                 LIMIT 1";
                using (MySqlCommand cmd = new MySqlCommand(q, con))
                {
                    cmd.Parameters.AddWithValue("@cid", _classId);
                    cmd.Parameters.AddWithValue("@pos", positionId);

                    using (var rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            winnerId = rd.GetInt32("candidate_id");
                            voteCount = rd.GetInt32("votes");
                        }
                    }
                }
                int electionId = GetOrCreateElectionId();
                // Save winner in elected_positions
                if (winnerId != 0)
                {
                    if (winnerId == GetInfo.UserID)
                    {
                        GetInfo.Role = positionName;
                        SetupAnnouncementPosting();
                    }
                    string checkQuery = "SELECT COUNT(*) FROM elected_positions WHERE election_id=@eid AND position=@pos";
                    using (MySqlCommand cmdCheck = new MySqlCommand(checkQuery, con))
                    {
                        cmdCheck.Parameters.AddWithValue("@eid", electionId);
                        cmdCheck.Parameters.AddWithValue("@pos", positions.First(p => p.id == positionId).name.ToLower());

                        int existingCount = Convert.ToInt32(cmdCheck.ExecuteScalar());
                        if (existingCount == 0)
                        {
                            // Insert the elected position if it doesn't already exist
                            string insertQuery = @"INSERT INTO elected_positions (election_id, position, user_id)
                                       VALUES (@eid, @pos, @uid)";
                            using (MySqlCommand cmd2 = new MySqlCommand(insertQuery, con))
                            {
                                cmd2.Parameters.AddWithValue("@eid", electionId);
                                cmd2.Parameters.AddWithValue("@pos", positions.First(p => p.id == positionId).name.ToLower());
                                cmd2.Parameters.AddWithValue("@uid", winnerId);
                                cmd2.ExecuteNonQuery();
                            }
                        }
                    }
                }

                lblWinner.Text = winnerId == 0 ? "No votes submitted." : $"{GetStudentName(winnerId)} ({voteCount} votes)";
                if (winnerId == GetInfo.UserID)
                {
                    GetInfo.Role = positionName;
                    SetupAnnouncementPosting(); // show announcement controls if VP/President
                }
            }
        }
        private void ShowAllElectedPositions()
        {
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();

                int electionId = GetOrCreateElectionId();

                string q = @"SELECT ep.position, u.username
                     FROM elected_positions ep
                     JOIN users u ON ep.user_id = u.user_id
                     WHERE ep.election_id = @eid
                     ORDER BY FIELD(ep.position, 'president','vice president','secretary','treasurer')";

                using (MySqlCommand cmd = new MySqlCommand(q, con))
                {
                    cmd.Parameters.AddWithValue("@eid", electionId);

                    using (var rd = cmd.ExecuteReader())
                    {
                        StringBuilder sb = new StringBuilder();

                        while (rd.Read())
                        {
                            string pos = rd.GetString("position");
                            string name = rd.GetString("username");

                            sb.AppendLine($"{char.ToUpper(pos[0]) + pos.Substring(1)}: {name}");
                        }

                        // IMPORTANT: write to lblResults, NOT lblWinner in status panel
                        lblWinner.Text = sb.ToString();
                    }
                }
            }
        }

        private int CountStudents()
        {
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                string q = "SELECT COUNT(*) FROM class_students WHERE class_id=@cid";
                using (MySqlCommand cmd = new MySqlCommand(q, con))
                {
                    cmd.Parameters.AddWithValue("@cid", _classId);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        private void timerCheckVotes_Tick(object sender, EventArgs e)
        {
            if (currentPositionIndex >= positions.Count)
            {
                // All positions are done
                timerCheckVotes.Stop();
                return;
            }

            int positionId = positions[currentPositionIndex].id;
            int votes = CountVotes(positionId);
            int total = CountStudents();

            lblStatusMessage.Text = $"Waiting for other students... ({votes}/{total} voted)";

            // If all votes are in, move to the next position
            if (votes >= total)
            {
                timerCheckVotes.Stop();
                ShowResults(positionId);


                if (currentPositionIndex >= positions.Count)
                {
                    // All positions voted for, finish the election
                    FinishElection();
                }
                else
                {
                    // Start the next voting round
                    BeginVotingRound();
                }
            }
        }


        private string GetStudentName(int id)
        {
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                string q = "SELECT username FROM users WHERE user_id=@id";
                using (MySqlCommand cmd = new MySqlCommand(q, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    object result = cmd.ExecuteScalar();
                    return result == null ? "Unknown" : result.ToString();
                }
            }
        }

        private void btnNextPosition_Click(object sender, EventArgs e)
        {
            currentPositionIndex++;

            if (currentPositionIndex >= positions.Count)
            {
                FinishElection();
            }
            else
            {
                BeginVotingRound();
            }
        }

        private void FinishElection()
        {
            panelResults.Visible = true;
            panelStatus.Visible = false;

            lblStatusMessage.Text = "Election completed! ";
            ShowAllElectedPositions();
            timerClearResults.Start();

        }
        private int GetOrCreateElectionId()
        {
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();

                // Check if an election already exists for this class
                string checkQuery = "SELECT election_id FROM elections WHERE class_id=@cid LIMIT 1";
                using (MySqlCommand cmd = new MySqlCommand(checkQuery, con))
                {
                    cmd.Parameters.AddWithValue("@cid", _classId);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        return Convert.ToInt32(result); // Return existing election_id
                    }
                }

                // If no election exists, create a new election
                string insertQuery = @"INSERT INTO elections (class_id, election_name, start_date)
                               VALUES (@cid, @ename, NOW())";
                using (MySqlCommand cmd = new MySqlCommand(insertQuery, con))
                {
                    cmd.Parameters.AddWithValue("@cid", _classId);
                    cmd.Parameters.AddWithValue("@ename", $"Election for Class {_classId}");
                    cmd.ExecuteNonQuery();
                }

                // Return the newly created election_id
                using (MySqlCommand cmd = new MySqlCommand("SELECT LAST_INSERT_ID()", con))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        private void timerClearResults_Tick(object sender, EventArgs e)
        {
            timerClearResults.Stop();

            // Clear the display
            lblWinner.Text = "";
            lblResultsTitle.Text = "";

            // Hide result panel, show status panel
            panelResults.Visible = false;
            panelStatus.Visible = true;

            lblStatusMessage.Text = "Election completed!";

            panelStatus.Visible = false;
            flowLayoutPanelAnnouncements.Visible = true;
            flowLayoutPanelAnnouncements.BringToFront();
            LoadAnnouncements();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //notif
            fmrNotification f4 = new fmrNotification();
            f4.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string role = (GetInfo.Role ?? "").Trim().ToLower();
            bool canPost = role == "president" || role == "vice president";

            if(canPost)
            {
                panelCreateAnnouncement.Visible = true;
                panelCreateAnnouncement.BringToFront();
            }
            else
            {
                MessageBox.Show("You don't have permission to create an announcement.");
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            //ff
            frmFlashcard f5 = new frmFlashcard();
            f5.Show();
            this.Hide();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            //ff
            frmFlashcard f5 = new frmFlashcard();
            f5.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            //home
            _dashboard?.LoadClasses();
            _dashboard?.Show();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //home
            _dashboard?.LoadClasses();
            _dashboard?.Show();
            this.Close();
        }


        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void lblClassName_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            frmPending p = new frmPending();
            p.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            frmPending p = new frmPending();
            p.Show();
            this.Hide();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            frmCallendar c = new frmCallendar();
            c.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            frmCallendar c = new frmCallendar();
            c.Show();
            this.Hide();
        }

        private void LoadAnnouncements()
        {
            flowLayoutPanelAnnouncements.Controls.Clear();

            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                string query = @"
            SELECT 
                a.announcement_id,
                a.title,
                a.content,
                a.created_at,
                a.is_done,
                a.user_id,  -- Added this line to select the user_id from the announcements table
                u.username,
                COALESCE(
                    (SELECT position 
                     FROM elected_positions 
                     WHERE user_id = u.user_id 
                     ORDER BY id DESC 
                     LIMIT 1),
                    u.role
                ) AS role
            FROM announcements a
            JOIN users u ON a.user_id = u.user_id
            WHERE a.class_id = @cid
            ORDER BY a.created_at DESC;";

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@cid", _classId);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var announcementCard = new ctrlAnnouncement();
                        string userRole = reader.GetString("role");  
                        announcementCard.LoadAnnouncementData(
                            reader.GetInt32("announcement_id"),
                            reader.GetString("title"),
                            reader.GetString("content"),
                            reader.GetDateTime("created_at"),
                            reader.GetBoolean("is_done"),
                            reader.GetInt32("user_id"),          // Creator ID
                            reader.GetString("username"),        // Creator username
                            reader.GetString("role"),            // Creator role
                            GetInfo.Role                         // Logged-in user role
                        );

                        // Add the card to the FlowLayoutPanel
                        flowLayoutPanelAnnouncements.Controls.Add(announcementCard);
                    }
                }
            }
        }

        private void SetupAnnouncementPosting()
        {
            string role = (GetInfo.Role ?? "").Trim().ToLower();

            bool canPost = role == "president" || role == "vice president";
            txtAnnouncementTitle.Visible = canPost;
            txtAnnouncementContent.Visible = canPost;
            btnNewAnnouncement.Visible = canPost;

            if (canPost)
            {
                txtAnnouncementTitle.Enabled = true;
                txtAnnouncementContent.Enabled = true;
                btnNewAnnouncement.Enabled = true;
            }
            Console.WriteLine($"User Role={GetInfo.Role}, txtAnnouncementTitle.Visible={txtAnnouncementTitle.Visible}");

        }


        private void Card_MarkAsDoneClicked(object sender, EventArgs e)
        {
            if (sender is ctrlAnnouncement card)
            {
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();
                    string query = "UPDATE announcements SET is_done=1 WHERE announcement_id=@aid";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@aid", card.AnnouncementId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Announcement marked as done.");
                LoadAnnouncements(); // Refresh list
            }
        }

        private void btnNewAnnouncement_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAnnouncementTitle.Text) || string.IsNullOrWhiteSpace(txtAnnouncementContent.Text))
            {
                MessageBox.Show("Title and content cannot be empty.");
                return;
            }

            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                string query = @"INSERT INTO announcements (class_id, user_id, title, content, created_at)
                         VALUES (@cid, @uid, @title, @content, NOW())";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@cid", _classId);
                    cmd.Parameters.AddWithValue("@uid", GetInfo.UserID);
                    cmd.Parameters.AddWithValue("@title", txtAnnouncementTitle.Text);
                    cmd.Parameters.AddWithValue("@content", txtAnnouncementContent.Text);
                    cmd.ExecuteNonQuery();
                }
            }

            // Clear fields
            txtAnnouncementTitle.Clear();
            txtAnnouncementContent.Clear();

            // Refresh announcements
            LoadAnnouncements();
            panelCreateAnnouncement.Visible = false;
            flowLayoutPanelAnnouncements.Visible = true;
            flowLayoutPanelAnnouncements.BringToFront();
        }
        private void SetPlaceholderText()
        {
            if (string.IsNullOrWhiteSpace(txtAnnouncementContent.Text))
            {
                txtAnnouncementContent.Text = "Enter your announcement...";
                txtAnnouncementContent.ForeColor = Color.Gray;
            }
        }
        private void richTextBoxAnnouncement_Enter(object sender, EventArgs e)
        {
            if (txtAnnouncementContent.Text == "Enter your announcement..." && txtAnnouncementContent.ForeColor == Color.Gray)
            {
                txtAnnouncementContent.Text = "";
                txtAnnouncementContent.ForeColor = Color.Black;
            }
        }

        // When the user leaves the RichTextBox (Focus Lost)
        private void richTextBoxAnnouncement_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAnnouncementContent.Text))
            {
                SetPlaceholderText();
            }
        }

        private void txtAnnouncementTitle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
