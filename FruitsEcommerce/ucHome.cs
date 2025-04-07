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

namespace FruitsEcommerce
{
    public partial class ucHome: UserControl
    {
        public ucHome()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

    private void test()
    {
        string currentDirectory = Directory.GetCurrentDirectory();
        MessageBox.Show("Current Working Directory: " + currentDirectory);

    }

    private void products1_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            products1.BringToFront();
        }
    }
}
