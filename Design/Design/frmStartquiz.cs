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
            totalSecs = 1 * 60;
            remainingSecs = totalSecs;
            Shuffle();
            GenerateQuestions();
            QuizTimer.Start();
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

                // Make sure orderedAnswers is a string or convert it to string to compare
                if (answer == Convert.ToString(orderedAnswers))
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
            int x = rand.Next(0, questions.Count);
            for (int i = 0; i < questions.Count; i++)
            {
                orderedQuestions.Enqueue(questions[x]);
                orderedAnswers.Enqueue(answers[x]);
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
        }

      
    }
}
