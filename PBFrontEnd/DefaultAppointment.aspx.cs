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
            // clear an existing error message
            lblError.Text = "";
            // if this is the first time the page is displayed
            if (IsPostBack == false)
            {                
                // update the list box
                lblError.Text = DisplayAppointments(Convert.ToDateTime("27/03/2019")) + "  records in the database";
            }
        }

        // Add button event handler
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            // store -1 into the session object to indicate this is a new record
            Session["AppointmentID"] = -1;
            // redirect to the data entry page
            Response.Redirect("AnAppointment.aspx");
        }

        // Edit button event handler
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
        
        // Apply button event handler
        protected void btnApply_Click(object sender, EventArgs e)
        {
            // delcare the variable to to the count of records
            Int32 RecordCount;
            //assign the results of the DisplayAppointments function to the record count var
            RecordCount = DisplayAppointments(Convert.ToDateTime(txtMOTDate.Text));
            //display the number of records found
            lblError.Text = RecordCount + " records found";
        }

        // function to populate the list box
        Int32 DisplayAppointments(DateTime MOTDateFilter)
        {
            // create an instance of the appointment collection class
            clsAppointmentCollection MyAppointmentBook = new clsAppointmentCollection();
            // var to store the count of records
            Int32 RecordCount;
            // var to store the staff id
            string StaffID;
            // var to store the customer id
            string CustomerID;
            // var to store the job id
            string JobID;
            // var to store the mot date
            string MOTDate;
            // var to store the car reg no
            string CarRegNo;
            // var to store the appointment id
            string AppointmentID;
            // var to store the index
            Int32 Index = 0;
            // clear the list of any existing items
            lstAppointments.Items.Clear();
            // call the filter by mot date method
            MyAppointmentBook.ReportByMOTDate(MOTDateFilter);
            // get the count of records found
            RecordCount = MyAppointmentBook.Count;
            //loop through each record found using the index to point to each record in the data table
            while (Index < RecordCount)
            {
                //get the car reg no from the query results
                CarRegNo = Convert.ToString(MyAppointmentBook.AppointmentList[Index].CarRegNo);
                //get the customer id from the query results
                CustomerID = Convert.ToString(MyAppointmentBook.AppointmentList[Index].CustomerID);
                //get the job id from the query results
                JobID = Convert.ToString(MyAppointmentBook.AppointmentList[Index].JobID);
                //get the staff id from the query results
                StaffID = Convert.ToString(MyAppointmentBook.AppointmentList[Index].StaffID);
                //get the appointment id from the query results
                AppointmentID = Convert.ToString(MyAppointmentBook.AppointmentList[Index].AppointmentID);
                //get the mot date from the query results
                MOTDate = Convert.ToString(MyAppointmentBook.AppointmentList[Index].MOTDate);
                //set up a new object of class list item 
                ListItem NewItem = new ListItem(MOTDate + " ", AppointmentID);
                //add the new item to the list
                lstAppointments.Items.Add(NewItem);
                //increment the index
                Index++;
            }
            // return the count of records
            return RecordCount;
        }
    }
}