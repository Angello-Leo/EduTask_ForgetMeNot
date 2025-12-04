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

        public void LoadAnnouncementData(
    int announcementId,
    int classId,
    string title,
    string content,
    DateTime createdAt,
    bool isDone,
    string username,
    string creatorRole,
    DateTime? dueDateTime,
    bool isPersonalTask = false      // <-- new flag
)
        {
            AnnouncementId = announcementId;
            IsDone = isDone;
            _classId = classId;

            lblTitle.Text = title;
            lblContent.Text = content;

            if (!isPersonalTask)
            {
                lblCreatedBy.Text = $"{username} ({creatorRole})";
            }
            else
            {
                lblCreatedBy.Text = "Personal Task";
            }

            lblCreatedAt.Text = createdAt.ToString("g");

            lblDueDate.Text = dueDateTime.HasValue
                ? dueDateTime.Value.ToString("g")
                : "No due date";

            this.Visible = true;

            SetButtonVisibility(GetInfo.Role, isDone, isPersonalTask);
        }

        private void SetButtonVisibility(string currentRole, bool isDone, bool isPersonalTask = false)
        {
            // Hide all buttons for personal tasks
            if (isPersonalTask)
            {
                btnEdit.Visible = false;
                btnCloseSubmission.Visible = false;

                // user can still mark a task as done
                btnMarkAsDone.Visible = !isDone;
                return;
            }

            // Original logic for announcements:
            currentRole = (currentRole ?? "").Trim().ToLower();

            btnEdit.Visible = false;
            btnMarkAsDone.Visible = !isDone;
            btnCloseSubmission.Visible = false;

            if (currentRole == "president" || currentRole == "vice president")
                btnEdit.Visible = true;

            if (currentRole == "secretary")
            {
                btnCloseSubmission.Visible = true;
                btnCloseSubmission.Click -= btnCloseSubmission_Click;
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
            if (AnnouncementId == 0)
            {
                MessageBox.Show("Announcement ID is not valid.");
                return;
            }

            // Retrieve all students in the class
            List<int> studentIds = new List<int>();

            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();

                // Query to get all students enrolled in the class
                string getStudentsQuery = @"
            SELECT student_id
            FROM class_students
            WHERE class_id = @cid";

                using (MySqlCommand cmd = new MySqlCommand(getStudentsQuery, con))
                {
                    cmd.Parameters.AddWithValue("@cid", _classId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            studentIds.Add(reader.GetInt32("student_id"));
                        }
                    }
                }

                // 1. Insert 'missing' status for students who haven't marked it as done
                foreach (int studentId in studentIds)
                {
                    string markMissingQuery = @"
                INSERT INTO announcement_status (announcement_id, user_id, status)
                VALUES (@announcement_id, @user_id, 'missing')
                ON DUPLICATE KEY UPDATE status = 'missing';"; // If already exists, update the status to 'missing'

                    using (MySqlCommand cmd = new MySqlCommand(markMissingQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@announcement_id", AnnouncementId); // The current announcement
                        cmd.Parameters.AddWithValue("@user_id", studentId); // Student's user_id
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Submission closed. Students who didn't mark as done are now marked as missing.");
            }

        }
    }
}
