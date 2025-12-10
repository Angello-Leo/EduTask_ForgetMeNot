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

        public frmPending()
        {
            InitializeComponent();
            panel1.Width = 60;
            panel1.Visible = true;
        }
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
            s.LoadPendingAnnouncement(flowLayoutPanelPendingAssignments);
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
            frmNotification f4 = new frmNotification();
            f4.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //add cvlass
            frmCreateClass f2 = new frmCreateClass();
            f2.Show();
            this.Hide();
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

        private void picHome_Click(object sender, EventArgs e)
        {
            //home
            frmDashBoard f1 = new frmDashBoard();
            f1.Show();
            this.Hide();
        }

        private void picHomeIcon_Click(object sender, EventArgs e)
        {
            //home
            frmDashBoard f1 = new frmDashBoard();
            f1.Show();
            this.Hide();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            //missing
            int currentClassId = GetInfo.ClassID;
            frmMissing f7 = new frmMissing();
            f7.Show();
            this.Hide();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            //accomplished
            frmAccomplished f7 = new frmAccomplished();
            f7.Show();
            this.Hide();
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            frmPersonal p = new frmPersonal();
            p.Show();
            this.Hide();
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
        private void panelPersonal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            panelPersonal.Visible = false;
            flowLayoutPanelPendingAssignments.Controls.Clear();
            s.LoadPersonalTasks(flowLayoutPanelPendingAssignments);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            frmCallendar c = new frmCallendar();
            c.Show();
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            frmCallendar c = new frmCallendar();
            c.Show();
            this.Close();
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {

        }
    }
}
