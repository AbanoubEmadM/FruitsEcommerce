using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace FruitsEcommerce
{
    public partial class AddedToCart : UserControl
    {
        public AddedToCart()
        {
            InitializeComponent();
        }
        private void ShowData()
        {
            DataTable Data = clsProduct.GetDataInCart(1);

            foreach (DataRow row in Data.Rows)
            {
                Panel panel = new Panel();
                panel.Width = 200;
                panel.Height = 250;

                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Image.FromFile("C:\\Users\\OEN\\source\\repos\\FruitsEcommerce\\FruitsEcommerce\\imgs\\error.png"); // Use a placeholder image
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Width = 180;
                pictureBox.Height = 120;

                Label nameLabel = new Label();
                nameLabel.Text = row["Name"].ToString();
                nameLabel.Font = new Font("Tahoma", 12);

                Label priceLabel = new Label();
                priceLabel.Text = "$" + row["Price"].ToString();
                priceLabel.AutoSize = true;
                priceLabel.Font = new Font("Tahoma", 12);

                panel.Controls.Add(pictureBox);
                panel.Controls.Add(nameLabel);
                panel.Controls.Add(priceLabel);

                // Layout controls inside panel
                nameLabel.Top = pictureBox.Bottom + 5;
                priceLabel.Top = nameLabel.Bottom + 5;

                flowLayoutPanel1.Controls.Add(panel);

                // Load the actual image in a background thread
                string imagePath = $"C:\\Users\\OEN\\source\\repos\\FruitsEcommerce\\FruitsEcommerce\\{row["ImagePath"]}";
                Task.Run(() =>
                {
                    try
                    {
                        Image image = Image.FromFile(imagePath);
                        pictureBox.Invoke((MethodInvoker)(() => pictureBox.Image = image));
                    }
                    catch (Exception ex)
                    {
                        // Handle exceptions (e.g., log the error, show a message, etc.)
                        Console.WriteLine($"Error loading image: {ex.Message}");
                    }
                });
            }

        }

        private void AddedToCart_Load(object sender, EventArgs e)
        {
            ShowData();

        }
    }
}