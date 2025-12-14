using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design
{
    internal abstract class PendingLogic
    {
        public int SaveTask(string title, string content, DateTime? dueDate, int userID, string conString)
        {
            int result = 0;
            try
            {
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();
                    string query = @"
                INSERT INTO personal_tasks (user_id, title, content, due_datetime, created_at)
                VALUES (@user_id, @title, @content, @due_datetime, NOW());";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@user_id", userID);
                        cmd.Parameters.AddWithValue("@title", title);
                        cmd.Parameters.AddWithValue("@content", content);
                        cmd.Parameters.AddWithValue("@due_datetime", (object)dueDate ?? DBNull.Value);
                        result = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return result;
        }
        public abstract void LoadMissingAnnouncement(FlowLayoutPanel flowLayoutPanelMissing);
        public abstract void LoadAccomplishedAnnouncement(FlowLayoutPanel flowLayoutPanelAccomplished);
        public abstract void LoadPendingAnnouncement(FlowLayoutPanel flowLayoutPanelPendingAssignments);
        public abstract void LoadPersonalTasks(FlowLayoutPanel flowLayoutPanelPendingAssignments);
    }
}
