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
    public class CustomTextBox : TextBox
    {
        private Color borderColor = Color.Blue;
        private int borderSize = 2;

        public Color BorderColor
        {
            get => borderColor;
            set { borderColor = value; Invalidate(); }
        }

        public int BorderSize
        {
            get => borderSize;
            set { borderSize = value; Invalidate(); }
        }

        public CustomTextBox()
        {
            BorderStyle = BorderStyle.None;
            Padding = new Padding(3);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
                borderColor, borderSize, ButtonBorderStyle.Solid,
                borderColor, borderSize, ButtonBorderStyle.Solid,
                borderColor, borderSize, ButtonBorderStyle.Solid,
                borderColor, borderSize, ButtonBorderStyle.Solid);
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.BackColor = Color.White;
        }
    }
}
