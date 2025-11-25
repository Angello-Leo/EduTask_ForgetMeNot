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
    public partial class Class : Form
    {
        private frmDashBoard _dashboard;
        private int _classId;
        public Class(int classId, frmDashBoard dashboard)
        {
            InitializeComponent();
            _classId = classId;
            _dashboard = dashboard;   // store dashboard reference
            lblUsername.Text = GetInfo.Username;
            panel1.Visible = false;
        }
        private bool panelIsExpanded = false;
        private int panelMaxWidth = 200;
        private int slideSpeed = 10;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (panelIsExpanded == false)
            {
                panel1.Visible = true;
                int distance = panelMaxWidth - panel1.Width;
                int dynamicSpeed = Math.Max(2, distance / 4);
                panel1.Width += dynamicSpeed;

                if (panel1.Width >= panelMaxWidth)
                {
                    panel1.Width = panelMaxWidth;
                    panelIsExpanded = true;
                    timer1.Stop();
                }
            }
            else
            {
                panel1.Width -= slideSpeed;

                if (panel1.Width <= 0)
                {
                    panel1.Width = 0;
                    panel1.Visible = false;
                    panelIsExpanded = false;
                    timer1.Stop();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //notif
            fmrNotification f4 = new fmrNotification();
            f4.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //add class
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            //ff
            frmFlashcard f5 = new frmFlashcard();
            f5.Show();
            this.Hide();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            //ff
            frmFlashcard f5 = new frmFlashcard();
            f5.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            //home
            _dashboard?.LoadClasses();
            _dashboard?.Show();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //home
            _dashboard?.LoadClasses();
            _dashboard?.Show();
            this.Close();
        }

        private void Class_Load(object sender, EventArgs e)
        {
            LoadClassInfo();
        }

        private void LoadClassInfo()
        {
            string conString = "server=localhost;database=edutask;uid=edutask_app;pwd=Ralfh_Leo_Sheky_Cholo2025!";

            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                string query = @"SELECT c.class_name, c.class_code, c.max_students, u.username AS adviser
                                 FROM classes c
                                 LEFT JOIN users u ON c.adviser_id = u.user_id
                                 WHERE c.class_id = @cid";

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@cid", _classId);

                    using (var rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            lblClassName.Text = rd.GetString("class_name");
                            lblClassCode.Text = rd.GetString("class_code");
                            lblAdviser.Text = rd.IsDBNull(rd.GetOrdinal("adviser")) ? "Student-created" : rd.GetString("adviser");
                        }
                    }
                }
            }
        }


        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void lblClassName_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            frmPending p = new frmPending();
            p.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            frmPending p = new frmPending();
            p.Show();
            this.Hide();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            frmCallendar c = new frmCallendar();
            c.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            frmCallendar c = new frmCallendar();
            c.Show();
            this.Hide();
        }
    }
}
