namespace Design
{
    partial class frmPending
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPending));
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
            picAddClass = new PictureBox();
            picPendingSelection = new PictureBox();
            picMissingSelection = new PictureBox();
            picAccomplishedSelection = new PictureBox();
            pictureBox20 = new PictureBox();
            picPersonalSelection = new PictureBox();
            tmrHamburgerMenu = new System.Windows.Forms.Timer(components);
            flowLayoutPanelPendingAssignments = new FlowLayoutPanel();
            panelPersonal = new Panel();
            lblClose = new Label();
            lblDue = new Label();
            lblTask = new Label();
            btnSaveTask = new Button();
            dtpTaskDueDate = new DateTimePicker();
            txtTaskContent = new RichTextBox();
            txtTaskTitle = new TextBox();
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
            ((System.ComponentModel.ISupportInitialize)picAddClass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPendingSelection).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMissingSelection).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAccomplishedSelection).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPersonalSelection).BeginInit();
            panelPersonal.SuspendLayout();
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
            panel2.Size = new Size(175, 346);
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
            picNotification.TabIndex = 32;
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
            picAddClass.TabIndex = 34;
            picAddClass.TabStop = false;
            picAddClass.Visible = false;
            picAddClass.Click += picAddClass_Click;
            // 
            // picPendingSelection
            // 
            picPendingSelection.BackgroundImage = (Image)resources.GetObject("picPendingSelection.BackgroundImage");
            picPendingSelection.BackgroundImageLayout = ImageLayout.Zoom;
            picPendingSelection.Cursor = Cursors.Hand;
            picPendingSelection.Location = new Point(313, 63);
            picPendingSelection.Margin = new Padding(3, 4, 3, 4);
            picPendingSelection.Name = "picPendingSelection";
            picPendingSelection.Size = new Size(191, 71);
            picPendingSelection.TabIndex = 35;
            picPendingSelection.TabStop = false;
            picPendingSelection.Click += picPendingSelection_Click;
            // 
            // picMissingSelection
            // 
            picMissingSelection.BackgroundImage = (Image)resources.GetObject("picMissingSelection.BackgroundImage");
            picMissingSelection.BackgroundImageLayout = ImageLayout.Zoom;
            picMissingSelection.Cursor = Cursors.Hand;
            picMissingSelection.Location = new Point(602, 63);
            picMissingSelection.Margin = new Padding(3, 4, 3, 4);
            picMissingSelection.Name = "picMissingSelection";
            picMissingSelection.Size = new Size(191, 71);
            picMissingSelection.TabIndex = 36;
            picMissingSelection.TabStop = false;
            picMissingSelection.Click += picMissingSelection_Click;
            // 
            // picAccomplishedSelection
            // 
            picAccomplishedSelection.BackgroundImage = (Image)resources.GetObject("picAccomplishedSelection.BackgroundImage");
            picAccomplishedSelection.BackgroundImageLayout = ImageLayout.Zoom;
            picAccomplishedSelection.Cursor = Cursors.Hand;
            picAccomplishedSelection.Location = new Point(881, 63);
            picAccomplishedSelection.Margin = new Padding(3, 4, 3, 4);
            picAccomplishedSelection.Name = "picAccomplishedSelection";
            picAccomplishedSelection.Size = new Size(191, 71);
            picAccomplishedSelection.TabIndex = 37;
            picAccomplishedSelection.TabStop = false;
            picAccomplishedSelection.Click += picAccomplishedSelection_Click;
            // 
            // pictureBox20
            // 
            pictureBox20.BackgroundImage = (Image)resources.GetObject("pictureBox20.BackgroundImage");
            pictureBox20.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox20.Location = new Point(602, 163);
            pictureBox20.Margin = new Padding(3, 4, 3, 4);
            pictureBox20.Name = "pictureBox20";
            pictureBox20.Size = new Size(191, 71);
            pictureBox20.TabIndex = 39;
            pictureBox20.TabStop = false;
            pictureBox20.Visible = false;
            // 
            // picPersonalSelection
            // 
            picPersonalSelection.BackgroundImage = (Image)resources.GetObject("picPersonalSelection.BackgroundImage");
            picPersonalSelection.BackgroundImageLayout = ImageLayout.Zoom;
            picPersonalSelection.Cursor = Cursors.Hand;
            picPersonalSelection.Location = new Point(602, 162);
            picPersonalSelection.Margin = new Padding(3, 4, 3, 4);
            picPersonalSelection.Name = "picPersonalSelection";
            picPersonalSelection.Size = new Size(191, 71);
            picPersonalSelection.TabIndex = 40;
            picPersonalSelection.TabStop = false;
            picPersonalSelection.Click += picPersonalSelection_Click;
            // 
            // tmrHamburgerMenu
            // 
            tmrHamburgerMenu.Tick += tmrHamburgerMenu_Tick;
            // 
            // flowLayoutPanelPendingAssignments
            // 
            flowLayoutPanelPendingAssignments.Anchor = AnchorStyles.None;
            flowLayoutPanelPendingAssignments.AutoScroll = true;
            flowLayoutPanelPendingAssignments.Location = new Point(313, 282);
            flowLayoutPanelPendingAssignments.Name = "flowLayoutPanelPendingAssignments";
            flowLayoutPanelPendingAssignments.Size = new Size(790, 423);
            flowLayoutPanelPendingAssignments.TabIndex = 41;
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
            panelPersonal.Location = new Point(297, 263);
            panelPersonal.Name = "panelPersonal";
            panelPersonal.Size = new Size(798, 527);
            panelPersonal.TabIndex = 0;
            panelPersonal.Visible = false;
            // 
            // lblClose
            // 
            lblClose.AutoSize = true;
            lblClose.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClose.ForeColor = Color.Red;
            lblClose.Location = new Point(765, 0);
            lblClose.Name = "lblClose";
            lblClose.Size = new Size(33, 34);
            lblClose.TabIndex = 6;
            lblClose.Text = "X";
            lblClose.Click += lblClose_Click;
            // 
            // lblDue
            // 
            lblDue.AutoSize = true;
            lblDue.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDue.ForeColor = SystemColors.ButtonFace;
            lblDue.Location = new Point(381, 480);
            lblDue.Name = "lblDue";
            lblDue.Size = new Size(90, 20);
            lblDue.TabIndex = 5;
            lblDue.Text = "Due Date:";
            // 
            // lblTask
            // 
            lblTask.AutoSize = true;
            lblTask.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTask.ForeColor = SystemColors.ButtonFace;
            lblTask.Location = new Point(246, 43);
            lblTask.Name = "lblTask";
            lblTask.Size = new Size(330, 34);
            lblTask.TabIndex = 4;
            lblTask.Text = "Create Personal Task";
            // 
            // btnSaveTask
            // 
            btnSaveTask.Cursor = Cursors.Hand;
            btnSaveTask.Location = new Point(73, 473);
            btnSaveTask.Name = "btnSaveTask";
            btnSaveTask.Size = new Size(94, 29);
            btnSaveTask.TabIndex = 3;
            btnSaveTask.Text = "Save";
            btnSaveTask.UseVisualStyleBackColor = true;
            btnSaveTask.Click += btnSaveTask_Click;
            // 
            // dtpTaskDueDate
            // 
            dtpTaskDueDate.Cursor = Cursors.Hand;
            dtpTaskDueDate.Location = new Point(477, 475);
            dtpTaskDueDate.Name = "dtpTaskDueDate";
            dtpTaskDueDate.Size = new Size(250, 27);
            dtpTaskDueDate.TabIndex = 2;
            // 
            // txtTaskContent
            // 
            txtTaskContent.Location = new Point(73, 128);
            txtTaskContent.Name = "txtTaskContent";
            txtTaskContent.Size = new Size(654, 335);
            txtTaskContent.TabIndex = 1;
            txtTaskContent.Text = "";
            // 
            // txtTaskTitle
            // 
            txtTaskTitle.Location = new Point(73, 80);
            txtTaskTitle.Name = "txtTaskTitle";
            txtTaskTitle.PlaceholderText = "Input task title...";
            txtTaskTitle.Size = new Size(654, 27);
            txtTaskTitle.TabIndex = 0;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Malgun Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(1173, 10);
            lblUsername.Name = "lblUsername";
            lblUsername.RightToLeft = RightToLeft.Yes;
            lblUsername.Size = new Size(0, 37);
            lblUsername.TabIndex = 42;
            // 
            // frmPending
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1326, 821);
            Controls.Add(lblUsername);
            Controls.Add(panelPersonal);
            Controls.Add(flowLayoutPanelPendingAssignments);
            Controls.Add(picPersonalSelection);
            Controls.Add(pictureBox20);
            Controls.Add(picAccomplishedSelection);
            Controls.Add(picMissingSelection);
            Controls.Add(picPendingSelection);
            Controls.Add(picAddClass);
            Controls.Add(picNotification);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox15);
            Controls.Add(picHamburgerMenu);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmPending";
            Text = "Form7";
            Load += frmPending_Load;
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
            ((System.ComponentModel.ISupportInitialize)picAddClass).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPendingSelection).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMissingSelection).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAccomplishedSelection).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPersonalSelection).EndInit();
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
        private PictureBox picAddClass;
        private PictureBox picPendingSelection;
        private PictureBox picMissingSelection;
        private PictureBox picAccomplishedSelection;
        private PictureBox pictureBox20;
        private PictureBox picPersonalSelection;
        private System.Windows.Forms.Timer tmrHamburgerMenu;
        private FlowLayoutPanel flowLayoutPanelPendingAssignments;
        private Panel panelPersonal;
        private Label lblDue;
        private Label lblTask;
        private Button btnSaveTask;
        private DateTimePicker dtpTaskDueDate;
        private RichTextBox txtTaskContent;
        private TextBox txtTaskTitle;
        private Label lblClose;
        private Label lblUsername;
    }
}