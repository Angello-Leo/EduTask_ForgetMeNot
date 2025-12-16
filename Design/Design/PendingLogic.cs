using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design
{
    internal abstract class PendingLogic
    {
        protected string conString = "server=localhost;database=edutask;uid=edutask_app;pwd=Ralfh_Leo_Sheky_Cholo2025!";
        protected void LoadAnnouncements(FlowLayoutPanel panel, string query, Func<MySqlDataReader, bool> isDoneResolver,
        Color? highlightColor = null)
        {
            panel.Controls.Clear();
            panel.AutoScroll = true;

            try
            {
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        // Add parameters
                        cmd.Parameters.AddWithValue("@uid", GetInfo.UserID);    


                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            int count = 0;

                            while (reader.Read())
                            {
                                count++;

                                // Debug each row
                                Debug.WriteLine($"Row {count}: ID={reader["announcement_id"]}, Title={reader["title"]}, Status={reader["status"] ?? "NULL"}, ClassID={reader["class_id"]}");

                                var card = new ctrlAnnouncement();

                                // Safely get due date
                                DateTime? due = reader["due_datetime"] != DBNull.Value
                                    ? (DateTime?)reader.GetDateTime("due_datetime")
                                    : null;

                                string status = reader["status"].ToString().Trim().ToLower();
                                bool isDone = status == "done";  // Mark as done if the status is "done"
                                bool isMissing = status == "missing";  // Mark as missing if the status is "missing"

                                // Handle pending tasks - if the status is neither "done" nor "missing", treat it as pending
                                if (!isDone && !isMissing)
                                {
                                    isDone = false;  // It's not done if it's neither done nor missing
                                    isMissing = false;  // It's not missing if it's neither done nor missing
                                }

                                Debug.WriteLine($"isDone for announcement {reader["announcement_id"]}: {isDone}");
                                // Load announcement data
                                card.LoadAnnouncementData(
                                    reader.GetInt32("announcement_id"),
                                    reader.GetInt32("class_id"),
                                    reader["title"].ToString(),
                                    reader["content"].ToString(),
                                    reader.GetDateTime("created_at"),
                                    isDone,
                                    reader["username"].ToString(),
                                    reader["creator_role"].ToString(),
                                    due
                                );

                                if (highlightColor.HasValue)
                                    card.BackColor = highlightColor.Value;

                                // Update the button visibility based on the task status and user role
                                card.SetButtonVisibility(GetInfo.Role, isDone);

                                panel.Controls.Add(card);
                            }

                            // If no rows returned, show a debug message
                            if (count == 0)
                            {
                                Debug.WriteLine("No rows returned by query.");
                                MessageBox.Show("No announcements found for this class/user.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    $"MySQL Error {ex.Number}\n{ex.Message}",
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            panel.Visible = true;
            panel.BringToFront();
        }
        public abstract void LoadMissingAnnouncement(FlowLayoutPanel flowLayoutPanelMissing);
        public abstract void LoadAccomplishedAnnouncement(FlowLayoutPanel flowLayoutPanelAccomplished);
        public abstract void LoadPendingAnnouncement(FlowLayoutPanel flowLayoutPanelPendingAssignments);
    }
}
