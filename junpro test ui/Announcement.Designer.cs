namespace junpro_test_ui
{
    partial class Announcement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Announcement));
            tbAnnounce = new TextBox();
            btnSendAnnounce = new Button();
            flowLPAnnouncement = new FlowLayoutPanel();
            button1 = new Button();
            SuspendLayout();
            // 
            // tbAnnounce
            // 
            tbAnnounce.BackColor = Color.FromArgb(241, 244, 249);
            tbAnnounce.BorderStyle = BorderStyle.None;
            tbAnnounce.Font = new Font("Microsoft Tai Le", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbAnnounce.Location = new Point(297, 232);
            tbAnnounce.Name = "tbAnnounce";
            tbAnnounce.Size = new Size(498, 28);
            tbAnnounce.TabIndex = 0;
            // 
            // btnSendAnnounce
            // 
            btnSendAnnounce.BackColor = Color.Transparent;
            btnSendAnnounce.FlatAppearance.BorderSize = 0;
            btnSendAnnounce.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSendAnnounce.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSendAnnounce.FlatStyle = FlatStyle.Flat;
            btnSendAnnounce.Location = new Point(876, 224);
            btnSendAnnounce.Name = "btnSendAnnounce";
            btnSendAnnounce.Size = new Size(164, 43);
            btnSendAnnounce.TabIndex = 1;
            btnSendAnnounce.UseVisualStyleBackColor = false;
            btnSendAnnounce.Click += btnSendAnnounce_Click_1;
            // 
            // flowLPAnnouncement
            // 
            flowLPAnnouncement.AutoScroll = true;
            flowLPAnnouncement.Location = new Point(275, 340);
            flowLPAnnouncement.Name = "flowLPAnnouncement";
            flowLPAnnouncement.Size = new Size(1114, 631);
            flowLPAnnouncement.TabIndex = 2;
            flowLPAnnouncement.Paint += flowLPAnnouncement_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(28, 92);
            button1.Name = "button1";
            button1.Size = new Size(194, 41);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Announcement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1418, 1050);
            Controls.Add(button1);
            Controls.Add(flowLPAnnouncement);
            Controls.Add(btnSendAnnounce);
            Controls.Add(tbAnnounce);
            Name = "Announcement";
            Text = "Announcement";
            Load += Announcement_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbAnnounce;
        private Button btnSendAnnounce;
        private FlowLayoutPanel flowLPAnnouncement;
        private Button button1;
    }
}