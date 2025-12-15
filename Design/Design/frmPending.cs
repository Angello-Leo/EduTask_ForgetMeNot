using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
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
    public partial class frmPending : Form
    {
        private string conString = "server=localhost;database=edutask;uid=edutask_app;pwd=Ralfh_Leo_Sheky_Cholo2025!";
        EnablerPending s = new EnablerPending();
        UiTransition n = new UiTransition();

        public frmPending()
        {
            InitializeComponent();
            panel1.Width = 60;
            panel1.Visible = true;
        }
        // Hamburger Menu Fields
        private bool panelIsExpanded = false;
        private int panelMaxWidth = 170;
        private int slideSpeed = 98;

        private void frmPending_Load(object sender, EventArgs e)
        {
            s.LoadPendingAnnouncement(flowLayoutPanelPendingAssignments);
            lblUsername.Text = GetInfo.Username;
        }

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

        private void picPendingSelection_Click(object sender, EventArgs e)
        {
            s.LoadPendingAnnouncement(flowLayoutPanelPendingAssignments);
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
            n.Home(this);
        }

        private void picHomeIcon_Click(object sender, EventArgs e)
        {
            n.Home(this);
        }

        private void picMissingSelection_Click(object sender, EventArgs e)
        {
            n.Missing(this);
        }

        private void picAccomplishedSelection_Click(object sender, EventArgs e)
        {
            n.Accomplished(this);
        }

        private void picPersonalSelection_Click(object sender, EventArgs e)
        {
            n.Personal(this);
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

            /*int result = s.SaveTask(txtTaskTitle.Text, txtTaskContent.Text, dtpTaskDueDate.Value, GetInfo.UserID, conString);
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
            }*/
            panelPersonal.Visible = false;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            panelPersonal.Visible = false;
            flowLayoutPanelPendingAssignments.Controls.Clear();
            //s.LoadPersonalTasks(flowLayoutPanelPendingAssignments);
        }

        private void picSchedule_Click(object sender, EventArgs e)
        {
            n.Schedule(this);
        }

        private void picScheduleIcon_Click(object sender, EventArgs e)
        {
            n.Schedule(this);
        }
    }
}
