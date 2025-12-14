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
        UiTransition n = new UiTransition();
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

        private void picHome_Click(object sender, EventArgs e)
        {
            n.Home(this);
        }

        private void tmrHamburgerMenu_Tick(object sender, EventArgs e)
        {
            if (panelIsExpanded)
            {
                panel1.Width -= slideSpeed;
                if (panel1.Width <= 0)
                {
                    panel1.Visible = false;
                    panel1.Width = 0;
                    panelIsExpanded = false;
                    tmrHamburgerMenu.Stop();
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
                    tmrHamburgerMenu.Stop();
                }

            }
        }

        private void picHamburgerMenu_Click(object sender, EventArgs e)
        {
            tmrHamburgerMenu.Start();
        }

        private void picHomeIcon_Click(object sender, EventArgs e)
        {
            n.Home(this);
        }

        private void picPending_Click(object sender, EventArgs e)
        {
            n.Pending(this);
        }

        private void picPendingIcon_Click(object sender, EventArgs e)
        {
           n.Pending(this);
        }

        private void picSchedule_Click(object sender, EventArgs e)
        {
            n.Schedule(this);
        }

        private void picScheduleIcon_Click(object sender, EventArgs e)
        {
            n.Schedule(this);
        }

        private void picFlashcard_Click(object sender, EventArgs e)
        {
            n.Flashcards(this);
        }

        private void picFlashcardIcon_Click(object sender, EventArgs e)
        {
           n.Flashcards(this);
        }

        private void picPendingSelection_Click(object sender, EventArgs e)
        {
            n.Pending(this);
        }

        private void picNotification_Click(object sender, EventArgs e)
        {
            n.Notification(this);
        }

        private void picAddClass_Click(object sender, EventArgs e)
        {
            n.AddClass(this);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            flowLayoutPanelCallendar.Controls.Clear();

            DateTime selectedDate = e.Start.Date; // only date part

            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();

                string query = @"
                   SELECT a.announcement_id, a.title, a.content, a.created_at, a.is_done,
                u.username, u.role, a.due_datetime
                FROM announcements a
                JOIN users u ON a.user_id = u.user_id
                WHERE (DATE(a.created_at) = @selectedDate 
                OR DATE(a.due_datetime) = @selectedDate)
                ORDER BY a.created_at DESC;     ";

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@selectedDate", selectedDate);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var announcementCard = new ctrlAnnouncement();
                            DateTime? dueDate = reader["due_datetime"] != DBNull.Value
                                ? (DateTime?)reader.GetDateTime("due_datetime")
                                : null;

                            announcementCard.LoadAnnouncementData(
                                reader.GetInt32("announcement_id"),
                                0, // no more class ID used
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
