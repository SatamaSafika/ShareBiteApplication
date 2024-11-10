namespace junpro_test_ui
{
    partial class product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(product));
            buttonMilk = new Button();
            btngeneralSetting = new Button();
            button1 = new Button();
            lblNotifUnread = new Label();
            SuspendLayout();
            // 
            // buttonMilk
            // 
            buttonMilk.BackColor = Color.Transparent;
            buttonMilk.FlatAppearance.BorderSize = 0;
            buttonMilk.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonMilk.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonMilk.FlatStyle = FlatStyle.Flat;
            buttonMilk.Location = new Point(211, 420);
            buttonMilk.Name = "buttonMilk";
            buttonMilk.Size = new Size(274, 405);
            buttonMilk.TabIndex = 0;
            buttonMilk.UseVisualStyleBackColor = false;
            buttonMilk.Click += buttonMilk_Click;
            // 
            // btngeneralSetting
            // 
            btngeneralSetting.BackColor = Color.Transparent;
            btngeneralSetting.FlatAppearance.BorderSize = 0;
            btngeneralSetting.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btngeneralSetting.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btngeneralSetting.FlatStyle = FlatStyle.Flat;
            btngeneralSetting.Location = new Point(21, 691);
            btngeneralSetting.Margin = new Padding(2);
            btngeneralSetting.Name = "btngeneralSetting";
            btngeneralSetting.Size = new Size(151, 36);
            btngeneralSetting.TabIndex = 1;
            btngeneralSetting.UseVisualStyleBackColor = false;
            btngeneralSetting.Click += btngeneralSetting_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(21, 233);
            button1.Name = "button1";
            button1.Size = new Size(200, 42);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblNotifUnread
            // 
            lblNotifUnread.AutoSize = true;
            lblNotifUnread.BackColor = Color.Transparent;
            lblNotifUnread.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNotifUnread.Location = new Point(175, 150);
            lblNotifUnread.Name = "lblNotifUnread";
            lblNotifUnread.Size = new Size(184, 128);
            lblNotifUnread.TabIndex = 3;
            lblNotifUnread.Text = "     ";
            lblNotifUnread.Click += lblNotifUnread_Click;
            // 
            // product
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1418, 1050);
            Controls.Add(lblNotifUnread);
            Controls.Add(button1);
            Controls.Add(btngeneralSetting);
            Controls.Add(buttonMilk);
            Name = "product";
            Text = "   ";
            Load += product_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonMilk;
        private Button btngeneralSetting;
        private Button button1;
        private Label lblNotifUnread;
    }
}