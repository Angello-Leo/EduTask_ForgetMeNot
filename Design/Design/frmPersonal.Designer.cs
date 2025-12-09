namespace Design
{
    partial class frmPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonal));
            picHamburgerMenu = new PictureBox();
            pictureBox15 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox14 = new PictureBox();
            pictureBox13 = new PictureBox();
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
            pictureBox4 = new PictureBox();
            picAddClass = new PictureBox();
            picPendingSelection = new PictureBox();
            picMissingSelection = new PictureBox();
            picAccomplishedSelection = new PictureBox();
            picMeeting = new PictureBox();
            pictureBox20 = new PictureBox();
            picPersonal = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panelPersonal = new Panel();
            lblClose = new Label();
            lblDue = new Label();
            lblTask = new Label();
            btnSaveTask = new Button();
            dtpTaskDueDate = new DateTimePicker();
            txtTaskContent = new RichTextBox();
            txtTaskTitle = new TextBox();
            flowLayoutPanelPendingAssignments = new FlowLayoutPanel();
            lblUsername = new Label();
            ((System.ComponentModel.ISupportInitialize)picHamburgerMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFlashcard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSchedule).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPending).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFlashcardIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picScheduleIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPendingIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHomeIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picNotification).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAddClass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPendingSelection).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMissingSelection).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAccomplishedSelection).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMeeting).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPersonal).BeginInit();
            panelPersonal.SuspendLayout();
            SuspendLayout();
            // 
            // picHamburgerMenu
            // 
            picHamburgerMenu.BackColor = Color.Transparent;
            picHamburgerMenu.BackgroundImageLayout = ImageLayout.Zoom;
            picHamburgerMenu.Image = (Image)resources.GetObject("picHamburgerMenu.Image");
            picHamburgerMenu.Location = new Point(1, 15);
            picHamburgerMenu.Margin = new Padding(4, 5, 4, 5);
            picHamburgerMenu.Name = "picHamburgerMenu";
            picHamburgerMenu.Size = new Size(70, 55);
            picHamburgerMenu.TabIndex = 4;
            picHamburgerMenu.TabStop = false;
            picHamburgerMenu.Click += picHamburgerMenu_Click;
            // 
            // pictureBox15
            // 
            pictureBox15.BackColor = Color.Transparent;
            pictureBox15.BackgroundImage = (Image)resources.GetObject("pictureBox15.BackgroundImage");
            pictureBox15.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox15.Location = new Point(66, -11);
            pictureBox15.Margin = new Padding(4, 5, 4, 5);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(112, 109);
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
            label1.Location = new Point(174, 24);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(264, 32);
            label1.TabIndex = 25;
            label1.Text = "EduTask : ForgetMeNot";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left;
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox14);
            panel1.Controls.Add(pictureBox13);
            panel1.Controls.Add(picFlashcard);
            panel1.Controls.Add(picSchedule);
            panel1.Controls.Add(picPending);
            panel1.Controls.Add(picHome);
            panel1.Controls.Add(picFlashcardIcon);
            panel1.Controls.Add(picScheduleIcon);
            panel1.Controls.Add(picPendingIcon);
            panel1.Controls.Add(picHomeIcon);
            panel1.Location = new Point(0, 74);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(242, 959);
            panel1.TabIndex = 26;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.Untitled_design__2_;
            panel2.Location = new Point(9, 590);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(219, 364);
            panel2.TabIndex = 8;
            panel2.Visible = false;
            // 
            // pictureBox14
            // 
            pictureBox14.BackColor = Color.Transparent;
            pictureBox14.BackgroundImage = (Image)resources.GetObject("pictureBox14.BackgroundImage");
            pictureBox14.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox14.Location = new Point(76, 511);
            pictureBox14.Margin = new Padding(4, 5, 4, 5);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(151, 69);
            pictureBox14.TabIndex = 20;
            pictureBox14.TabStop = false;
            // 
            // pictureBox13
            // 
            pictureBox13.BackColor = Color.Transparent;
            pictureBox13.BackgroundImage = (Image)resources.GetObject("pictureBox13.BackgroundImage");
            pictureBox13.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox13.Location = new Point(9, 511);
            pictureBox13.Margin = new Padding(4, 5, 4, 5);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(59, 69);
            pictureBox13.TabIndex = 19;
            pictureBox13.TabStop = false;
            // 
            // picFlashcard
            // 
            picFlashcard.BackColor = Color.Transparent;
            picFlashcard.BackgroundImage = (Image)resources.GetObject("picFlashcard.BackgroundImage");
            picFlashcard.BackgroundImageLayout = ImageLayout.Zoom;
            picFlashcard.Location = new Point(82, 409);
            picFlashcard.Margin = new Padding(4, 5, 4, 5);
            picFlashcard.Name = "picFlashcard";
            picFlashcard.Size = new Size(156, 86);
            picFlashcard.TabIndex = 18;
            picFlashcard.TabStop = false;
            picFlashcard.Click += picFlashcard_Click;
            // 
            // picSchedule
            // 
