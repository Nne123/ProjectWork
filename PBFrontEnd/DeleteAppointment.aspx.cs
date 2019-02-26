using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Class_Library;

namespace PBFrontEnd
{
    public partial class DeleteAppointment : System.Web.UI.Page
    {
        // var to store the primary key value of the record to be deleted
        Int32 AppointmentID;
        
        // event handler for the load event
        protected void Page_Load(object sender, EventArgs e)
        {
            // get the number of the appointment to be deleted from the session object
            AppointmentID = Convert.ToInt32(Session["AppointmentID"]);

        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            // delete the record
            DeleteAppointments();
            // redirect back to the main page
            Response.Redirect("DefaultAppointment.aspx");
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            // redirect back to the main page
            Response.Redirect("Default.aspx");

        }

        void DeleteAppointments()
        {
            // function to delete the selected record
            clsAppointmentCollection AppointmentBook = new clsAppointmentCollection();
            // find the record to delete
            AppointmentBook.ThisAppointment.Find(AppointmentID);
            // delete the record
            AppointmentBook.Delete();
        }
        
    }
}