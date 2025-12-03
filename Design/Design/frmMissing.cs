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
    public partial class frmMissing : Form
    {
        private string conString = "server=localhost;database=edutask;uid=edutask_app;pwd=Ralfh_Leo_Sheky_Cholo2025!";
        private int _classId;

        public frmMissing(int classId)
        {
            InitializeComponent();
            _classId = classId;
            panel1.Width = 60;
            panel1.Visible = true;

        }
        private bool panelIsExpanded = false;
        private int panelMaxWidth = 170;
        private int slideSpeed = 98;

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
            //pendign
            frmPending f7 = new frmPending();
            f7.Show();
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

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            //pending
            frmPending f7 = new frmPending();
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //notif
            frmNotification f4 = new frmNotification();
            f4.Show();
            this.Hide();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // add class
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            LoadMissingAssignments();
        }

        private void frmMissing_Load(object sender, EventArgs e)
        {

        }
        private void LoadMissingAssignments()
        {
            flowLayoutPanelMissing.Controls.Clear();
            flowLayoutPanelMissing.AutoScroll = true;

            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();

                string query = @"
        SELECT a.assignment_id, a.title, a.description, a.due_date
        FROM assignments a
        LEFT JOIN assignment_status s 
            ON s.assignment_id = a.assignment_id 
            AND s.student_id = @uid
        WHERE a.class_id = @cid
          AND a.due_date < NOW()                -- past due
          AND (s.status IS NULL OR s.status = 'pending') -- not completed
        ORDER BY a.due_date ASC;";

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@uid", GetInfo.UserID);
                    cmd.Parameters.AddWithValue("@cid", _classId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var assignmentCard = new ctrlAssignment();

                            DateTime? dueDate = reader["due_date"] != DBNull.Value
                                ? (DateTime?)reader.GetDateTime("due_date")
                                : null;

                            assignmentCard.LoadAssignmentData(
                                reader.GetInt32("assignment_id"),
                                reader.GetString("title"),
                                reader["description"]?.ToString(),
                                dueDate
                            );

                            // Highlight missing assignments
                            assignmentCard.BackColor = Color.LightCoral;

                            flowLayoutPanelMissing.Controls.Add(assignmentCard);
                        }
                    }
                }
            }

            flowLayoutPanelMissing.Visible = true;
            flowLayoutPanelMissing.BringToFront();
        }

    }
}
