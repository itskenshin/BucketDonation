namespace BucketDonation
{
    partial class SplashScrreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScrreen));
            this.splashpick = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splashpick)).BeginInit();
            this.SuspendLayout();
            // 
            // splashpick
            // 
            this.splashpick.Image = ((System.Drawing.Image)(resources.GetObject("splashpick.Image")));
            this.splashpick.Location = new System.Drawing.Point(0, 2);
            this.splashpick.Name = "splashpick";
            this.splashpick.Size = new System.Drawing.Size(798, 565);
            this.splashpick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.splashpick.TabIndex = 0;
            this.splashpick.TabStop = false;
            // 
            // SplashScrreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 567);
            this.ControlBox = false;
            this.Controls.Add(this.splashpick);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SplashScrreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.TransparencyKey = System.Drawing.SystemColors.Window;
            ((System.ComponentModel.ISupportInitialize)(this.splashpick)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox splashpick;
    }
}