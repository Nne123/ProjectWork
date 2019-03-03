using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PBFrontEnd
{
    public partial class EasyFixBank : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCustomerDetails_Click(object sender, EventArgs e)
        {
            Response.Redirect("DefaultCustomer.aspx");
        }

        protected void btnManageCustomers_Click(object sender, EventArgs e)
        {
            Response.Redirect("DefaultCustomer_StaffSide.aspx");
        }
    }
}