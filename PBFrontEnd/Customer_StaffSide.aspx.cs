using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
            // New instance of clsDataConnection class
            Class_Library.clsCustomerCollection Customers = new Class_Library.clsCustomerCollection();
            // Set the data source to the list of customers in the collection
            lstCustomers.DataSource = Customers.CustomerList;
            // Set the name of the primary key
            lstCustomers.DataValueField = "CustomerID";
            // Set the data field to display
            lstCustomers.DataTextField = "CarRegNo";
            // Bind the data to the list
            lstCustomers.DataBind();
        }
    }
}