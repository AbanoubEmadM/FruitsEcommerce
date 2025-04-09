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
        }

        private void label11_Click(object sender, EventArgs e)
        {
            products1.BringToFront();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            if (GlobalUser.Instance.IsLoggedIn)
            {

                var addedToCart = new AddedToCart();
                this.Controls.Clear();
                this.Controls.Add(addedToCart);
                addedToCart.BringToFront();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.BringToFront();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            login1.BringToFront();
        }
    }
      
    
}
