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
        public object lblError { get; private set; }

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

        //event handler for thr delete button
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be deleted
            Int32 StaffID;
            //if a record has been selected from the list
            if (lstStaff.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                StaffID = Convert.ToInt32(lstStaff.SelectedValue);
                //store the data in the session object
                Session["StaffID"] = StaffID;
                //redirect the page to the delete page
                Response.Redirect("DeleteStaff.aspx");
            }
            else //if no record has been selected
            {
                //display an error 
                //lblError.Text = "Please select a record to delete from the list";
            }
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