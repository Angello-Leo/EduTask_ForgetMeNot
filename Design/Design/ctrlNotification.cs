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
    public partial class ctrlNotification : UserControl
    {
        private string conString = "server=localhost;database=edutask;uid=edutask_app;pwd=Ralfh_Leo_Sheky_Cholo2025!";
        public int NotificationId { get; private set; }
        public bool IsRead { get; private set; }

        public ctrlNotification()
        {
            InitializeComponent();
            this.AutoSize = false; // explicitly
            this.Height = 150;
        }

        private void ctrlNotification_Load(object sender, EventArgs e)
        {

        }
        public void LoadNotificationData(int notificationId, string message, DateTime createdAt, string type, bool isRead)
        {
            NotificationId = notificationId;
            IsRead = isRead;

            lblMessage.Text = message;
            lblTimestamp.Text = createdAt.ToString("g");

            // Color coding by type
            switch (type)
            {
                case "announcement":
                    this.BackColor = Color.LightSalmon;
                    break;
                case "personal_task":
                    this.BackColor = Color.LightGreen;
                    break;
                case "system":
                    this.BackColor = Color.LightGray;
                    break;
                case "role":
                    this.BackColor = Color.LightBlue;
                    break;
                default:
                    this.BackColor = Color.White;
                    break;
            }

            this.ForeColor = isRead ? Color.Gray : Color.Black;

            // Show or hide "Mark as Read" button
            btnMarkRead.Visible = !isRead;
            btnMarkRead.Click -= btnMarkRead_Click;
            btnMarkRead.Click += btnMarkRead_Click;
        }


        private void btnMarkRead_Click(object sender, EventArgs e)
        {
            using (var con = new MySql.Data.MySqlClient.MySqlConnection(frmNotification.conString))
            {
                con.Open();
                string updateQuery = "UPDATE notifications SET is_read = 1 WHERE notification_id = @nid";
                using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(updateQuery, con))
                {
                    cmd.Parameters.AddWithValue("@nid", NotificationId);
                    cmd.ExecuteNonQuery();
                }
            }

            IsRead = true;
            btnMarkRead.Visible = false;
            this.ForeColor = Color.Gray;
        }
    }
}

