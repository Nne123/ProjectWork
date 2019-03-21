using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackOffice
{
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //create an instance of the security class
            clsSecurity Sec = new clsSecurity();
            //get the new users details
            string EMail = txtEMail.Text;
            string Password1 = txtPassword1.Text;
            string Password2 = txtPassword2.Text;
            //try to sign up the new user
            lblError.Text = Sec.SignUp(EMail, Password1, Password2, true);
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            //close the current form
            this.Close();
        }
    }
}
