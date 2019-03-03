using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PBFrontEnd
{
    public partial class ListStaff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            // Temporary
            Response.Redirect("AddStaff.aspx");
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            // Temporary
            Response.Redirect("EditStaff.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            // Temporary
            Response.Redirect("DeleteStaff.aspx");
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            // Temporary
            Response.Redirect("ListStaff.aspx");
        }

        protected void btnListAll_Click(object sender, EventArgs e)
        {

        }
    }
}