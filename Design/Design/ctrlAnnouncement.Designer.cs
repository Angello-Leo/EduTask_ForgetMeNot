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
            lblTitle.Location = new Point(49, 24);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(44, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title";
            // 
            // lblContent
            // 
            lblContent.AutoSize = true;
            lblContent.Location = new Point(49, 52);
            lblContent.Margin = new Padding(4, 0, 4, 0);
            lblContent.Name = "lblContent";
            lblContent.Size = new Size(75, 25);
            lblContent.TabIndex = 1;
            lblContent.Text = "Content";
            // 
            // lblCreatedBy
            // 
            lblCreatedBy.AutoSize = true;
            lblCreatedBy.Location = new Point(49, 90);
            lblCreatedBy.Margin = new Padding(4, 0, 4, 0);
            lblCreatedBy.Name = "lblCreatedBy";
            lblCreatedBy.Size = new Size(102, 25);
            lblCreatedBy.TabIndex = 2;
            lblCreatedBy.Text = "Created by:";
            // 
            // lblCreatedAt
            // 
            lblCreatedAt.AutoSize = true;
            lblCreatedAt.Location = new Point(49, 126);
            lblCreatedAt.Margin = new Padding(4, 0, 4, 0);
            lblCreatedAt.Name = "lblCreatedAt";
            lblCreatedAt.Size = new Size(102, 25);
            lblCreatedAt.TabIndex = 3;
            lblCreatedAt.Text = "Created by:";
            // 
            // btnMarkAsDone
            // 
            btnMarkAsDone.Location = new Point(646, 145);
            btnMarkAsDone.Margin = new Padding(4, 4, 4, 4);
            btnMarkAsDone.Name = "btnMarkAsDone";
            btnMarkAsDone.Size = new Size(118, 36);
            btnMarkAsDone.TabIndex = 4;
            btnMarkAsDone.Text = "Done";
            btnMarkAsDone.UseVisualStyleBackColor = true;
            btnMarkAsDone.Click += btnMarkAsDone_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(646, 90);
            btnEdit.Margin = new Padding(4, 4, 4, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(118, 36);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.ForeColor = Color.Red;
            lblDueDate.Location = new Point(49, 164);
            lblDueDate.Margin = new Padding(4, 0, 4, 0);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(102, 25);
            lblDueDate.TabIndex = 6;
            lblDueDate.Text = "Created by:";
            lblDueDate.Click += label1_Click;
            // 
            // btnCloseSubmission
            // 
            btnCloseSubmission.Location = new Point(646, 29);
            btnCloseSubmission.Margin = new Padding(4, 4, 4, 4);
            btnCloseSubmission.Name = "btnCloseSubmission";
            btnCloseSubmission.Size = new Size(118, 36);
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
            panel1.Location = new Point(34, 22);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(905, 216);
            panel1.TabIndex = 8;
            // 
            // ctrlAnnouncement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(panel1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "ctrlAnnouncement";
            Size = new Size(972, 254);
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
