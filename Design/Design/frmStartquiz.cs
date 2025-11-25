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
    public partial class frmStartquiz : Form
    {
        List<string> questions = new List<string>();
        List<string> answers = new List<string>();
        public frmStartquiz(List<string> questions, List<string> answers)
        {
            InitializeComponent();
            this.questions = questions;
            this.answers = answers;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void txtAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               string answer = txtAnswer.Text.Trim();
            }
        }
    }
}
