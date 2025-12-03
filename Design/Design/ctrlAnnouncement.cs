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
    public partial class ctrlAnnouncement : UserControl
    {
        private string conString = "server=localhost;database=edutask;uid=edutask_app;pwd=Ralfh_Leo_Sheky_Cholo2025!";
        private int _classId;

        public int AnnouncementId { get; private set; }
        public bool IsDone { get; private set; }

        public ctrlAnnouncement()
        {
            InitializeComponent();
        }

        private void ctrlAnnouncement_Load(object sender, EventArgs e)
        {

        }

        public void LoadAnnouncementData(int announcementId, int classId, string title, string content, DateTime createdAt,
                                         bool isDone, string username, string creatorRole, DateTime? dueDateTime)
        {
            string query = "SELECT a.announcement_id, a.title, a.content, a.created_at, a.is_done, u.username, u.role " +
                    "FROM announcements a " +
                    "JOIN users u ON a.user_id = u.user_id " +
                    "WHERE a.announcement_id = @announcementId";

            AnnouncementId = announcementId;
            IsDone = isDone;
            _classId = classId;

            lblTitle.Text = title;
            lblContent.Text = content;
            lblCreatedBy.Text = $"{username} ({creatorRole})";
            lblCreatedAt.Text = createdAt.ToString("g");
            if (dueDateTime.HasValue)
                lblDueDate.Text = dueDateTime.Value.ToString("g");
            else
                lblDueDate.Text = "No due date";
            this.Visible = true;

            SetButtonVisibility(GetInfo.Role, isDone);


        }
        private void SetButtonVisibility(string currentRole, bool isDone)
        {
            currentRole = (currentRole ?? "").Trim().ToLower();

            // Reset all buttons by default
            btnEdit.Visible = false;
            btnMarkAsDone.Visible = false;
            btnCloseSubmission.Visible = false;

            // President / VP can edit
            if (currentRole == "president" || currentRole == "vice president")
            {
                btnEdit.Visible = true;
            }

            // Everyone can mark as done if not done yet
            btnMarkAsDone.Visible = !isDone;

            // Secretary sees Close Submission
            if (currentRole == "secretary")
            {
                btnCloseSubmission.Visible = true;
                btnCloseSubmission.Click -= btnCloseSubmission_Click; // prevent multiple subscriptions
                btnCloseSubmission.Click += btnCloseSubmission_Click;
            }
        }

        private void btnMarkAsDone_Click(object sender, EventArgs e)
        {
            MarkAnnouncementAsDone();
        }


        private void MarkAnnouncementAsDone()
        {
            if (GetInfo.UserID == 0)
            {
                MessageBox.Show("User not logged in!");
                return;
            }

            string query = @"
            INSERT INTO announcement_status (announcement_id, user_id, status)
            VALUES (@aid, @uid, 'done')
            ON DUPLICATE KEY UPDATE status = 'done';";

            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@aid", AnnouncementId);
                    cmd.Parameters.AddWithValue("@uid", GetInfo.UserID);
                    cmd.ExecuteNonQuery();
                }
            }

            IsDone = true;
            btnMarkAsDone.Visible = false;
            this.BackColor = SystemColors.Control;
            this.Visible = false; // hide card after marking as done

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCloseSubmission_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();

                // 1. Insert 'missing' status for students who haven't marked it as done
                string markMissingQuery = @"
            INSERT INTO announcement_status (announcement_id, user_id, status)
            SELECT a.announcement_id, cs.student_id, 'missing'
            FROM announcements a
            JOIN class_students cs ON cs.class_id = a.class_id
            WHERE a.class_id = @cid
            AND NOT EXISTS (
                SELECT 1 
                FROM announcement_status s
                WHERE s.announcement_id = a.announcement_id
                  AND s.user_id = cs.student_id
                  AND s.status = 'done'
            );";

                using (MySqlCommand cmd = new MySqlCommand(markMissingQuery, con))
                {
                    cmd.Parameters.AddWithValue("@cid", _classId);
                    cmd.ExecuteNonQuery();
                }

                // 2. Optionally, you can hide or disable the announcement cards
                //    instead of deleting them, so the UI can show missing/completed
                // Example: set a flag in announcements table: is_closed = 1
                string closeAnnouncementsQuery = @"
            UPDATE announcements
            SET is_closed = 1
            WHERE class_id = @cid;";

                using (MySqlCommand cmd2 = new MySqlCommand(closeAnnouncementsQuery, con))
                {
                    cmd2.Parameters.AddWithValue("@cid", _classId);
                    cmd2.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Submission closed. Students who didn't mark as done are now marked as missing.");
        }
    }
}

