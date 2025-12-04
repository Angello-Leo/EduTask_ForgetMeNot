using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design
{
    public partial class frmMissing : Form
    {
        private string conString = "server=localhost;database=edutask;uid=edutask_app;pwd=Ralfh_Leo_Sheky_Cholo2025!";
        private int _classId;

        public frmMissing()
        {
            InitializeComponent();
            panel1.Width = 60;
            panel1.Visible = true;

        }
        private bool panelIsExpanded = false;
        private int panelMaxWidth = 170;
        private int slideSpeed = 98;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (panelIsExpanded)
            {
                panel1.Width -= slideSpeed;
                if (panel1.Width <= 0)
                {
                    panel1.Visible = false;
                    panel1.Width = 0;
                    panelIsExpanded = false;
                    timer1.Stop();
                }
            }
            else
            {
                panel1.Width += slideSpeed;
                if (panel1.Width >= panelMaxWidth)
                {
                    panel1.Visible = true;
                    panel1.Width = panelMaxWidth;
                    panelIsExpanded = true;
                    timer1.Stop();
                }

            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            //home 
            frmDashBoard f1 = new frmDashBoard();
            f1.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //home
            frmDashBoard f1 = new frmDashBoard();
            f1.Show();
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            //pending
            frmPending f7 = new frmPending();
            f7.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //pendign
            frmPending f7 = new frmPending();
            f7.Show();
            this.Hide();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            //ff
            frmFlashcard f5 = new frmFlashcard();
            f5.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            //ff
            frmFlashcard f5 = new frmFlashcard();
            f5.Show();
            this.Hide();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            //pending
            frmPending f7 = new frmPending();
            f7.Show();
            this.Hide();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            //accomplished
            frmAccomplished f7 = new frmAccomplished();
            f7.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //notif
            frmNotification f4 = new frmNotification();
            f4.Show();
            this.Hide();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // add class
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            LoadMissingAssignments();
        }

        private void frmMissing_Load(object sender, EventArgs e)
        {
            LoadMissingAssignments();
            lblUsername.Text = GetInfo.Username;
        }
        private void LoadMissingAssignments()
        {
            flowLayoutPanelMissing.Controls.Clear();  // Clear previous data
            flowLayoutPanelMissing.AutoScroll = true;  // Enable scrolling

            flowLayoutPanelMissing.Visible = true;
            flowLayoutPanelMissing.BringToFront();

            // Log the parameters being passed
            Debug.WriteLine($"Loading all missing announcements for UserID: {GetInfo.UserID}");

            using (MySqlConnection con = new MySqlConnection(conString))
            {
                try
                {
                    con.Open();
                    Debug.WriteLine("Database connection established.");

                    string query = @"
                SELECT a.announcement_id, a.title, a.content, a.due_datetime, a.created_at, u.username, s.status
                FROM announcements a
                JOIN users u ON a.user_id = u.user_id
                LEFT JOIN announcement_status s 
                    ON s.announcement_id = a.announcement_id 
                    AND s.user_id = @uid
                WHERE s.status = 'missing'   -- Only get announcements marked as 'missing'
                ORDER BY a.due_datetime ASC;";  // Sort by due date (ascending)

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@uid", GetInfo.UserID);  // Add user ID parameter (for missing)

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            int recordCount = 0;  // Counter to keep track of the records fetched
                            while (reader.Read())
                            {
                                recordCount++;

                                // Debug log to check what data is being retrieved
                                string title = reader["title"].ToString();
                                string status = reader["status"].ToString();
                                Debug.WriteLine($"Announcement Found: {title}, Status: {status}");

                                // Check for null or empty values
                                if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(status))
                                {
                                    Debug.WriteLine("Error: Missing required fields (title or status) in the announcement.");
                                    continue;
                                }

                                var announcementCard = new ctrlAnnouncement();  // Create the UserControl for announcement

                                // Read data from the database
                                int announcementId = reader.GetInt32("announcement_id");
                                string content = reader["content"].ToString();
                                DateTime dueDate = reader.GetDateTime("due_datetime");
                                DateTime createdAt = reader.GetDateTime("created_at");
                                string createdBy = reader["username"].ToString();

                                // For missing tasks, set 'isDone' as false (they are not done)
                                bool isDone = false;

                                // Load the data into the control
                                announcementCard.LoadAnnouncementData(
                                    announcementId,
                                    0,  // No class ID needed here
                                    title,
                                    content,
                                    createdAt,
                                    isDone,  // These are marked as missing, so they are not done
                                    createdBy,
                                    "creator",
                                    dueDate
                                );

                                // Add to the FlowLayoutPanel
                                flowLayoutPanelMissing.Controls.Add(announcementCard);
                            }

                            // Check if there were any records loaded
                            if (recordCount == 0)
                            {
                                Debug.WriteLine("No missing announcements found.");
                                MessageBox.Show("No missing announcements found.");
                            }
                            else
                            {
                                Debug.WriteLine($"{recordCount} missing announcements found.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading missing assignments: {ex.Message}");
                    Debug.WriteLine($"Error: {ex.Message}");
                }
            }

            flowLayoutPanelMissing.Refresh();  // Refresh the FlowLayoutPanel to display new data
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            frmPersonal fp = new frmPersonal();
            fp.Show();
            this.Hide();
        }

    }
}
