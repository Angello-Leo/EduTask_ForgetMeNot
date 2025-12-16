namespace Design
{
    partial class frmStartquiz
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStartquiz));
            picHamburgerMenu = new PictureBox();
            pictureBox15 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            picFlashcard = new PictureBox();
            picSchedule = new PictureBox();
            picPending = new PictureBox();
            picHome = new PictureBox();
            picFlashcardIcon = new PictureBox();
            picScheduleIcon = new PictureBox();
            picPendingIcon = new PictureBox();
            picHomeIcon = new PictureBox();
            label2 = new Label();
            picNotification = new PictureBox();
            quizCard = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            lblCorrect = new Label();
            lblMiss = new Label();
            txtAnswer = new TextBox();
            tmrQuiz = new System.Windows.Forms.Timer(components);
            Time = new Label();
            tmrStart = new System.Windows.Forms.Timer(components);
            tmrGo = new System.Windows.Forms.Timer(components);
            tmrInterval = new System.Windows.Forms.Timer(components);
            pnlFlashcard = new Panel();
            tmrHamburgerMenu = new System.Windows.Forms.Timer(components);
            lblUsername = new Label();
            ((System.ComponentModel.ISupportInitialize)picHamburgerMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFlashcard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSchedule).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPending).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFlashcardIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picScheduleIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPendingIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHomeIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picNotification).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quizCard).BeginInit();
            pnlFlashcard.SuspendLayout();
            SuspendLayout();
            // 
            // picHamburgerMenu
            // 
            picHamburgerMenu.BackColor = Color.Transparent;
            picHamburgerMenu.BackgroundImageLayout = ImageLayout.Zoom;
            picHamburgerMenu.Cursor = Cursors.Hand;
            picHamburgerMenu.Image = (Image)resources.GetObject("picHamburgerMenu.Image");
            picHamburgerMenu.Location = new Point(1, 12);
            picHamburgerMenu.Margin = new Padding(3, 4, 3, 4);
            picHamburgerMenu.Name = "picHamburgerMenu";
            picHamburgerMenu.Size = new Size(56, 44);
            picHamburgerMenu.TabIndex = 4;
            picHamburgerMenu.TabStop = false;
            picHamburgerMenu.Click += picHamburgerMenu_Click;
            // 
            // pictureBox15
            // 
            pictureBox15.BackColor = Color.Transparent;
            pictureBox15.BackgroundImage = (Image)resources.GetObject("pictureBox15.BackgroundImage");
            pictureBox15.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox15.Location = new Point(53, -9);
            pictureBox15.Margin = new Padding(3, 4, 3, 4);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(90, 87);
            pictureBox15.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox15.TabIndex = 24;
            pictureBox15.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(139, 19);
            label1.Name = "label1";
            label1.Size = new Size(217, 28);
            label1.TabIndex = 25;
            label1.Text = "EduTask : ForgetMeNot";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left;
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(picFlashcard);
            panel1.Controls.Add(picSchedule);
            panel1.Controls.Add(picPending);
            panel1.Controls.Add(picHome);
            panel1.Controls.Add(picFlashcardIcon);
            panel1.Controls.Add(picScheduleIcon);
            panel1.Controls.Add(picPendingIcon);
            panel1.Controls.Add(picHomeIcon);
            panel1.Location = new Point(0, 59);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(194, 767);
            panel1.TabIndex = 26;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.Untitled_design__2_;
            panel2.Location = new Point(11, 451);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(175, 342);
            panel2.TabIndex = 8;
            panel2.Visible = false;
            // 
            // picFlashcard
            // 
            picFlashcard.BackColor = Color.Transparent;
            picFlashcard.BackgroundImage = (Image)resources.GetObject("picFlashcard.BackgroundImage");
            picFlashcard.BackgroundImageLayout = ImageLayout.Zoom;
            picFlashcard.Cursor = Cursors.Hand;
            picFlashcard.Location = new Point(65, 356);
            picFlashcard.Margin = new Padding(3, 4, 3, 4);
            picFlashcard.Name = "picFlashcard";
            picFlashcard.Size = new Size(125, 69);
            picFlashcard.TabIndex = 18;
            picFlashcard.TabStop = false;
            picFlashcard.Click += picFlashcard_Click;
            // 
            // picSchedule
            // 
            picSchedule.BackColor = Color.Transparent;
            picSchedule.BackgroundImage = (Image)resources.GetObject("picSchedule.BackgroundImage");
            picSchedule.BackgroundImageLayout = ImageLayout.Zoom;
            picSchedule.Cursor = Cursors.Hand;
            picSchedule.Location = new Point(63, 285);
            picSchedule.Margin = new Padding(3, 4, 3, 4);
            picSchedule.Name = "picSchedule";
            picSchedule.Size = new Size(127, 63);
            picSchedule.TabIndex = 17;
            picSchedule.TabStop = false;
            picSchedule.Click += picSchedule_Click;
            // 
            // picPending
            // 
            picPending.BackColor = Color.Transparent;
            picPending.BackgroundImage = (Image)resources.GetObject("picPending.BackgroundImage");
            picPending.BackgroundImageLayout = ImageLayout.Zoom;
            picPending.Cursor = Cursors.Hand;
            picPending.Location = new Point(63, 210);
            picPending.Margin = new Padding(3, 4, 3, 4);
            picPending.Name = "picPending";
            picPending.Size = new Size(121, 55);
            picPending.TabIndex = 16;
            picPending.TabStop = false;
            picPending.Click += picPending_Click;
            // 
            // picHome
            // 
            picHome.BackColor = Color.Transparent;
            picHome.BackgroundImage = (Image)resources.GetObject("picHome.BackgroundImage");
            picHome.BackgroundImageLayout = ImageLayout.Zoom;
            picHome.Cursor = Cursors.Hand;
            picHome.Location = new Point(65, 134);
            picHome.Margin = new Padding(3, 4, 3, 4);
            picHome.Name = "picHome";
            picHome.Size = new Size(121, 55);
            picHome.TabIndex = 15;
            picHome.TabStop = false;
            picHome.Click += picHome_Click;
            // 
            // picFlashcardIcon
            // 
            picFlashcardIcon.BackColor = Color.Transparent;
            picFlashcardIcon.BackgroundImage = (Image)resources.GetObject("picFlashcardIcon.BackgroundImage");
            picFlashcardIcon.BackgroundImageLayout = ImageLayout.Zoom;
            picFlashcardIcon.Cursor = Cursors.Hand;
            picFlashcardIcon.Location = new Point(11, 362);
            picFlashcardIcon.Margin = new Padding(3, 4, 3, 4);
            picFlashcardIcon.Name = "picFlashcardIcon";
            picFlashcardIcon.Size = new Size(47, 55);
            picFlashcardIcon.TabIndex = 11;
            picFlashcardIcon.TabStop = false;
            picFlashcardIcon.Click += picFlashcardIcon_Click;
            // 
            // picScheduleIcon
            // 
            picScheduleIcon.BackColor = Color.Transparent;
            picScheduleIcon.BackgroundImage = (Image)resources.GetObject("picScheduleIcon.BackgroundImage");
            picScheduleIcon.BackgroundImageLayout = ImageLayout.Zoom;
            picScheduleIcon.Cursor = Cursors.Hand;
            picScheduleIcon.Location = new Point(11, 286);
            picScheduleIcon.Margin = new Padding(3, 4, 3, 4);
            picScheduleIcon.Name = "picScheduleIcon";
            picScheduleIcon.Size = new Size(47, 55);
            picScheduleIcon.TabIndex = 10;
            picScheduleIcon.TabStop = false;
            picScheduleIcon.Click += picScheduleIcon_Click;
            // 
            // picPendingIcon
            // 
            picPendingIcon.BackColor = Color.Transparent;
            picPendingIcon.BackgroundImage = (Image)resources.GetObject("picPendingIcon.BackgroundImage");
            picPendingIcon.BackgroundImageLayout = ImageLayout.Zoom;
            picPendingIcon.Cursor = Cursors.Hand;
            picPendingIcon.Location = new Point(11, 210);
            picPendingIcon.Margin = new Padding(3, 4, 3, 4);
            picPendingIcon.Name = "picPendingIcon";
            picPendingIcon.Size = new Size(47, 55);
            picPendingIcon.TabIndex = 9;
            picPendingIcon.TabStop = false;
            picPendingIcon.Click += picPendingIcon_Click;
            // 
            // picHomeIcon
            // 
            picHomeIcon.BackColor = Color.Transparent;
            picHomeIcon.BackgroundImage = (Image)resources.GetObject("picHomeIcon.BackgroundImage");
            picHomeIcon.BackgroundImageLayout = ImageLayout.Zoom;
            picHomeIcon.Cursor = Cursors.Hand;
            picHomeIcon.Location = new Point(11, 133);
            picHomeIcon.Margin = new Padding(3, 4, 3, 4);
            picHomeIcon.Name = "picHomeIcon";
            picHomeIcon.Size = new Size(47, 55);
            picHomeIcon.TabIndex = 8;
            picHomeIcon.TabStop = false;
            picHomeIcon.Click += picHomeIcon_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Malgun Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1035, 7);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(143, 37);
            label2.TabIndex = 30;
            label2.Text = ",Welcome";
            // 
            // picNotification
            // 
            picNotification.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picNotification.BackColor = Color.Transparent;
            picNotification.BackgroundImage = (Image)resources.GetObject("picNotification.BackgroundImage");
            picNotification.BackgroundImageLayout = ImageLayout.Zoom;
            picNotification.Cursor = Cursors.Hand;
            picNotification.Location = new Point(1212, 74);
            picNotification.Margin = new Padding(3, 4, 3, 4);
            picNotification.Name = "picNotification";
            picNotification.Size = new Size(51, 55);
            picNotification.TabIndex = 34;
            picNotification.TabStop = false;
            picNotification.Click += picNotification_Click;
            // 
            // quizCard
            // 
            quizCard.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            quizCard.BackgroundImage = (Image)resources.GetObject("quizCard.BackgroundImage");
            quizCard.Location = new Point(40, 59);
            quizCard.Margin = new Padding(3, 4, 3, 4);
            quizCard.Name = "quizCard";
            quizCard.Size = new Size(695, 413);
            quizCard.TabIndex = 36;
            quizCard.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 192, 0);
            label3.Location = new Point(40, 517);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 24);
            label3.TabIndex = 37;
            label3.Text = "Correct:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(192, 0, 0);
            label4.Location = new Point(649, 517);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(55, 24);
            label4.TabIndex = 38;
            label4.Text = "Miss:";
            // 
            // lblCorrect
            // 
            lblCorrect.Anchor = AnchorStyles.None;
            lblCorrect.AutoSize = true;
            lblCorrect.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCorrect.ForeColor = Color.Black;
            lblCorrect.Location = new Point(112, 517);
            lblCorrect.Margin = new Padding(2, 0, 2, 0);
            lblCorrect.Name = "lblCorrect";
            lblCorrect.Size = new Size(21, 24);
            lblCorrect.TabIndex = 39;
            lblCorrect.Text = "0";
            // 
            // lblMiss
            // 
            lblMiss.Anchor = AnchorStyles.None;
            lblMiss.AutoSize = true;
            lblMiss.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMiss.ForeColor = Color.Black;
            lblMiss.Location = new Point(696, 517);
            lblMiss.Margin = new Padding(2, 0, 2, 0);
            lblMiss.Name = "lblMiss";
            lblMiss.Size = new Size(21, 24);
            lblMiss.TabIndex = 40;
            lblMiss.Text = "0";
            // 
            // txtAnswer
            // 
            txtAnswer.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtAnswer.Location = new Point(159, 486);
            txtAnswer.Margin = new Padding(2, 2, 2, 2);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(477, 27);
            txtAnswer.TabIndex = 41;
            txtAnswer.KeyDown += txtAnswer_KeyDown;
            // 
            // tmrQuiz
            // 
            tmrQuiz.Interval = 1000;
            tmrQuiz.Tick += tmrQuiz_Tick;
            // 
            // Time
            // 
            Time.Anchor = AnchorStyles.Top;
            Time.AutoSize = true;
            Time.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Time.Location = new Point(359, 20);
            Time.Margin = new Padding(2, 0, 2, 0);
            Time.Name = "Time";
            Time.Size = new Size(60, 29);
            Time.TabIndex = 42;
            Time.Text = "1:00";
            // 
            // tmrStart
            // 
            tmrStart.Interval = 1000;
            tmrStart.Tick += tmrStart_Tick;
            // 
            // tmrGo
            // 
            tmrGo.Interval = 1000;
            tmrGo.Tick += tmrGo_Tick;
            // 
            // tmrInterval
            // 
            tmrInterval.Interval = 1000;
            tmrInterval.Tick += tmrInterval_Tick;
            // 
            // pnlFlashcard
            // 
            pnlFlashcard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlFlashcard.Controls.Add(Time);
            pnlFlashcard.Controls.Add(txtAnswer);
            pnlFlashcard.Controls.Add(quizCard);
            pnlFlashcard.Controls.Add(lblMiss);
            pnlFlashcard.Controls.Add(label4);
            pnlFlashcard.Controls.Add(lblCorrect);
            pnlFlashcard.Controls.Add(label3);
            pnlFlashcard.Location = new Point(354, 116);
            pnlFlashcard.Margin = new Padding(2, 2, 2, 2);
            pnlFlashcard.Name = "pnlFlashcard";
            pnlFlashcard.Size = new Size(778, 656);
            pnlFlashcard.TabIndex = 43;
            // 
            // tmrHamburgerMenu
            // 
            tmrHamburgerMenu.Tick += tmrHamburgerMenu_Tick;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Malgun Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(1178, 12);
            lblUsername.Name = "lblUsername";
            lblUsername.RightToLeft = RightToLeft.Yes;
            lblUsername.Size = new Size(0, 37);
            lblUsername.TabIndex = 44;
            // 
            // frmStartquiz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design__1_2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1326, 821);
            Controls.Add(lblUsername);
            Controls.Add(pnlFlashcard);
            Controls.Add(picNotification);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox15);
            Controls.Add(picHamburgerMenu);
            Margin = new Padding(2, 2, 2, 2);
            Name = "frmStartquiz";
            Text = "Flash Card Quiz";
            Load += frmStartquiz_Load;
            ((System.ComponentModel.ISupportInitialize)picHamburgerMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picFlashcard).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSchedule).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPending).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)picFlashcardIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)picScheduleIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPendingIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHomeIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)picNotification).EndInit();
            ((System.ComponentModel.ISupportInitialize)quizCard).EndInit();
            pnlFlashcard.ResumeLayout(false);
            pnlFlashcard.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picHamburgerMenu;
        private PictureBox pictureBox15;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private PictureBox picFlashcard;
        private PictureBox picSchedule;
        private PictureBox picPending;
        private PictureBox picHome;
        private PictureBox picFlashcardIcon;
        private PictureBox picScheduleIcon;
        private PictureBox picPendingIcon;
        private PictureBox picHomeIcon;
        private Label label2;
        private PictureBox picNotification;
        private PictureBox quizCard;
        private Label label3;
        private Label label4;
        private Label lblCorrect;
        private Label lblMiss;
        private TextBox txtAnswer;
        private System.Windows.Forms.Timer tmrQuiz;
        private Label Time;
        private System.Windows.Forms.Timer tmrStart;
        private System.Windows.Forms.Timer tmrGo;
        private System.Windows.Forms.Timer tmrInterval;
        private Panel pnlFlashcard;
        private System.Windows.Forms.Timer tmrHamburgerMenu;
        private Label lblUsername;
    }
}