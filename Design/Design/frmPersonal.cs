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
    public partial class frmPersonal : Form
    {
        private string conString = "server=localhost;database=edutask;uid=edutask_app;pwd=Ralfh_Leo_Sheky_Cholo2025!";

        public frmPersonal()
        {
            InitializeComponent();
            LoadPersonalTasks();
            panel1.Width = 60;
            panel1.Visible = true;
            lblUsername.Text = GetInfo.Username;

        }
        private bool panelIsExpanded = false;
        private int panelMaxWidth = 170;
        private int slideSpeed = 98;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            //pending 
            frmPending f7 = new frmPending();
            f7.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //pending
            frmPending f7 = new frmPending();
            f7.Show();
            this.Hide();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (panelIsExpanded)
            {
                panel1.Width -= slideSpeed;
                if (panel1.Width <= 0)
                {
                    panel1.Visible = false;
                    panel1.Width = 0;
                    panelIsExpanded = false;
                    timer1.Stop();
                }
            }
            else
            {
                panel1.Width += slideSpeed;
                if (panel1.Width >= panelMaxWidth)
                {
                    panel1.Visible = true;
                    panel1.Width = panelMaxWidth;
                    panelIsExpanded = true;
                    timer1.Stop();
                }

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //notif
            frmNotification notification = new frmNotification();
            notification.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //add cvlass
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            //ff
            frmFlashcard f5 = new frmFlashcard();
            f5.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            //ff
            frmFlashcard f5 = new frmFlashcard();
            f5.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            //home
            frmDashBoard f1 = new frmDashBoard();
            f1.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //home
            frmDashBoard f1 = new frmDashBoard();
            f1.Show();
            this.Hide();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            //missing
            frmMissing m = new frmMissing();
            m.Show();
            this.Hide();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            //accomplished
            frmAccomplished f9 = new frmAccomplished();
            f9.Show();
            this.Hide();
        }
        private void pictureBox21_Click(object sender, EventArgs e)
        {
            panelPersonal.Visible = true;
            panelPersonal.BringToFront();
            flowLayoutPanelPendingAssignments.Controls.Clear();
            LoadPersonalTasks();
        }
        private void btnSaveTask_Click(object sender, EventArgs e)
        {
            string title = txtTaskTitle.Text;
            string content = txtTaskTitle.Text;
            DateTime? dueDate = dtpTaskDueDate.Value;

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(content))
            {
                MessageBox.Show("Please fill in both title and content.");
                return;
            }

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
                        cmd.Parameters.AddWithValue("@user_id", GetInfo.UserID);
                        cmd.Parameters.AddWithValue("@title", title);
                        cmd.Parameters.AddWithValue("@content", content);
                        cmd.Parameters.AddWithValue("@due_datetime", (object)dueDate ?? DBNull.Value);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Task created successfully!");
                            // Optionally clear the input fields
                            txtTaskTitle.Clear();
                            txtTaskTitle.Clear();
                            dtpTaskDueDate.Value = DateTime.Now; // Reset to current date
                            LoadPersonalTasks(); // Refresh the list of personal tasks
                        }
                        else
                        {
                            MessageBox.Show("Error saving the task.");
                        }
                    }
                }
                panelPersonal.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void LoadPersonalTasks()
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
