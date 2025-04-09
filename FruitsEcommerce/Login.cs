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
                    Password = Password_login.Text
                };

                MessageBox.Show("Login Successful", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
