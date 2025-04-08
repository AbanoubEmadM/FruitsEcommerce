namespace FruitsEcommerce
{
    partial class ucHome
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel22 = new System.Windows.Forms.Panel();
            this.panel23 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel24 = new System.Windows.Forms.Panel();
            this.panel25 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.panel26 = new System.Windows.Forms.Panel();
            this.panel27 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.panel28 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.products1 = new FruitsEcommerce.Products();
            this.addedToCart1 = new FruitsEcommerce.AddedToCart();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel23.SuspendLayout();
            this.panel25.SuspendLayout();
            this.panel27.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::FruitsEcommerce.Properties.Resources.background;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1229, 862);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Green;
            this.panel8.Controls.Add(this.pictureBox1);
            this.panel8.Controls.Add(this.panel11);
            this.panel8.Controls.Add(this.panel23);
            this.panel8.Controls.Add(this.panel25);
            this.panel8.Controls.Add(this.panel27);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1229, 89);
            this.panel8.TabIndex = 6;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Transparent;
            this.panel11.Controls.Add(this.label11);
            this.panel11.Controls.Add(this.panel22);
            this.panel11.Location = new System.Drawing.Point(425, 9);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(113, 67);
            this.panel11.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(19, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 19);
            this.label11.TabIndex = 2;
            this.label11.Text = "Products";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.Color.Transparent;
            this.panel22.BackgroundImage = global::FruitsEcommerce.Properties.Resources.icons8_product_50;
            this.panel22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel22.ForeColor = System.Drawing.Color.Black;
            this.panel22.Location = new System.Drawing.Point(32, 3);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(39, 31);
            this.panel22.TabIndex = 1;
            // 
            // panel23
            // 
            this.panel23.BackColor = System.Drawing.Color.Transparent;
            this.panel23.Controls.Add(this.label12);
            this.panel23.Controls.Add(this.panel24);
            this.panel23.Location = new System.Drawing.Point(643, 6);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(114, 70);
            this.panel23.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(33, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 19);
            this.label12.TabIndex = 3;
            this.label12.Text = "Cart";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // panel24
            // 
            this.panel24.BackColor = System.Drawing.Color.Transparent;
            this.panel24.BackgroundImage = global::FruitsEcommerce.Properties.Resources.shopping_bag;
            this.panel24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel24.Location = new System.Drawing.Point(32, 6);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(39, 31);
            this.panel24.TabIndex = 2;
            // 
            // panel25
            // 
            this.panel25.BackColor = System.Drawing.Color.Transparent;
            this.panel25.Controls.Add(this.label13);
            this.panel25.Controls.Add(this.panel26);
            this.panel25.Location = new System.Drawing.Point(862, 9);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(120, 67);
            this.panel25.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(20, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 19);
            this.label13.TabIndex = 3;
            this.label13.Text = "WhishList";
            // 
            // panel26
            // 
            this.panel26.BackColor = System.Drawing.Color.Transparent;
            this.panel26.BackgroundImage = global::FruitsEcommerce.Properties.Resources.heart;
            this.panel26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel26.Location = new System.Drawing.Point(39, 3);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(39, 31);
            this.panel26.TabIndex = 2;
            // 
            // panel27
            // 
            this.panel27.BackColor = System.Drawing.Color.Transparent;
            this.panel27.Controls.Add(this.label14);
            this.panel27.Controls.Add(this.panel28);
            this.panel27.Location = new System.Drawing.Point(1087, 9);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(120, 67);
            this.panel27.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label14.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(24, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 19);
            this.label14.TabIndex = 2;
            this.label14.Text = "Account";
            // 
            // panel28
            // 
            this.panel28.BackColor = System.Drawing.Color.Transparent;
            this.panel28.BackgroundImage = global::FruitsEcommerce.Properties.Resources.user;
            this.panel28.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel28.ForeColor = System.Drawing.Color.Black;
            this.panel28.Location = new System.Drawing.Point(38, 3);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(39, 31);
            this.panel28.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FruitsEcommerce.Properties.Resources.logo_o_w_300x;
            this.pictureBox1.Location = new System.Drawing.Point(83, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 56);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // products1
            // 
            this.products1.AutoScroll = true;
            this.products1.Location = new System.Drawing.Point(3, 0);
            this.products1.Name = "products1";
            this.products1.Size = new System.Drawing.Size(1226, 862);
            this.products1.TabIndex = 7;
            this.products1.Load += new System.EventHandler(this.products1_Load);
            // 
            // addedToCart1
            // 
            this.addedToCart1.AutoScroll = true;
            this.addedToCart1.Location = new System.Drawing.Point(0, 0);
            this.addedToCart1.Name = "addedToCart1";
            this.addedToCart1.Size = new System.Drawing.Size(1229, 862);
            this.addedToCart1.TabIndex = 8;
            // 
            // ucHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.products1);
            this.Controls.Add(this.addedToCart1);
            this.Name = "ucHome";
            this.Size = new System.Drawing.Size(1229, 862);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel23.ResumeLayout(false);
            this.panel23.PerformLayout();
            this.panel25.ResumeLayout(false);
            this.panel25.PerformLayout();
            this.panel27.ResumeLayout(false);
            this.panel27.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel28;
        private Products products1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private AddedToCart addedToCart1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
