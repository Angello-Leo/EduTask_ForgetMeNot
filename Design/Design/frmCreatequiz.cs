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
        int setTime = 60;
        int setCard = 10;
        public frmCreatequiz()
        {
            InitializeComponent();
            panel1.Visible = false;
        }
        public frmCreatequiz(int setCard, int setTime)
        {
            InitializeComponent();
            panel1.Visible = false;
            this.setCard = setCard;
            this.setTime = setTime;
            lblCountCards.Text = $"0/{setCard}";
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
                if (questions.Count == setCard)
                {
                    MessageBox.Show($"You have reached the maximum number of flashcard.");
                    return;
                }
                questions.Add(rtxtInput.Text.Trim());
                rtxtInput.Clear();
                answers.Add(txtAnswer.Text.Trim());
                txtAnswer.Clear();
                MessageBox.Show("Saved succesfully!");

                lblCountCards.Text = $"{questions.Count}/{setCard}";
                if (questions.Count == setCard)
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
            frmNotification f4 = new frmNotification();
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
            if (questions.Count == setCard)
            {
                MessageBox.Show($"Starting Quiz with {questions.Count.ToString()} Flashcards!");
                frmStartquiz f7 = new frmStartquiz(questions, answers, this, setTime);
                this.Hide();
                f7.Show();
            }
            else
            {
                MessageBox.Show($"Please enter up to {setCard} Flashcards");
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void pboxClear_Click(object sender, EventArgs e)
        {
            questions.Clear();
            answers.Clear();
            txtAnswer.Clear();
            rtxtInput.Text = defaultText;
            MessageBox.Show("All flashcards have been cleared.");
            lblCountCards.ForeColor = Color.Red;
            lblCountCards.Text = $"0/{setCard}";
        }

        private void picSettings_Click(object sender, EventArgs e)
        {
            frmFlashcardSettings f8 = new frmFlashcardSettings(this);
            f8.ShowDialog();
        }
    }
}
