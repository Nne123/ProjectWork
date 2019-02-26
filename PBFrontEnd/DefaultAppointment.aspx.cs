using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Class_Library;

namespace PBFrontEnd
{
    public partial class Default : System.Web.UI.Page
    {
        // handles the load event for the page
        protected void Page_Load(object sender, EventArgs e)
        {
            // if this is the first time the page is displayed
            if (IsPostBack == false)
            {
                // update the list box
                DisplayAppointments();
            }
        }

        void DisplayAppointments()
        {
            // create an instance of the Appointment collection
            Class_Library.clsAppointmentCollection Appointments = new Class_Library.clsAppointmentCollection();
            // set the data source to the list of appointments in the collection
            lstAppointments.DataSource = Appointments.AppointmentList;
            // set the name of the primary key
            lstAppointments.DataValueField = "AppointmentID";
            // set the field to display
            lstAppointments.DataTextField = "MOTDate";
            // bind the data to the list
            lstAppointments.DataBind();
        }
    }
}