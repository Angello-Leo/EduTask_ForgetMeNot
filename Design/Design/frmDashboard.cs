using MySql.Data.MySqlClient;
namespace Design
{
    public partial class frmDashBoard : Form
    {
        UiTransition n = new UiTransition();
        public frmDashBoard()
        {
            InitializeComponent();
            InitializeNotifyIcon();
            LoadLastNotification();
            tmrStartNotification();
        }

        private bool panelIsExpanded = false;
        private int panelMaxWidth = 200;
        private int slideSpeed = 10;
        private int lastNotifId = 0;

        private void frmDashboard_Load(object sender, EventArgs e)
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
            if (notifyIcon1 == null)
            {
                notifyIcon1 = new NotifyIcon();
                notifyIcon1.Icon = SystemIcons.Information;
                notifyIcon1.Visible = true;
            }

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


        private void tmrStartNotification()
        {
            tmrCheckNotification.Interval = 10000; // check every 10 seconds
            tmrCheckNotification.Tick += tmrCheckNotification_Tick;
            tmrCheckNotification.Start();
        }


        private void tmrCheckNotification_Tick(object sender, EventArgs e)
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

        private void frmDashboard_Shown(object sender, EventArgs e)
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



        private void picHamburgerMenu_Click(object sender, EventArgs e)
        {
            tmrHamburgerMenu.Start();
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
                    tmrHamburgerMenu.Stop();
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
                    tmrHamburgerMenu.Stop();
                }
            }
        }

        private void picNotification_Click(object sender, EventArgs e)
        {
             n.Notification(this);
        }

        private void picAddClass_Click(object sender, EventArgs e)
        {
            n.AddClass(this);
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            flowPanelClasses.Refresh();
        }

        private void picPendingIcon_Click(object sender, EventArgs e)
        {
            n.Pending(this);
        }

        private void picScheduleIcon_Click(object sender, EventArgs e)
        {
           n.Schedule(this);
        }

        private void picFlashcardIcon_Click(object sender, EventArgs e)
        {
           n.Flashcards(this);
        }

        private void picPending_Click(object sender, EventArgs e)
        {
            n.Pending(this);
        }

        private void picSchedule_Click(object sender, EventArgs e)
        {
            n.Schedule(this);
        }

        private void picFlashcard_Click(object sender, EventArgs e)
        {
            n.Flashcards(this);
        }

        private void picHomeIcon_Click(object sender, EventArgs e)
        {
            flowPanelClasses.Refresh();
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
