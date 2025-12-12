namespace Design
{
    partial class frmNotification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotification));
            picBack = new PictureBox();
            pictureBox2 = new PictureBox();
            flowLayoutPanelNotif = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)picBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // picBack
            // 
            picBack.BackColor = Color.Transparent;
            picBack.BackgroundImage = (Image)resources.GetObject("picBack.BackgroundImage");
            picBack.BackgroundImageLayout = ImageLayout.Zoom;
            picBack.Image = (Image)resources.GetObject("picBack.Image");
            picBack.Location = new Point(18, 30);
            picBack.Margin = new Padding(4, 5, 4, 5);
            picBack.Name = "picBack";
            picBack.Size = new Size(79, 50);
            picBack.SizeMode = PictureBoxSizeMode.Zoom;
            picBack.TabIndex = 4;
            picBack.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(94, -5);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(152, 125);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // flowLayoutPanelNotif
            // 
            flowLayoutPanelNotif.Anchor = AnchorStyles.None;
            flowLayoutPanelNotif.AutoScroll = true;
            flowLayoutPanelNotif.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelNotif.Location = new Point(72, 159);
            flowLayoutPanelNotif.Margin = new Padding(4, 4, 4, 4);
            flowLayoutPanelNotif.Name = "flowLayoutPanelNotif";
            flowLayoutPanelNotif.Size = new Size(1550, 822);
            flowLayoutPanelNotif.TabIndex = 6;
            // 
            // frmNotification
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1658, 1026);
            Controls.Add(flowLayoutPanelNotif);
            Controls.Add(pictureBox2);
            Controls.Add(picBack);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmNotification";
            Text = "Notification ";
            Load += frmNotification_Load;
            ((System.ComponentModel.ISupportInitialize)picBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picBack;
        private PictureBox pictureBox2;
        private FlowLayoutPanel flowLayoutPanelNotif;
    }
}