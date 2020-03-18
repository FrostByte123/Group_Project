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
    public partial class frmCheckout : Form
    {
        public frmCheckout()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to make this purchase", "Purchase", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {

                dialog = MessageBox.Show("Do you want to pay for this purchase online", "Purchase", MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes)
                {
                    frmOnlinePayment online = new frmOnlinePayment();
                    online.ShowDialog();
                }
                else if (dialog == DialogResult.No)
                {
                    MessageBox.Show("YOUR ORDER IS GETTING READY");

                    FrmReceipt receipt = new FrmReceipt();
                    receipt.Show();
                }
            }
            else if (dialog == DialogResult.No)
            {
                MessageBox.Show("world");
            }


        }
    }
}
