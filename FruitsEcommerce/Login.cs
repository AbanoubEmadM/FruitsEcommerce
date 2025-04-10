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
    public partial class Login: UserControl
    {
        public Login()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (clsProduct.Login(Email_login.Text, Password_login.Text))
            {
                GlobalUser.Instance.LoggedInUser = new clsUser
                {
                    Email = Email_login.Text,
                    Password = Password_login.Text,
                    Name = clsProduct.GetUserName(Email_login.Text, Password_login.Text)
                };

                MessageBox.Show("Login Successful", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Hide();
                Form1 parentForm = this.ParentForm as Form1;
                if (parentForm != null)
                {
                    parentForm.LoadControl(new ucHome());
                }

            }
            else
            {
                MessageBox.Show("Login Failed", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Password_login_Paint(object sender, PaintEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox != null)
            {
                using (Pen pen = new Pen(Color.Blue, 2)) // Blue color, 2px thickness
                {
                    e.Graphics.DrawRectangle(pen, 0, 0, textBox.Width - 1, textBox.Height - 1);
                }
            }
        }

        private void Email_login_Paint(object sender, PaintEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox != null)
            {
                using (Pen pen = new Pen(Color.Blue, 2)) // Blue color, 2px thickness
                {
                    e.Graphics.DrawRectangle(pen, 0, 0, textBox.Width - 1, textBox.Height - 1);
                }
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox != null)
            {
                using (Pen pen = new Pen(Color.Blue, 2)) // Blue color, 2px thickness
                {
                    e.Graphics.DrawRectangle(pen, 0, 0, textBox.Width - 1, textBox.Height - 1);
                }
            }

        }
    }
}
