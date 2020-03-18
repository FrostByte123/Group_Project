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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            
            User user = new User();
            UserData userdata = new UserData();


           if (txtUserName.Text == "")
            {
                txtUserName.Focus();
                MessageBox.Show("PLEASE ENTER YOUR USERNAME", "USERNAME",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

            }
            else if (txtPassword.Text == "")
            {

                txtPassword.Focus();
                MessageBox.Show("PLEASE ENTER YOUR PASSWORD", "PASSWORD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if(true == userdata.LoggingIn(txtUserName.Text, txtPassword.Text))
            {
                frmMenu menu = new frmMenu();
                this.Hide();
                menu.Show();
            
            }
            else if (true == userdata.AdminLoggingIn(txtUserName.Text, txtPassword.Text))
            {
                FrmAdmin admin = new FrmAdmin(txtUserName.Text);          
                this.Hide();
                admin.Show();
            
            }
            else
            {
                
                MessageBox.Show("Incorrect Detail");
                
            }


        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            FrmSignUp signup = new FrmSignUp();
            signup.Show();
            this.Hide();


        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Hide();
        }
    }
}
