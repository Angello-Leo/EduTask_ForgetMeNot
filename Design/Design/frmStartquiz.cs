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
        List<string> questions = new List<string>();
        List<string> answers = new List<string>();
        Queue<string> orderedQuestions = new Queue<string>();
        Queue<string> orderedAnswers = new Queue<string>();
        int totalSecs = 0;
        int remainingSecs = 0;

        public frmStartquiz(List<string> questions, List<string> answers)
        {
            InitializeComponent();
            this.questions = questions;
            this.answers = answers;
        }
        private void frmStartquiz_Load(object sender, EventArgs e)
        {
            HideItems();
            totalSecs = 1 * 60;
            remainingSecs = totalSecs;
            Shuffle();
            CreateStartLabel();
            StartingTimer.Start();
        }

        private void QuizTimer_Tick(object sender, EventArgs e)
        {
            if (remainingSecs > 0)
            {
                remainingSecs--;
            }
            else
            {
                QuizTimer.Stop();
                MessageBox.Show("Time's up!");
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
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;

                string answer = txtAnswer.Text.Trim();
                string queAnswer = orderedAnswers.Dequeue();

                // Make sure orderedAnswers is a string or convert it to string to compare
                if (answer == queAnswer)
                {
                    int correct = int.Parse(lblCorrect.Text);
                    lblCorrect.Text = (correct + 1).ToString();
                }
                else
                {
                    int miss = int.Parse(lblMiss.Text);
                    lblMiss.Text = (miss + 1).ToString();
                }

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
            int height = quizCard.Height;
            int width = quizCard.Width;

            // Create a new label for the question
            Label questionLabel = new Label();
            questionLabel.Text = orderedQuestions.Dequeue();
            questionLabel.AutoSize = true;
            questionLabel.Font = new Font("Arial", 14);
            questionLabel.BackColor = Color.Transparent;
            questionLabel.ForeColor = Color.Black;

            // Calculate the center position
            int x = (width - questionLabel.Width) / 2;
            int y = (height - questionLabel.Height) / 2;

            // Set the location of the label to the calculated center
            questionLabel.Location = new Point(x, y);

            // Add the label to the quizCard (make sure quizCard is a container control)
            quizCard.Controls.Add(questionLabel);
            QuizTimer.Start();
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

        Label lblStart = new Label();
        private void CreateStartLabel()
        {
            lblStart.Text = "3";
            lblStart.AutoSize = true;
            lblStart.Font = new Font("Arial", 48, FontStyle.Bold);
            lblStart.BackColor = Color.Transparent;
            lblStart.ForeColor = Color.Red;
            lblStart.Location = new Point((this.Width - lblStart.Width) / 2, ((this.Height - lblStart.Height) / 2 ) + 5);
            this.Controls.Add(lblStart);
        }

        Label lblGo = new Label();
        private void CreateGoLabel()
        {
            lblStart.Text = "GO";
            lblStart.AutoSize = true;
            lblStart.Font = new Font("Arial", 48, FontStyle.Bold);
            lblStart.BackColor = Color.Transparent;
            lblStart.ForeColor = Color.Black;
            lblStart.Location = new Point((this.Width - lblGo.Width) / 2, ((this.Height - lblGo.Height) / 2) + 5);
            this.Controls.Add(lblStart);
        }

        int start = 3;
        private void StartingTimer_Tick(object sender, EventArgs e)
        {
            if (start > 0)
            {
                start--;
                lblStart.Text = Convert.ToString(start);
            }
            else
            {
                this.Controls.Remove(lblStart);
                CreateGoLabel();
                GoTimer.Start();
            }
        }
        int goTime = 1;
        private void GoTimer_Tick(object sender, EventArgs e)
        {
            if (goTime > 0)
            {
                goTime--;
            }
            else
            {
                this.Controls.Remove(lblGo);
                BringBackItems();
                GenerateQuestions();
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

        
    }
}
