using Class_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PBFrontEnd
{
    public partial class DeleteStaff : System.Web.UI.Page
    {
        // New variable for the primary key
        Int32 StaffID;

        // When the page loads
        protected void Page_Load(object sender, EventArgs e)
        {
            // Store the data into the variable
            StaffID = Convert.ToInt32(Session["StaffID"]);
        }

        // Function to delete a Staff
        void DeleteStaff()
        {
            // New instance of clsStaffCollection class
            clsStaffCollection AllStaff = new clsStaffCollection();
            // Find a record to delete
            AllStaff.ThisStaff.Find(StaffID);
            // Delete the record
            AllStaff.Delete();
        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            // Delete the Staff
            DeleteStaff();
            // Redirect to the previous page
            Response.Redirect("DeleteStaff.aspx");
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            // Redirect to the previous page
            Response.Redirect("ListStaff.aspx");
        }
    }
}