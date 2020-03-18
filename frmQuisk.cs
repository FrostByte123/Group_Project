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
    public partial class frmQuisk : Form
    {
        public frmQuisk()
        {
            InitializeComponent();
        }

        private void lblConfirm_Click(object sender, EventArgs e)
        {
            if (!mtxtQuiskNumber.MaskFull)
            {
                mtxtQuiskNumber.Focus();
                MessageBox.Show("PLEASE ENTER YOUR Paypal NUMBER", "PHONE NUMBER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                FrmReceipt receipt = new FrmReceipt();
                receipt.Show();
            }
        }
    }
}
