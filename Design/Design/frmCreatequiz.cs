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
        //Initialize Ui Transition
        UiTransition n = new UiTransition();

        // Default Settings
        int setTime = 60;
        int setCard = 10;
        public frmCreatequiz()
        {
            InitializeComponent();
            lblUsername.Text = GetInfo.Username;
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

        // Panel Animation
        private bool panelIsExpanded = false;
        private int panelMaxWidth = 200;
        private int slideSpeed = 10;

        // Flashcard Data
        private string defaultText = "Type or paste in your notes...";
        private bool isPress = false;
        private List<string> questions = new List<string>();
        private List<string> answers = new List<string>();

        private void rtbInput_TextChanged(object sender, EventArgs e)
        {
            string currentText = rtbInput.Text.Trim();
            if (currentText != defaultText && isPress == false)
            {
                rtbInput.Text = "";
                isPress = true;
            }
            else if (string.IsNullOrWhiteSpace(currentText))
            {
                rtbInput.Text = defaultText;
                isPress = false;
            }
        }

        private void picSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(rtbInput.Text) && rtbInput.Text != defaultText && !string.IsNullOrWhiteSpace(txtAnswer.Text))
            {
                if (questions.Count == setCard)
                {
                    MessageBox.Show($"You have reached the maximum number of flashcard.");
                    return;
                }
                questions.Add(rtbInput.Text.Trim());
                rtbInput.Clear();
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
            n.Notification(this);
        }

        private void picAddClass_Click(object sender, EventArgs e)
        {
            n.AddClass(this);
        }

        private void picFlashcard_Click(object sender, EventArgs e)
        {
            n.Flashcards(this);
        }

        private void picFLashcardIcon_Click(object sender, EventArgs e)
        {
            n.Flashcards(this);
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            n.Home(this);
        }

        private void picHomeIcon_Click(object sender, EventArgs e)
        {
            n.Home(this);
        }

        private void picStartQuiz_Click(object sender, EventArgs e)
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

        private void picClear_Click(object sender, EventArgs e)
        {
            questions.Clear();
            answers.Clear();
            txtAnswer.Clear();
            rtbInput.Text = defaultText;
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
            n.Pending(this);
        }

        private void picSchedule_Click(object sender, EventArgs e)
        {
            n.Schedule(this);
        }

        private void picPendingIcon_Click(object sender, EventArgs e)
        {
            n.Pending(this);
        }

        private void picScheduleIcon_Click(object sender, EventArgs e)
        {
            n.Schedule(this);
        }
    }
}
