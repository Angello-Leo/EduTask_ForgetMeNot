using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        EnablerPending s = new EnablerPending();
        UiTransition n = new UiTransition();

        public frmPersonal()
        {
            InitializeComponent();
            s.LoadPersonalTasks(flowLayoutPanelPendingAssignments);
            panel1.Width = 60;
            panel1.Visible = true;
            lblUsername.Text = GetInfo.Username;
            ShowPersonalPanel();

        }

        // Hamburger Menu Field
        private bool panelIsExpanded = false;
        private int panelMaxWidth = 170;
        private int slideSpeed = 98;

        private void picHamburgerMenu_Click(object sender, EventArgs e)
        {
            tmrHamburgerMenu.Start();
        }

        private void picPending_Click(object sender, EventArgs e)
        {
            n.Pending(this);
        }

        private void picPendingIcon_Click(object sender, EventArgs e)
        {
            n.Pending(this);
        }
        private void tmrHamburgerMenu_Tick(object sender, EventArgs e)
        {
            if (panelIsExpanded)
            {
                panel1.Width -= slideSpeed;
                if (panel1.Width <= 0)
                {
                    panel1.Visible = false;
                    panel1.Width = 0;
                    panelIsExpanded = false;
                    tmrHamburgerMenu.Stop();
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
                    tmrHamburgerMenu.Stop();
                }

            }
        }

        private void picNotification_Click(object sender, EventArgs e)
        {
           n.Notification(this);
        }

        private void picAddClass_Click(object sender, EventArgs e)
        {
            n.AddClass(this);
        }

        private void picFlashcard_Click(object sender, EventArgs e)
        {
            n.Flashcards(this);
        }

        private void picFlashcardIcon_Click(object sender, EventArgs e)
        {
           n.Flashcards(this);
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            n.Flashcards(this);
        }

        private void picHomeIcon_Click(object sender, EventArgs e)
        {
            n.Home(this);
        }

        private void picMissingSelection_Click(object sender, EventArgs e)
        {
            //missing
            frmMissing m = new frmMissing();
            m.Show();
            this.Hide();
        }

        private void picAccomplishedSelection_Click(object sender, EventArgs e)
        {
            //accomplished
            frmAccomplished f9 = new frmAccomplished();
            f9.Show();
            this.Hide();
        }
        private void ShowPersonalPanel()
        {
            panelPersonal.Visible = true;
            panelPersonal.BringToFront();
            flowLayoutPanelPendingAssignments.Controls.Clear();
            s.LoadPersonalTasks(flowLayoutPanelPendingAssignments);
        }

        private void picPersonalSelection_Click(object sender, EventArgs e)
        {
            ShowPersonalPanel();
        }
        private void picSchedule_Click(object sender, EventArgs e)
        {
           n.Schedule(this);
        }

        private void picScheduleIcon_Click(object sender, EventArgs e)
        {
            n.Schedule(this);
        }

        private void picPendingSelection_Click(object sender, EventArgs e)
        {

        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            panelPersonal.Visible = false;
            s.LoadPersonalTasks(flowLayoutPanelPendingAssignments);
        }

        private void btnSaveTask_Click_1(object sender, EventArgs e)
        {
            string title = txtTaskTitle.Text;
            string content = txtTaskTitle.Text;
            DateTime? dueDate = dtpTaskDueDate.Value;

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(content))
            {
                MessageBox.Show("Please fill in both title and content.");
                return;
            }

            int result = s.SaveTask(txtTaskTitle.Text, txtTaskContent.Text, dtpTaskDueDate.Value, GetInfo.UserID, conString);
            if (result > 0)
            {
                MessageBox.Show("Task created successfully!");
                // Optionally clear the input fields
                txtTaskTitle.Clear();
                txtTaskTitle.Clear();
                dtpTaskDueDate.Value = DateTime.Now; // Reset to current date
                s.LoadPersonalTasks(flowLayoutPanelPendingAssignments); // Refresh the list of personal tasks
            }
            else
            {
                MessageBox.Show("Error saving the task.");
            }
            panelPersonal.Visible = false;
        }
        private void LoadCompletedPersonalTasks()
        {
            flowLayoutPanelPendingAssignments.Controls.Clear();  // Clear previous data
            flowLayoutPanelPendingAssignments.AutoScroll = true;  // Enable scrolling

            flowLayoutPanelPendingAssignments.Visible = true;
            flowLayoutPanelPendingAssignments.BringToFront();

            // Log the action
            Debug.WriteLine($"Loading all completed tasks for UserID: {GetInfo.UserID}");

            using (MySqlConnection con = new MySqlConnection(conString))
            {
                try
                {
                    con.Open();
                    Debug.WriteLine("Database connection established.");

                    string query = @"
                SELECT task_id, title, content, due_datetime, created_at, status
                FROM personal_tasks
                WHERE user_id = @uid AND status = 'done'
                ORDER BY due_datetime ASC;";  // Sort by due date

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@uid", GetInfo.UserID);  // Filter by current user

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            int recordCount = 0;

                            while (reader.Read())
                            {
                                recordCount++;

                                string title = reader["title"].ToString();
                                string status = reader["status"].ToString();
                                Debug.WriteLine($"Task Found: {title}, Status: {status}");

                                if (string.IsNullOrEmpty(title))
                                {
                                    Debug.WriteLine("Error: Missing title in task.");
                                    continue;
                                }

                                var taskCard = new ctrlAnnouncement(); // Reusing your announcement control

                                int taskId = reader.GetInt32("task_id");
                                string content = reader["content"].ToString();
                                DateTime dueDate = reader["due_datetime"] == DBNull.Value
                                    ? DateTime.MinValue
                                    : reader.GetDateTime("due_datetime");
                                DateTime createdAt = reader.GetDateTime("created_at");

                                // These are done tasks
                                bool isDone = true;

                                taskCard.LoadAnnouncementData(
                                    taskId,
                                    0,  // No class ID needed
                                    title,
                                    content,
                                    createdAt,
                                    isDone,
                                    "You",  // Owner of the task
                                    "owner",
                                    dueDate
                                );

                                flowLayoutPanelPendingAssignments.Controls.Add(taskCard);
                            }

                            if (recordCount == 0)
                            {
                                Debug.WriteLine("No completed tasks found.");
                                MessageBox.Show("No completed tasks found.");
                            }
                            else
                            {
                                Debug.WriteLine($"{recordCount} completed tasks found.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading completed tasks: {ex.Message}");
                    Debug.WriteLine($"Error: {ex.Message}");
                }
            }

            flowLayoutPanelPendingAssignments.Refresh();  // Refresh to show loaded tasks
        }
        private void btnShowAccomplished_Click(object sender, EventArgs e)
        {
            LoadCompletedPersonalTasks();
        }
    }
}
