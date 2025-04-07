namespace FruitsEcommerce
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ucHome1 = new FruitsEcommerce.ucHome();
            this.SuspendLayout();
            // 
            // ucHome1
            // 
            this.ucHome1.BackColor = System.Drawing.Color.White;
            this.ucHome1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucHome1.Location = new System.Drawing.Point(-7, 1);
            this.ucHome1.Name = "ucHome1";
            this.ucHome1.Size = new System.Drawing.Size(1205, 846);
            this.ucHome1.TabIndex = 0;
            this.ucHome1.Load += new System.EventHandler(this.ucHome1_Load_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1199, 840);
            this.Controls.Add(this.ucHome1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ucHome ucHome1;
    }
}

