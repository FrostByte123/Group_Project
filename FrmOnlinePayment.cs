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
    public partial class frmOnlinePayment : Form
    {
        public frmOnlinePayment()
        {
            InitializeComponent();
        }

        private void picboxPayPal_Click(object sender, EventArgs e)
        {
            frmPaypal paypal = new frmPaypal();
            paypal.ShowDialog();
        }

        private void picboxQuiskPicture_Click(object sender, EventArgs e)
        {
            frmQuisk quisk = new frmQuisk();
            quisk.Show();
        }
    }
}