<<<<<<< HEAD
            picSchedule.BackColor = Color.Transparent;
            picSchedule.BackgroundImage = (Image)resources.GetObject("picSchedule.BackgroundImage");
            picSchedule.BackgroundImageLayout = ImageLayout.Zoom;
            picSchedule.Location = new Point(74, 319);
            picSchedule.Margin = new Padding(4, 5, 4, 5);
            picSchedule.Name = "picSchedule";
            picSchedule.Size = new Size(159, 79);
            picSchedule.TabIndex = 17;
            picSchedule.TabStop = false;
            picSchedule.Click += picSchedule_Click;
=======
            pictureBox11.BackColor = Color.Transparent;
            pictureBox11.BackgroundImage = (Image)resources.GetObject("pictureBox11.BackgroundImage");
            pictureBox11.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox11.Location = new Point(59, 255);
            pictureBox11.Margin = new Padding(3, 4, 3, 4);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(127, 63);
            pictureBox11.TabIndex = 17;
            pictureBox11.TabStop = false;
            pictureBox11.Click += pictureBox11_Click;
>>>>>>> 9628be367ca809d9be56a6047913eacfe447ae3b
            // 
            // picPending
            // 
            picPending.BackColor = Color.Transparent;
            picPending.BackgroundImage = (Image)resources.GetObject("picPending.BackgroundImage");
            picPending.BackgroundImageLayout = ImageLayout.Zoom;
            picPending.Location = new Point(74, 226);
            picPending.Margin = new Padding(4, 5, 4, 5);
            picPending.Name = "picPending";
            picPending.Size = new Size(151, 69);
            picPending.TabIndex = 16;
            picPending.TabStop = false;
            picPending.Click += picPending_Click;
            // 
            // picHome
            // 
            picHome.BackColor = Color.Transparent;
            picHome.BackgroundImage = (Image)resources.GetObject("picHome.BackgroundImage");
            picHome.BackgroundImageLayout = ImageLayout.Zoom;
            picHome.Location = new Point(76, 130);
            picHome.Margin = new Padding(4, 5, 4, 5);
            picHome.Name = "picHome";
            picHome.Size = new Size(151, 69);
            picHome.TabIndex = 15;
            picHome.TabStop = false;
            picHome.Click += picHome_Click;
            // 
            // picFlashcardIcon
            // 
            picFlashcardIcon.BackColor = Color.Transparent;
            picFlashcardIcon.BackgroundImage = (Image)resources.GetObject("picFlashcardIcon.BackgroundImage");
            picFlashcardIcon.BackgroundImageLayout = ImageLayout.Zoom;
            picFlashcardIcon.Location = new Point(9, 415);
            picFlashcardIcon.Margin = new Padding(4, 5, 4, 5);
            picFlashcardIcon.Name = "picFlashcardIcon";
            picFlashcardIcon.Size = new Size(59, 69);
            picFlashcardIcon.TabIndex = 11;
            picFlashcardIcon.TabStop = false;
            picFlashcardIcon.Click += picFlashcardIcon_Click;
            // 
            // picScheduleIcon
            // 
<<<<<<< HEAD
            picScheduleIcon.BackColor = Color.Transparent;
            picScheduleIcon.BackgroundImage = (Image)resources.GetObject("picScheduleIcon.BackgroundImage");
            picScheduleIcon.BackgroundImageLayout = ImageLayout.Zoom;
            picScheduleIcon.Location = new Point(9, 320);
            picScheduleIcon.Margin = new Padding(4, 5, 4, 5);
            picScheduleIcon.Name = "picScheduleIcon";
            picScheduleIcon.Size = new Size(59, 69);
            picScheduleIcon.TabIndex = 10;
            picScheduleIcon.TabStop = false;
            picScheduleIcon.Click += picScheduleIcon_Click;
=======
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.BackgroundImage = (Image)resources.GetObject("pictureBox7.BackgroundImage");
            pictureBox7.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox7.Location = new Point(7, 256);
            pictureBox7.Margin = new Padding(3, 4, 3, 4);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(47, 55);
            pictureBox7.TabIndex = 10;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
