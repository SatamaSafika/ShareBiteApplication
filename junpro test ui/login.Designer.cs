﻿namespace junpro_test_ui
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            button1 = new Button();
            button2 = new Button();
            tbusername = new TextBox();
            tbpassword = new TextBox();
            btncreate_account = new Button();
            btnlogin = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(663, 955);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(227, 65);
            button1.TabIndex = 1;
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
            button2.Location = new Point(1031, 957);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(235, 63);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // tbusername
            // 
            tbusername.BackColor = Color.FromArgb(241, 244, 249);
            tbusername.BorderStyle = BorderStyle.None;
            tbusername.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbusername.Location = new Point(493, 456);
            tbusername.Margin = new Padding(4);
            tbusername.Name = "tbusername";
            tbusername.Size = new Size(502, 41);
            tbusername.TabIndex = 3;
            // 
            // tbpassword
            // 
            tbpassword.BackColor = Color.FromArgb(241, 244, 249);
            tbpassword.BorderStyle = BorderStyle.None;
            tbpassword.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbpassword.Location = new Point(493, 590);
            tbpassword.Margin = new Padding(4);
            tbpassword.Name = "tbpassword";
            tbpassword.Size = new Size(502, 41);
            tbpassword.TabIndex = 4;
            // 
            // btncreate_account
            // 
            btncreate_account.BackColor = Color.Transparent;
            btncreate_account.FlatAppearance.BorderSize = 0;
            btncreate_account.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btncreate_account.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btncreate_account.FlatStyle = FlatStyle.Flat;
            btncreate_account.Location = new Point(783, 811);
            btncreate_account.Name = "btncreate_account";
            btncreate_account.Size = new Size(150, 46);
            btncreate_account.TabIndex = 5;
            btncreate_account.UseVisualStyleBackColor = false;
            btncreate_account.Click += create_account_Click;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.Transparent;
            btnlogin.FlatAppearance.BorderSize = 0;
            btnlogin.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnlogin.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnlogin.FlatStyle = FlatStyle.Flat;
            btnlogin.Location = new Point(523, 748);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(447, 46);
            btnlogin.TabIndex = 6;
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1439, 1073);
            Controls.Add(btnlogin);
            Controls.Add(btncreate_account);
            Controls.Add(tbpassword);
            Controls.Add(tbusername);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(4);
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox tbusername;
        private TextBox tbpassword;
        private Button btncreate_account;
        private Button btnlogin;
    }
}