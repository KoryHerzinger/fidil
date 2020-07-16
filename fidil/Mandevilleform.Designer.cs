namespace fidil
{
    partial class Mandevilleform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mandevilleform));
            this.Yasirbox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Yasirbox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Yasirbox1
            // 
            this.Yasirbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Yasirbox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Yasirbox1.Image = ((System.Drawing.Image)(resources.GetObject("Yasirbox1.Image")));
            this.Yasirbox1.Location = new System.Drawing.Point(0, 0);
            this.Yasirbox1.Name = "Yasirbox1";
            this.Yasirbox1.Size = new System.Drawing.Size(800, 450);
            this.Yasirbox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Yasirbox1.TabIndex = 0;
            this.Yasirbox1.TabStop = false;
            // 
            // Mandevilleform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Yasirbox1);
            this.Name = "Mandevilleform";
            this.Text = "Mandevilleform";
            ((System.ComponentModel.ISupportInitialize)(this.Yasirbox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Yasirbox1;
    }
}