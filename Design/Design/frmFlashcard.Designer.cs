namespace Design
{
    partial class frmFlashcard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFlashcard));
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
            picAddClass = new PictureBox();
            picNotification = new PictureBox();
            label2 = new Label();
            pictureBox16 = new PictureBox();
            picCreateCards = new PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)picAddClass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picNotification).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCreateCards).BeginInit();
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
            picHamburgerMenu.TabIndex = 2;
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
            pictureBox15.TabIndex = 22;
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
            label1.TabIndex = 23;
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
            panel1.TabIndex = 24;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.AutoScroll = true;
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.Untitled_design__2_;
            panel2.Location = new Point(11, 451);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(175, 304);
            panel2.TabIndex = 8;
            panel2.Visible = false;
            // 
            // picFlashcard
            // 
            picFlashcard.Anchor = AnchorStyles.Left;
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
            picSchedule.Anchor = AnchorStyles.Left;
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
            picPending.Anchor = AnchorStyles.Left;
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
            // picAddClass
            // 
            picAddClass.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            picAddClass.BackColor = Color.Transparent;
            picAddClass.BackgroundImage = (Image)resources.GetObject("picAddClass.BackgroundImage");
            picAddClass.BackgroundImageLayout = ImageLayout.Zoom;
            picAddClass.Cursor = Cursors.Hand;
            picAddClass.Location = new Point(1191, 701);
            picAddClass.Margin = new Padding(3, 4, 3, 4);
            picAddClass.Name = "picAddClass";
            picAddClass.Size = new Size(125, 89);
            picAddClass.TabIndex = 25;
            picAddClass.TabStop = false;
            picAddClass.Click += picAddClass_Click;
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
            picNotification.TabIndex = 26;
            picNotification.TabStop = false;
            picNotification.Click += picNotification_Click;
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
            label2.TabIndex = 28;
            label2.Text = ",Welcome";
            // 
            // pictureBox16
            // 
            pictureBox16.BackColor = Color.Transparent;
            pictureBox16.BackgroundImage = (Image)resources.GetObject("pictureBox16.BackgroundImage");
            pictureBox16.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox16.Location = new Point(307, 104);
            pictureBox16.Margin = new Padding(3, 4, 3, 4);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new Size(286, 85);
            pictureBox16.TabIndex = 29;
            pictureBox16.TabStop = false;
            // 
            // picCreateCards
            // 
            picCreateCards.BackgroundImage = (Image)resources.GetObject("picCreateCards.BackgroundImage");
            picCreateCards.BackgroundImageLayout = ImageLayout.Stretch;
            picCreateCards.Cursor = Cursors.Hand;
            picCreateCards.Location = new Point(259, 225);
            picCreateCards.Margin = new Padding(3, 4, 3, 4);
            picCreateCards.Name = "picCreateCards";
            picCreateCards.Size = new Size(317, 144);
            picCreateCards.TabIndex = 30;
            picCreateCards.TabStop = false;
            picCreateCards.Click += picCreateQuiz_Click;
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
            lblUsername.TabIndex = 31;
            // 
            // frmFlashcard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design__1_1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1326, 821);
            Controls.Add(lblUsername);
            Controls.Add(picCreateCards);
            Controls.Add(pictureBox16);
            Controls.Add(label2);
            Controls.Add(picNotification);
            Controls.Add(picAddClass);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox15);
            Controls.Add(picHamburgerMenu);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmFlashcard";
            Text = "Flashcards";
            Load += frmFlashcard_Load;
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
            ((System.ComponentModel.ISupportInitialize)picAddClass).EndInit();
            ((System.ComponentModel.ISupportInitialize)picNotification).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCreateCards).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picHamburgerMenu;
        private PictureBox pictureBox15;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox14;
        private PictureBox pictureBox13;
        private PictureBox picFlashcard;
        private PictureBox picSchedule;
        private PictureBox picPending;
        private PictureBox picHome;
        private PictureBox pictureBox9;
        private PictureBox picFlashcardIcon;
        private PictureBox picScheduleIcon;
        private PictureBox picPendingIcon;
        private PictureBox picHomeIcon;
        private PictureBox picAddClass;
        private PictureBox picNotification;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label2;
        private PictureBox pictureBox16;
        private PictureBox picCreateCards;
        private System.Windows.Forms.Timer tmrHamburgerMenu;
        private Label lblUsername;
    }
}