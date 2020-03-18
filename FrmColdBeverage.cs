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
    public partial class FrmColdBeverage : Form
    {
        public FrmColdBeverage()
        {
            InitializeComponent();
            
        }
        public FrmColdBeverage(String user)
        {
            InitializeComponent();
            if (user == "admin")
            {
                lblAdd.Show();
                lblDelete.Show();
                lblUpdate.Show();
            }
        }

        private void lblBreakfast_Click(object sender, EventArgs e)
        {
            FrmBreakFastMenu breakfast = new FrmBreakFastMenu();
            breakfast.Show();
            this.Hide();
        }

        private void lblLunch_Click(object sender, EventArgs e)
        {
            FrmLunchMenu lunch = new FrmLunchMenu();
            lunch.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            frmHotBeverage hotBeverage = new frmHotBeverage();
            hotBeverage.Show();
            this.Hide();
        }

        private void lblCheckout_Click(object sender, EventArgs e)
        {
            frmCheckout checkout = new frmCheckout();

            checkout.ShowDialog();
        }

        private void FrmColdBeverage_Load(object sender, EventArgs e)
        {

        }

        private void lblAdd_Click(object sender, EventArgs e)
        {
            FrmEditItems editItems = new FrmEditItems();
            editItems.ShowDialog();
        }
    }
}
