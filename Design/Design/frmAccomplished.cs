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
using System.Diagnostics;

namespace Design
{
    public partial class frmAccomplished : Form
    {
        private string conString = "server=localhost;database=edutask;uid=edutask_app;pwd=Ralfh_Leo_Sheky_Cholo2025!";

        public frmAccomplished()
        {
            InitializeComponent();
            panel1.Width = 60;
            panel1.Visible = true;
        }
        private bool panelIsExpanded = false;
        private int panelMaxWidth = 170;
        private int slideSpeed = 98;

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            //pending
            frmPending f7 = new frmPending();
            f7.Show();
            this.Hide();
        }

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
            //pending
            frmPending f7 = new frmPending();
            f7.Show();
            this.Hide();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            //schedule
            frmCallendar f10 = new frmCallendar();
            f10.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //schedule
            frmCallendar f10 = new frmCallendar();
            f10.Show();
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
            frmDashBoard f5 = new frmDashBoard();
            f5.Show();
            this.Hide();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            //missing
            int currentClassId = GetInfo.ClassID;
            frmMissing f7 = new frmMissing();
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
            //add class
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void frmAccomplished_Load(object sender, EventArgs e)
        {
            LoadAccomplishedAnnouncements();
            lblUsername.Text = GetInfo.Username;
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            LoadAccomplishedAnnouncements();

        }

        private void LoadAccomplishedAnnouncements()
        {
            flowLayoutPanelAccomplished.Controls.Clear();
            flowLayoutPanelAccomplished.AutoScroll = true;

            try
            {
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();
                    Debug.WriteLine("Database connection opened.");

                    string query = @"
    SELECT a.announcement_id, a.class_id, a.title, a.content, a.due_datetime, a.created_at,
           u.username, 
           COALESCE(
               (SELECT position 
                FROM elected_positions 
                WHERE user_id = u.user_id 
                ORDER BY id DESC 
                LIMIT 1),
               u.role
           ) AS creator_role,
           COALESCE(s.status, 'missing') AS status
    FROM announcements a
    LEFT JOIN announcement_status s
           ON s.announcement_id = a.announcement_id AND s.user_id = @uid
    JOIN users u ON a.user_id = u.user_id
    WHERE COALESCE(s.status, 'missing') = 'done'
    ORDER BY a.created_at DESC;";


                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@uid", GetInfo.UserID);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            int rowCount = 0;

                            while (reader.Read())
                            {
                                rowCount++;
                                var announcementCard = new ctrlAnnouncement();

                                DateTime? due = reader["due_datetime"] != DBNull.Value
                                    ? (DateTime?)reader.GetDateTime("due_datetime")
                                    : null;

                                bool isDone = reader["status"].ToString() == "done";

                                int classIdFromDb = reader["class_id"] != DBNull.Value
                                    ? Convert.ToInt32(reader["class_id"])
                                    : 0;

                                announcementCard.LoadAnnouncementData(
                                    reader.GetInt32("announcement_id"),
                                    classIdFromDb,
                                    reader.GetString("title"),
                                    reader.GetString("content"),
                                    reader.GetDateTime("created_at"),
                                    isDone,
                                    reader.GetString("username"),
                                    reader.GetString("creator_role"),
                                    due
                                );

                                if (!isDone)
                                    announcementCard.BackColor = Color.LightSalmon;

                                flowLayoutPanelAccomplished.Controls.Add(announcementCard);
                            }

                            Debug.WriteLine($"Total announcements loaded: {rowCount}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Database or query error: {ex.Message}");
                MessageBox.Show("Error loading announcements: " + ex.Message);
            }

            flowLayoutPanelAccomplished.Visible = true;
            flowLayoutPanelAccomplished.BringToFront();

            Debug.WriteLine("=== LoadAccomplishedAnnouncements Finished ===");
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            frmPersonal fp = new frmPersonal();
            fp.Show();
            this.Hide();
        }
    }
}



