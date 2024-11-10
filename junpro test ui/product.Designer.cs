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
            panelContainer = new Panel();
            lblName = new Label();
            lblStock = new Label();
            panelContainer.SuspendLayout();
            SuspendLayout();
            // 
            // buttonMilk
            // 
            buttonMilk.BackColor = Color.Transparent;
            buttonMilk.FlatAppearance.BorderSize = 0;
            buttonMilk.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonMilk.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonMilk.FlatStyle = FlatStyle.Flat;
            buttonMilk.Location = new Point(274, 538);
            buttonMilk.Margin = new Padding(4);
            buttonMilk.Name = "buttonMilk";
            buttonMilk.Size = new Size(356, 518);
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
            btngeneralSetting.Location = new Point(27, 884);
            btngeneralSetting.Name = "btngeneralSetting";
            btngeneralSetting.Size = new Size(196, 46);
            btngeneralSetting.TabIndex = 1;
            btngeneralSetting.UseVisualStyleBackColor = false;
            btngeneralSetting.Click += btngeneralSetting_Click;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.Transparent;
            panelContainer.Controls.Add(lblName);
            panelContainer.Controls.Add(lblStock);
            panelContainer.Location = new Point(274, 529);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1160, 527);
            panelContainer.TabIndex = 2;
            panelContainer.Paint += panel1_Paint;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(29, 344);
            lblName.Name = "lblName";
            lblName.Size = new Size(0, 32);
            lblName.TabIndex = 2;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(16, 462);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(0, 32);
            lblStock.TabIndex = 1;
            // 
            // product
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1446, 1084);
            Controls.Add(panelContainer);
            Controls.Add(btngeneralSetting);
            Controls.Add(buttonMilk);
            Margin = new Padding(4);
            Name = "product";
            Text = "Form1";
            Load += product_Load;
            panelContainer.ResumeLayout(false);
            panelContainer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonMilk;
        private Button btngeneralSetting;
        private Panel panelContainer;
        private Label lblStock;
        private Label lblName;
    }
}