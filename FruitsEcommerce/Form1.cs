using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FruitsEcommerce
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            ucHome ucHome1 = new ucHome();
            ucHome1.Dock = DockStyle.Fill;
            panel1.Dock = DockStyle.Fill;
            panel1.Controls.Clear(); // mainPanel = the container Panel or placeholder
            panel1.Controls.Add(ucHome1);

        }
        public void LoadControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panel1.Dock = DockStyle.Fill;
            panel1.Controls.Clear(); // mainPanel = the container Panel or placeholder
            panel1.Controls.Add(uc);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
