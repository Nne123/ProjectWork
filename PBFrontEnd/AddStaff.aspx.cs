﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PBFrontEnd
{
    public partial class AddStaff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            // Temporary
            Response.Redirect("ListStaff.aspx");
        }

        protected void btnAddNewAccount_Click(object sender, EventArgs e)
        {
            // Temporary
            Response.Redirect("ListStaff.aspx");
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            // Temporary
            Response.Redirect("SaveStaff.aspx");
        }
    }
}