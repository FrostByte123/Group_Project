namespace GroupProject
{
    partial class frmOnlinePayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOnlinePayment));
            this.picboxPayPal = new System.Windows.Forms.PictureBox();
            this.picboxQuiskPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPayPal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxQuiskPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // picboxPayPal
            // 
            this.picboxPayPal.BackColor = System.Drawing.Color.Transparent;
            this.picboxPayPal.Image = ((System.Drawing.Image)(resources.GetObject("picboxPayPal.Image")));
            this.picboxPayPal.Location = new System.Drawing.Point(96, 208);
            this.picboxPayPal.Name = "picboxPayPal";
            this.picboxPayPal.Size = new System.Drawing.Size(248, 99);
            this.picboxPayPal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxPayPal.TabIndex = 2;
            this.picboxPayPal.TabStop = false;
            this.picboxPayPal.Click += new System.EventHandler(this.picboxPayPal_Click);
            // 
            // picboxQuiskPicture
            // 
            this.picboxQuiskPicture.BackColor = System.Drawing.Color.Transparent;
            this.picboxQuiskPicture.Image = ((System.Drawing.Image)(resources.GetObject("picboxQuiskPicture.Image")));
            this.picboxQuiskPicture.Location = new System.Drawing.Point(510, 208);
            this.picboxQuiskPicture.Name = "picboxQuiskPicture";
            this.picboxQuiskPicture.Size = new System.Drawing.Size(248, 99);
            this.picboxQuiskPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxQuiskPicture.TabIndex = 3;
            this.picboxQuiskPicture.TabStop = false;
            this.picboxQuiskPicture.Click += new System.EventHandler(this.picboxQuiskPicture_Click);
            // 
            // frmOnlinePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GroupProject.Properties.Resources.Menu;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picboxPayPal);
            this.Controls.Add(this.picboxQuiskPicture);
            this.Name = "frmOnlinePayment";
            this.Text = "Online Payment";
            ((System.ComponentModel.ISupportInitialize)(this.picboxPayPal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxQuiskPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picboxPayPal;
        private System.Windows.Forms.PictureBox picboxQuiskPicture;
    }
}