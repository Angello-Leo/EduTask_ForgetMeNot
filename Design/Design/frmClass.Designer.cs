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
            pictureBox1 = new PictureBox();
            pictureBox16 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox14 = new PictureBox();
            pictureBox13 = new PictureBox();
            pictureBox12 = new PictureBox();
            pictureBox11 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            pictureBox15 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox17 = new PictureBox();
            pictureBox18 = new PictureBox();
            lblClassName = new Label();
            lblClassCode = new Label();
            lblAdviser = new Label();
            lblMaxStud = new Label();
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
            timerCheckStudents = new System.Windows.Forms.Timer(components);
            timerCheckVotes = new System.Windows.Forms.Timer(components);
            timerClearResults = new System.Windows.Forms.Timer(components);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).BeginInit();
            panelStatus.SuspendLayout();
            panelVoting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCandidates).BeginInit();
            panelResults.SuspendLayout();
            panelCreateAnnouncement.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 12);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 44);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
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
            panel1.Controls.Add(pictureBox14);
            panel1.Controls.Add(pictureBox13);
            panel1.Controls.Add(pictureBox12);
            panel1.Controls.Add(pictureBox11);
            panel1.Controls.Add(pictureBox10);
            panel1.Controls.Add(pictureBox9);
            panel1.Controls.Add(pictureBox8);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(pictureBox5);
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
            // pictureBox14
            // 
            pictureBox14.BackColor = Color.Transparent;
            pictureBox14.BackgroundImage = (Image)resources.GetObject("pictureBox14.BackgroundImage");
            pictureBox14.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox14.Location = new Point(61, 409);
            pictureBox14.Margin = new Padding(3, 4, 3, 4);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(121, 55);
            pictureBox14.TabIndex = 20;
            pictureBox14.TabStop = false;
            // 
            // pictureBox13
            // 
            pictureBox13.BackColor = Color.Transparent;
            pictureBox13.BackgroundImage = (Image)resources.GetObject("pictureBox13.BackgroundImage");
            pictureBox13.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox13.Location = new Point(7, 409);
            pictureBox13.Margin = new Padding(3, 4, 3, 4);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(47, 55);
            pictureBox13.TabIndex = 19;
            pictureBox13.TabStop = false;
            // 
            // pictureBox12
            // 
            pictureBox12.BackColor = Color.Transparent;
            pictureBox12.BackgroundImage = (Image)resources.GetObject("pictureBox12.BackgroundImage");
            pictureBox12.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox12.Location = new Point(67, 327);
            pictureBox12.Margin = new Padding(3, 4, 3, 4);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(125, 69);
            pictureBox12.TabIndex = 18;
            pictureBox12.TabStop = false;
            pictureBox12.Click += pictureBox12_Click;
            // 
            // pictureBox11
            // 
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
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = Color.Transparent;
            pictureBox10.BackgroundImage = (Image)resources.GetObject("pictureBox10.BackgroundImage");
            pictureBox10.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox10.Location = new Point(59, 181);
            pictureBox10.Margin = new Padding(3, 4, 3, 4);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(121, 55);
            pictureBox10.TabIndex = 16;
            pictureBox10.TabStop = false;
            pictureBox10.Click += pictureBox10_Click;
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.Transparent;
            pictureBox9.BackgroundImage = (Image)resources.GetObject("pictureBox9.BackgroundImage");
            pictureBox9.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox9.Location = new Point(61, 104);
            pictureBox9.Margin = new Padding(3, 4, 3, 4);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(121, 55);
            pictureBox9.TabIndex = 15;
            pictureBox9.TabStop = false;
            pictureBox9.Click += pictureBox9_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Transparent;
            pictureBox8.BackgroundImage = (Image)resources.GetObject("pictureBox8.BackgroundImage");
            pictureBox8.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox8.Location = new Point(7, 332);
            pictureBox8.Margin = new Padding(3, 4, 3, 4);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(47, 55);
            pictureBox8.TabIndex = 11;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // pictureBox7
            // 
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
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox6.Location = new Point(7, 181);
            pictureBox6.Margin = new Padding(3, 4, 3, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(47, 55);
            pictureBox6.TabIndex = 9;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Location = new Point(7, 103);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(47, 55);
            pictureBox5.TabIndex = 8;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(1247, 75);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 55);
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(1189, 77);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(49, 55);
            pictureBox4.TabIndex = 27;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(1191, 701);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 89);
            pictureBox3.TabIndex = 28;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
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
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox17
            // 
            pictureBox17.BackColor = Color.Transparent;
            pictureBox17.BackgroundImage = (Image)resources.GetObject("pictureBox17.BackgroundImage");
            pictureBox17.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox17.Location = new Point(440, 351);
            pictureBox17.Margin = new Padding(3, 4, 3, 4);
            pictureBox17.Name = "pictureBox17";
            pictureBox17.Size = new Size(65, 36);
            pictureBox17.TabIndex = 30;
            pictureBox17.TabStop = false;
            pictureBox17.Click += pictureBox17_Click;
            // 
            // pictureBox18
            // 
            pictureBox18.BackColor = Color.Transparent;
            pictureBox18.BackgroundImage = (Image)resources.GetObject("pictureBox18.BackgroundImage");
            pictureBox18.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox18.Location = new Point(368, 351);
            pictureBox18.Margin = new Padding(3, 4, 3, 4);
            pictureBox18.Name = "pictureBox18";
            pictureBox18.Size = new Size(65, 36);
            pictureBox18.TabIndex = 31;
            pictureBox18.TabStop = false;
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
            lblClassName.Click += lblClassName_Click;
            // 
            // lblClassCode
            // 
            lblClassCode.AutoSize = true;
            lblClassCode.Location = new Point(1080, 350);
            lblClassCode.Name = "lblClassCode";
            lblClassCode.Size = new Size(17, 20);
            lblClassCode.TabIndex = 33;
            lblClassCode.Text = "  ";
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
            // lblMaxStud
            // 
            lblMaxStud.AutoSize = true;
            lblMaxStud.Location = new Point(531, 357);
            lblMaxStud.Name = "lblMaxStud";
            lblMaxStud.Size = new Size(50, 20);
            lblMaxStud.TabIndex = 35;
            lblMaxStud.Text = "label6";
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
            // timerCheckStudents
            // 
            timerCheckStudents.Enabled = true;
            timerCheckStudents.Interval = 5000;
            // 
            // timerCheckVotes
            // 
            timerCheckVotes.Enabled = true;
            timerCheckVotes.Interval = 3000;
            // 
            // timerClearResults
            // 
            timerClearResults.Enabled = true;
            timerClearResults.Interval = 3000;
            timerClearResults.Tick += timerClearResults_Tick;
            // 
            // flowLayoutPanelAnnouncements
            // 
            flowLayoutPanelAnnouncements.Location = new Point(357, 386);
            flowLayoutPanelAnnouncements.Name = "flowLayoutPanelAnnouncements";
            flowLayoutPanelAnnouncements.Size = new Size(778, 423);
            flowLayoutPanelAnnouncements.TabIndex = 3;
            flowLayoutPanelAnnouncements.Visible = false;
            // 
            // panelCreateAnnouncement
            // 
            panelCreateAnnouncement.Anchor = AnchorStyles.None;
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
            panelCreateAnnouncement.Paint += panelCreateAnnouncement_Paint;
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
            txtAnnouncementTitle.TextChanged += txtAnnouncementTitle_TextChanged;
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
            // Class
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1326, 821);
            Controls.Add(panelCreateAnnouncement);
            Controls.Add(flowLayoutPanelAnnouncements);
            Controls.Add(panelResults);
            Controls.Add(panelVoting);
            Controls.Add(panelStatus);
            Controls.Add(lblUsername);
            Controls.Add(lblMaxStud);
            Controls.Add(lblAdviser);
            Controls.Add(lblClassCode);
            Controls.Add(lblClassName);
            Controls.Add(pictureBox18);
            Controls.Add(pictureBox17);
            Controls.Add(pictureBox15);
            Controls.Add(label4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox16);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Class";
            Text = "Class Interface";
            Load += Class_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).EndInit();
            panelStatus.ResumeLayout(false);
            panelStatus.PerformLayout();
            panelVoting.ResumeLayout(false);
            panelVoting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCandidates).EndInit();
            panelResults.ResumeLayout(false);
            panelResults.PerformLayout();
            panelCreateAnnouncement.ResumeLayout(false);
            panelCreateAnnouncement.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox16;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox14;
        private PictureBox pictureBox13;
        private PictureBox pictureBox12;
        private PictureBox pictureBox11;
        private PictureBox pictureBox10;
        private PictureBox pictureBox9;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Label label4;
        private PictureBox pictureBox15;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox17;
        private PictureBox pictureBox18;
        private Label lblClassName;
        private Label lblClassCode;
        private Label lblAdviser;
        private Label lblMaxStud;
        private Label lblUsername;
        private Panel panelStatus;
        private Label lblStatusMessage;
        private Panel panelVoting;
        private Button btnSubmitVote;
        private DataGridView dgvCandidates;
        private Panel panelResults;
        private Label lblWinner;
        private System.Windows.Forms.Timer timerCheckStudents;
        private System.Windows.Forms.Timer timerCheckVotes;
        private Label lblInstruction;
        private Button btnNextPosition;
        private Label lblResultsTitle;
        private System.Windows.Forms.Timer timerClearResults;
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
    }
}