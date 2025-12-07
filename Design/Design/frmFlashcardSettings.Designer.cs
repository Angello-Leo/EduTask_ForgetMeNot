namespace Design
{
    partial class frmFlashcardSettings
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtMax = new TextBox();
            txtTime = new TextBox();
            btnSave = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 70);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 0;
            label1.Text = "Maximum Card: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 135);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 1;
            label2.Text = "Set Time:";
            // 
            // txtMax
            // 
            txtMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtMax.Location = new Point(241, 70);
            txtMax.Name = "txtMax";
            txtMax.Size = new Size(155, 31);
            txtMax.TabIndex = 2;
            txtMax.Text = "10";
            txtMax.TextChanged += txtCard_TextChanged;
            // 
            // txtTime
            // 
            txtTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTime.Location = new Point(241, 129);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(155, 31);
            txtTime.TabIndex = 3;
            txtTime.Text = "60";
            txtTime.TextChanged += txtTime_TextChanged;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Transparent;
            btnSave.Location = new Point(153, 208);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(402, 135);
            label3.Name = "label3";
            label3.Size = new Size(45, 25);
            label3.TabIndex = 5;
            label3.Text = "secs";
            // 
            // frmFlashcardSettings
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(448, 271);
            Controls.Add(label3);
            Controls.Add(btnSave);
            Controls.Add(txtTime);
            Controls.Add(txtMax);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmFlashcardSettings";
            Text = "frmFlashcardSettings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtMax;
        private TextBox txtTime;
        private Button btnSave;
        private Label label3;
    }
}