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
                // Populate the list of customers
                DisplayCustomers();
                // Display the first customer data
                DisplayCustomer(1);
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
            // Show the count
            lblCurrentCount.Text = Convert.ToString(AllCustomers.CustomerList.Count);
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
                // Refresh the page indicating a successfull add of a record
                Response.Redirect("Customer_StaffSide.aspx");
            }
            // If there is an error
            else
            {
                // Show an error message
                lblError.Text = "There were problems with the data entered: <br /><br />" + Error;
            }
        }

        // Function to update a customer
        void Update()
        {
            // New instance of clsCustomerCollection class
            clsCustomerCollection Customer = new clsCustomerCollection();
            // Check if there is an error message returned
            String Error = Customer.ThisCustomer.Valid(txtAddressLn1.Text, txtAddressLn2.Text, txtEmailAddress.Text, txtFirstName.Text, txtLastName.Text, txtPhoneNo.Text, txtCarRegNo.Text);
            // New variable for the primary key
            Int32 CustomerID = Convert.ToInt32(lstCustomers.SelectedValue);
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
                Customer.Add();
                // Refresh the page indicating a successfull update of a record
                Response.Redirect("Customer_StaffSide.aspx");
            }
            // If there is an error
            else
            {
                // Show an error message
                lblError.Text = "There were problems: <br /><br />Please select a record to update from the list.";
            }
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            // Add the new customer
            Add();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            // New variable for the primary key
            Int32 CustomerID;
            // If a record has been selected from the list
            if (lstCustomers.SelectedIndex != -1)
            {
                // Get the primary key value of the record to delete
                CustomerID = Convert.ToInt32(lstCustomers.SelectedValue);
                // Store the data into the session object
                Session["CustomerID"] = CustomerID;
                // Redirect to the delete page
                Response.Redirect("Customer_StaffSideConfirm.aspx");
            }
            // If no record has been selected
            else
            {
                // Show an error message
                lblError.Text = "There were problems: <br /><br />Please select a record to delete from the list.";
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            // Add the new customer
            Update();
        }

        protected void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            // New variable for the primary key
            Int32 CustomerID = Convert.ToInt32(lstCustomers.SelectedValue);
            // Display the selected customer data
            DisplayCustomer(CustomerID);
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            // New instance of clsCustomerCollection class
            clsCustomerCollection Customers = new clsCustomerCollection();
            // Find the record
            Customers.ReportByCarRegNo(txtSearchField.Text);
            // Set the data source to the list of customers in the search collection
            lstCustomers.DataSource = Customers.CustomerList;
            // Set the name of the primary key
            lstCustomers.DataValueField = "CustomerID";
            // Set the data field to display
            lstCustomers.DataTextField = "CarRegNo";
            // Bind the data to the list
            lstCustomers.DataBind();
            // Show the count
            lblCurrentCount.Text = Convert.ToString(Customers.CustomerList.Count);
        }

        protected void btnShowAll_Click(object sender, EventArgs e)
        {
            // Populate the list of customers
            DisplayCustomers();
        }
    }
}