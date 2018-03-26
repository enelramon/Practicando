namespace benifu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuVTrackbar1 = new Bunifu.Framework.UI.BunifuVTrackbar();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(79, 89);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(84, 40);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuVTrackbar1
            // 
            this.bunifuVTrackbar1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuVTrackbar1.BackgroudColor = System.Drawing.Color.DarkGray;
            this.bunifuVTrackbar1.BorderRadius = 0;
            this.bunifuVTrackbar1.IndicatorColor = System.Drawing.Color.SeaGreen;
            this.bunifuVTrackbar1.Location = new System.Drawing.Point(417, 118);
            this.bunifuVTrackbar1.MaximumValue = 100;
            this.bunifuVTrackbar1.Name = "bunifuVTrackbar1";
            this.bunifuVTrackbar1.Size = new System.Drawing.Size(28, 415);
            this.bunifuVTrackbar1.SliderRadius = 0;
            this.bunifuVTrackbar1.TabIndex = 1;
            this.bunifuVTrackbar1.Value = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 586);
            this.Controls.Add(this.bunifuVTrackbar1);
            this.Controls.Add(this.bunifuImageButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuVTrackbar bunifuVTrackbar1;
    }
}

