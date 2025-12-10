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

        public frmAccomplished()
        {
            InitializeComponent();
            panel1.Width = 60;
            panel1.Visible = true;
        }
        private bool panelIsExpanded = false;
        private int panelMaxWidth = 170;
        private int slideSpeed = 98;

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            //pending
            frmPending f7 = new frmPending();
            f7.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();
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

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            //schedule
            frmCallendar f10 = new frmCallendar();
            f10.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //schedule
            frmCallendar f10 = new frmCallendar();
            f10.Show();
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
            frmDashBoard f5 = new frmDashBoard();
            f5.Show();
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //notif
            frmNotification f4 = new frmNotification();
            f4.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //add class
            frmCreateClass f2 = new frmCreateClass();
            f2.Show();
            this.Hide();
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
        private void pictureBox21_Click(object sender, EventArgs e)
        {
            frmPersonal fp = new frmPersonal();
            fp.Show();
            this.Hide();
        }
    }
}



