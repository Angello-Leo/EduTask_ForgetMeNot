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
        private string conString = "server=localhost;database=edutask;uid=edutask_app;pwd=Ralfh_Leo_Sheky_Cholo2025!";

        public frmNotification()
        {
            InitializeComponent();
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
            flowLayoutPanelNotif.Controls.Clear();

            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                string query = @"
            SELECT message, created_at
            FROM notifications
            WHERE class_id = @cid
            ORDER BY created_at DESC";

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@cid", GetInfo.ClassID);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Label lbl = new Label();
                            lbl.Text = $"{reader["created_at"]:g} - {reader["message"]}";
                            lbl.AutoSize = true;
                            lbl.MaximumSize = new Size(flowLayoutPanelNotif.Width - 20, 0);
                            lbl.Font = new Font("Segoe UI", 9, FontStyle.Regular);

                            flowLayoutPanelNotif.Controls.Add(lbl);
                        }
                    }
                }
            }
        }
    }
}
