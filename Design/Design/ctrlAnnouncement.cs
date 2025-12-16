using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
            string className = GetClassName(classId);
            lblClassName.Text = className;

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
            btnMarkAsDone.Click -= btnMarkAsDone_Click;
            btnMarkAsDone.Click -= MarkPersonalTaskAsDone;


            if (isPersonalTask)
            {
                btnMarkAsDone.Text = "Finished";
                btnMarkAsDone.BackColor = Color.LightBlue;

                // Add personal task handler
                btnMarkAsDone.Click += MarkPersonalTaskAsDone;
            }
            else
            {
                btnMarkAsDone.Text = "Done";
                btnMarkAsDone.BackColor = Color.LightGray;
                btnMarkAsDone.Click += btnMarkAsDone_Click;
            }
        }

        public void SetButtonVisibility(string currentRole, bool isDone, bool isPersonalTask = false, bool isMissing = false)
        {
            Debug.WriteLine($"SetButtonVisibility called with: isDone = {isDone}, isPersonalTask = {isPersonalTask}, isMissing = {isMissing}");

            // Initially hide all buttons
            btnEdit.Visible = false;
            btnCloseSubmission.Visible = false;
            btnMarkAsDone.Visible = false;

            // Handle personal task scenario
            if (isPersonalTask)
            {
                btnMarkAsDone.Visible = !isDone;  // Only show if the task is not done
                btnMarkAsDone.Text = isDone ? "Finished" : "Mark as Done";
                btnMarkAsDone.BackColor = isDone ? Color.LightGreen : Color.LightBlue;
                return;
            }

            // Debugging: Check if we should show the 'Mark as Done' button for non-personal tasks
            if (isMissing || !isDone)
            {
                Debug.WriteLine($"Showing 'Mark as Done' button for status: Missing = {isMissing}, Done = {isDone}");
                btnMarkAsDone.Visible = true;
                btnMarkAsDone.Text = "Mark as Done";
                btnMarkAsDone.BackColor = Color.LightBlue;
            }

            // If task is done, update the button text and color
            if (isDone)
            {
                Debug.WriteLine("Task is done. Showing 'Finished' button.");
                btnMarkAsDone.Text = "Finished";
                btnMarkAsDone.BackColor = Color.LightGreen;
            }


            // Show 'Close Submission' button for 'secretary' role
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

        private void MarkPersonalTaskAsDone(object sender, EventArgs e)
        {
            if (GetInfo.UserID == 0)
            {
                MessageBox.Show("User not logged in!");
                return;
            }

            string query = @"
        UPDATE personal_tasks
        SET status = 'done'
        WHERE task_id = @tid AND user_id = @uid;
    ";

            try
            {
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@tid", AnnouncementId); // use AnnouncementId to store task_id
                        cmd.Parameters.AddWithValue("@uid", GetInfo.UserID);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            MessageBox.Show("Task not found or already done.");
                            return;
                        }
                    }
                }

                // Update UI
                IsDone = true;
                btnMarkAsDone.Visible = false;
                this.BackColor = SystemColors.Control;
                this.Visible = false; // hide the card
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error marking task as done: " + ex.Message);
            }
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
        private string GetClassName(int classId)
        {
            string className = string.Empty;

            // MySQL query to get the class name by class_id
            string query = "SELECT class_name FROM classes WHERE class_id = @classId";

            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@classId", classId);

                    // Execute the query and read the class name
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            className = reader.GetString("class_name");
                        }
                    }
                }
            }

            return className;
        }
    }
}
