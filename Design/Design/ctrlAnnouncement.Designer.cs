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
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(41, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(38, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title";
            // 
            // lblContent
            // 
            lblContent.AutoSize = true;
            lblContent.Location = new Point(41, 49);
            lblContent.Name = "lblContent";
            lblContent.Size = new Size(61, 20);
            lblContent.TabIndex = 1;
            lblContent.Text = "Content";
            // 
            // lblCreatedBy
            // 
            lblCreatedBy.AutoSize = true;
            lblCreatedBy.Location = new Point(41, 79);
            lblCreatedBy.Name = "lblCreatedBy";
            lblCreatedBy.Size = new Size(84, 20);
            lblCreatedBy.TabIndex = 2;
            lblCreatedBy.Text = "Created by:";
            // 
            // lblCreatedAt
            // 
            lblCreatedAt.AutoSize = true;
            lblCreatedAt.Location = new Point(41, 108);
            lblCreatedAt.Name = "lblCreatedAt";
            lblCreatedAt.Size = new Size(84, 20);
            lblCreatedAt.TabIndex = 3;
            lblCreatedAt.Text = "Created by:";
            // 
            // btnMarkAsDone
            // 
            btnMarkAsDone.Location = new Point(8, 171);
            btnMarkAsDone.Name = "btnMarkAsDone";
            btnMarkAsDone.Size = new Size(94, 29);
            btnMarkAsDone.TabIndex = 4;
            btnMarkAsDone.Text = "Done";
            btnMarkAsDone.UseVisualStyleBackColor = true;
            btnMarkAsDone.Click += btnMarkAsDone_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(108, 171);
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
            lblDueDate.Location = new Point(41, 138);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(84, 20);
            lblDueDate.TabIndex = 6;
            lblDueDate.Text = "Created by:";
            lblDueDate.Click += label1_Click;
            // 
            // btnCloseSubmission
            // 
            btnCloseSubmission.Location = new Point(208, 171);
            btnCloseSubmission.Name = "btnCloseSubmission";
            btnCloseSubmission.Size = new Size(94, 29);
            btnCloseSubmission.TabIndex = 7;
            btnCloseSubmission.Text = "Close Submission";
            btnCloseSubmission.UseVisualStyleBackColor = true;
            btnCloseSubmission.Click += btnCloseSubmission_Click;
            // 
            // ctrlAnnouncement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(btnCloseSubmission);
            Controls.Add(lblDueDate);
            Controls.Add(btnEdit);
            Controls.Add(btnMarkAsDone);
            Controls.Add(lblCreatedAt);
            Controls.Add(lblCreatedBy);
            Controls.Add(lblContent);
            Controls.Add(lblTitle);
            Name = "ctrlAnnouncement";
            Size = new Size(316, 203);
            Load += ctrlAnnouncement_Load;
            ResumeLayout(false);
            PerformLayout();
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
    }
}
