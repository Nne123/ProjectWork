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
            Response.Redirect("Customer.aspx");
        }

        protected void btnManageCustomers_Click(object sender, EventArgs e)
        {
            Response.Redirect("Customer_StaffSide.aspx");
        }

        protected void btnManageParts_Click(object sender, EventArgs e)
        {
            Response.Redirect("Part.aspx");
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            // Temporary
            Response.Redirect("Default.aspx");
        }
    }
}