>>>>>>> 9628be367ca809d9be56a6047913eacfe447ae3b
            // 
            // picPendingIcon
            // 
            picPendingIcon.BackColor = Color.Transparent;
            picPendingIcon.BackgroundImage = (Image)resources.GetObject("picPendingIcon.BackgroundImage");
            picPendingIcon.BackgroundImageLayout = ImageLayout.Zoom;
            picPendingIcon.Location = new Point(9, 226);
            picPendingIcon.Margin = new Padding(4, 5, 4, 5);
            picPendingIcon.Name = "picPendingIcon";
            picPendingIcon.Size = new Size(59, 69);
            picPendingIcon.TabIndex = 9;
            picPendingIcon.TabStop = false;
            picPendingIcon.Click += picPendingIcon_Click;
            // 
            // picHomeIcon
            // 
            picHomeIcon.BackColor = Color.Transparent;
            picHomeIcon.BackgroundImage = (Image)resources.GetObject("picHomeIcon.BackgroundImage");
            picHomeIcon.BackgroundImageLayout = ImageLayout.Zoom;
            picHomeIcon.Location = new Point(9, 129);
            picHomeIcon.Margin = new Padding(4, 5, 4, 5);
            picHomeIcon.Name = "picHomeIcon";
            picHomeIcon.Size = new Size(59, 69);
            picHomeIcon.TabIndex = 8;
            picHomeIcon.TabStop = false;
            picHomeIcon.Click += picHomeIcon_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Malgun Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1294, 9);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(171, 45);
            label2.TabIndex = 30;
            label2.Text = ",Welcome";
            // 
            // picNotification
            // 
            picNotification.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picNotification.BackColor = Color.Transparent;
            picNotification.BackgroundImage = (Image)resources.GetObject("picNotification.BackgroundImage");
            picNotification.BackgroundImageLayout = ImageLayout.Zoom;
            picNotification.Location = new Point(1559, 94);
            picNotification.Margin = new Padding(4, 5, 4, 5);
            picNotification.Name = "picNotification";
            picNotification.Size = new Size(64, 69);
            picNotification.TabIndex = 32;
            picNotification.TabStop = false;
            picNotification.Click += picNotification_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(1486, 96);
            pictureBox4.Margin = new Padding(4, 5, 4, 5);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(61, 69);
            pictureBox4.TabIndex = 33;
            pictureBox4.TabStop = false;
            // 
            // picAddClass
            // 
            picAddClass.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            picAddClass.BackColor = Color.Transparent;
            picAddClass.BackgroundImage = (Image)resources.GetObject("picAddClass.BackgroundImage");
            picAddClass.BackgroundImageLayout = ImageLayout.Zoom;
            picAddClass.Location = new Point(1489, 876);
            picAddClass.Margin = new Padding(4, 5, 4, 5);
            picAddClass.Name = "picAddClass";
            picAddClass.Size = new Size(156, 111);
            picAddClass.TabIndex = 34;
            picAddClass.TabStop = false;
            picAddClass.Click += picAddClass_Click;
            // 
            // picPendingSelection
            // 
            picPendingSelection.BackgroundImage = (Image)resources.GetObject("picPendingSelection.BackgroundImage");
            picPendingSelection.BackgroundImageLayout = ImageLayout.Zoom;
            picPendingSelection.Location = new Point(391, 79);
            picPendingSelection.Margin = new Padding(4, 5, 4, 5);
            picPendingSelection.Name = "picPendingSelection";
            picPendingSelection.Size = new Size(239, 89);
            picPendingSelection.TabIndex = 35;
            picPendingSelection.TabStop = false;
            picPendingSelection.Click += picPendingSelection_Click;
            // 
            // picMissingSelection
            // 
            picMissingSelection.BackgroundImage = (Image)resources.GetObject("picMissingSelection.BackgroundImage");
            picMissingSelection.BackgroundImageLayout = ImageLayout.Zoom;
            picMissingSelection.Location = new Point(752, 79);
            picMissingSelection.Margin = new Padding(4, 5, 4, 5);
            picMissingSelection.Name = "picMissingSelection";
            picMissingSelection.Size = new Size(239, 89);
            picMissingSelection.TabIndex = 36;
            picMissingSelection.TabStop = false;
            picMissingSelection.Click += picMissingSelection_Click;
            // 
            // picAccomplishedSelection
            // 
            picAccomplishedSelection.BackgroundImage = (Image)resources.GetObject("picAccomplishedSelection.BackgroundImage");
            picAccomplishedSelection.BackgroundImageLayout = ImageLayout.Zoom;
            picAccomplishedSelection.Location = new Point(1101, 79);
            picAccomplishedSelection.Margin = new Padding(4, 5, 4, 5);
            picAccomplishedSelection.Name = "picAccomplishedSelection";
            picAccomplishedSelection.Size = new Size(239, 89);
            picAccomplishedSelection.TabIndex = 37;
            picAccomplishedSelection.TabStop = false;
            picAccomplishedSelection.Click += picAccomplishedSelection_Click;
            // 
            // picMeeting
            // 
            picMeeting.BackgroundImage = (Image)resources.GetObject("picMeeting.BackgroundImage");
            picMeeting.BackgroundImageLayout = ImageLayout.Zoom;
            picMeeting.Location = new Point(391, 204);
            picMeeting.Margin = new Padding(4, 5, 4, 5);
            picMeeting.Name = "picMeeting";
            picMeeting.Size = new Size(239, 89);
            picMeeting.TabIndex = 38;
            picMeeting.TabStop = false;
            picMeeting.Visible = false;
            // 
            // pictureBox20
            // 
            pictureBox20.BackgroundImage = (Image)resources.GetObject("pictureBox20.BackgroundImage");
            pictureBox20.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox20.Location = new Point(752, 204);
            pictureBox20.Margin = new Padding(4, 5, 4, 5);
            pictureBox20.Name = "pictureBox20";
            pictureBox20.Size = new Size(239, 89);
            pictureBox20.TabIndex = 39;
            pictureBox20.TabStop = false;
            pictureBox20.Visible = false;
            // 
            // picPersonal
            // 
            picPersonal.BackgroundImage = (Image)resources.GetObject("picPersonal.BackgroundImage");
            picPersonal.BackgroundImageLayout = ImageLayout.Zoom;
            picPersonal.Location = new Point(754, 204);
            picPersonal.Margin = new Padding(4, 5, 4, 5);
            picPersonal.Name = "picPersonal";
            picPersonal.Size = new Size(239, 89);
            picPersonal.TabIndex = 40;
            picPersonal.TabStop = false;
            picPersonal.Click += pictureBox21_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // panelPersonal
            // 
            panelPersonal.Anchor = AnchorStyles.None;
            panelPersonal.BackColor = Color.Green;
            panelPersonal.Controls.Add(lblClose);
            panelPersonal.Controls.Add(lblDue);
            panelPersonal.Controls.Add(lblTask);
            panelPersonal.Controls.Add(btnSaveTask);
            panelPersonal.Controls.Add(dtpTaskDueDate);
            panelPersonal.Controls.Add(txtTaskContent);
            panelPersonal.Controls.Add(txtTaskTitle);
            panelPersonal.Location = new Point(371, 329);
            panelPersonal.Margin = new Padding(4);
            panelPersonal.Name = "panelPersonal";
            panelPersonal.Size = new Size(998, 659);
            panelPersonal.TabIndex = 42;
            panelPersonal.Visible = false;
            // 
            // lblClose
            // 
            lblClose.AutoSize = true;
            lblClose.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClose.ForeColor = Color.Red;
            lblClose.Location = new Point(956, 0);
            lblClose.Margin = new Padding(4, 0, 4, 0);
            lblClose.Name = "lblClose";
            lblClose.Size = new Size(40, 42);
            lblClose.TabIndex = 6;
            lblClose.Text = "X";
            lblClose.Click += lblClose_Click;
            // 
            // lblDue
            // 
            lblDue.AutoSize = true;
            lblDue.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDue.ForeColor = SystemColors.ButtonFace;
            lblDue.Location = new Point(476, 600);
            lblDue.Margin = new Padding(4, 0, 4, 0);
            lblDue.Name = "lblDue";
            lblDue.Size = new Size(110, 24);
            lblDue.TabIndex = 5;
            lblDue.Text = "Due Date:";
            // 
            // lblTask
            // 
            lblTask.AutoSize = true;
            lblTask.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTask.ForeColor = SystemColors.ButtonFace;
            lblTask.Location = new Point(308, 54);
            lblTask.Margin = new Padding(4, 0, 4, 0);
            lblTask.Name = "lblTask";
            lblTask.Size = new Size(396, 42);
            lblTask.TabIndex = 4;
            lblTask.Text = "Create Personal Task";
            // 
            // btnSaveTask
            // 
            btnSaveTask.Location = new Point(91, 591);
            btnSaveTask.Margin = new Padding(4);
            btnSaveTask.Name = "btnSaveTask";
            btnSaveTask.Size = new Size(118, 36);
            btnSaveTask.TabIndex = 3;
            btnSaveTask.Text = "Save";
            btnSaveTask.UseVisualStyleBackColor = true;
            btnSaveTask.Click += btnSaveTask_Click_1;
            // 
            // dtpTaskDueDate
            // 
            dtpTaskDueDate.Location = new Point(596, 594);
            dtpTaskDueDate.Margin = new Padding(4);
            dtpTaskDueDate.Name = "dtpTaskDueDate";
            dtpTaskDueDate.Size = new Size(312, 31);
            dtpTaskDueDate.TabIndex = 2;
            // 
            // txtTaskContent
            // 
            txtTaskContent.Location = new Point(91, 160);
            txtTaskContent.Margin = new Padding(4);
            txtTaskContent.Name = "txtTaskContent";
            txtTaskContent.Size = new Size(816, 418);
            txtTaskContent.TabIndex = 1;
            txtTaskContent.Text = "";
            // 
            // txtTaskTitle
            // 
            txtTaskTitle.Location = new Point(91, 100);
            txtTaskTitle.Margin = new Padding(4);
            txtTaskTitle.Name = "txtTaskTitle";
            txtTaskTitle.PlaceholderText = "Input task title...";
            txtTaskTitle.Size = new Size(816, 31);
            txtTaskTitle.TabIndex = 0;
            // 
            // flowLayoutPanelPendingAssignments
            // 
            flowLayoutPanelPendingAssignments.Anchor = AnchorStyles.None;
            flowLayoutPanelPendingAssignments.AutoScroll = true;
            flowLayoutPanelPendingAssignments.Location = new Point(391, 352);
            flowLayoutPanelPendingAssignments.Margin = new Padding(4);
            flowLayoutPanelPendingAssignments.Name = "flowLayoutPanelPendingAssignments";
            flowLayoutPanelPendingAssignments.Size = new Size(972, 529);
            flowLayoutPanelPendingAssignments.TabIndex = 43;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Malgun Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(1471, 14);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.RightToLeft = RightToLeft.Yes;
            lblUsername.Size = new Size(0, 45);
            lblUsername.TabIndex = 44;
            // 
            // frmPersonal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1658, 1026);
            Controls.Add(lblUsername);
            Controls.Add(panelPersonal);
            Controls.Add(flowLayoutPanelPendingAssignments);
            Controls.Add(picPersonal);
            Controls.Add(pictureBox20);
            Controls.Add(picMeeting);
            Controls.Add(picAccomplishedSelection);
            Controls.Add(picMissingSelection);
            Controls.Add(picPendingSelection);
            Controls.Add(picAddClass);
            Controls.Add(pictureBox4);
            Controls.Add(picNotification);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox15);
            Controls.Add(picHamburgerMenu);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmPersonal";
            Text = "Form7";
