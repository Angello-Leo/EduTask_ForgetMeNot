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
    public partial class ctrlAnnouncement : UserControl
    {
        public int AnnouncementId { get; private set; }

        public ctrlAnnouncement()
        {
            InitializeComponent();
        }

        private void ctrlAnnouncement_Load(object sender, EventArgs e)
        {

        }

        public void LoadAnnouncementData(int announcementId, string title, string content, DateTime createdAt,
                                 bool isDone, int creatorId, string username, string creatorRole, string currentUserRole)
        {
            AnnouncementId = announcementId;

            lblTitle.Text = title;
            lblContent.Text = content;
            lblCreatedBy.Text = $"{username} ({creatorRole})";
            lblCreatedAt.Text = createdAt.ToString("g");

            SetButtonVisibility(currentUserRole, isDone);
        }
        private void SetButtonVisibility(string currentRole, bool isDone)
        {
            currentRole = (currentRole ?? "").Trim().ToLower();

            // Reset buttons by default
            btnEdit.Visible = false;
            btnMarkAsDone.Visible = false;

            if (currentRole == "president" || currentRole == "vice president")
            {
                btnEdit.Visible = true;
                btnMarkAsDone.Visible = false; 
            }
            else if (currentRole == "secretary")
            {
                btnMarkAsDone.Visible = !isDone;
            }
        }

    }
}
