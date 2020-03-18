namespace GroupProject
{
    partial class frmQuisk
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
            this.mtxtQuiskNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblPaypalNumber = new System.Windows.Forms.Label();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mtxtQuiskNumber
            // 
            this.mtxtQuiskNumber.Location = new System.Drawing.Point(361, 205);
            this.mtxtQuiskNumber.Mask = "000-000-0000";
            this.mtxtQuiskNumber.Name = "mtxtQuiskNumber";
            this.mtxtQuiskNumber.Size = new System.Drawing.Size(100, 20);
            this.mtxtQuiskNumber.TabIndex = 8;
            // 
            // lblPaypalNumber
            // 
            this.lblPaypalNumber.AutoSize = true;
            this.lblPaypalNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblPaypalNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaypalNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPaypalNumber.Location = new System.Drawing.Point(222, 203);
            this.lblPaypalNumber.Name = "lblPaypalNumber";
            this.lblPaypalNumber.Size = new System.Drawing.Size(129, 22);
            this.lblPaypalNumber.TabIndex = 6;
            this.lblPaypalNumber.Text = "Quisk  Number";
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblConfirm.Location = new System.Drawing.Point(365, 345);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(72, 22);
            this.lblConfirm.TabIndex = 7;
            this.lblConfirm.Text = "Confirm";
            this.lblConfirm.Click += new System.EventHandler(this.lblConfirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(375, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "QUISK";
            // 
            // frmQuisk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GroupProject.Properties.Resources.Menu;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mtxtQuiskNumber);
            this.Controls.Add(this.lblPaypalNumber);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.label1);
            this.Name = "frmQuisk";
            this.Text = "frmQuisk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxtQuiskNumber;
        private System.Windows.Forms.Label lblPaypalNumber;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.Label label1;
    }
}