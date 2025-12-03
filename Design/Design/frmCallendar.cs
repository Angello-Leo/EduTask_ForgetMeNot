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
    public partial class frmCallendar : Form
    {
        private string conString = "server=localhost;database=edutask;uid=edutask_app;pwd=Ralfh_Leo_Sheky_Cholo2025!";

        public frmCallendar()
        {
            InitializeComponent();
            panel1.Width = 60;
            panel1.Visible = true;
        }
        private bool panelIsExpanded = false;
        private int panelMaxWidth = 170;
        private int slideSpeed = 98;

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            //add schedule
            frmAddSchedule form11 = new frmAddSchedule();
            form11.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //home
            frmDashBoard f1 = new frmDashBoard();
            f1.Show();
            this.Hide();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
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
            this.Hide(); ;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            //sched
            frmCallendar f10 = new frmCallendar();
            f10.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //sched
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
            frmFlashcard f5 = new frmFlashcard();
            f5.Show();
            this.Hide();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            //pending
            frmPending f7 = new frmPending();
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

        private void frmCallendar_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            flowLayoutPanelCallendar.Controls.Clear();

            DateTime selectedDate = e.Start.Date; // only date part

            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();

                string query = @"
            SELECT a.announcement_id, a.title, a.content, a.created_at, a.is_done, u.username, u.role, a.due_date
            FROM announcements a
            JOIN users u ON a.user_id = u.user_id
            WHERE a.class_id = @cid
            AND (DATE(a.created_at) = @selectedDate OR DATE(a.due_date) = @selectedDate)
            ORDER BY a.created_at DESC;";

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@cid", GetInfo.ClassID);
                    cmd.Parameters.AddWithValue("@selectedDate", selectedDate);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var announcementCard = new ctrlAnnouncement();
                            DateTime? dueDate = reader["due_date"] != DBNull.Value ? (DateTime?)reader.GetDateTime("due_date") : null;

                            announcementCard.LoadAnnouncementData(
                                reader.GetInt32("announcement_id"),
                                GetInfo.ClassID,
                                reader.GetString("title"),
                                reader.GetString("content"),
                                reader.GetDateTime("created_at"),
                                reader.GetBoolean("is_done"),
                                reader.GetString("username"),
                                reader.GetString("role"),
                                dueDate
                            );

                            flowLayoutPanelCallendar.Controls.Add(announcementCard);
                        }
                    }
                }
            }
        }
    }
}
