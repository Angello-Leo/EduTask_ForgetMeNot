namespace Design
{
    partial class Class
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Class));
            picHamburgerMenu = new PictureBox();
            pictureBox16 = new PictureBox();
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
            picNotification = new PictureBox();
            picAddClass = new PictureBox();
            label4 = new Label();
            pictureBox15 = new PictureBox();
            tmrHamburgerMenu = new System.Windows.Forms.Timer(components);
            picPeople = new PictureBox();
            picClass = new PictureBox();
            lblClassName = new Label();
            lblAdviser = new Label();
            lblUsername = new Label();
            panelStatus = new Panel();
            lblStatusMessage = new Label();
            panelVoting = new Panel();
            lblInstruction = new Label();
            btnSubmitVote = new Button();
            dgvCandidates = new DataGridView();
            panelResults = new Panel();
            btnNextPosition = new Button();
            lblWinner = new Label();
            lblResultsTitle = new Label();
            tmrCheckStudents = new System.Windows.Forms.Timer(components);
            tmrCheckVotes = new System.Windows.Forms.Timer(components);
            tmrClearResults = new System.Windows.Forms.Timer(components);
            flowLayoutPanelAnnouncements = new FlowLayoutPanel();
            panelCreateAnnouncement = new Panel();
            chkSetDueDate = new CheckBox();
            lblSetDueDate = new Label();
            dtpDueDateTime = new DateTimePicker();
            label2 = new Label();
            btnNewAnnouncement = new Button();
            txtAnnouncementTitle = new TextBox();
            txtAnnouncementContent = new RichTextBox();
            mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            dgvShowStudents = new DataGridView();
            lblClassCode = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picHamburgerMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)picAddClass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPeople).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picClass).BeginInit();
            panelStatus.SuspendLayout();
            panelVoting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCandidates).BeginInit();
            panelResults.SuspendLayout();
            panelCreateAnnouncement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvShowStudents).BeginInit();
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
            picHamburgerMenu.TabIndex = 3;
            picHamburgerMenu.TabStop = false;
            picHamburgerMenu.Click += picHamburgerMenu_Click;
            // 
            // pictureBox16
            // 
            pictureBox16.BackColor = Color.Transparent;
            pictureBox16.BackgroundImage = (Image)resources.GetObject("pictureBox16.BackgroundImage");
            pictureBox16.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox16.Location = new Point(53, -9);
            pictureBox16.Margin = new Padding(3, 4, 3, 4);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new Size(90, 87);
            pictureBox16.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox16.TabIndex = 23;
            pictureBox16.TabStop = false;
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
            label1.TabIndex = 24;
            label1.Text = "EduTask : ForgetMeNot";
            // 
            // panel1
            // 
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
            panel1.TabIndex = 25;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.Untitled_design__2_;
            panel2.Location = new Point(7, 472);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(175, 291);
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
            picAddClass.TabIndex = 28;
            picAddClass.TabStop = false;
            picAddClass.Click += pictureBox3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Malgun Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(1035, 7);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(143, 37);
            label4.TabIndex = 21;
            label4.Text = ",Welcome";
            // 
            // pictureBox15
            // 
            pictureBox15.Anchor = AnchorStyles.None;
            pictureBox15.BackColor = Color.Transparent;
            pictureBox15.BackgroundImage = (Image)resources.GetObject("pictureBox15.BackgroundImage");
            pictureBox15.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox15.Location = new Point(357, 77);
            pictureBox15.Margin = new Padding(3, 4, 3, 4);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(773, 265);
            pictureBox15.TabIndex = 29;
            pictureBox15.TabStop = false;
            // 
            // tmrHamburgerMenu
            // 
            tmrHamburgerMenu.Tick += tmrHamburgerMenu_Tick;
            // 
            // picPeople
            // 
            picPeople.BackColor = Color.Transparent;
            picPeople.BackgroundImage = (Image)resources.GetObject("picPeople.BackgroundImage");
            picPeople.BackgroundImageLayout = ImageLayout.Zoom;
            picPeople.Cursor = Cursors.Hand;
            picPeople.Location = new Point(440, 351);
            picPeople.Margin = new Padding(3, 4, 3, 4);
            picPeople.Name = "picPeople";
            picPeople.Size = new Size(65, 36);
            picPeople.TabIndex = 30;
            picPeople.TabStop = false;
            picPeople.Click += picPeople_Click;
            // 
            // picClass
            // 
            picClass.BackColor = Color.Transparent;
            picClass.BackgroundImage = (Image)resources.GetObject("picClass.BackgroundImage");
            picClass.BackgroundImageLayout = ImageLayout.Zoom;
            picClass.Cursor = Cursors.Hand;
            picClass.Location = new Point(368, 351);
            picClass.Margin = new Padding(3, 4, 3, 4);
            picClass.Name = "picClass";
            picClass.Size = new Size(65, 36);
            picClass.TabIndex = 31;
            picClass.TabStop = false;
            picClass.Click += picClass_Click;
            // 
            // lblClassName
            // 
            lblClassName.AutoSize = true;
            lblClassName.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClassName.Location = new Point(460, 240);
            lblClassName.Name = "lblClassName";
            lblClassName.Size = new Size(30, 23);
            lblClassName.TabIndex = 32;
            lblClassName.Text = "    ";
            // 
            // lblAdviser
            // 
            lblAdviser.AutoSize = true;
            lblAdviser.Location = new Point(440, 275);
            lblAdviser.Name = "lblAdviser";
            lblAdviser.Size = new Size(17, 20);
            lblAdviser.TabIndex = 34;
            lblAdviser.Text = "  ";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Malgun Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(1171, 7);
            lblUsername.Name = "lblUsername";
            lblUsername.RightToLeft = RightToLeft.Yes;
            lblUsername.Size = new Size(0, 37);
            lblUsername.TabIndex = 36;
            // 
            // panelStatus
            // 
            panelStatus.Anchor = AnchorStyles.None;
            panelStatus.Controls.Add(lblStatusMessage);
            panelStatus.Location = new Point(357, 394);
            panelStatus.Name = "panelStatus";
            panelStatus.Size = new Size(773, 415);
            panelStatus.TabIndex = 37;
            // 
            // lblStatusMessage
            // 
            lblStatusMessage.AutoSize = true;
            lblStatusMessage.ForeColor = SystemColors.ControlDarkDark;
            lblStatusMessage.Location = new Point(280, 386);
            lblStatusMessage.Name = "lblStatusMessage";
            lblStatusMessage.Size = new Size(218, 20);
            lblStatusMessage.TabIndex = 0;
            lblStatusMessage.Text = "Waiting for all students to join...";
            // 
            // panelVoting
            // 
            panelVoting.Anchor = AnchorStyles.None;
            panelVoting.Controls.Add(lblInstruction);
            panelVoting.Controls.Add(btnSubmitVote);
            panelVoting.Controls.Add(dgvCandidates);
            panelVoting.Location = new Point(357, 391);
            panelVoting.Name = "panelVoting";
            panelVoting.Size = new Size(778, 415);
            panelVoting.TabIndex = 38;
            panelVoting.Visible = false;
            // 
            // lblInstruction
            // 
            lblInstruction.AutoSize = true;
            lblInstruction.Location = new Point(11, 392);
            lblInstruction.Name = "lblInstruction";
            lblInstruction.Size = new Size(50, 20);
            lblInstruction.TabIndex = 2;
            lblInstruction.Text = "label2";
            lblInstruction.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnSubmitVote
            // 
            btnSubmitVote.Location = new Point(610, 383);
            btnSubmitVote.Name = "btnSubmitVote";
            btnSubmitVote.Size = new Size(130, 29);
            btnSubmitVote.TabIndex = 1;
            btnSubmitVote.Text = "Submit Vote";
            btnSubmitVote.UseVisualStyleBackColor = true;
            btnSubmitVote.Click += btnSubmitVote_Click;
            // 
            // dgvCandidates
            // 
            dgvCandidates.AllowUserToAddRows = false;
            dgvCandidates.AllowUserToDeleteRows = false;
            dgvCandidates.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCandidates.Dock = DockStyle.Fill;
            dgvCandidates.Location = new Point(0, 0);
            dgvCandidates.MultiSelect = false;
            dgvCandidates.Name = "dgvCandidates";
            dgvCandidates.ReadOnly = true;
            dgvCandidates.RowHeadersVisible = false;
            dgvCandidates.RowHeadersWidth = 51;
            dgvCandidates.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCandidates.Size = new Size(778, 415);
            dgvCandidates.TabIndex = 0;
            // 
            // panelResults
            // 
            panelResults.Anchor = AnchorStyles.None;
            panelResults.AutoScroll = true;
            panelResults.Controls.Add(btnNextPosition);
            panelResults.Controls.Add(lblWinner);
            panelResults.Controls.Add(lblResultsTitle);
            panelResults.Location = new Point(357, 391);
            panelResults.Name = "panelResults";
            panelResults.Size = new Size(778, 415);
            panelResults.TabIndex = 39;
            panelResults.Visible = false;
            // 
            // btnNextPosition
            // 
            btnNextPosition.Anchor = AnchorStyles.None;
            btnNextPosition.Location = new Point(338, 212);
            btnNextPosition.Name = "btnNextPosition";
            btnNextPosition.Size = new Size(107, 28);
            btnNextPosition.TabIndex = 2;
            btnNextPosition.Text = "Next Position";
            btnNextPosition.UseVisualStyleBackColor = true;
            btnNextPosition.Visible = false;
            // 
            // lblWinner
            // 
            lblWinner.Anchor = AnchorStyles.None;
            lblWinner.AutoSize = true;
            lblWinner.Location = new Point(364, 189);
            lblWinner.Name = "lblWinner";
            lblWinner.Size = new Size(50, 20);
            lblWinner.TabIndex = 1;
            lblWinner.Text = "label2";
            // 
            // lblResultsTitle
            // 
            lblResultsTitle.Anchor = AnchorStyles.None;
            lblResultsTitle.AutoSize = true;
            lblResultsTitle.Location = new Point(364, 153);
            lblResultsTitle.Name = "lblResultsTitle";
            lblResultsTitle.Size = new Size(50, 20);
            lblResultsTitle.TabIndex = 0;
            lblResultsTitle.Text = "label2";
            lblResultsTitle.Visible = false;
            // 
            // tmrCheckStudents
            // 
            tmrCheckStudents.Enabled = true;
            tmrCheckStudents.Interval = 5000;
            // 
            // tmrCheckVotes
            // 
            tmrCheckVotes.Enabled = true;
            tmrCheckVotes.Interval = 3000;
            // 
            // tmrClearResults
            // 
            tmrClearResults.Enabled = true;
            tmrClearResults.Interval = 3000;
            tmrClearResults.Tick += tmrClearResults_Tick;
            // 
            // flowLayoutPanelAnnouncements
            // 
            flowLayoutPanelAnnouncements.AutoScroll = true;
            flowLayoutPanelAnnouncements.Location = new Point(347, 386);
            flowLayoutPanelAnnouncements.Name = "flowLayoutPanelAnnouncements";
            flowLayoutPanelAnnouncements.Size = new Size(814, 423);
            flowLayoutPanelAnnouncements.TabIndex = 3;
            flowLayoutPanelAnnouncements.Visible = false;
            // 
            // panelCreateAnnouncement
            // 
            panelCreateAnnouncement.Anchor = AnchorStyles.None;
            panelCreateAnnouncement.AutoScroll = true;
            panelCreateAnnouncement.BackColor = Color.DarkGreen;
            panelCreateAnnouncement.Controls.Add(chkSetDueDate);
            panelCreateAnnouncement.Controls.Add(lblSetDueDate);
            panelCreateAnnouncement.Controls.Add(dtpDueDateTime);
            panelCreateAnnouncement.Controls.Add(label2);
            panelCreateAnnouncement.Controls.Add(btnNewAnnouncement);
            panelCreateAnnouncement.Controls.Add(txtAnnouncementTitle);
            panelCreateAnnouncement.Controls.Add(txtAnnouncementContent);
            panelCreateAnnouncement.Location = new Point(368, 397);
            panelCreateAnnouncement.Name = "panelCreateAnnouncement";
            panelCreateAnnouncement.Size = new Size(778, 425);
            panelCreateAnnouncement.TabIndex = 40;
            panelCreateAnnouncement.Visible = false;
            // 
            // chkSetDueDate
            // 
            chkSetDueDate.AutoSize = true;
            chkSetDueDate.Location = new Point(257, 379);
            chkSetDueDate.Name = "chkSetDueDate";
            chkSetDueDate.Size = new Size(18, 17);
            chkSetDueDate.TabIndex = 44;
            chkSetDueDate.UseVisualStyleBackColor = true;
            chkSetDueDate.CheckedChanged += chkSetDueDate_CheckedChanged;
            // 
            // lblSetDueDate
            // 
            lblSetDueDate.AutoSize = true;
            lblSetDueDate.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSetDueDate.ForeColor = SystemColors.ButtonFace;
            lblSetDueDate.Location = new Point(130, 378);
            lblSetDueDate.Name = "lblSetDueDate";
            lblSetDueDate.Size = new Size(121, 17);
            lblSetDueDate.TabIndex = 43;
            lblSetDueDate.Text = "Set Due Date ?:";
            // 
            // dtpDueDateTime
            // 
            dtpDueDateTime.Location = new Point(284, 374);
            dtpDueDateTime.Name = "dtpDueDateTime";
            dtpDueDateTime.Size = new Size(250, 27);
            dtpDueDateTime.TabIndex = 42;
            dtpDueDateTime.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(284, 38);
            label2.Name = "label2";
            label2.Size = new Size(192, 20);
            label2.TabIndex = 41;
            label2.Text = "Create Announcement";
            // 
            // btnNewAnnouncement
            // 
            btnNewAnnouncement.Anchor = AnchorStyles.None;
            btnNewAnnouncement.Location = new Point(548, 372);
            btnNewAnnouncement.Name = "btnNewAnnouncement";
            btnNewAnnouncement.Size = new Size(94, 29);
            btnNewAnnouncement.TabIndex = 40;
            btnNewAnnouncement.Text = "Post";
            btnNewAnnouncement.UseVisualStyleBackColor = true;
            btnNewAnnouncement.Click += btnNewAnnouncement_Click;
            // 
            // txtAnnouncementTitle
            // 
            txtAnnouncementTitle.Anchor = AnchorStyles.Left;
            txtAnnouncementTitle.Location = new Point(130, 79);
            txtAnnouncementTitle.Name = "txtAnnouncementTitle";
            txtAnnouncementTitle.PlaceholderText = "Enter Title";
            txtAnnouncementTitle.Size = new Size(512, 27);
            txtAnnouncementTitle.TabIndex = 0;
            // 
            // txtAnnouncementContent
            // 
            txtAnnouncementContent.Anchor = AnchorStyles.None;
            txtAnnouncementContent.Location = new Point(130, 134);
            txtAnnouncementContent.Name = "txtAnnouncementContent";
            txtAnnouncementContent.Size = new Size(512, 227);
            txtAnnouncementContent.TabIndex = 1;
            txtAnnouncementContent.Text = "";
            // 
            // dgvShowStudents
            // 
            dgvShowStudents.AllowUserToAddRows = false;
            dgvShowStudents.AllowUserToDeleteRows = false;
            dgvShowStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvShowStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShowStudents.Location = new Point(343, 386);
            dgvShowStudents.Name = "dgvShowStudents";
            dgvShowStudents.ReadOnly = true;
            dgvShowStudents.RowHeadersWidth = 51;
            dgvShowStudents.Size = new Size(792, 442);
            dgvShowStudents.TabIndex = 0;
            dgvShowStudents.Visible = false;
            // 
            // lblClassCode
            // 
            lblClassCode.Location = new Point(1058, 349);
            lblClassCode.Name = "lblClassCode";
            lblClassCode.PlaceholderText = "1234567";
            lblClassCode.ReadOnly = true;
            lblClassCode.Size = new Size(72, 27);
            lblClassCode.TabIndex = 41;
            // 
            // Class
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1326, 821);
            Controls.Add(lblClassCode);
            Controls.Add(dgvShowStudents);
            Controls.Add(panelCreateAnnouncement);
            Controls.Add(flowLayoutPanelAnnouncements);
            Controls.Add(panelResults);
            Controls.Add(panelVoting);
            Controls.Add(panelStatus);
            Controls.Add(lblUsername);
            Controls.Add(lblAdviser);
            Controls.Add(lblClassName);
            Controls.Add(picClass);
            Controls.Add(picPeople);
            Controls.Add(pictureBox15);
            Controls.Add(label4);
            Controls.Add(picAddClass);
            Controls.Add(picNotification);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox16);
            Controls.Add(picHamburgerMenu);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Class";
            Text = "Class Interface";
            Load += Class_Load;
            ((System.ComponentModel.ISupportInitialize)picHamburgerMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)picAddClass).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPeople).EndInit();
            ((System.ComponentModel.ISupportInitialize)picClass).EndInit();
            panelStatus.ResumeLayout(false);
            panelStatus.PerformLayout();
            panelVoting.ResumeLayout(false);
            panelVoting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCandidates).EndInit();
            panelResults.ResumeLayout(false);
            panelResults.PerformLayout();
            panelCreateAnnouncement.ResumeLayout(false);
            panelCreateAnnouncement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvShowStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picHamburgerMenu;
        private PictureBox pictureBox16;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox14;
        private PictureBox pictureBox13;
        private PictureBox picFlashcard;
        private PictureBox picSchedule;
        private PictureBox picPending;
        private PictureBox picHome;
        private PictureBox picFlashcardIcon;
        private PictureBox picScheduleIcon;
        private PictureBox picPendingIcon;
        private PictureBox picHomeIcon;
        private PictureBox picNotification;
        private PictureBox pictureBox4;
        private PictureBox picAddClass;
        private Label label4;
        private PictureBox pictureBox15;
        private System.Windows.Forms.Timer tmrHamburgerMenu;
        private PictureBox picPeople;
        private PictureBox picClass;
        private Label lblClassName;
        private Label lblAdviser;
        private Label lblUsername;
        private Panel panelStatus;
        private Label lblStatusMessage;
        private Panel panelVoting;
        private Button btnSubmitVote;
        private DataGridView dgvCandidates;
        private Panel panelResults;
        private Label lblWinner;
        private System.Windows.Forms.Timer tmrCheckStudents;
        private System.Windows.Forms.Timer tmrCheckVotes;
        private Label lblInstruction;
        private Button btnNextPosition;
        private Label lblResultsTitle;
        private System.Windows.Forms.Timer tmrClearResults;
        private FlowLayoutPanel flowLayoutPanelAnnouncements;
        private Button btnNewAnnouncement;
        private TextBox txtAnnouncementTitle;
        private RichTextBox txtAnnouncementContent;
        private Panel panelCreateAnnouncement;
        private Label label2;
        private DateTimePicker dtpDueDateTime;
        private Label lblSetDueDate;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
        private CheckBox chkSetDueDate;
        private DataGridView dgvShowStudents;
        private TextBox lblClassCode;
    }
}