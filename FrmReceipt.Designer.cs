namespace GroupProject
{
    partial class FrmReceipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReceipt));
            this.lblRestaurauntName = new System.Windows.Forms.Label();
            this.lblRestaurantAddress = new System.Windows.Forms.Label();
            this.lblOrderTime = new System.Windows.Forms.Label();
            this.lblReceiptNumber = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPrint = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRestaurauntName
            // 
            this.lblRestaurauntName.AutoSize = true;
            this.lblRestaurauntName.BackColor = System.Drawing.Color.Transparent;
            this.lblRestaurauntName.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestaurauntName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRestaurauntName.Location = new System.Drawing.Point(361, 53);
            this.lblRestaurauntName.Name = "lblRestaurauntName";
            this.lblRestaurauntName.Size = new System.Drawing.Size(245, 36);
            this.lblRestaurauntName.TabIndex = 0;
            this.lblRestaurauntName.Text = "Restaurant Name";
            // 
            // lblRestaurantAddress
            // 
            this.lblRestaurantAddress.AutoSize = true;
            this.lblRestaurantAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblRestaurantAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestaurantAddress.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRestaurantAddress.Location = new System.Drawing.Point(381, 101);
            this.lblRestaurantAddress.Name = "lblRestaurantAddress";
            this.lblRestaurantAddress.Size = new System.Drawing.Size(204, 26);
            this.lblRestaurantAddress.TabIndex = 1;
            this.lblRestaurantAddress.Text = "Restaurant Address";
            // 
            // lblOrderTime
            // 
            this.lblOrderTime.AutoSize = true;
            this.lblOrderTime.BackColor = System.Drawing.Color.Transparent;
            this.lblOrderTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOrderTime.Location = new System.Drawing.Point(247, 217);
            this.lblOrderTime.Name = "lblOrderTime";
            this.lblOrderTime.Size = new System.Drawing.Size(121, 26);
            this.lblOrderTime.TabIndex = 1;
            this.lblOrderTime.Text = "Order Time";
            // 
            // lblReceiptNumber
            // 
            this.lblReceiptNumber.AutoSize = true;
            this.lblReceiptNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblReceiptNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiptNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblReceiptNumber.Location = new System.Drawing.Point(247, 258);
            this.lblReceiptNumber.Name = "lblReceiptNumber";
            this.lblReceiptNumber.Size = new System.Drawing.Size(170, 26);
            this.lblReceiptNumber.TabIndex = 1;
            this.lblReceiptNumber.Text = "Receipt Number";
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.BackColor = System.Drawing.Color.Transparent;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPaymentMethod.Location = new System.Drawing.Point(247, 324);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(177, 26);
            this.lblPaymentMethod.TabIndex = 1;
            this.lblPaymentMethod.Text = "Payment Method";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-18, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 334);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            // 
            // lblPrint
            // 
            this.lblPrint.AutoSize = true;
            this.lblPrint.BackColor = System.Drawing.Color.Transparent;
            this.lblPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrint.ForeColor = System.Drawing.Color.White;
            this.lblPrint.Location = new System.Drawing.Point(554, 363);
            this.lblPrint.Name = "lblPrint";
            this.lblPrint.Size = new System.Drawing.Size(52, 24);
            this.lblPrint.TabIndex = 78;
            this.lblPrint.Text = "Print";
            // 
            // FrmReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GroupProject.Properties.Resources.Menu;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPrint);
            this.Controls.Add(this.lblPaymentMethod);
            this.Controls.Add(this.lblReceiptNumber);
            this.Controls.Add(this.lblOrderTime);
            this.Controls.Add(this.lblRestaurantAddress);
            this.Controls.Add(this.lblRestaurauntName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmReceipt";
            this.Text = "Receipt";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRestaurauntName;
        private System.Windows.Forms.Label lblRestaurantAddress;
        private System.Windows.Forms.Label lblOrderTime;
        private System.Windows.Forms.Label lblReceiptNumber;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPrint;
    }
}