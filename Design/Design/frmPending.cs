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
    public partial class frmPending : Form
    {
        private string conString = "server=localhost;database=edutask;uid=edutask_app;pwd=Ralfh_Leo_Sheky_Cholo2025!";

        public frmPending()
        {
            InitializeComponent();

            panel1.Width = 60;
            panel1.Visible = true;
        }
        private bool panelIsExpanded = false;
        private int panelMaxWidth = 170;
        private int slideSpeed = 98;

        private void frmPending_Load(object sender, EventArgs e)
        {
            LoadPendingAnnouncements();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();
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

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            LoadPendingAnnouncements();
        }

        private void LoadPendingAnnouncements()
        {
            flowLayoutPanelPendingAssignments.Controls.Clear();
            flowLayoutPanelPendingAssignments.AutoScroll = true;

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
                       COALESCE(s.status, 'pending') AS status
                FROM announcements a
                LEFT JOIN announcement_status s
                    ON s.announcement_id = a.announcement_id AND s.user_id = @uid
                JOIN users u ON a.user_id = u.user_id
                WHERE COALESCE(s.status, 'pending') = 'pending'
                ORDER BY a.created_at DESC;";  // <-- Only pending

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

                                int classIdFromDb = reader["class_id"] != DBNull.Value
                                    ? Convert.ToInt32(reader["class_id"])
                                    : 0;

                                announcementCard.LoadAnnouncementData(
                                    reader.GetInt32("announcement_id"),
                                    classIdFromDb,
                                    reader.GetString("title"),
                                    reader.GetString("content"),
                                    reader.GetDateTime("created_at"),
                                    false,  // Always false because it's pending
                                    reader.GetString("username"),
                                    reader.GetString("creator_role"),
                                    due
                                );

                                // Highlight pending announcements
                                announcementCard.BackColor = Color.LightSalmon;

                                flowLayoutPanelPendingAssignments.Controls.Add(announcementCard);
                            }

                            Debug.WriteLine($"Total pending announcements loaded: {rowCount}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Database or query error: {ex.Message}");
                MessageBox.Show("Error loading pending announcements: " + ex.Message);
            }

            flowLayoutPanelPendingAssignments.Visible = true;
            flowLayoutPanelPendingAssignments.BringToFront();
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //notif
            frmNotification f4 = new frmNotification();
            f4.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //add cvlass
            Form2 f2 = new Form2();
            f2.Show();
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

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            //missing
            int currentClassId = GetInfo.ClassID;
            frmMissing f7 = new frmMissing(currentClassId);
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
    }
}
