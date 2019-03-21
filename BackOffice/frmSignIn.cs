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
    public partial class frmSignIn : Form
    {
        private clsSecurity mSec;

        public frmSignIn()
        {
            InitializeComponent();
        }

        internal clsSecurity Sec { get; set; }

        private void frmSignIn_Load(object sender, EventArgs e)
        {
            mSec = new clsSecurity();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string Error = mSec.SignIn(txtEMail.Text, txtPassword.Text);
            //if there were no errors
            if (Error == "")
            {
                //close this form
                this.Close();
            }
            else
            {
                //otherwise show any errors
                lblError.Text = Error;
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }

        private void txtEMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }
    }
}
