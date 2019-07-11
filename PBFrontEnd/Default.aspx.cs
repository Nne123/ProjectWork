using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PBFrontEnd
{
    public partial class Default1 : System.Web.UI.Page
    {
        public object lstStaff { get; private set; }

        //this function handles the load event for the page
        protected void Page_Load(object sender, EventArgs e)
        {
            //if this ia the first time the page is displayed
            if (IsPostBack == false)
            {
                //Update the list box
                DisplayStaff();
            }
        }

        private void DisplayStaff()
        {
            //throw new NotImplementedException();
        }

        //void DisplayStaff()
        //{
        //    //create an instance of the Staff Collection
        //    Class_Library.clsStaffCollection staff = new Class_Library.clsStaffCollection();
        //    //set the data source to the list of staff in the collection
        //    lstStaff.DataSource = Staff.StaffList;
        //    //set the name of the primary key
        //    lstStaff.DataValueField = "StaffID";
        //    //blind the data to the list
        //    lstStaff.DataBind();
        //}

        //private void DisplayStaff()
        //{
        //    throw new NotImplementedException();
        //}

        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            // Temporary
            Response.Redirect("MainPage.aspx");
        }

        protected void lstPart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}