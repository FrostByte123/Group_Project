using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject
{
    public partial class frmPaypal : Form
    {
        public frmPaypal()
        {
            InitializeComponent();
        }
        
        private void lblConfirm_Click(object sender, EventArgs e)
        {
            if(!mtxtlblPaypalNumber.MaskFull)
            {
                mtxtlblPaypalNumber.Focus();
                MessageBox.Show("PLEASE ENTER YOUR Paypal NUMBER", "PHONE NUMBER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                FrmReceipt receipt = new FrmReceipt();
                receipt.Show();
            }
        }

        private void lblPaypalNumber_Click(object sender, EventArgs e)
        {

        }

        private void mtxtlblPaypalNumber_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
