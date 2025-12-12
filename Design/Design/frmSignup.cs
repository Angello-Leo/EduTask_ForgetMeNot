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
    public partial class frmSignup : Form
    {
        string conString = "server=localhost;database=edutask;uid=edutask_app;pwd=Ralfh_Leo_Sheky_Cholo2025!";
        frmLogin loginForm;
        public frmSignup(frmLogin loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // NEW ROLE LOGIC (checkbox-based)
            string role = "";

            if (chkTeacher.Checked && !chkStudent.Checked)
            {
                role = "teacher";
            }
            else if (!chkTeacher.Checked && chkStudent.Checked)
            {
                role = "student";
            }
            else
            {
                MessageBox.Show("Please select only one role: Teacher OR Student.");
                return;
            }

            if (username == "" || password == "")
            {
                MessageBox.Show("Please fill out all fields.");
                return;
            }

            // Hash password using BCrypt
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            using (MySqlConnection conn = new MySqlConnection(conString))
            {
                try
                {
                    conn.Open();

                    // Check if username exists
                    string checkQuery = "SELECT COUNT(*) FROM users WHERE username=@username";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@username", username);

                    int exists = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (exists > 0)
                    {
                        MessageBox.Show("Username already exists!");
                        return;
                    }

                    // Insert user
                    string query = "INSERT INTO users (username, password_hash, role) VALUES (@username, @password, @role)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", hashedPassword);
                    cmd.Parameters.AddWithValue("@role", role);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Signup successful!");

                    //LoginForm login = new LoginForm();
                    //login.Show();
                    //this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

                GetInfo.Username = username;
                GetInfo.Role = role;
            }
        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginForm.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
