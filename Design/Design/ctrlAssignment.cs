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
    public partial class ctrlAssignment : UserControl
    {
        public ctrlAssignment()
        {
            InitializeComponent();
        }

        private void ctrlAssignment_Load(object sender, EventArgs e)
        {

        }
        public void LoadAssignmentData(int assignmentId, string title, string description, DateTime? dueDate)
        {
            lblTitle.Text = title;
            lblDescription.Text = description;
            lblDueDate.Text = dueDate.HasValue ? dueDate.Value.ToString("g") : "No due date";
        }

    }
}
