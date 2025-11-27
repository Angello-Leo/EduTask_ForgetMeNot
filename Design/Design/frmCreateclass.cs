using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Design
{
    public partial class Form2 : Form
    {
        private frmDashBoard _dashboard;
        private bool panelIsExpanded = false;
        private int panelMaxWidth = 200;
        private int slideSpeed = 10;

        public Form2(frmDashBoard dashboard = null)
        {
            InitializeComponent();
            panel1.Visible = true;
            lblUsername.Text = GetInfo.Username;
            _dashboard = dashboard;// store reference to dashboard
        }
        private string GenerateClassCode()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random rand = new Random();

            return new string(Enumerable.Repeat(chars, 7)
                        .Select(s => s[rand.Next(s.Length)]).ToArray());
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1️⃣ Validate inputs
            if (string.IsNullOrWhiteSpace(richTextBoxClassName.Text))
            {
                MessageBox.Show("Please enter a class name.");
                return;
            }

            if (!int.TryParse(richTextBoxClassmates.Text.Trim(), out int maxStudents))
            {
                MessageBox.Show("Max students must be a number.");
                return;
            }

            string className = richTextBoxClassName.Text.Trim();
            string classCode;
            long newClassId = 0; // Use long to match MySQL LastInsertedId

            string conString = "server=localhost;database=edutask;uid=edutask_app;pwd=Ralfh_Leo_Sheky_Cholo2025!";

            try
            {
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();

                    // 2️⃣ Ensure unique class code
                    bool codeExists;
                    do
                    {
                        classCode = GenerateClassCode();
                        string checkQuery = "SELECT COUNT(*) FROM classes WHERE class_code=@code";
                        using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, con))
                        {
                            checkCmd.Parameters.AddWithValue("@code", classCode);
                            codeExists = Convert.ToInt32(checkCmd.ExecuteScalar()) > 0;
                        }
                    } while (codeExists);

                    // 3️⃣ Insert class
                    string insertQuery = @"INSERT INTO classes (class_name, class_code, adviser_id, creator_id, max_students) 
                       VALUES (@name, @code, @adviser, @creator, @max)";

                    using (var cmd = new MySqlCommand(insertQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@name", className);
                        cmd.Parameters.AddWithValue("@code", classCode);
                        cmd.Parameters.AddWithValue("@adviser", GetInfo.Role == "teacher" ? GetInfo.UserID : (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@creator", GetInfo.UserID);
                        cmd.Parameters.AddWithValue("@max", maxStudents);

                        cmd.ExecuteNonQuery();
                        newClassId = cmd.LastInsertedId;
                    }

                    // 4️⃣ Auto-enroll student if not a teacher
                    if (GetInfo.Role != "teacher" && newClassId > 0)
                    {
                        string enrollQuery = "INSERT IGNORE INTO class_students (class_id, student_id) VALUES (@cid, @sid)";
                        using (var enrollCmd = new MySqlCommand(enrollQuery, con))
                        {
                            enrollCmd.Parameters.AddWithValue("@cid", newClassId);
                            enrollCmd.Parameters.AddWithValue("@sid", GetInfo.UserID);
                            enrollCmd.ExecuteNonQuery();
                        }
                    }
                }

                // 5️⃣ Refresh dashboard safely
                _dashboard?.LoadClasses();

                // 6️⃣ Open the newly created class page
                Class cls = new Class((int)newClassId, _dashboard);
                cls.Show();
                this.Hide();
            }
            catch (MySqlException ex)
            {
                // Only show real errors
                MessageBox.Show("MySQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Any other error
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //navigation icon
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //add icon 

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //notif icon
            fmrNotification f4 = new fmrNotification();
            f4.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //message icon
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            ///flashcards
            frmFlashcard f5 = new frmFlashcard();
            f5.Show();
            this.Hide();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            // ff
            frmFlashcard f5 = new frmFlashcard();
            f5.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            //home 
            _dashboard?.LoadClasses(); // reload the dashboard
            _dashboard?.Show();        // make it visible
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //home
            _dashboard?.LoadClasses(); // reload the dashboard
            _dashboard?.Show();        // make it visible
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        //Join class
        private void button2_Click(object sender, EventArgs e)
        {
            string enteredCode = richTextBoxClassCode.Text.Trim();
            if (string.IsNullOrEmpty(enteredCode))
            {
                MessageBox.Show("Please enter a class code.");
                return;
            }

            string conString = "server=localhost;database=edutask;uid=edutask_app;pwd=Ralfh_Leo_Sheky_Cholo2025!";

            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();

                // 1️⃣ Find the class info (id and max_students)
                string findClass = "SELECT class_id, max_students FROM classes WHERE class_code = @code";
                MySqlCommand cmd = new MySqlCommand(findClass, con);
                cmd.Parameters.AddWithValue("@code", enteredCode);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int classId = reader.GetInt32("class_id");
                        int maxStudents = reader.GetInt32("max_students");
                        reader.Close();

                        // 2️⃣ Count current students
                        string countQuery = "SELECT COUNT(*) FROM class_students WHERE class_id = @cid";
                        MySqlCommand countCmd = new MySqlCommand(countQuery, con);
                        countCmd.Parameters.AddWithValue("@cid", classId);
                        int currentCount = Convert.ToInt32(countCmd.ExecuteScalar());

                        if (currentCount >= maxStudents)
                        {
                            MessageBox.Show("This class has already reached its maximum number of students.");
                            return;
                        }

                        // 3️⃣ Enroll student
                        string enrollQuery = "INSERT IGNORE INTO class_students (class_id, student_id) VALUES (@cid, @sid)";
                        MySqlCommand enrollCmd = new MySqlCommand(enrollQuery, con);
                        enrollCmd.Parameters.AddWithValue("@cid", classId);
                        enrollCmd.Parameters.AddWithValue("@sid", GetInfo.UserID);
                        enrollCmd.ExecuteNonQuery();

                        MessageBox.Show("Successfully joined the class!");

                        // Open the class page
                        Class clsPage = new Class(classId, _dashboard);
                        clsPage.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid class code.");
                    }
                }
            }
        }


        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click_1(object sender, EventArgs e)
        {
            _dashboard?.LoadClasses(); // reload the dashboard
            _dashboard?.Show();        // make it visible
            this.Hide();
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            _dashboard?.LoadClasses(); // reload the dashboard
            _dashboard?.Show();        // make it visible
            this.Hide();
        }

        private void pictureBox10_Click_1(object sender, EventArgs e)
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

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            frmPending p = new frmPending();
            p.Show();
            this.Hide();
        }

        private void pictureBox12_Click_1(object sender, EventArgs e)
        {
            frmFlashcard ff = new frmFlashcard();
            ff.Show();
            this.Hide();
        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            frmFlashcard ff = new frmFlashcard();
            ff.Show();
            this.Hide();
        }
    }
}
