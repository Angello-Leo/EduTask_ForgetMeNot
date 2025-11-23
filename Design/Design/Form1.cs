namespace Design
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool panelIsExpanded = false;
        private int panelMaxWidth = 170;
        private int slideSpeed = 98;

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Width = 0;
            panel1.Visible = true;
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
            Form2 f2 = new Form2();
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
    }
}
