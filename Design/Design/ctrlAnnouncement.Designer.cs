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
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(41, 31);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(38, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title";
            // 
            // lblContent
            // 
            lblContent.AutoSize = true;
            lblContent.Location = new Point(41, 66);
            lblContent.Name = "lblContent";
            lblContent.Size = new Size(61, 20);
            lblContent.TabIndex = 1;
            lblContent.Text = "Content";
            // 
            // lblCreatedBy
            // 
            lblCreatedBy.AutoSize = true;
            lblCreatedBy.Location = new Point(41, 96);
            lblCreatedBy.Name = "lblCreatedBy";
            lblCreatedBy.Size = new Size(84, 20);
            lblCreatedBy.TabIndex = 2;
            lblCreatedBy.Text = "Created by:";
            // 
            // lblCreatedAt
            // 
            lblCreatedAt.AutoSize = true;
            lblCreatedAt.Location = new Point(41, 125);
            lblCreatedAt.Name = "lblCreatedAt";
            lblCreatedAt.Size = new Size(84, 20);
            lblCreatedAt.TabIndex = 3;
            lblCreatedAt.Text = "Created by:";
            // 
            // btnMarkAsDone
            // 
            btnMarkAsDone.Location = new Point(41, 148);
            btnMarkAsDone.Name = "btnMarkAsDone";
            btnMarkAsDone.Size = new Size(94, 29);
            btnMarkAsDone.TabIndex = 4;
            btnMarkAsDone.Text = "Done";
            btnMarkAsDone.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(174, 148);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // ctrlAnnouncement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(btnEdit);
            Controls.Add(btnMarkAsDone);
            Controls.Add(lblCreatedAt);
            Controls.Add(lblCreatedBy);
            Controls.Add(lblContent);
            Controls.Add(lblTitle);
            Name = "ctrlAnnouncement";
            Size = new Size(282, 189);
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
    }
}
