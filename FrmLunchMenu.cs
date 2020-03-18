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
    public partial class FrmLunchMenu : Form
    {
        public FrmLunchMenu()
        {
            InitializeComponent();
        }

        public FrmLunchMenu(String user)
        {
            InitializeComponent();
            if (user == "admin")
            {
                lblAdd.Show();
                lblDelete.Show();
                lblUpdate.Show();
            }
        }

        private void FrmLunchMenu_Load(object sender, EventArgs e)
        {

        }

        private void lblBreakfastSwitch_Click(object sender, EventArgs e)
        {
            FrmBreakFastMenu breakFastMenu = new FrmBreakFastMenu();
            breakFastMenu.Show();
            this.Hide();
        }

        private void lblLunchSwitch_Click(object sender, EventArgs e)
        {
            FrmLunchMenu lunchmenu = new FrmLunchMenu();
            lunchmenu.Show();
            this.Hide();
        }

        private void lblHotBeverageSwitch_Click(object sender, EventArgs e)
        {
            frmHotBeverage hotbeverage = new frmHotBeverage();
            hotbeverage.Show();
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

        private void lblAdd_Click(object sender, EventArgs e)
        {
            FrmEditItems editItems = new FrmEditItems();
            editItems.ShowDialog();
        }
    }
}
                                