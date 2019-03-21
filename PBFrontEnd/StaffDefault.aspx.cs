using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PBFrontEnd
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            {
                // Temporary
                Response.Redirect("ListStaff.aspx");
            }
        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            // Temporary
            Response.Redirect("AddStaff.aspx");
        }

        protected void txtEMail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}