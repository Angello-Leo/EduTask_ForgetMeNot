using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design
{
    internal class EnablerPending : PendingLogic
    {
        private string conString = "server=localhost;database=edutask;uid=edutask_app;pwd=Ralfh_Leo_Sheky_Cholo2025!";

        public override void LoadMissingAnnouncement(FlowLayoutPanel flowLayoutPanelMissing)
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
        public override void LoadAccomplishedAnnouncement(FlowLayoutPanel flowLayoutPanelAccomplished)
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
        public override void LoadPendingAnnouncement(FlowLayoutPanel flowLayoutPanelPendingAssignments)
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
        public override void LoadPersonalTasks(FlowLayoutPanel flowLayoutPanelPendingAssignments)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();
                    string query = @"
                    SELECT task_id, title, content, due_datetime, created_at, status
                    FROM personal_tasks
                    WHERE user_id = @uid AND status = 'pending'
                    ORDER BY created_at DESC;";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@uid", GetInfo.UserID);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var taskCard = new ctrlAnnouncement();

                                DateTime? due = reader["due_datetime"] != DBNull.Value
                                    ? reader.GetDateTime("due_datetime")
                                    : (DateTime?)null;

                                taskCard.LoadAnnouncementData(
                                    announcementId: reader.GetInt32("task_id"),
                                    classId: 0,
                                    title: reader.GetString("title"),
                                    content: reader.GetString("content"),
                                    createdAt: reader.GetDateTime("created_at"),
                                    isDone: false,
                                    username: "",
                                    creatorRole: "",
                                    dueDateTime: due,
                                    isPersonalTask: true   // <-- IMPORTANT!
                                );

                                taskCard.BackColor = Color.LightGreen;

                                flowLayoutPanelPendingAssignments.Controls.Add(taskCard);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading personal tasks: " + ex.Message);
            }
        }
    }
}
