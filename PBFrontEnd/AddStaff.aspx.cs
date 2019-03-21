using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PBFrontEnd
{
    public partial class AddStaff : System.Web.UI.Page
    {
        // When the page loads
        protected void Page_Load(object sender, EventArgs e)
        {
            // If this is the first time the page is displayed
            if (IsPostBack == false)
            {
                // Display the first Staff data (Need to change when security class is added)
                DisplayStaff(1);
            }
        }

        // Function to display Staff data
        void DisplayStaff(Int32 StaffID)
        {
            // New instance of clsCustomerCollection class
            clsStaffCollection Staff = new clsStaffCollection();
            // Find the record to update
            Staff.ThisStaff.Find(StaffID);
            // Display the data for this record
            txtAddressLn1.Text = Staff.ThisStaff.AddressLine1;
            txtAddressLn2.Text = Staff.ThisStaff.AddressLine2;
            txtEmailAddress.Text = Staff.ThisStaff.Email;
            txtFirstName.Text = Staff.ThisStaff.FirstName;
            txtLastName.Text = Staff.ThisStaff.LastName;
            txtPhoneNo.Text = Staff.ThisStaff.PhoneNo;
        }

        // Function to update a Staff
        void Update()
        {
            // New instance of clsStaffCollection class
            clsStaffCollection Customer = new clsStaffCollection();
            // Check if there is an error message returned
            String Error = Staff.ThisStaff.Valid(txtAddressLn1.Text, txtAddressLn2.Text, txtEmailAddress.Text, txtFirstName.Text, txtLastName.Text, txtPhoneNo.Text, txtCarRegNo.Text);
            // New variable for the primary key (Need to change when security class is added)
            Int32 StaffID = 1;
            // If there are no errors
            if (Error == "")
            {
                // Find the record to update
                Staff.ThisStaff.Find(StaffID);
                // Get the data entered by the user
                Staff.ThisStaff.AddressLine1 = txtAddressLn1.Text;
                Staff.ThisStaff.AddressLine2 = txtAddressLn2.Text;
                Staff.ThisStaff.Email = txtEmailAddress.Text;
                Staff.ThisStaff.FirstName = txtFirstName.Text;
                Staff.ThisStaff.LastName = txtLastName.Text;
                Staff.ThisStaff.PhoneNo = txtPhoneNo.Text;
                // Update the record
                Staff.Update();
                // Indicate a successfull update of a record
                lblSuccess.Text = "Your details updated successfully.";
            }
            // If there is an error
            else
            {
                // Show an error message
                lblError.Text = "There were problems with the data entered: <br /><br />" + Error;
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            // Temporary
            // Update the customer details
            Update();
            Response.Redirect("SaveStaff.aspx");
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            // Temporary
            Response.Redirect("ListStaff.aspx");
        }

        protected void btnAddNewAccount_Click(object sender, EventArgs e)
        {
            // Temporary
            Response.Redirect("ListStaff.aspx");
        }

    }
}