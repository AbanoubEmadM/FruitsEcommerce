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
    public partial class AddedToWishlist: UserControl
    {
        public AddedToWishlist()
        {
            InitializeComponent();
        }
        private void ShowData()
        {
            int UserID = -1;

            if (GlobalUser.Instance.IsLoggedIn)
            {
                UserID = clsProduct.GetUserID(GlobalUser.Instance.LoggedInUser.Email, GlobalUser.Instance.LoggedInUser.Password);
            }

            DataTable Data = clsProduct.GetDataInWishlist(UserID);

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

                Button button = new Button();
                button.Text = "Remove From Wishlist";
                button.Size = new Size(150, 30);
                button.BackColor = Color.FromArgb(120, 177, 68);
                button.Font = new Font(button.Font, FontStyle.Bold);
                button.ForeColor = Color.White;
                button.FlatStyle = FlatStyle.Flat;
                button.Cursor = Cursors.Hand;

                button.Click += (s, e) =>
                {
                    if (clsProduct.RemoveFromWishlist(UserID, (int)row["ID"]))
                    {
                        // Handle button click event
                        MessageBox.Show($"Removed {row["Name"]} From Wishlist.", "Remove From Wishlist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Form1 parentForm = this.ParentForm as Form1;
                        if (parentForm != null)
                        {
                            parentForm.LoadControl(new AddedToWishlist());
                        }
                    }
                    else
                    {
                        // Handle Error
                        MessageBox.Show($"Error: Cannot Remove {row["Name"]} From Wishlist", "Remove From Wishlist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                };


                Label priceLabel = new Label();
                priceLabel.Text = "$" + row["Price"].ToString();
                priceLabel.AutoSize = true;
                priceLabel.Font = new Font("Tahoma", 12);

                panel.Controls.Add(pictureBox);
                panel.Controls.Add(nameLabel);
                panel.Controls.Add(priceLabel);
                panel.Controls.Add(button);



                // Add controls to panel
                panel.Controls.Add(pictureBox);
                panel.Controls.Add(nameLabel);
                panel.Controls.Add(priceLabel);
                panel.Controls.Add(button); // <-- This was missing!

                // Layout controls inside panel
                pictureBox.Top = 10;
                pictureBox.Left = 10;

                nameLabel.Top = pictureBox.Bottom + 5;
                nameLabel.Left = 10;

                priceLabel.Top = nameLabel.Bottom + 5;
                priceLabel.Left = 10;

                button.Top = priceLabel.Bottom + 10;
                button.Left = 10;

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddedToWishlist_Load(object sender, EventArgs e)
        {
            ShowData();
        }
    }
}
