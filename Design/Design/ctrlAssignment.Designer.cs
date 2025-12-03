namespace Design
{
    partial class ctrlAssignment
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
            lblDescription = new Label();
            lblDueDate = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(30, 26);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(50, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "label1";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(30, 62);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(50, 20);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "label1";
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Location = new Point(30, 98);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(50, 20);
            lblDueDate.TabIndex = 2;
            lblDueDate.Text = "label1";
            // 
            // ctrlAssignment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblDueDate);
            Controls.Add(lblDescription);
            Controls.Add(lblTitle);
            Name = "ctrlAssignment";
            Size = new Size(845, 150);
            Load += ctrlAssignment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblDescription;
        private Label lblDueDate;
    }
}
