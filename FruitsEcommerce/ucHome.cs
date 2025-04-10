using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using BusinessLayer;

namespace FruitsEcommerce
{
    public partial class ucHome : UserControl
    {
        public ucHome()
        {
            InitializeComponent();
        }
        private void products1_Load(object sender, EventArgs e)
        {
            products1.Dock = DockStyle.Fill;
            if (GlobalUser.Instance.IsLoggedIn)
            {
                label14.Text = GlobalUser.Instance.LoggedInUser.Name;
            }
            else
            {
                label14.Text = "Account";
            }

        }
        private void label11_Click(object sender, EventArgs e)
        {
           /* Form1 parentForm = this.ParentForm as Form1;
            if (parentForm != null)
            {
                parentForm.LoadControl(new Products());
            }*/

            products1.BringToFront();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 parentForm = this.ParentForm as Form1;
             if (parentForm != null)
             {
                 parentForm.LoadControl(new ucHome());
             }
        }

        private void label14_Click(object sender, EventArgs e)
        {
            if (!GlobalUser.Instance.IsLoggedIn)
            {
                  
                login1.BringToFront();
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            if (GlobalUser.Instance.IsLoggedIn)
            {
                addedToCart1.BringToFront();
            }
            else
            {
                MessageBox.Show("Please login to view your cart", "Login Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                login1.BringToFront();
            }

        }

        private void label13_Click(object sender, EventArgs e)
        {
            addedToWishlist1.BringToFront();
        }
    }
      
    
}
