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
    public partial class frmMenu : Form
    {
        String user;
        public frmMenu()
        {
            InitializeComponent();
        }

        public frmMenu(String user)
        {
            InitializeComponent();
            this.user = user;
                
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

       
        private void frmMenu_Load(object sender, EventArgs e)
        {
            frmMenuOption menuoption = new frmMenuOption(user);
            menuoption.MdiParent=this;
            menuoption.Show();
        
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin login = new FrmLogin();
            login.Show();
        }
    }
}
