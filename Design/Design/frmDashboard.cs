using MySql.Data.MySqlClient;
namespace Design
{
    public partial class frmDashBoard : Form
    {

        public frmDashBoard()
        {
            InitializeComponent();
            InitializeNotifyIcon();
            LoadLastNotification();
            StartNotificationTimer();
        }

        private bool panelIsExpanded = false;
        private int panelMaxWidth = 200;
        private int slideSpeed = 10;
        private int lastNotifId = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Width = 200;
            panel1.Visible = false;

            lblUsername.Text = GetInfo.Username;
            try
            {
                LoadClasses();
            }
            catch (Exception ex)
            {
                MessageBox.Show("LoadClasses error: " + ex.Message);
            }
        }

        private void InitializeNotifyIcon()
        {
            notifyIcon1.Icon = SystemIcons.Information;
            notifyIcon1.Visible = true;

        }
        private void LoadLastNotification()
        {
            string conString = "server=localhost;database=edutask;uid=edutask_app;pwd=Ralfh_Leo_Sheky_Cholo2025!";
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                string query = "SELECT IFNULL(MAX(notification_id), 0) FROM notifications";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    lastNotifId = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }


        private void StartNotificationTimer()
        {
            timerCheckNotification.Interval = 10000; // check every 10 seconds
            timerCheckNotification.Tick += TimerCheckNotification_Tick;
            timerCheckNotification.Start();
        }


