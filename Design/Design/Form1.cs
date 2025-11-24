using MySql.Data.MySqlClient;
namespace Design
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            this.Shown += Form1_Shown;
        }

        private bool panelIsExpanded = false;
        private int panelMaxWidth = 200;
        private int slideSpeed = 10;

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Width = 200;
            panel1.Visible = false;

            lblUsername.Text = GetInfo.Username;
            try
            {
                LoadClasses();
            }
            catch (Exception ex)
            {
                MessageBox.Show("LoadClasses error: " + ex.Message);
            }
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            try
            {
                LoadClasses(); // this will populate the FlowLayoutPanel when the form first appears
            }
            catch (Exception ex)
            {
                MessageBox.Show("LoadClasses error: " + ex.Message);
            }
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            LoadClasses();
        }

        public void LoadClasses()
        {
            flowPanelClasses.Controls.Clear();

            string conString = "server=localhost;database=edutask;uid=edutask_app;pwd=Ralfh_Leo_Sheky_Cholo2025!";

            Console.WriteLine($"[DEBUG] Starting LoadClasses for user {GetInfo.UserID} with role '{GetInfo.Role}'");

            try
            {
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();
                    Console.WriteLine("[DEBUG] Database connection opened successfully.");

                    string query = (GetInfo.Role == "teacher")
                        ? @"SELECT c.class_id, c.class_name, c.class_code, u.username AS adviser
                    FROM classes c
                    LEFT JOIN users u ON c.adviser_id = u.user_id
                    WHERE c.adviser_id = @aid"
                        : @"SELECT c.class_id, c.class_name, c.class_code, u.username AS adviser
                    FROM classes c
                    JOIN class_students cs ON c.class_id = cs.class_id
                    LEFT JOIN users u ON c.adviser_id = u.user_id
                    WHERE cs.student_id = @sid";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        if (GetInfo.Role == "teacher")
                            cmd.Parameters.AddWithValue("@aid", GetInfo.UserID);
                        else
                            cmd.Parameters.AddWithValue("@sid", GetInfo.UserID);

                        Console.WriteLine("[DEBUG] SQL command prepared. Executing query...");

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            int rowCount = 0;

                            while (reader.Read())
                            {
                                rowCount++;
                                int classId = reader.GetInt32("class_id");
                                string className = reader.GetString("class_name");
                                string classCode = reader.GetString("class_code");
                                string adviser = reader.IsDBNull(reader.GetOrdinal("adviser"))
                                    ? "Student-created"
                                    : reader.GetString("adviser");

                                Console.WriteLine($"[DEBUG] Row {rowCount}: {className} ({classCode}), Adviser: {adviser}");

                                CreateClassCard(classId, className, classCode, adviser);
                            }

                            if (rowCount == 0)
                                Console.WriteLine("[DEBUG] No classes found for this user.");
                            else
                                Console.WriteLine($"[DEBUG] Total {rowCount} class(es) loaded.");
                        }
                    }
                }

                // Make sure the FlowLayoutPanel is visible
                if (!flowPanelClasses.Visible)
                {
                    Console.WriteLine("[DEBUG] FlowLayoutPanel was hidden. Making it visible.");
                    flowPanelClasses.Visible = true;
                }

                flowPanelClasses.Refresh();
            }
            catch (Exception ex)
            {
                Console.WriteLine("[ERROR] Exception in LoadClasses: " + ex.Message);
                MessageBox.Show("LoadClasses error: " + ex.Message);
            }
        }




        private void CreateClassCard(int classId, string className, string classCode, string adviser)
        {
            Panel card = new Panel();
            card.Width = 250;
            card.Height = 150; // slightly bigger for adviser
            card.BackColor = Color.FromArgb(52, 152, 219);
            card.Margin = new Padding(10);
            card.Cursor = Cursors.Hand;
            card.Tag = classId; // <-- IMPORTANT

            Label lblTitle = new Label();
            lblTitle.Text = className;
            lblTitle.ForeColor = Color.White;
            lblTitle.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblTitle.Location = new Point(10, 10);
            lblTitle.AutoSize = true;

            Label lblCode = new Label();
            lblCode.Text = "Code: " + classCode;
            lblCode.ForeColor = Color.White;
            lblCode.Font = new Font("Segoe UI", 10);
            lblCode.Location = new Point(10, 50);
            lblCode.AutoSize = true;

            Label lblAdviser = new Label();
            lblAdviser.Text = "Adviser: " + adviser;
            lblAdviser.ForeColor = Color.White;
            lblAdviser.Font = new Font("Segoe UI", 10);
            lblAdviser.Location = new Point(10, 80);
            lblAdviser.AutoSize = true;

            card.Controls.Add(lblTitle);
            card.Controls.Add(lblCode);
            card.Controls.Add(lblAdviser);

            // Attach the same click handler to labels so clicking anywhere works
            card.Click += ClassCard_Click;
            lblTitle.Click += ClassCard_Click;
            lblCode.Click += ClassCard_Click;
            lblAdviser.Click += ClassCard_Click;

            flowPanelClasses.Controls.Add(card);
        }


        private void ClassCard_Click(object sender, EventArgs e)
        {
            Control c = sender as Control;

            // Ensure we get the Panel that holds the Tag
            Panel card = c is Panel ? (Panel)c : (Panel)c.Parent;

            int classId = (int)card.Tag;

            // Open the class page for this classId
            Class classPage = new Class(classId, this);
            classPage.Show();

            // Optionally hide the dashboard
            this.Hide();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

            timer1.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //e2 ay sa message button

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // e2 ay sa notification button
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //e2 ay sa add ng class button
            Form2 f2 = new Form2(this); // pass reference to this dashboard
            f2.Show();
            this.Hide();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // e2 ay home icon button
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //e2 ay pending icom button
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //e2 ay schedule icon button
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            //e2 ay flashcards icon button
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            //e2 ay home label button
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            //e2 ay pending label button
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            //e2 ay schedule label button
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            //e2 ay flashcards label button
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            // e2 ay course icon btton
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            //e2 ay sa course label button
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //e2 ay panel ng courses pag nipinfot yung button sa taas. 
            //dapat ay mag ddrop down tong panel pag niindot yugn button then nasa loob yung courses
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            //navigation icon 

            timer1.Start();
        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            //flashcards
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
