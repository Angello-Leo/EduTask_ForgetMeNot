using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Design
{
    public partial class frmLogin : Form
    {
        string conString = "server=localhost;database=edutask;uid=edutask_app;pwd=Ralfh_Leo_Sheky_Cholo2025!";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                CenterControlsInPanel();
            }
        }

        private void CenterControlsInPanel()
        {
            int panelWidth = this.panel1.ClientSize.Width;
            int panelHeight = this.panel1.ClientSize.Height;

            foreach (Control control in this.panel1.Controls)
            {
                // Skip if the control is not visible
                if (!control.Visible) continue;

                // Center the control inside the panel
                control.Left = (panelWidth - control.Width) / 2;
                control.Top = (panelHeight - control.Height) / 2;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(conString))
            {
                try
                {
                    conn.Open();

                    // Get stored hash and role for the username
                    string query = "SELECT user_id, password_hash, role FROM users WHERE username=@username";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedHash = reader.GetString("password_hash");
                            string role = reader.GetString("role");

                            if (BCrypt.Net.BCrypt.Verify(password, storedHash))
                            {
                                MessageBox.Show("Login successful!");

                                // Store user info
                                GetInfo.UserID = reader.GetInt32("user_id");   // FIXED
                                GetInfo.Username = username;
                                GetInfo.Role = role;

                                reader.Close();

                                string electedQuery = @"SELECT position 
                                        FROM elected_positions 
                                        WHERE user_id = @uid 
                                        ORDER BY id DESC 
                                        LIMIT 1";

                                MySqlCommand electedCmd = new MySqlCommand(electedQuery, conn);
                                electedCmd.Parameters.AddWithValue("@uid", GetInfo.UserID);

                                var electedPosition = electedCmd.ExecuteScalar();

                                if (electedPosition != null)
                                {
                                    GetInfo.Role = electedPosition.ToString();  // "vice president", "president", etc.
                                }
                                System.Diagnostics.Debug.WriteLine("FINAL ROLE AFTER LOGIN = " + GetInfo.Role);
                                frmDashBoard dash = new frmDashBoard();
                                this.Hide();
                                dash.Show();
                            }
                            else
                            {
                                MessageBox.Show("Invalid password!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Username not found!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSignup signup = new frmSignup();
            signup.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
