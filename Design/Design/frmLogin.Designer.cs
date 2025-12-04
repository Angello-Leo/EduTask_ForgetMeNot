namespace Design
{
    partial class frmLogin
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
            button1 = new Button();
            label4 = new Label();
            txtUsername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtPassword = new TextBox();
            lblHasAcc = new Label();
            btnSubmit = new Button();
            button2 = new Button();
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Transparent;
            button1.Location = new Point(686, 247);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(87, 32);
            button1.TabIndex = 12;
            button1.Text = "LOG IN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += login_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial Rounded MT Bold", 12F);
            label4.Location = new Point(197, 142);
            label4.Name = "label4";
            label4.Size = new Size(117, 23);
            label4.TabIndex = 1;
            label4.Text = "Username:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtUsername.Location = new Point(316, 142);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(468, 27);
            txtUsername.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Rounded MT Bold", 19.8000011F);
            label3.Location = new Point(193, 67);
            label3.Name = "label3";
            label3.Size = new Size(388, 39);
            label3.TabIndex = 0;
            label3.Text = "EduTask:ForgetMeNot";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Rounded MT Bold", 12F);
            label2.Location = new Point(197, 202);
            label2.Name = "label2";
            label2.Size = new Size(113, 23);
            label2.TabIndex = 7;
            label2.Text = "Password:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.Location = new Point(316, 202);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(468, 27);
            txtPassword.TabIndex = 8;
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
            btnSubmit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSubmit.Location = new Point(1496, 736);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Location = new Point(806, 830);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 11;
            button2.Text = "Dash";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackgroundImage = Properties.Resources.BgLogin;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnSubmit);
            panel1.Controls.Add(lblHasAcc);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(966, 471);
            panel1.TabIndex = 13;
            panel1.Paint += panel1_Paint;
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.None;
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(523, 254);
            linkLabel1.Margin = new Padding(2, 0, 2, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(162, 20);
            linkLabel1.TabIndex = 14;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "I don't have an account";
            linkLabel1.LinkClicked += lnkSignup_LinkClicked;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(966, 471);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "frmLogin";
            Text = "Log In";
            Load += frmLogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Label label4;
        private TextBox txtUsername;
        private Label label3;
        private Label label2;
        private TextBox txtPassword;
        private Label lblHasAcc;
        private Button btnSubmit;
        private Button button2;
        private Panel panel1;
        private LinkLabel linkLabel1;
    }
}