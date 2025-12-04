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
    public partial class frmNotification : Form
    {
        public static string conString = "server=localhost;database=edutask;uid=edutask_app;pwd=Ralfh_Leo_Sheky_Cholo2025!";

        public frmNotification()
        {
            InitializeComponent();
            NotificationManager.CurrentForm = this; // register this instance
            LoadNotifications();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmDashBoard f1 = new frmDashBoard();
            f1.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            LoadNotifications();
        }

        private void LoadNotifications()
        {
            flowLayoutPanelNotif.Controls.Clear();
            flowLayoutPanelNotif.AutoScroll = true; // ensure scrolling

            using (MySqlConnection con = new MySqlConnection(frmNotification.conString))
            {
                con.Open();

                string query = @"
            SELECT n.notification_id, n.message, n.created_at, n.user_id, n.class_id, n.is_read,
                   u.username AS sender, c.class_name
            FROM notifications n
            LEFT JOIN users u ON n.user_id = u.user_id
            LEFT JOIN classes c ON n.class_id = c.class_id
            WHERE n.user_id = @uid OR n.class_id IN 
                  (SELECT class_id FROM class_students WHERE student_id = @uid)
            ORDER BY n.created_at DESC;";

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@uid", GetInfo.UserID);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int notificationId = reader.GetInt32("notification_id");
                            string message = reader["message"]?.ToString() ?? "";
                            DateTime createdAt = reader["created_at"] != DBNull.Value
                                ? reader.GetDateTime("created_at")
                                : DateTime.Now;

                            bool isRead = reader["is_read"] != DBNull.Value && Convert.ToBoolean(reader["is_read"]);

                            string type = "system"; // default
                            if (reader["class_id"] != DBNull.Value)
                                type = "announcement";
                            else if (reader["user_id"] != DBNull.Value)
                                type = "role";

                            var notifCard = new ctrlNotification();
                            notifCard.Width = flowLayoutPanelNotif.Width - 25;
                            notifCard.Height = 60;
                            notifCard.LoadNotificationData(notificationId, message, createdAt, type, isRead);

                            flowLayoutPanelNotif.Controls.Add(notifCard);
                        }
                    }
                }
            }
        }

        public void AddNotificationToPanel(int notificationId, string message, string type, DateTime createdAt)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => AddNotificationToPanel(notificationId, message, type, createdAt)));
                return;
            }

            var notifCard = new ctrlNotification();
            notifCard.Width = flowLayoutPanelNotif.Width - 25;
            notifCard.Height = 60;
            notifCard.LoadNotificationData(notificationId, message, createdAt, type, false);

            flowLayoutPanelNotif.Controls.Add(notifCard);

            // Auto-scroll to latest
            flowLayoutPanelNotif.VerticalScroll.Value = flowLayoutPanelNotif.VerticalScroll.Maximum;
            flowLayoutPanelNotif.PerformLayout();
        }



        private void flowLayoutPanelNotif_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
