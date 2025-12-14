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
using System.Diagnostics;

namespace Design
{
    public partial class frmAccomplished : Form
    {
        private string conString = "server=localhost;database=edutask;uid=edutask_app;pwd=Ralfh_Leo_Sheky_Cholo2025!";
        EnablerPending s = new EnablerPending();
        UiTransition n = new UiTransition();

        public frmAccomplished()
        {
            InitializeComponent();
            panel1.Width = 60;
            panel1.Visible = true;
        }
        private bool panelIsExpanded = false;
        private int panelMaxWidth = 170;
        private int slideSpeed = 98;

        private void picPending_Click(object sender, EventArgs e)
        {
            n.Pending(this);
        }

        private void picHamburgerMenu_Click(object sender, EventArgs e)
        {
            tmrHamburgerMenu.Start();
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

        private void picHome_Click(object sender, EventArgs e)
        {
            n.Home(this);
        }

        private void picHomeIcon_Click(object sender, EventArgs e)
        {
            n.Home(this);
        }

        private void picPendingIcon_Click(object sender, EventArgs e)
        {
            n.Pending(this);
        }

        private void picPendingSelection_Click(object sender, EventArgs e)
        {
            n.Pending(this);
        }

        private void picSchedule_Click(object sender, EventArgs e)
        {
            n.Schedule(this);
        }

        private void picScheduleIcon_Click(object sender, EventArgs e)
        {
            n.Schedule(this);
        }

        private void picFlashcard_Click(object sender, EventArgs e)
        {
            n.Flashcards(this);
        }

        private void picFlashcardIcon_Click(object sender, EventArgs e)
        {
            n.Flashcards(this);
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            //missing
            int currentClassId = GetInfo.ClassID;
            frmMissing f7 = new frmMissing();
            f7.Show();
            this.Hide();
        }

        private void picNotification_Click(object sender, EventArgs e)
        {
            n.Notification(this);
        }

        private void picAddClass_Click(object sender, EventArgs e)
        {
            n.AddClass(this);
        }

        private void frmAccomplished_Load(object sender, EventArgs e)
        {
            s.LoadAccomplishedAnnouncement(flowLayoutPanelAccomplished);
            lblUsername.Text = GetInfo.Username;
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            s.LoadAccomplishedAnnouncement(flowLayoutPanelAccomplished);

        }
        private void picPersonalSelection_Click(object sender, EventArgs e)
        {
            frmPersonal fp = new frmPersonal();
            fp.Show();
            this.Hide();
        }
    }
}



