﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PBFrontEnd
{
    public partial class AppointmentCartDetailsStaff2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // Back button event handler
        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("AnAppointment.aspx");
        }
    }
}