        private void TimerCheckNotification_Tick(object sender, EventArgs e)
        {
            string conString = "server=localhost;database=edutask;uid=edutask_app;pwd=Ralfh_Leo_Sheky_Cholo2025!";

            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();

                // Fetch notifications for this user or for classes the user is in
                string query = @"
            SELECT n.notification_id, n.message, n.user_id, n.class_id, u.username AS sender, c.class_name
            FROM notifications n
            LEFT JOIN users u ON n.user_id = u.user_id
            LEFT JOIN classes c ON n.class_id = c.class_id
            WHERE (n.user_id = @uid OR n.class_id IN 
                   (SELECT class_id FROM class_students WHERE student_id = @uid))
              AND n.notification_id > @lastId
            ORDER BY n.notification_id ASC";

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@uid", GetInfo.UserID);
                    cmd.Parameters.AddWithValue("@lastId", lastNotifId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int notifId = Convert.ToInt32(reader["notification_id"]);
                            string msg = reader["message"].ToString();
                            string senderName = reader["sender"] != DBNull.Value ? reader["sender"].ToString() : "System";
                            string className = reader["class_name"] != DBNull.Value ? reader["class_name"].ToString() : null;

                            string title = className != null ? $"Class: {className}" : $"From: {senderName}";
                            ShowTrayNotification(msg, title);

                            lastNotifId = notifId; // update last notification
                        }
                    }
                }
            }
        }






        private void Form1_Shown(object sender, EventArgs e)
        {
            try
            {
                LoadClasses(); // this will populate the FlowLayoutPanel when the form first appears
            }
            catch (Exception ex)
            {
                MessageBox.Show("LoadClasses error: " + ex.Message);
            }
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            LoadClasses();
        }

        public void LoadClasses()
        {
            flowPanelClasses.Controls.Clear();

            string conString = "server=localhost;database=edutask;uid=edutask_app;pwd=Ralfh_Leo_Sheky_Cholo2025!";

            try
            {
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();

                    string query = "";

                    if (GetInfo.Role == "teacher")
                    {
                        query = @"
                        SELECT * FROM (
                            -- classes where teacher is adviser
                            SELECT c.class_id, c.class_name, c.class_code, u.username AS adviser
                            FROM classes c
                            LEFT JOIN users u ON c.adviser_id = u.user_id
                            WHERE c.adviser_id = @tid

                            UNION

                            -- classes the teacher created
                            SELECT c.class_id, c.class_name, c.class_code, u.username AS adviser
                            FROM classes c
                            LEFT JOIN users u ON c.adviser_id = u.user_id
                            WHERE c.creator_id = @tid

                            UNION

                            -- classes the teacher JOINED (added in class_students)
                            SELECT c.class_id, c.class_name, c.class_code, u.username AS adviser
                            FROM classes c
                            LEFT JOIN users u ON c.adviser_id = u.user_id
                            INNER JOIN class_students cs ON c.class_id = cs.class_id
                            WHERE cs.student_id = @tid
                        ) t
                        ORDER BY class_name ASC";
                    }
                    else
                    {
                        query = @"
                        SELECT * FROM
                        (
                            SELECT c.class_id, c.class_name, c.class_code, u.username AS adviser
                            FROM classes c
                            LEFT JOIN users u ON c.adviser_id = u.user_id
                            WHERE c.creator_id = @sid

                            UNION

                            SELECT c.class_id, c.class_name, c.class_code, u.username AS adviser
                            FROM classes c
                            LEFT JOIN users u ON c.adviser_id = u.user_id
                            INNER JOIN class_students cs ON c.class_id = cs.class_id
                            WHERE cs.student_id = @sid
                        ) AS student_classes
                        ORDER BY class_name ASC";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        if (GetInfo.Role == "teacher")
                            cmd.Parameters.AddWithValue("@tid", GetInfo.UserID);
                        else
                            cmd.Parameters.AddWithValue("@sid", GetInfo.UserID);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int classId = reader.GetInt32("class_id");
                                string className = reader.GetString("class_name");
                                string classCode = reader.GetString("class_code");
                                string adviser = reader.IsDBNull(reader.GetOrdinal("adviser"))
                                    ? "Student-created"
                                    : reader.GetString("adviser");

                                CreateClassCard(classId, className, classCode, adviser);
                            }
                        }
                    }
                }

                flowPanelClasses.Visible = true;
                flowPanelClasses.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("LoadClasses error: " + ex.Message);
            }
        }

        private void CreateClassCard(int classId, string className, string classCode, string adviser)
        {
            Panel card = new Panel();
            card.Width = 250;
            card.Height = 150; // slightly bigger for adviser
            card.BackColor = Color.FromArgb(52, 152, 219);
            card.Margin = new Padding(10);
            card.Cursor = Cursors.Hand;
            card.Tag = classId; // <-- IMPORTANT

            Label lblTitle = new Label();
            lblTitle.Text = className;
            lblTitle.ForeColor = Color.White;
            lblTitle.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblTitle.Location = new Point(10, 10);
            lblTitle.AutoSize = true;

            Label lblCode = new Label();
            lblCode.Text = "Code: " + classCode;
            lblCode.ForeColor = Color.White;
            lblCode.Font = new Font("Segoe UI", 10);
            lblCode.Location = new Point(10, 50);
            lblCode.AutoSize = true;

            Label lblAdviser = new Label();
            lblAdviser.Text = "Adviser: " + adviser;
            lblAdviser.ForeColor = Color.White;
            lblAdviser.Font = new Font("Segoe UI", 10);
            lblAdviser.Location = new Point(10, 80);
            lblAdviser.AutoSize = true;

            card.Controls.Add(lblTitle);
            card.Controls.Add(lblCode);
            card.Controls.Add(lblAdviser);

            // Attach the same click handler to labels so clicking anywhere works
            card.Click += ClassCard_Click;
            lblTitle.Click += ClassCard_Click;
            lblCode.Click += ClassCard_Click;
            lblAdviser.Click += ClassCard_Click;

            flowPanelClasses.Controls.Add(card);
        }


        private void ClassCard_Click(object sender, EventArgs e)
        {
            Control c = sender as Control;

            // Ensure we get the Panel that holds the Tag
            Panel card = c is Panel ? (Panel)c : (Panel)c.Parent;

            int classId = (int)card.Tag;

            // Open the class page for this classId
            Class classPage = new Class(classId, this);
            classPage.Show();

            // Optionally hide the dashboard
            this.Hide();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

            timer1.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //e2 ay sa message button

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // e2 ay sa notification button
            frmNotification f4 = new frmNotification();
            f4.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //e2 ay sa add ng class button
            Form2 f2 = new Form2(this); // pass reference to this dashboard
            f2.Show();
            this.Hide();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // e2 ay home icon button
            frmDashBoard frmDashBoard = new frmDashBoard();
            frmDashBoard.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //e2 ay pending icom button
            frmPending f7 = new frmPending();
            f7.Show();
            this.Hide(); ;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //e2 ay schedule icon button
            frmCallendar  callendar = new frmCallendar();
            callendar.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            //e2 ay flashcards icon button
            frmFlashcard ff = new frmFlashcard();
            ff.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            //e2 ay home label button
            frmDashBoard f = new frmDashBoard();
            f.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            //e2 ay pending label button 
            frmPending f7 = new frmPending();
            f7.Show();
            this.Hide();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            //e2 ay schedule label button
            frmCallendar c = new frmCallendar();
            c.Show();
            this.Hide();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            //e2 ay flashcards label button
            frmFlashcard f5 = new frmFlashcard();
            f5.Show();
            this.Hide();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            // e2 ay course icon btton
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            //e2 ay sa course label button
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //e2 ay panel ng courses pag nipinfot yung button sa taas. 
            //dapat ay mag ddrop down tong panel pag niindot yugn button then nasa loob yung courses
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            //navigation icon 

            timer1.Start();
        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            //flashcards
            frmFlashcard f5 = new frmFlashcard();
            f5.Show();
            this.Hide();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void ShowTrayNotification(string message, string title = "EduTask Notification")
        {
            notifyIcon1.BalloonTipTitle = title;
            notifyIcon1.BalloonTipText = message;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.ShowBalloonTip(5000); // shows for 5 seconds
            System.Media.SystemSounds.Exclamation.Play(); // optional sound
        }


    }
}
