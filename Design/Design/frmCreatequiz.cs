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

        private void picHamburgerMenu_Click(object sender, EventArgs e)
        {
            tmrHamburgerMenu.Start();
        }

        private void tmrHamburgerMenu_Tick(object sender, EventArgs e)
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
                    tmrHamburgerMenu.Stop();
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
                    tmrHamburgerMenu.Stop();
                }
            }
        }

        private void picNotification_Click(object sender, EventArgs e)
        {
            //notif
            frmNotification notification = new frmNotification();
            notification.Show();
            this.Hide();
        }

        private void picAddClass_Click(object sender, EventArgs e)
        {
            //add class
            frmCreateClass createClass = new frmCreateClass();
            createClass.Show();
            this.Hide();
        }

        private void picFlashcard_Click(object sender, EventArgs e)
        {
            //ff
            frmFlashcard flashcard = new frmFlashcard();
            flashcard.Show();
            this.Hide();
        }

        private void picFLashcardIcon_Click(object sender, EventArgs e)
        {
            //ff
            frmFlashcard flashcard = new frmFlashcard();
            flashcard.Show();
            this.Hide();
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            // home
            frmDashBoard dashBoard = new frmDashBoard();
            dashBoard.Show();
            this.Hide();
        }

        private void picHomeIcon_Click(object sender, EventArgs e)
        {
            //home
            frmDashBoard dashBoard = new frmDashBoard();
            dashBoard.Show();
            this.Hide();
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

        private void picPending_Click(object sender, EventArgs e)
        {
            frmPending pending = new frmPending();
            pending.Show();
            this.Hide();
        }

        private void picSchedule_Click(object sender, EventArgs e)
        {
            frmCallendar callendar = new frmCallendar();
            callendar.Show();
            this.Hide();
        }
    }
}