<<<<<<< HEAD
            ((System.ComponentModel.ISupportInitialize)picHamburgerMenu).EndInit();
=======
            Load += frmPersonal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
>>>>>>> 9628be367ca809d9be56a6047913eacfe447ae3b
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)picFlashcard).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSchedule).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPending).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)picFlashcardIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)picScheduleIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPendingIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHomeIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)picNotification).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAddClass).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPendingSelection).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMissingSelection).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAccomplishedSelection).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMeeting).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPersonal).EndInit();
            panelPersonal.ResumeLayout(false);
            panelPersonal.PerformLayout();
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
        private PictureBox picFlashcardIcon;
        private PictureBox picScheduleIcon;
        private PictureBox picPendingIcon;
        private PictureBox picHomeIcon;
        private Label label2;
        private PictureBox picNotification;
        private PictureBox pictureBox4;
        private PictureBox picAddClass;
        private PictureBox picPendingSelection;
        private PictureBox picMissingSelection;
        private PictureBox picAccomplishedSelection;
        private PictureBox picMeeting;
        private PictureBox pictureBox20;
        private PictureBox picPersonal;
        private System.Windows.Forms.Timer timer1;
        private Panel panelPersonal;
        private Label lblClose;
        private Label lblDue;
        private Label lblTask;
        private Button btnSaveTask;
        private DateTimePicker dtpTaskDueDate;
        private RichTextBox txtTaskContent;
        private TextBox txtTaskTitle;
        private FlowLayoutPanel flowLayoutPanelPendingAssignments;
        private Label lblUsername;
    }
}