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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }
        public FrmAdmin(String user)
        {
            InitializeComponent();

            if(user =="Member")
            {
                btnAddAdmin.Show();
            }
        }
        private void lblSalesReview_Click(object sender, EventArgs e)
        {
            FrmSalesReview Salesreview = new FrmSalesReview();
            Salesreview.ShowDialog();
        }

        private void lblReceipts_Click(object sender, EventArgs e)
        {
            FrmReceipt receipt = new FrmReceipt();
            receipt.ShowDialog();
        }

        private void lblMenu_Click(object sender, EventArgs e)
        {
            String user = "admin";
            frmMenu menu = new frmMenu(user);
            menu.Show();
            this.Hide();
        }

        private void lblEditItems_Click(object sender, EventArgs e)
        {
            FrmEditItems editItems = new FrmEditItems();
            editItems.ShowDialog();
        }

    }
}
