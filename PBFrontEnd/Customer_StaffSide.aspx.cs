using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Class_Library;

namespace PBFrontEnd
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        // When the page loads
        protected void Page_Load(object sender, EventArgs e)
        {
            // If this is the first time the page is displayed
            if (IsPostBack == false)
            {
                // Update the list box
                DisplayCustomers();
            }
        }

        // Function to display customers
        void DisplayCustomers()
        {
            // New instance of clsCustomerCollection class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            // Set the data source to the list of customers in the collection
            lstCustomers.DataSource = AllCustomers.CustomerList;
            // Set the name of the primary key
            lstCustomers.DataValueField = "CustomerID";
            // Set the data field to display
            lstCustomers.DataTextField = "CarRegNo";
            // Bind the data to the list
            lstCustomers.DataBind();
        }

        // Function to add a customer
        void Add()
        {
            // New instance of clsCustomerCollection class
            clsCustomerCollection Customer = new clsCustomerCollection();
            // Store -1 into the session object to indicate this is a new record
            Session["CustomerID"] = -1;
            // Check if there is an error message returned
            String Error = Customer.ThisCustomer.Valid(txtAddressLn1.Text, txtAddressLn2.Text, txtEmailAddress.Text, txtFirstName.Text, txtLastName.Text, txtPhoneNo.Text, txtCarRegNo.Text);
            // If there are no errors
            if (Error == "")
            {
                // Get the data entered by the user
                Customer.ThisCustomer.AddressLine1 = txtAddressLn1.Text;
                Customer.ThisCustomer.AddressLine2 = txtAddressLn2.Text;
                Customer.ThisCustomer.Email = txtEmailAddress.Text;
                Customer.ThisCustomer.FirstName = txtFirstName.Text;
                Customer.ThisCustomer.LastName = txtLastName.Text;
                Customer.ThisCustomer.PhoneNo = txtPhoneNo.Text;
                Customer.ThisCustomer.CarRegNo = txtCarRegNo.Text;
                // Add the record
                Customer.Add();
                // Refresh the page indicating a successfull adding of a customer
                Response.Redirect("Customer_StaffSide.aspx");
            }
            // If there is an error
            else
            {
                // Show an error message
                lblError.Text = "There were problems with the data entered: <br /><br />" + Error;
            }
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            // Add the new customer
            Add();
        }
    }
}