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
    public partial class frmMenuOption : Form
    {

        String user;
        public frmMenuOption()
        {
            InitializeComponent();
        }

        public frmMenuOption(String user)
        {
            InitializeComponent();
            if(user == "admin")
            {

                lblOrder.Show();
                this.user = user;
            }
        }


        private void picboxBreakfast_Click(object sender, EventArgs e)
        {

            if (this.user=="admin") {
                FrmBreakFastMenu breakfast = new FrmBreakFastMenu(user);

                breakfast.ShowDialog();
            }
            else
            {
                FrmBreakFastMenu breakfast = new FrmBreakFastMenu();

                breakfast.ShowDialog(); 
            }

            
        }

        private void frmMenuOption_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            
        }

        private void picboxLunch_Click(object sender, EventArgs e)
        {

            if (this.user == "admin")
            {

                FrmLunchMenu lunch = new FrmLunchMenu(user);

                lunch.ShowDialog();

            }
            else
            {
                FrmLunchMenu lunch = new FrmLunchMenu();

                lunch.ShowDialog();
            }

        }

        private void picboxHotBeverage_Click(object sender, EventArgs e)
        {
            if (this.user == "admin")
            {
                frmHotBeverage HotBeverage = new frmHotBeverage(user);

                HotBeverage.ShowDialog();
            }
            else { 

            frmHotBeverage HotBeverage = new frmHotBeverage();

            HotBeverage.ShowDialog();

        }
     }

        private void picboxColdBeverage_Click(object sender, EventArgs e)
        {
            if (this.user == "admin")
            {
                FrmColdBeverage coldBeverage = new FrmColdBeverage(user);
                coldBeverage.Show();
            }
            else {
                FrmColdBeverage coldBeverage = new FrmColdBeverage();
                coldBeverage.Show();
            }
                
        }

        private void label1_Click(object sender, EventArgs e)
        {

            frmCheckout checkout = new frmCheckout();

            checkout.ShowDialog();


        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            FrmLogin login = new FrmLogin();
            login.Show();

            menu.Hide();

        }


        private void lblOrder_Click(object sender, EventArgs e)
        {
            frmOrderList orderList = new frmOrderList();
            orderList.ShowDialog();
        }
    }
}
