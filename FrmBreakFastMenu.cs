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
    public partial class FrmBreakFastMenu : Form
    {
        public FrmBreakFastMenu()
        {
            InitializeComponent();
        }
        public FrmBreakFastMenu(String user)
        {
            InitializeComponent();

            if (user == "admin")
            {
                lblAdd.Show();
                lblDelete.Show();
                lblUpdate.Show();
            }
        }

        private void lblLunchSwitch_Click(object sender, EventArgs e)
        {
            FrmLunchMenu lunch = new FrmLunchMenu();
            lunch.Show();
            this.Hide();
        }

        private void lblHotBeverageSwitch_Click(object sender, EventArgs e)
        {
            frmHotBeverage hotBeverage = new frmHotBeverage();
            hotBeverage.Show();
            this.Hide();
        }

        private void lblColdBeverageSwitch_Click(object sender, EventArgs e)
        {
            FrmColdBeverage coldBeverage = new FrmColdBeverage();
            coldBeverage.Show();
            this.Hide();
        }

        private void lblCheckout_Click(object sender, EventArgs e)
        {
            frmCheckout checkout = new frmCheckout();

            checkout.ShowDialog();
        }

        private void lblBreakFast_Click(object sender, EventArgs e)
        {

        }

        private void lblAdd_Click(object sender, EventArgs e)
        {
            FrmEditItems editItems = new FrmEditItems();
            editItems.ShowDialog();
        }
    }
}
