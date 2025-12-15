using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
                        cmd.Parameters.AddWithValue("@uid", GetInfo.UserID);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var card = new ctrlAnnouncement();

                                DateTime? due = reader["due_datetime"] != DBNull.Value
                                    ? (DateTime?)reader.GetDateTime("due_datetime")
                                    : null;

                                int classId = reader["class_id"] != DBNull.Value
                                    ? Convert.ToInt32(reader["class_id"])
                                    : 0;

                                bool isDone = isDoneResolver(reader);

                                card.LoadAnnouncementData(
                                    reader.GetInt32("announcement_id"),
                                    classId,
                                    reader.GetString("title"),
                                    reader.GetString("content"),
                                    reader.GetDateTime("created_at"),
                                    isDone,
                                    reader.GetString("username"),
                                    reader.GetString("creator_role"),
                                    due
                                );

                                if (highlightColor.HasValue)
                                    card.BackColor = highlightColor.Value;

                                panel.Controls.Add(card);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading announcements: " + ex.Message);
            }

            panel.Visible = true;
            panel.BringToFront();
        }
        public abstract void LoadMissingAnnouncement(FlowLayoutPanel flowLayoutPanelMissing);
        public abstract void LoadAccomplishedAnnouncement(FlowLayoutPanel flowLayoutPanelAccomplished);
        public abstract void LoadPendingAnnouncement(FlowLayoutPanel flowLayoutPanelPendingAssignments);
    }
}
