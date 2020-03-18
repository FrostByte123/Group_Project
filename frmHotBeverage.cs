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
    public partial class frmHotBeverage : Form
    {
        public frmHotBeverage()
        {
            InitializeComponent();
        }

        public frmHotBeverage(String user)
        {
            InitializeComponent();
            if (user == "admin")
            {
                lblAdd.Show();
                lblDelete.Show();
                lblUpdate.Show();
            }
        }
        private void frmColdBeverage_Load(object sender, EventArgs e)
        {

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

        private void lblColdBeverage_Click(object sender, EventArgs e)
        {
            FrmColdBeverage coldbeverage = new FrmColdBeverage();
            coldbeverage.Show();
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

        /*  private void lblHotBeverageSwitch_Click(object sender, EventArgs e)
          {
              frmHotBeverage hotbeverage = new frmHotBeverage();
              hotbeverage.Show();
              this.Hide();
          }*/
    }
}
