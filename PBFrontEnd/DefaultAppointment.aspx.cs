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

        protected void btnApply_Click(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            // store -1 into the session object to indicate this is a new record
            Session["AppointmentID"] = -1;
            // redirect to the data entry page
            Response.Redirect("AnAppointment.aspx");
        }

        // event handler for the delete button
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            // var to store the primary key value of the record to be deleted
            Int32 AppointmentID;
            // if a record has been selected from the list
            if (lstAppointments.SelectedIndex != 1)
            {
                // get the primary key value of the record to delete
                AppointmentID = Convert.ToInt32(lstAppointments.SelectedValue);
                // store the data in the session object
                Session["AppointmentID"] = AppointmentID;
                // redirect to the delete page
                Response.Redirect("Delete.aspx");
            }
            else // if no record has been selected
            {
                // display an error
                lblError.Text = "Please select a reocord to delete from the list";
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            // var to store the primary key value of the record to be edited
            Int32 AppointmentID;
            // if a record has been selected from the list
            if (lstAppointments.SelectedIndex != 1)
            {
                // get the primary key value of the record to edit
                AppointmentID = Convert.ToInt32(lstAppointments.SelectedValue);
                // store the data in the session object
                Session["AppointmentID"] = AppointmentID;
                // redirect to the edit page
                Response.Redirect("AnAppointment.aspx");
            }
            else // if no record has been selected
            {
                // display an error
                lblError.Text = "Please select a record to delete from the list";
            }

        }
    }
}