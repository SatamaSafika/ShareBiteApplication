﻿namespace junpro_test_ui
{
    partial class dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            button1 = new Button();
            productPemberi = new Button();
            btngeneralSetting = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Tai Le", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(26, 181);
            button1.Name = "button1";
            button1.Size = new Size(160, 45);
            button1.TabIndex = 0;
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // productPemberi
            // 
            productPemberi.BackColor = Color.Transparent;
            productPemberi.FlatAppearance.BorderSize = 0;
            productPemberi.FlatAppearance.MouseDownBackColor = Color.Transparent;
            productPemberi.FlatAppearance.MouseOverBackColor = Color.Transparent;
            productPemberi.FlatStyle = FlatStyle.Flat;
            productPemberi.Location = new Point(10, 102);
            productPemberi.Name = "productPemberi";
            productPemberi.Size = new Size(159, 31);
            productPemberi.TabIndex = 1;
            productPemberi.UseVisualStyleBackColor = false;
            productPemberi.Click += productPemberi_Click;
            // 
            // btngeneralSetting
            // 
            btngeneralSetting.BackColor = Color.Transparent;
            btngeneralSetting.FlatAppearance.BorderSize = 0;
            btngeneralSetting.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btngeneralSetting.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btngeneralSetting.FlatStyle = FlatStyle.Flat;
            btngeneralSetting.Location = new Point(16, 691);
            btngeneralSetting.Margin = new Padding(2, 2, 2, 2);
            btngeneralSetting.Name = "btngeneralSetting";
            btngeneralSetting.Size = new Size(153, 36);
            btngeneralSetting.TabIndex = 2;
            btngeneralSetting.TextAlign = ContentAlignment.TopLeft;
            btngeneralSetting.UseVisualStyleBackColor = false;
            btngeneralSetting.Click += btngeneralSetting_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(16, 142);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(170, 34);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(28, 291);
            button3.Name = "button3";
            button3.Size = new Size(186, 34);
            button3.TabIndex = 4;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1110, 809);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btngeneralSetting);
            Controls.Add(productPemberi);
            Controls.Add(button1);
            Name = "dashboard";
            Text = "Form3";
            Load += dashboard_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button productPemberi;
        private Button btngeneralSetting;
        private Button button2;
        private Button button3;
    }
}