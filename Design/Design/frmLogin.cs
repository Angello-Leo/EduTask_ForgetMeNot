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
    public partial class frmLogin : Form
    {
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
            // Dito ka na magvalidation para pumunta sa dashboard

            frmDashBoard frmDashBoard = new frmDashBoard();
            frmDashBoard.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSignup signup = new frmSignup();
            signup.Show();
            this.Hide();
        }
    }
}
