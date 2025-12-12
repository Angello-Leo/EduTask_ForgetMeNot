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
    public partial class frmFlashcardSettings : Form
    {
        private int defaultTime = 60;
        private int defaultmaxCard = 10;
        int setTime = 60;
        int maxCard = 10;
        frmCreatequiz createquizForm;

        public frmFlashcardSettings(frmCreatequiz form)
        {
            InitializeComponent();
            createquizForm = form;
        }

        private void txtTime_TextChanged(object sender, EventArgs e)
        {
            string txt = txtTime.Text;
            if (txt == "")
            {
                setTime = defaultTime;
            }
            else if (txt != Convert.ToString(setTime))
            {
                txtTime.Text = txt;
                setTime = Convert.ToInt32(txt);
            }
        }

        private void txtCard_TextChanged(object sender, EventArgs e)
        {
            string txt = txtMax.Text;
            if (txt == "")
            {
                maxCard = defaultmaxCard;
            }
            else if (txt != Convert.ToString(maxCard))
            {
                txtMax.Text = txt;
                maxCard = Convert.ToInt32(txt);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Hide();
            createquizForm.Close();
            frmCreatequiz form = new frmCreatequiz(maxCard, setTime);
            form.Show();
        }
    }
}
