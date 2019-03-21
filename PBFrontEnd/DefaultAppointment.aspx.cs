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
           // DateTime MOTDateListed = Convert.ToDateTime("dd/mm/yyyy");

            //DateTime? testDate = null;

            // clear an existing error message
            lblError.Text = "";
            // if this is the first time the page is displayed
            if (IsPostBack == false)
            {
                // update the list box
                lblError.Text = DisplayAppointments(Convert.ToDateTime("27/03/2019")) + "  records in the database";
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            // store -1 into the session object to indicate this is a new record
            Session["AppointmentID"] = -1;
            // redirect to the data entry page
            Response.Redirect("AnAppointment.aspx");
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            // var to store the primary key value of the record to be edited
            Int32 AppointmentID;
            // if a record has been selected from the list
            if (lstAppointments.SelectedIndex != -1)
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
        

        protected void btnApply_Click(object sender, EventArgs e)
        {
            Int32 RecordCount;
            RecordCount = DisplayAppointments(Convert.ToDateTime(txtMOTDate.Text));
            lblError.Text = RecordCount + " records found";
        }

        Int32 DisplayAppointments(DateTime MOTDateFilter)
        {
            Class_Library.clsAppointmentCollection MyAppointmentBook = new Class_Library.clsAppointmentCollection();
            Int32 RecordCount;
            string StaffID;
            string CustomerID;
            string JobID;
            string MOTDate;
            string CarRegNo;
            string AppointmentID;
            Int32 Index = 0;
            lstAppointments.Items.Clear();
            MyAppointmentBook.ReportByMOTDate(MOTDateFilter);
            RecordCount = MyAppointmentBook.Count;
            while (Index < RecordCount)
            {
                CarRegNo = Convert.ToString(MyAppointmentBook.AppointmentList[Index].CarRegNo);
                CustomerID = Convert.ToString(MyAppointmentBook.AppointmentList[Index].CustomerID);
                JobID = Convert.ToString(MyAppointmentBook.AppointmentList[Index].JobID);
                StaffID = Convert.ToString(MyAppointmentBook.AppointmentList[Index].StaffID);
                AppointmentID = Convert.ToString(MyAppointmentBook.AppointmentList[Index].AppointmentID);
                MOTDate = Convert.ToString(MyAppointmentBook.AppointmentList[Index].MOTDate);
                ListItem NewItem = new ListItem(MOTDate + " ", AppointmentID);
                lstAppointments.Items.Add(NewItem);
                Index++;
            }
            return RecordCount;

            //// create an instance of the Appointment collection
            //Class_Library.clsAppointmentCollection Appointments = new Class_Library.clsAppointmentCollection();
            //// set the data source to the list of appointments in the collection
            //lstAppointments.DataSource = Appointments.AppointmentList;
            //// set the name of the primary key
            //lstAppointments.DataValueField = "AppointmentID";
            //// set the field to display
            //lstAppointments.DataTextField = "MOTDate";
            //// bind the data to the list
            //lstAppointments.DataBind();
        }
    }
}