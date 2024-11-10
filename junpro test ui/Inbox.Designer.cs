namespace junpro_test_ui
{
    partial class Inbox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inbox));
            btnReadMsg = new Button();
            btnDelete = new Button();
            listViewNotifications = new ListView();
            label1 = new Label();
            lblNotifUnread = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // btnReadMsg
            // 
            btnReadMsg.BackColor = Color.Transparent;
            btnReadMsg.FlatAppearance.BorderSize = 0;
            btnReadMsg.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnReadMsg.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnReadMsg.FlatStyle = FlatStyle.Flat;
            btnReadMsg.Location = new Point(1249, 206);
            btnReadMsg.Name = "btnReadMsg";
            btnReadMsg.Size = new Size(41, 34);
            btnReadMsg.TabIndex = 0;
            btnReadMsg.UseVisualStyleBackColor = false;
            btnReadMsg.Click += btnReadMsg_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Transparent;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(1293, 210);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(37, 34);
            btnDelete.TabIndex = 1;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // listViewNotifications
            // 
            listViewNotifications.Location = new Point(300, 288);
            listViewNotifications.Name = "listViewNotifications";
            listViewNotifications.Size = new Size(1030, 704);
            listViewNotifications.TabIndex = 2;
            listViewNotifications.UseCompatibleStateImageBehavior = false;
            listViewNotifications.SelectedIndexChanged += listViewNotifications_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Location = new Point(182, 219);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 3;
            // 
            // lblNotifUnread
            // 
            lblNotifUnread.AutoSize = true;
            lblNotifUnread.BackColor = Color.Transparent;
            lblNotifUnread.FlatStyle = FlatStyle.Flat;
            lblNotifUnread.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNotifUnread.Location = new Point(175, 150);
            lblNotifUnread.Name = "lblNotifUnread";
            lblNotifUnread.Size = new Size(184, 128);
            lblNotifUnread.TabIndex = 4;
            lblNotifUnread.Text = "     ";
            lblNotifUnread.Click += lblNotifUnread_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(26, 938);
            button1.Name = "button1";
            button1.Size = new Size(196, 42);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(26, 86);
            button2.Name = "button2";
            button2.Size = new Size(185, 44);
            button2.TabIndex = 6;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Inbox
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1418, 1050);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblNotifUnread);
            Controls.Add(label1);
            Controls.Add(listViewNotifications);
            Controls.Add(btnDelete);
            Controls.Add(btnReadMsg);
            Name = "Inbox";
            Text = "Inbox";
            Load += Inbox_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReadMsg;
        private Button btnDelete;
        private ListView listViewNotifications;
        private Label label1;
        private Label lblNotifUnread;
        private Button button1;
        private Button button2;
    }
}