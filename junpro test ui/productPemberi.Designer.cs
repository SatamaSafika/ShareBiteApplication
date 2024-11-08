namespace junpro_test_ui
{
    partial class productPemberi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productPemberi));
            productEdit = new Button();
            productPost = new Button();
            bnLoadData = new Button();
            panelContainer = new Panel();
            SuspendLayout();
            // 
            // productEdit
            // 
            productEdit.BackColor = Color.Transparent;
            productEdit.FlatAppearance.BorderSize = 0;
            productEdit.FlatAppearance.MouseDownBackColor = Color.Transparent;
            productEdit.FlatAppearance.MouseOverBackColor = Color.Transparent;
            productEdit.FlatStyle = FlatStyle.Flat;
            productEdit.ForeColor = Color.Transparent;
            productEdit.Location = new Point(1370, 370);
            productEdit.Margin = new Padding(4, 4, 4, 4);
            productEdit.Name = "productEdit";
            productEdit.Size = new Size(458, 540);
            productEdit.TabIndex = 0;
            productEdit.UseVisualStyleBackColor = false;
            productEdit.Click += productEdit_Click;
            // 
            // productPost
            // 
            productPost.BackColor = Color.Transparent;
            productPost.FlatAppearance.BorderSize = 0;
            productPost.FlatAppearance.MouseDownBackColor = Color.Transparent;
            productPost.FlatAppearance.MouseOverBackColor = Color.Transparent;
            productPost.FlatStyle = FlatStyle.Flat;
            productPost.Location = new Point(1570, 221);
            productPost.Margin = new Padding(4, 4, 4, 4);
            productPost.Name = "productPost";
            productPost.Size = new Size(214, 59);
            productPost.TabIndex = 1;
            productPost.UseVisualStyleBackColor = false;
            productPost.Click += productPost_Click;
            // 
            // bnLoadData
            // 
            bnLoadData.BackColor = Color.Transparent;
            bnLoadData.FlatAppearance.BorderSize = 0;
            bnLoadData.FlatAppearance.MouseDownBackColor = Color.Transparent;
            bnLoadData.FlatAppearance.MouseOverBackColor = Color.Transparent;
            bnLoadData.FlatStyle = FlatStyle.Flat;
            bnLoadData.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bnLoadData.Location = new Point(546, 129);
            bnLoadData.Margin = new Padding(4, 4, 4, 4);
            bnLoadData.Name = "bnLoadData";
            bnLoadData.Size = new Size(68, 59);
            bnLoadData.TabIndex = 2;
            bnLoadData.UseVisualStyleBackColor = false;
            bnLoadData.Click += bnLoadData_Click;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.Transparent;
            panelContainer.Location = new Point(238, 282);
            panelContainer.Margin = new Padding(4, 4, 4, 4);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1505, 973);
            panelContainer.TabIndex = 3;
            // 
            // productPemberi
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1374, 1050);
            Controls.Add(panelContainer);
            Controls.Add(bnLoadData);
            Controls.Add(productPost);
            Controls.Add(productEdit);
            Margin = new Padding(4, 4, 4, 4);
            Name = "productPemberi";
            Text = "Form1";
            ResumeLayout(false);
        }

        private void bnLoadData_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void PanelContainer_MouseClick(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void productEdit_Click(object sender, EventArgs e)
        {
            /*DatabaseHelper dbHelper = new DatabaseHelper();
            List<ProductItem> products = dbHelper.GetProducts(); 

            // Misalnya kita ambil produk pertama untuk diedit.
            ProductItem selectedProduct = products.FirstOrDefault();

            if (selectedProduct != null)
            {
                productEditDelete form10 = new productEditDelete(selectedProduct); // Berikan parameter
                form10.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tidak ada produk yang tersedia untuk diedit.");
            }*/
        }

        #endregion

        private Button productEdit;
        private Button productPost;
        private Button bnLoadData;
        private Panel panelContainer;
    }
}