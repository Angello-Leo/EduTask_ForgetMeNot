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
    public partial class frmCreatequiz : Form
    {
        public frmCreatequiz()
        {
            InitializeComponent();
            panel1.Visible = false;
        }
        private bool panelIsExpanded = false;
        private int panelMaxWidth = 200;
        private int slideSpeed = 10;

        private string defaultText = "Type or paste in your notes...";
        private bool isPress = false;
        private List<string> questions = new List<string>();
        private List<string> answers = new List<string>();

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string currentText = rtxtInput.Text.Trim();
            if (currentText != defaultText && isPress == false)
            {
                rtxtInput.Text = "";
                isPress = true;
            }
            else if (string.IsNullOrWhiteSpace(currentText))
            {
                rtxtInput.Text = defaultText;
                isPress = false;
            }
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(rtxtInput.Text) && rtxtInput.Text != defaultText && !string.IsNullOrWhiteSpace(txtAnswer.Text))
            {
                questions.Add(rtxtInput.Text.Trim());
                rtxtInput.Clear();
                answers.Add(txtAnswer.Text.Trim());
                txtAnswer.Clear();
                MessageBox.Show("Saved succesfully!");

                lblCountCards.Text = questions.Count.ToString() + "/10";
                if (questions.Count >= 10)
                {
                    lblCountCards.ForeColor = Color.Green;
                }
                else
                {
                    lblCountCards.ForeColor = Color.Red;
                }
                return;
            }
            else
            {
                MessageBox.Show("Please fill in both question and answer fields before saving.");
            }
        }

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

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            // home
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

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pboxStartquiz_Click(object sender, EventArgs e)
        {
            if (questions.Count >= 10)
            {
                MessageBox.Show($"Starting Quiz with {questions.Count.ToString()} Flashcards!");
                frmStartquiz f7 = new frmStartquiz(questions, answers);
                this.Hide();
                f7.Show();
            }
            else
            {
                MessageBox.Show("Please enter up to 10 Flashcards");
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }
    }
}
