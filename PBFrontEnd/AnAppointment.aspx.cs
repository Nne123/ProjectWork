using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Class_Library;

namespace PBFrontEnd
{
    public partial class AddAppointment : System.Web.UI.Page
    {
        // variable to store the primary key
        Int32 AppointmentID;

        // event handler for the page load event
        protected void Page_Load(object sender, EventArgs e)
        {
            // get the number of the appointment to be processed
            AppointmentID = Convert.ToInt32(Session["AppointmentID"]);
            if (IsPostBack == false)
            {
                // populate the list of mot times
                DisplayMOTTimes();
                // if this is not a new record
                if (AppointmentID != -1)
                {
                    // display the current data for the record
                    DisplayAppointment();
                }
                else // this is a new record
                {  // set the date to tomorrows date
                    txtMOTDate.Text = DateTime.Now.Date.AddDays(1).ToString("dd/mm/yyyy");
                }
            }
        }

        
        
        // event handler for OK button
        protected void btnOK_Click(object sender, EventArgs e)
        {
            // if appointment does not exist
            if (AppointmentID == -1)
            {
                // add it to the database
                Add();
            }
            // otherwise
            else
            {
                // update it to the database
                Update();
            }
            // return to main page
            Response.Redirect("DefaultAppointment.aspx");          
        }


        // function for adding records
        void Add()
        {
            // create an instance of the appointment book
            clsAppointmentCollection AppointmentBook = new clsAppointmentCollection();
            // validate the data on the web form
            String Error = AppointmentBook.ThisAppointment.Valid(txtMOTDate.Text, txtCarRegNo.Text, txtCustomerID.Text, txtStaffID.Text, txtJobID.Text);
            // if the data is OK then add it to the object
            if (Error == "")
            {
                // get the data entered by the user
                AppointmentBook.ThisAppointment.MOTDate = Convert.ToDateTime(txtMOTDate.Text);
                AppointmentBook.ThisAppointment.CarRegNo = txtCarRegNo.Text;
                AppointmentBook.ThisAppointment.CustomerID = Convert.ToInt32(txtCustomerID.Text);
                AppointmentBook.ThisAppointment.StaffID = Convert.ToInt32(txtStaffID.Text);
                AppointmentBook.ThisAppointment.JobID = Convert.ToInt32(txtJobID.Text);
                AppointmentBook.ThisAppointment.Active = chkActive.Checked;
                AppointmentBook.ThisAppointment.MOTTimeID = Convert.ToInt32(ddlMOTTime.SelectedValue);
                // add the record
                AppointmentBook.Add();
                // all done so redirect back to the main page
                Response.Redirect("DefaultAppointment.aspx");
            }
            else
            {
                // report an error
                lblError.Text = "There were problems wit the data entered:  " + "  " + Error;
            }
        }


        // function for updating records
        void Update()
        {
            // create an instance of the appointment book
            clsAppointmentCollection AppointmentBook = new clsAppointmentCollection();
            // validate the data on the web form
            String Error = AppointmentBook.ThisAppointment.Valid(txtMOTDate.Text, txtCarRegNo.Text, txtCustomerID.Text, txtStaffID.Text, txtJobID.Text);
            // if the data is OK then add it to the object
            if (Error == "")
            {
                // find the record to update
                AppointmentBook.ThisAppointment.Find(AppointmentID);
                // get the data entered by the user
                AppointmentBook.ThisAppointment.MOTDate = Convert.ToDateTime(txtMOTDate.Text);
                AppointmentBook.ThisAppointment.CarRegNo = txtCarRegNo.Text;
                AppointmentBook.ThisAppointment.CustomerID = Convert.ToInt32(txtCustomerID.Text);
                AppointmentBook.ThisAppointment.StaffID = Convert.ToInt32(txtStaffID.Text);
                AppointmentBook.ThisAppointment.JobID = Convert.ToInt32(txtJobID.Text);
                AppointmentBook.ThisAppointment.Active = chkActive.Checked;
                AppointmentBook.ThisAppointment.MOTTimeID = Convert.ToInt32(ddlMOTTime.SelectedValue);
                // update the record
                AppointmentBook.Update();
                // all done so redirect back to the main page
                Response.Redirect("DefaultAppointment.aspx");
            }
            else
            {
                // report an error
                lblError.Text = "There were problems wit the data entered " + Error;
            }
        }

        void DisplayAppointment()
        {
            // create an instance of the appointment book
            clsAppointmentCollection AppointmentBook = new clsAppointmentCollection();
            // find the record to update
            AppointmentBook.ThisAppointment.Find(AppointmentID);
            // display the data for this record
            txtMOTDate.Text = AppointmentBook.ThisAppointment.MOTDate.ToString("dd/mm/yyyy");
            txtCarRegNo.Text = AppointmentBook.ThisAppointment.CarRegNo;
            txtCustomerID.Text = AppointmentBook.ThisAppointment.CustomerID.ToString();
            txtStaffID.Text = AppointmentBook.ThisAppointment.StaffID.ToString();
            txtJobID.Text = AppointmentBook.ThisAppointment.JobID.ToString();
            chkActive.Checked = AppointmentBook.ThisAppointment.Active;
            ddlMOTTime.SelectedValue = AppointmentBook.ThisAppointment.MOTTimeID.ToString();
        }
        
        // function for populating the mot times drop down list
        Int32 DisplayMOTTimes()
        {
            clsMOTTimeCollection MOTTimes = new clsMOTTimeCollection();
            string MOTTimeID;
            Int32 MOTTime;
            Int32 Index = 0;
            while (Index < MOTTimes.Count)
            {
                MOTTimeID = Convert.ToString(MOTTimes.AllMOTTimes[Index].MOTTimeID);
                MOTTime = MOTTimes.AllMOTTimes[Index].MOTTime;
                ListItem NewMOTTime = new ListItem(Convert.ToString(MOTTime), MOTTimeID);
                ddlMOTTime.Items.Add(NewMOTTime);
                Index++;
            }
            return MOTTimes.Count;
        }

        // Cancel button event handler
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("DefaultAppointment.aspx");
        }

        // Staff Reference button event handler
        protected void btnStaffIDs_Click(object sender, EventArgs e)
        {
            Response.Redirect("AppointmentStaffDetails.aspx");
        }

        protected void btnClearFields_Click(object sender, EventArgs e)
        {
            // clear the texyt boxes
            txtMOTDate.Text = "";
            txtCarRegNo.Text = "";
            txtCustomerID.Text = "";
            txtStaffID.Text = "";
            txtJobID.Text = "";
            chkActive.Checked = false;
        }
    }
}