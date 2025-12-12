namespace Design
{
    partial class frmSignup
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
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblHasAcc = new Label();
            btnSubmit = new Button();
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            chkTeacher = new CheckBox();
            chkStudent = new CheckBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 19.8000011F);
            label1.Location = new Point(193, 67);
            label1.Name = "label1";
            label1.Size = new Size(591, 39);
            label1.TabIndex = 0;
            label1.Text = "Welcome to EduTask:ForgetMeNot";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Arial Rounded MT Bold", 12F);
            lblUsername.Location = new Point(197, 142);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(117, 23);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username:";
            lblUsername.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtUsername.Location = new Point(316, 142);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(468, 27);
            txtUsername.TabIndex = 3;
            // 
            // lblHasAcc
            // 
            lblHasAcc.Location = new Point(0, 0);
            lblHasAcc.Margin = new Padding(2, 0, 2, 0);
            lblHasAcc.Name = "lblHasAcc";
            lblHasAcc.Size = new Size(80, 18);
            lblHasAcc.TabIndex = 13;
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.None;
            btnSubmit.BackColor = Color.Transparent;
            btnSubmit.Cursor = Cursors.Hand;
            btnSubmit.Location = new Point(690, 345);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackgroundImage = Properties.Resources.BgSignup;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(chkTeacher);
            panel1.Controls.Add(btnSubmit);
            panel1.Controls.Add(chkStudent);
            panel1.Controls.Add(lblHasAcc);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(lblUsername);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(966, 471);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.None;
            linkLabel1.AutoSize = true;
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(492, 352);
            linkLabel1.Margin = new Padding(2, 0, 2, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(196, 17);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "I already have an account";
            linkLabel1.LinkClicked += lnkLogin_LinkClicked;
            // 
            // chkTeacher
            // 
            chkTeacher.Anchor = AnchorStyles.None;
            chkTeacher.AutoSize = true;
            chkTeacher.BackColor = Color.Transparent;
            chkTeacher.Location = new Point(316, 298);
            chkTeacher.Name = "chkTeacher";
            chkTeacher.Size = new Size(127, 24);
            chkTeacher.TabIndex = 10;
            chkTeacher.Text = "I am a Teacher";
            chkTeacher.UseVisualStyleBackColor = false;
            // 
            // chkStudent
            // 
            chkStudent.Anchor = AnchorStyles.None;
            chkStudent.AutoSize = true;
            chkStudent.BackColor = Color.Transparent;
            chkStudent.Location = new Point(316, 268);
            chkStudent.Name = "chkStudent";
            chkStudent.Size = new Size(122, 24);
            chkStudent.TabIndex = 9;
            chkStudent.Text = "I am a Sudent";
            chkStudent.UseVisualStyleBackColor = false;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.Location = new Point(316, 202);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(468, 27);
            txtPassword.TabIndex = 8;
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Arial Rounded MT Bold", 12F);
            lblPassword.Location = new Point(197, 202);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(113, 23);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Password:";
            lblPassword.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmSignup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 471);
            Controls.Add(panel1);
            Name = "frmSignup";
            Text = "frmSignup";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblHasAcc;
        private Button btnSubmit;
        private Panel panel1;
        private CheckBox chkTeacher;
        private CheckBox chkStudent;
        private TextBox txtPassword;
        private Label lblPassword;
        private LinkLabel linkLabel1;
    }
}