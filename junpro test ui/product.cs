using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static junpro_test_ui.Program;

namespace junpro_test_ui
{
    public partial class product : Form
    {
        public product()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.product_Load);
        }

        private void buttonMilk_Click(object sender, EventArgs e)
        {
        }

        private void btngeneralSetting_Click(object sender, EventArgs e)
        {
            ViewgeneralSetting settingsForm = new ViewgeneralSetting(Program.UserSession.LoggedInUsername);
            settingsForm.Show();
            this.Hide();
        }

        private void product_Load(object sender, EventArgs e)
        {
            LoadDataForReceiver();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private PictureBox CreateRoundedPictureBox(Image image, int width, int height, int cornerRadius)
        {
            PictureBox pictureBox = new PictureBox
            {
                Width = width,
                Height = height,
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            pictureBox.Paint += (sender, e) =>
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
                    path.AddArc(width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
                    path.AddArc(width - cornerRadius, height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
                    path.AddArc(0, height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
                    path.CloseFigure();

                    pictureBox.Region = new Region(path);
                    g.DrawImage(image, new Rectangle(0, 0, width, height));
                }
            };

            pictureBox.Image = image;
            return pictureBox;
        }

        private void LoadDataForReceiver()
        {
            DatabaseHelper dbHelper = new DatabaseHelper();
            List<ProductItem> products = dbHelper.GetProducts(); // Mengambil semua produk tanpa filter
            int x = 10, y = 10, counter = 0;

            foreach (var product in products)
            {
                Panel panel = new Panel
                {
                    Width = 361,
                    Height = 497,
                    Location = new Point(x, y)
                };

                // Create PictureBox with rounded corners
                PictureBox pictureBox = CreateRoundedPictureBox(
                    Image.FromFile(product.ImagePath), 361, 317, 20 // 20 is the corner radius
                );
                pictureBox.Location = new Point(0, 0); // Position at the top of the panel

                Label lblName = new Label
                {
                    Text = product.Name,
                    Location = new Point(10, 338),
                    AutoSize = true,
                    Font = new Font("Microsoft Tai Le", 12, FontStyle.Bold)
                };

                Label lblStock = new Label
                {
                    Text = "Stock: " + product.Stock,
                    Location = new Point(24, 441), // Adjusted vertical position
                    AutoSize = true,
                    Font = new Font("Microsoft Tai Le", 8, FontStyle.Bold)
                };

                panel.Controls.Add(pictureBox);
                panel.Controls.Add(lblName);
                panel.Controls.Add(lblStock);
                panelContainer.Controls.Add(panel); // Make sure panelContainer is defined in the designer

                x += 389; // Adjust horizontal position
                counter++;

                if (counter % 3 == 0)
                {
                    x = 0;
                    y += 526; // Adjust vertical position for new row
                }

                panel.Tag = product.ID; // Save product ID as Tag
                panel.Click += (s, e) => ShowRequestForm(product);
                pictureBox.Click += (s, e) => ShowRequestForm(product);
                lblName.Click += (s, e) => ShowRequestForm(product);
                lblStock.Click += (s, e) => ShowRequestForm(product);

            }
        }

        private void ShowRequestForm(ProductItem product)
        {
            // Membuka form foodReq dan meneruskan ProductID ke form tersebut
            foodReq requestForm = new foodReq(product.ID);
            requestForm.Show();
        }


    }
}