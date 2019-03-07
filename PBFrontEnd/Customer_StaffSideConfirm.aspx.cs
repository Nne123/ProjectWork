using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Class_Library;

namespace PBFrontEnd
{
    public partial class Customer_StaffSideConfirm : System.Web.UI.Page
    {
        // New variable for the primary key
        Int32 CustomerID;

        // When the page loads
        protected void Page_Load(object sender, EventArgs e)
        {
            // Store the data into the variable
            CustomerID = Convert.ToInt32(Session["CustomerID"]);
        }

        // Function to delete a customer
        void DeleteCustomer()
        {
            // New instance of clsCustomerCollection class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            // Find a record to delete
            AllCustomers.ThisCustomer.Find(CustomerID);
            // Delete the record
            AllCustomers.Delete();
        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            // Delete the customer
            DeleteCustomer();
            // Redirect to the previous page
            Response.Redirect("Customer_StaffSide.aspx");
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            // Redirect to the previous page
            Response.Redirect("Customer_StaffSide.aspx");
        }
    }
}