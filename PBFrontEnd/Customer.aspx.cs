using Class_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PBFrontEnd
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        // When the page loads
        protected void Page_Load(object sender, EventArgs e)
        {
            // If this is the first time the page is displayed
            if (IsPostBack == false)
            {
                // Display the first customer data (Need to change when security class is added)
                DisplayCustomer(1);
            }
        }

        // Function to display customer data
        void DisplayCustomer(Int32 CustomerID)
        {
            // New instance of clsCustomerCollection class
            clsCustomerCollection Customer = new clsCustomerCollection();
            // Find the record to update
            Customer.ThisCustomer.Find(CustomerID);
            // Display the data for this record
            txtAddressLn1.Text = Customer.ThisCustomer.AddressLine1;
            txtAddressLn2.Text = Customer.ThisCustomer.AddressLine2;
            txtEmailAddress.Text = Customer.ThisCustomer.Email;
            txtFirstName.Text = Customer.ThisCustomer.FirstName;
            txtLastName.Text = Customer.ThisCustomer.LastName;
            txtPhoneNo.Text = Customer.ThisCustomer.PhoneNo;
            txtCarRegNo.Text = Customer.ThisCustomer.CarRegNo;
        }

        // Function to update a customer
        void Update()
        {
            // New instance of clsCustomerCollection class
            clsCustomerCollection Customer = new clsCustomerCollection();
            // Check if there is an error message returned
            String Error = Customer.ThisCustomer.Valid(txtAddressLn1.Text, txtAddressLn2.Text, txtEmailAddress.Text, txtFirstName.Text, txtLastName.Text, txtPhoneNo.Text, txtCarRegNo.Text);
            // New variable for the primary key (Need to change when security class is added)
            Int32 CustomerID = 1;
            // If there are no errors
            if (Error == "")
            {
                // Find the record to update
                Customer.ThisCustomer.Find(CustomerID);
                // Get the data entered by the user
                Customer.ThisCustomer.AddressLine1 = txtAddressLn1.Text;
                Customer.ThisCustomer.AddressLine2 = txtAddressLn2.Text;
                Customer.ThisCustomer.Email = txtEmailAddress.Text;
                Customer.ThisCustomer.FirstName = txtFirstName.Text;
                Customer.ThisCustomer.LastName = txtLastName.Text;
                Customer.ThisCustomer.PhoneNo = txtPhoneNo.Text;
                Customer.ThisCustomer.CarRegNo = txtCarRegNo.Text;
                // Update the record
                Customer.Update();
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
            // Update the customer details
            Update();
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            // Refresh the page to reset the fields
            Response.Redirect("Customer.aspx");
        }
    }
}