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
            btnSendAnnounce.BackColor = SystemColors.ActiveCaption;
            btnSendAnnounce.Location = new Point(862, 232);
            btnSendAnnounce.Name = "btnSendAnnounce";
            btnSendAnnounce.Size = new Size(112, 34);
            btnSendAnnounce.TabIndex = 1;
            btnSendAnnounce.Text = "Send";
            btnSendAnnounce.UseVisualStyleBackColor = false;
            btnSendAnnounce.Click += btnSendAnnounce_Click_1;
            // 
            // Announcement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1418, 1050);
            Controls.Add(btnSendAnnounce);
            Controls.Add(tbAnnounce);
            Name = "Announcement";
            Text = "Announcement";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbAnnounce;
        private Button btnSendAnnounce;
    }
}