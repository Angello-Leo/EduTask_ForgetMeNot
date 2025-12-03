using MySql.Data.MySqlClient;
using System;

namespace Design
{
    internal class GetInfo
    {
        public static int UserID { get; set; }
        public static string Username { get; set; }
        public static string Role { get; set; }
        public static int ClassID { get; set; }

        // --- Notification helper ---
        private static string conString = "server=localhost;database=edutask;uid=edutask_app;pwd=Ralfh_Leo_Sheky_Cholo2025!";

        public static void AddNotification(int classId, string message)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();
                    string query = "INSERT INTO notifications (class_id, message) VALUES (@cid, @msg)";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@cid", classId);
                        cmd.Parameters.AddWithValue("@msg", message);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Optional: log the error somewhere
                Console.WriteLine("AddNotification error: " + ex.Message);
            }
        }
    }
}
