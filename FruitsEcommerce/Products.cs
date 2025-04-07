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
using System.IO;
namespace FruitsEcommerce
{
    public partial class Products: UserControl
    {
        public Products()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private DataTable _LoadData(string Type = "All")
        {
            DataTable products = null;

            switch (Type)
            {
                case "All":
                    products = clsProduct.GetAllProducts();
                    break;
                case "Books":
                    products = clsProduct.GetProductsWithCategory("Books");
                    break;
                case "Fruits":
                    products = clsProduct.GetProductsWithCategory("Fruits");
                    break;

                case "Vegetables":
                    products = clsProduct.GetProductsWithCategory("Vegetables");
                    break;
                case "Juices":
                    products = clsProduct.GetProductsWithCategory("Juices");
                    break;
                case "Bread":
                    products = clsProduct.GetProductsWithCategory("Bread");
                    break;
                default:
                    return null;
            }
            return products;
        }
        private void ShowData(DataTable Data)
        {
            foreach (DataRow row in Data.Rows)
            {
                Panel panel = new Panel();
                panel.Width = 200;
                panel.Height = 250;

                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Image.FromFile("C:\\Users\\OEN\\source\\repos\\FruitsEcommerce\\FruitsEcommerce\\imgs\\kiwi.jpg"); // Use a placeholder image
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

                Button button = new Button();
                button.Text = "ADD TO CART";
                button.Size = new Size(150, 30);
                button.BackColor = Color.FromArgb(120, 177, 68);
                button.Font = new Font(button.Font, FontStyle.Bold);
                button.ForeColor = Color.White;
                button.FlatStyle = FlatStyle.Flat;
                button.Cursor = Cursors.Hand;
                button.Click += (s, e) =>
                {
                    // Handle button click event
                    MessageBox.Show($"Added {row["Name"]} to cart.");
                };
                panel.Controls.Add(pictureBox);
                panel.Controls.Add(nameLabel);
                panel.Controls.Add(priceLabel);
                panel.Controls.Add(button);

                // Layout controls inside panel
                nameLabel.Top = pictureBox.Bottom + 5;
                priceLabel.Top = nameLabel.Bottom + 5;
                button.Top = priceLabel.Bottom + 10;

                nameLabel.Left = priceLabel.Left = button.Left = 10;

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
        private void label4_Click(object sender, EventArgs e)
        {
            label3.ForeColor = Color.FromArgb(0, 0, 0);
            label6.ForeColor = Color.FromArgb(0, 0, 0);
            label5.ForeColor = Color.FromArgb(0, 0, 0);
            label4.ForeColor = Color.FromArgb(120, 177, 68);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            label3.ForeColor = Color.FromArgb(0, 0, 0);
            label4.ForeColor = Color.FromArgb(0, 0, 0);
            label5.ForeColor = Color.FromArgb(0, 0, 0);
            label6.ForeColor = Color.FromArgb(120, 177, 68);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Products_Load(object sender, EventArgs e)
        {
            ShowData(_LoadData("All"));
        }

        private void label8_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            ShowData(_LoadData(label8.Text));

            label13.Enabled = true;
            label9.Enabled = true;
            label11.Enabled = true;
            label8.Enabled = false;
            label10.Enabled = true;

            label13.ForeColor = Color.FromArgb(0, 0, 0);
            label11.ForeColor = Color.FromArgb(0, 0, 0);
            label10.ForeColor = Color.FromArgb(0, 0, 0);
            label9.ForeColor = Color.FromArgb(0, 0, 0);
            label8.ForeColor = Color.FromArgb(120, 177, 68, 1);

        }

        private void label9_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            ShowData(_LoadData(label9.Text));

            label13.Enabled = true;
            label9.Enabled = false;
            label11.Enabled = true;
            label8.Enabled = true;
            label10.Enabled = true;

            label13.ForeColor = Color.FromArgb(0, 0, 0);
            label11.ForeColor = Color.FromArgb(0, 0, 0);
            label10.ForeColor = Color.FromArgb(0, 0, 0);
            label8.ForeColor = Color.FromArgb(0, 0, 0);
            label9.ForeColor = Color.FromArgb(120, 177, 68, 1);

        }

        private void label11_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            ShowData(_LoadData(label11.Text));

            label13.Enabled = true;
            label9.Enabled = true;
            label11.Enabled = false;
            label8.Enabled = true;
            label10.Enabled = true;

            label13.ForeColor = Color.FromArgb(0, 0, 0);
            label9.ForeColor = Color.FromArgb(0, 0, 0);
            label10.ForeColor = Color.FromArgb(0, 0, 0);
            label8.ForeColor = Color.FromArgb(0, 0, 0);
            label11.ForeColor = Color.FromArgb(120, 177, 68, 1);
        }

        private void label13_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            ShowData(_LoadData(label13.Text));

            label13.Enabled = false;
            label9.Enabled = true;
            label11.Enabled = true;
            label8.Enabled = true;
            label10.Enabled = true;
            label11.ForeColor = Color.FromArgb(0, 0, 0);
            label9.ForeColor = Color.FromArgb(0, 0, 0);
            label10.ForeColor = Color.FromArgb(0, 0, 0);
            label8.ForeColor = Color.FromArgb(0, 0, 0);
            label13.ForeColor = Color.FromArgb(120, 177, 68, 1);

        }

        private void label10_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            ShowData(_LoadData());
            
            label10.Enabled = false;
            label9.Enabled = true;
            label11.Enabled = true;
            label13.Enabled = true;
            label8.Enabled = true;

            label13.ForeColor = Color.FromArgb(0, 0, 0);
            label9.ForeColor = Color.FromArgb(0, 0, 0);
            label11.ForeColor = Color.FromArgb(0, 0, 0);
            label8.ForeColor = Color.FromArgb(0, 0, 0);
            label10.ForeColor = Color.FromArgb(120, 177, 68, 1);
        }
    }
}
