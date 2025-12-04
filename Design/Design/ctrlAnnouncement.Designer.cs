namespace Design
{
    partial class ctrlAnnouncement
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblContent = new Label();
            lblCreatedBy = new Label();
            lblCreatedAt = new Label();
            btnMarkAsDone = new Button();
            btnEdit = new Button();
            lblDueDate = new Label();
            btnCloseSubmission = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(39, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(38, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title";
            // 
            // lblContent
            // 
            lblContent.AutoSize = true;
            lblContent.Location = new Point(39, 42);
            lblContent.Name = "lblContent";
            lblContent.Size = new Size(61, 20);
            lblContent.TabIndex = 1;
            lblContent.Text = "Content";
            // 
            // lblCreatedBy
            // 
            lblCreatedBy.AutoSize = true;
            lblCreatedBy.Location = new Point(39, 72);
            lblCreatedBy.Name = "lblCreatedBy";
            lblCreatedBy.Size = new Size(84, 20);
            lblCreatedBy.TabIndex = 2;
            lblCreatedBy.Text = "Created by:";
            // 
            // lblCreatedAt
            // 
            lblCreatedAt.AutoSize = true;
            lblCreatedAt.Location = new Point(39, 101);
            lblCreatedAt.Name = "lblCreatedAt";
            lblCreatedAt.Size = new Size(84, 20);
            lblCreatedAt.TabIndex = 3;
            lblCreatedAt.Text = "Created by:";
            // 
            // btnMarkAsDone
            // 
            btnMarkAsDone.Location = new Point(517, 116);
            btnMarkAsDone.Name = "btnMarkAsDone";
            btnMarkAsDone.Size = new Size(94, 29);
            btnMarkAsDone.TabIndex = 4;
            btnMarkAsDone.Text = "Done";
            btnMarkAsDone.UseVisualStyleBackColor = true;
            btnMarkAsDone.Click += btnMarkAsDone_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(517, 72);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.ForeColor = Color.Red;
            lblDueDate.Location = new Point(39, 131);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(84, 20);
            lblDueDate.TabIndex = 6;
            lblDueDate.Text = "Created by:";
            lblDueDate.Click += label1_Click;
            // 
            // btnCloseSubmission
            // 
            btnCloseSubmission.Location = new Point(517, 23);
            btnCloseSubmission.Name = "btnCloseSubmission";
            btnCloseSubmission.Size = new Size(94, 29);
            btnCloseSubmission.TabIndex = 7;
            btnCloseSubmission.Text = "Close Submission";
            btnCloseSubmission.UseVisualStyleBackColor = true;
            btnCloseSubmission.Click += btnCloseSubmission_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleGreen;
            panel1.Controls.Add(lblCreatedBy);
            panel1.Controls.Add(btnCloseSubmission);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnMarkAsDone);
            panel1.Controls.Add(lblDueDate);
            panel1.Controls.Add(lblContent);
            panel1.Controls.Add(lblCreatedAt);
            panel1.Location = new Point(27, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(724, 173);
            panel1.TabIndex = 8;
            // 
            // ctrlAnnouncement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(panel1);
            Name = "ctrlAnnouncement";
            Size = new Size(778, 203);
            Load += ctrlAnnouncement_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblContent;
        private Label lblCreatedBy;
        private Label lblCreatedAt;
        private Button btnMarkAsDone;
        private Button btnEdit;
        private Label lblDueDate;
        private Button btnCloseSubmission;
        private Panel panel1;
    }
}
