namespace GroupProject
{
    partial class frmPaypal
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.lblPaypalNumber = new System.Windows.Forms.Label();
            this.mtxtlblPaypalNumber = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(309, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paypal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblConfirm.Location = new System.Drawing.Point(299, 337);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(72, 22);
            this.lblConfirm.TabIndex = 2;
            this.lblConfirm.Text = "Confirm";
            this.lblConfirm.Click += new System.EventHandler(this.lblConfirm_Click);
            // 
            // lblPaypalNumber
            // 
            this.lblPaypalNumber.AutoSize = true;
            this.lblPaypalNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblPaypalNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaypalNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPaypalNumber.Location = new System.Drawing.Point(156, 195);
            this.lblPaypalNumber.Name = "lblPaypalNumber";
            this.lblPaypalNumber.Size = new System.Drawing.Size(133, 22);
            this.lblPaypalNumber.TabIndex = 2;
            this.lblPaypalNumber.Text = "Paypal Number";
            this.lblPaypalNumber.Click += new System.EventHandler(this.lblPaypalNumber_Click);
            // 
            // mtxtlblPaypalNumber
            // 
            this.mtxtlblPaypalNumber.Location = new System.Drawing.Point(295, 197);
            this.mtxtlblPaypalNumber.Mask = "000-000-0000";
            this.mtxtlblPaypalNumber.Name = "mtxtlblPaypalNumber";
            this.mtxtlblPaypalNumber.Size = new System.Drawing.Size(100, 20);
            this.mtxtlblPaypalNumber.TabIndex = 4;
            this.mtxtlblPaypalNumber.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtlblPaypalNumber_MaskInputRejected);
            // 
            // frmPaypal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GroupProject.Properties.Resources.Menu;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mtxtlblPaypalNumber);
            this.Controls.Add(this.lblPaypalNumber);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.label1);
            this.Name = "frmPaypal";
            this.Text = "frmPaypal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.Label lblPaypalNumber;
        private System.Windows.Forms.MaskedTextBox mtxtlblPaypalNumber;
    }
}