namespace Design
{
    partial class ctrlNotification
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
            lblMessage = new Label();
            lblTimestamp = new Label();
            btnMarkRead = new Button();
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(60, 25);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(50, 20);
            lblMessage.TabIndex = 0;
            lblMessage.Text = "label1";
            // 
            // lblTimestamp
            // 
            lblTimestamp.AutoSize = true;
            lblTimestamp.Location = new Point(60, 64);
            lblTimestamp.Name = "lblTimestamp";
            lblTimestamp.Size = new Size(50, 20);
            lblTimestamp.TabIndex = 1;
            lblTimestamp.Text = "label1";
            // 
            // btnMarkRead
            // 
            btnMarkRead.Location = new Point(60, 105);
            btnMarkRead.Name = "btnMarkRead";
            btnMarkRead.Size = new Size(130, 29);
            btnMarkRead.TabIndex = 2;
            btnMarkRead.Text = "Mark as Read";
            btnMarkRead.UseVisualStyleBackColor = true;
            btnMarkRead.Click += btnMarkRead_Click;
            // 
            // ctrlNotification
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(btnMarkRead);
            Controls.Add(lblTimestamp);
            Controls.Add(lblMessage);
            Name = "ctrlNotification";
            Size = new Size(927, 150);
            Load += ctrlNotification_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMessage;
        private Label lblTimestamp;
        private Button btnMarkRead;
    }
}
