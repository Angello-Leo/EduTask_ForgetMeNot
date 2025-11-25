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
            button1 = new Button();
            chkTeacher = new CheckBox();
            chkStudent = new CheckBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 19.8000011F);
            label1.Location = new Point(241, 84);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(695, 46);
            label1.TabIndex = 0;
            label1.Text = "Welcome to EduTask:ForgetMeNot";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Arial Rounded MT Bold", 12F);
            lblUsername.Location = new Point(246, 178);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(139, 28);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username:";
            lblUsername.TextAlign = ContentAlignment.MiddleLeft;
            lblUsername.Click += label2_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(395, 178);
            txtUsername.Margin = new Padding(4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(584, 31);
            txtUsername.TabIndex = 3;
            // 
            // lblHasAcc
            // 
            lblHasAcc.Location = new Point(0, 0);
            lblHasAcc.Name = "lblHasAcc";
            lblHasAcc.Size = new Size(100, 23);
            lblHasAcc.TabIndex = 13;
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSubmit.Location = new Point(862, 431);
            btnSubmit.Margin = new Padding(4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(118, 36);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(button1);
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
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1208, 589);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(615, 440);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(240, 21);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "I already have an account";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(0, 549);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(118, 36);
            button1.TabIndex = 11;
            button1.Text = "Dash";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // chkTeacher
            // 
            chkTeacher.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chkTeacher.AutoSize = true;
            chkTeacher.Location = new Point(395, 372);
            chkTeacher.Margin = new Padding(4);
            chkTeacher.Name = "chkTeacher";
            chkTeacher.Size = new Size(150, 29);
            chkTeacher.TabIndex = 10;
            chkTeacher.Text = "I am a Teacher";
            chkTeacher.UseVisualStyleBackColor = true;
            // 
            // chkStudent
            // 
            chkStudent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chkStudent.AutoSize = true;
            chkStudent.Location = new Point(395, 335);
            chkStudent.Margin = new Padding(4);
            chkStudent.Name = "chkStudent";
            chkStudent.Size = new Size(148, 29);
            chkStudent.TabIndex = 9;
            chkStudent.Text = "I am a Sudent";
            chkStudent.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(395, 252);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(584, 31);
            txtPassword.TabIndex = 8;
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Arial Rounded MT Bold", 12F);
            lblPassword.Location = new Point(246, 252);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(136, 28);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Password:";
            lblPassword.TextAlign = ContentAlignment.MiddleLeft;
            lblPassword.Click += label3_Click;
            // 
            // frmSignup
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 589);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "frmSignup";
            Text = "frmSignup";
            Load += frmSignup_Load;
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
        private Button button1;
        private LinkLabel linkLabel1;
    }
}