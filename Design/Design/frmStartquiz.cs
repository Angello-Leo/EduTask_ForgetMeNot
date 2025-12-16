using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design
{
    public partial class frmStartquiz : Form
    {
        // Initialize Ui transition
        UiTransition n = new UiTransition();

        // Local Fields needed for quiz functionality
        List<string> questions = new List<string>();
        List<string> answers = new List<string>();
        Queue<string> orderedQuestions = new Queue<string>();
        Queue<string> orderedAnswers = new Queue<string>();
        int totalSecs = 0;
        int remainingSecs = 0;
        frmCreatequiz createQuizForm;
        string queAnswer;
        int correct;
        int miss;
        int start = 3;
        int goTime = 1;
        int interval = 2;

        // Dynamic Labels
        Label questionLabel = new Label();
        Label lblAnswer = new Label();
        Label lblStart = new Label();
        Label lblGo = new Label();
        Label lblResult = new Label();
        Label lblCorrects = new Label();
        Label lblNumAnswer = new Label();
        Label lblNumMiss = new Label();
        Label lblMisses = new Label();
        Label input = new Label();

        // Hamburger Menu Fields
        private bool panelIsExpanded = false;
        private int panelMaxWidth = 200;
        private int slideSpeed = 10;
        public frmStartquiz(List<string> questions, List<string> answers, frmCreatequiz form, int time)
        {
            InitializeComponent();
            lblUsername.Text = GetInfo.Username;
            this.questions = questions;
            this.answers = answers;
            createQuizForm = form;
            panel1.Visible = false;
            totalSecs = time;
        }
        private void frmStartquiz_Load(object sender, EventArgs e)
        {
            StartQuiz(); // Start the quiz when form loads
        }

        private void StartQuiz()
        {
            // Prepares the Quiz
            HideItems();
            start = 3;
            goTime = 1;
            correct = 0;
            miss = 0;
            lblCorrect.Text = correct.ToString();
            lblMiss.Text = miss.ToString();
            remainingSecs = totalSecs;
            UpdateTimerDisplay();
            Shuffle();
            CreateStartLabel();
            tmrStart.Start();
        }

        private void tmrQuiz_Tick(object sender, EventArgs e)
        {
            if (remainingSecs > 0)
            {
                remainingSecs--;
            }
            else
            {
                tmrQuiz.Stop();
                MessageBox.Show("Time's up!");
                miss = int.Parse(lblMiss.Text) + 1;
                lblMiss.Text = miss.ToString();
                remainingSecs = totalSecs;
                RevealAnswers(queAnswer);
                tmrInterval.Start();
                interval = 2;
                txtAnswer.Visible = false;
                txtAnswer.Clear();
            }
            UpdateTimerDisplay();
        }

        private void UpdateTimerDisplay()
        {
            int mins = remainingSecs / 60;
            int secs = remainingSecs % 60;

            Time.Text = $"{mins:D2}:{secs:D2}";
        }

        private void txtAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            bool isCorrect = false;
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;

                string answer = txtAnswer.Text.Trim();
                queAnswer = orderedAnswers.Dequeue();

                // Make sure orderedAnswers is a string or convert it to string to compare
                if (answer.ToLower() == queAnswer.ToLower())
                {
                    correct = int.Parse(lblCorrect.Text) + 1;
                    lblCorrect.Text = correct.ToString();
                    isCorrect = true;
                }
                else
                {
                    miss = int.Parse(lblMiss.Text) + 1;
                    lblMiss.Text = miss.ToString();
                }
                tmrQuiz.Stop();
                remainingSecs = totalSecs;
                GenerateAnswers(queAnswer, isCorrect);
                txtAnswer.Visible = false;
                tmrInterval.Start();
                interval = 2;
                txtAnswer.Clear();
            }
        }
        private void Shuffle()
        {
            Random rand = new Random();
            List<int> indices = Enumerable.Range(0, questions.Count).ToList(); // Create a list of indices from 0 to questions.Count - 1
            indices = indices.OrderBy(x => rand.Next()).ToList(); // Shuffle the indices randomly

            foreach (int index in indices)
            {
                orderedQuestions.Enqueue(questions[index]);
                orderedAnswers.Enqueue(answers[index]);
            }
        }
        private void GenerateQuestions()
        {
            if (orderedQuestions.Count > 0)
            {
                int height = quizCard.Height;
                int width = quizCard.Width;

                // Create a new label for the question
                questionLabel.Text = orderedQuestions.Dequeue();
                questionLabel.BackColor = Color.Transparent;
                questionLabel.ForeColor = Color.Black;

                // Add the label to the quizCard (make sure quizCard is a container control)
                DrawQuestion(quizCard, questionLabel.Text);
            }
        }
        private void GenerateAnswers(string answer, bool isCorrect)
        {
            RemoveQuestion(quizCard);
            int height = quizCard.Height;
            int width = quizCard.Width;

            // Create a new label for the answer
            lblAnswer.Text = answer;
            lblAnswer.Font = new Font("Arial", 34);
            lblAnswer.BackColor = Color.Transparent;
            lblAnswer.ForeColor = isCorrect ? Color.Green : Color.Red;
            CenterLabel(lblAnswer, width, height);
            quizCard.Controls.Add(lblAnswer);
        }
        public static void RemoveQuestion(Control container)
        {
            // Clear the container by refreshing it
            container.Refresh();
        }
        private void CenterLabel(Label label, int containerWidth, int containerHeight)
        {
            label.AutoSize = true;

            // Force measurement of text size
            Size textSize = TextRenderer.MeasureText(label.Text, label.Font);

            // Calculate centered position
            int x = (containerWidth - textSize.Width) / 2;
            int y = (containerHeight - textSize.Height) / 2;

            label.Location = new Point(x, y);
        }
        public static void DrawQuestion(Control container, string question)
        {
            using (Graphics g = container.CreateGraphics())
            {
                int maxFontSize = 14;
                int minFontSize = 9;
                Font font = new Font("Arial", maxFontSize);

                // Measure text size
                SizeF textSize = g.MeasureString(question, font);

                // Shrink font until it fits height
                while (textSize.Height > container.ClientSize.Height && font.Size > minFontSize)
                {
                    font = new Font(font.FontFamily, font.Size - 1, font.Style);
                    textSize = g.MeasureString(question, font);
                }

                container.Refresh();

                // If text width exceeds container, split into two lines
                if (textSize.Width > container.ClientSize.Width)
                {
                    // Find midpoint near a space to split nicely
                    int mid = question.Length / 2;
                    int splitIndex = question.LastIndexOf(' ', mid);
                    if (splitIndex == -1) splitIndex = mid; // fallback

                    string upper = question.Substring(0, splitIndex).Trim();
                    string lower = question.Substring(splitIndex).Trim();

                    // Measure each line
                    SizeF upperSize = g.MeasureString(upper, font);
                    SizeF lowerSize = g.MeasureString(lower, font);

                    // Calculate centered positions
                    float upperX = (container.ClientSize.Width - upperSize.Width) / 2;
                    float lowerX = (container.ClientSize.Width - lowerSize.Width) / 2;

                    float totalHeight = upperSize.Height + lowerSize.Height;
                    float startY = (container.ClientSize.Height - totalHeight) / 2;

                    // Draw both lines
                    g.DrawString(upper, font, Brushes.Black, new PointF(upperX, startY));
                    g.DrawString(lower, font, Brushes.Black, new PointF(lowerX, startY + upperSize.Height));
                }
                else
                {
                    // Normal centered draw
                    float x = (container.ClientSize.Width - textSize.Width) / 2;
                    float y = (container.ClientSize.Height - textSize.Height) / 2;
                    g.DrawString(question, font, Brushes.Black, new PointF(x, y));
                }
            }
        }
        private void CenterLabel(Label label, int containerWidth, int containerHeight, int adjx, int adjy)
        {
            label.AutoSize = true;

            // Force measurement of text size
            Size textSize = TextRenderer.MeasureText(label.Text, label.Font);

            // Calculate centered position
            int x = (containerWidth - textSize.Width) / 2 + adjx;
            int y = (containerHeight - textSize.Height) / 2 + adjy;

            label.Location = new Point(x, y);
        }

        private void RevealAnswers(string answer)
        {
            quizCard.Controls.Remove(questionLabel);
            int height = quizCard.Height;
            int width = quizCard.Width;

            // Create a new label for the answer
            lblAnswer.Text = answer;
            lblAnswer.Font = new Font("Arial", 34);
            lblAnswer.BackColor = Color.Transparent;
            lblAnswer.ForeColor = Color.Red;
            CenterLabel(lblAnswer, width, height);

            // Add the label to the quizCard (make sure quizCard is a container control)
            quizCard.Controls.Add(lblAnswer);
        }

        private void HideItems()
        {
            quizCard.Visible = false;
            txtAnswer.Visible = false;
            Time.Visible = false;
            lblCorrect.Visible = false;
            lblMiss.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }
        private void CreateStartLabel()
        {
            lblStart.Text = "3";
            lblStart.AutoSize = true;
            lblStart.Font = new Font("Arial", 48, FontStyle.Bold);
            lblStart.BackColor = Color.Transparent;
            lblStart.ForeColor = Color.Red;
            CenterLabel(lblStart, pnlFlashcard.Width, pnlFlashcard.Height);
            pnlFlashcard.Controls.Add(lblStart);
        }
        private void CreateGoLabel()
        {
            lblGo.Text = "GO";
            lblGo.AutoSize = true;
            lblGo.Font = new Font("Arial", 48, FontStyle.Bold);
            lblGo.BackColor = Color.Transparent;
            lblGo.ForeColor = Color.Black;
            CenterLabel(lblGo, pnlFlashcard.Width, pnlFlashcard.Height);
            pnlFlashcard.Controls.Add(lblGo);
        }
        private void tmrStart_Tick(object sender, EventArgs e)
        {
            if (start > 0)
            {
                start--;
                lblStart.Text = Convert.ToString(start);
            }
            else
            {
                pnlFlashcard.Controls.Remove(lblStart);
                CreateGoLabel();
                tmrGo.Start();
                tmrStart.Stop();
            }
        }
        private void tmrGo_Tick(object sender, EventArgs e)
        {
            if (goTime > 0)
            {
                goTime--;
            }
            else
            {
                pnlFlashcard.Controls.Remove(lblGo);
                BringBackItems();
                GenerateQuestions();
                tmrQuiz.Start();
                tmrGo.Stop();
            }
        }

        private void BringBackItems()
        {
            quizCard.Visible = true;
            txtAnswer.Visible = true;
            Time.Visible = true;
            lblCorrect.Visible = true;
            lblMiss.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
        }
        private void tmrInterval_Tick(object sender, EventArgs e)
        {
            if (interval > 0)
            {
                interval--;
            }
            else
            {
                quizCard.Controls.Remove(lblAnswer);

                if (orderedQuestions.Count > 0)
                {
                    txtAnswer.Visible = true;
                    GenerateQuestions();
                    tmrQuiz.Start();
                }
                else
                {
                    tmrQuiz.Stop();
                    Result();
                }
                tmrInterval.Stop();
            }
        }

        private void Result()
        {
            HideItems();
            byte[] imageBytes = Properties.Resources.BgResultFlashCard_1;
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                pnlFlashcard.BackgroundImage = Image.FromStream(ms);  // Convert byte array to Image
            }
            pnlFlashcard.BackgroundImageLayout = ImageLayout.Stretch;
            // Update label sizes and positioning
            if (correct >= questions.Count * 0.75)
            {
                lblResult.Text = "YOU PASSED!";
                lblResult.ForeColor = Color.Green;
            }
            else
            {
                lblResult.Text = "YOU FAILED!";
                lblResult.ForeColor = Color.Red;
            }
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Arial", 65, FontStyle.Bold);
            lblResult.BackColor = Color.Transparent;
            CenterLabel(lblResult, pnlFlashcard.Width, pnlFlashcard.Height, 0, -300);
            pnlFlashcard.Controls.Add(lblResult);

            // Correct Label
            lblCorrects.Text = "Correct:";
            lblCorrects.AutoSize = true;
            lblCorrects.Font = new Font("Arial", 24, FontStyle.Bold);
            lblCorrects.BackColor = Color.Transparent;
            lblCorrects.ForeColor = Color.Green;
            CenterLabel(lblCorrects, pnlFlashcard.Width, pnlFlashcard.Height, -100, -50); // Adjusted position
            pnlFlashcard.Controls.Add(lblCorrects);

            // Correct Answer Number
            lblNumAnswer.Text = correct.ToString();
            lblNumAnswer.AutoSize = true;
            lblNumAnswer.Font = new Font("Arial", 24, FontStyle.Bold);
            lblNumAnswer.BackColor = Color.Transparent;
            lblNumAnswer.ForeColor = Color.Black;
            CenterLabel(lblNumAnswer, pnlFlashcard.Width, pnlFlashcard.Height, 50, -50); // Adjusted position
            pnlFlashcard.Controls.Add(lblNumAnswer);

            // Misses Label
            lblMisses.Text = "Miss:";
            lblMisses.AutoSize = true;
            lblMisses.Font = new Font("Arial", 24, FontStyle.Bold);
            lblMisses.BackColor = Color.Transparent;
            lblMisses.ForeColor = Color.Red;
            CenterLabel(lblMisses, pnlFlashcard.Width, pnlFlashcard.Height, -100, 50); // Adjusted position
            pnlFlashcard.Controls.Add(lblMisses);

            // Missed Answers Number
            lblNumMiss.Text = miss.ToString();
            lblNumMiss.AutoSize = true;
            lblNumMiss.Font = new Font("Arial", 24, FontStyle.Bold);
            lblNumMiss.BackColor = Color.Transparent;
            lblNumMiss.ForeColor = Color.Black;
            CenterLabel(lblNumMiss, pnlFlashcard.Width, pnlFlashcard.Height, 50, 50); // Adjusted position
            pnlFlashcard.Controls.Add(lblNumMiss);

            // Retake Prompt Input Text
            input.Text = "Do you want to retake again? (y/n).";
            input.AutoSize = true;
            input.Font = new Font("Arial", 12, FontStyle.Bold);
            input.BackColor = Color.Transparent;
            input.ForeColor = Color.Yellow;
            CenterLabel(input, pnlFlashcard.Width, pnlFlashcard.Height, 0, +300); // Adjusted position
            pnlFlashcard.Controls.Add(input);

            this.KeyPreview = true;
            this.KeyDown += KeyPresses;
        }

        private void RemoveResultLabels()
        {
            pnlFlashcard.Controls.Remove(lblResult);
            pnlFlashcard.Controls.Remove(lblCorrects);
            pnlFlashcard.Controls.Remove(lblNumAnswer);
            pnlFlashcard.Controls.Remove(lblNumMiss);
            pnlFlashcard.Controls.Remove(lblMisses);
            pnlFlashcard.Controls.Remove(input);
            pnlFlashcard.BackgroundImage = null;
        }

        private void KeyPresses(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Y)
            {
                this.KeyPreview = false;
                RemoveResultLabels();
                StartQuiz();
            }
            else if (e.KeyCode == Keys.N)
            {
                this.Close();
                createQuizForm.Show(); 
            }
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

        private void picHome_Click(object sender, EventArgs e)
        {
            n.Home(this);
        }

        private void picPending_Click(object sender, EventArgs e)
        {
            n.Pending(this);
        }

        private void picHamburgerMenu_Click(object sender, EventArgs e)
        {
            tmrHamburgerMenu.Start();
        }

        private void picFlashcard_Click(object sender, EventArgs e)
        {
            n.Flashcards(this);
        }

        private void picFlashcardIcon_Click(object sender, EventArgs e)
        {
            n.Flashcards(this);
        }

        private void picScheduleIcon_Click(object sender, EventArgs e)
        {
            n.Schedule(this);
        }

        private void picSchedule_Click(object sender, EventArgs e)
        {
            n.Schedule(this);
        }

        private void picPendingIcon_Click(object sender, EventArgs e)
        {
            n.Pending(this);
        }

        private void picHomeIcon_Click(object sender, EventArgs e)
        {
            n.Home(this);
        }

        private void picNotification_Click(object sender, EventArgs e)
        {
            n.Notification(this);
        }
    }
}
