using Class_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PBFrontEnd
{
    public partial class ListStaff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // If this is the first time the page is displayed
            if (IsPostBack == false)
            {
                // Populate the list of customers
                DisplayStaff();
                // Display the first customer data
                DisplayStaff(1);
                // Make the first customer in the list selected
                lstStaff.SelectedIndex = 0;
            }
        }

        // Function to display Staff
        void DisplayStaff()
        {
            // New instance of clsStaffCollection class
            clsStaffCollection AllStaff = new clsStaffCollection();
            // Set the data source to the list of Staff in the collection
            lstStaff.DataSource = AllStaff.StaffList;
            // Set the name of the primary key
            lstStaff.DataValueField = "StaffID";
            // Set the data field to display
            lstStaff.DataTextField = "PhoneNo";
            // Bind the data to the list
            lstStaff.DataBind();
            // Show the count
            lblCurrentCount.Text = Convert.ToString(AllStaff.StaffList.Count);
        }

        // Function to display customer data
        void DisplayStaff(Int32 StaffID)
        {
            // New instance of clsStaffCollection class
            clsStaffCollection AllStaff = new clsStaffCollection()
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

        void Add()
        {
            //New instance of clsStaffCollection class
            clsStaffCollection Staff = new clsStaffCollection();
            // Store -1 into the session object to indicate this is a new record
            Session["StaffID"] = -1;
            // Check if there is an error message returned
            String Error = Staff.ThisStaff.Valid(txtAddressLn1.Text, txtAddressLn2.Text, txtEmailAddress.Text, txtFirstName.Text, txtLastName.Text, txtPhoneNo.Text);
            // If there are no errors
            if (Error == "")
            {
                // Get the data entered by the user
                Staff.ThisStaff.AddressLine1 = txtAddressLn1.Text;
                Staff.ThisStaff.AddressLine2 = txtAddressLn2.Text;
                Staff.ThisStaff.Email = txtEmailAddress.Text;
                Staff.ThisStaff.FirstName = txtFirstName.Text;
                Staff.ThisStaff.LastName = txtLastName.Text;
                Staff.ThisStaff.PhoneNo = txtPhoneNo.Text;
                // Add the record
                Staff.Add();
                // Refresh the page indicating a successfull add of a record
                Response.Redirect("ListStaff.aspx");
            }
            // If there is an error
            else
            {
                // Show an error message
                lblError.Text = "There were problems with the data entered: <br /><br />" + Error;
            }
        }

        // Function to update a Staff
        void Update()
        {
            // New instance of clsStaffCollection class
            clsStaffCollection Staff = new clsStaffCollection();
            // If a record has been selected from the list
            if (lstStaff.SelectedIndex != -1)
            {
                // Check if there is an error message returned
                String Error = Staff.ThisStaff.Valid(txtAddressLn1.Text, txtAddressLn2.Text, txtEmailAddress.Text, txtFirstName.Text, txtLastName.Text, txtPhoneNo.Text);
                // If there are no errors
                if (Error == "")
                {
                    // New variable for the primary key
                    Int32 StaffID = Convert.ToInt32(lstStaff.SelectedValue);
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
                    // Refresh the page indicating a successfull update of a record
                    Response.Redirect("ListStaff.aspx");
                }
                // If there is an error
                else
                {
                    // Show an error message
                    lblError.Text = "There were problems with the data entered: <br /><br />" + Error;
                }
            }
            // If no record has been selected
            else
            {
                // Show an error message
                lblError.Text = "There were problems: <br /><br />Please select a record to update from the list.";
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            // Add the new customer
            Add();
        }

        protected void btnShowAll_Click(object sender, EventArgs e)
        {
            // Populate the list of customers
            DisplayStaff();
        }
        //event handler for thr delete button
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            // New variable for the primary key
            Int32 StaffID;
            // If a record has been selected from the list
            if (lstStaff.SelectedIndex != -1)
            {
                // Get the primary key value of the record to delete
                StaffID = Convert.ToInt32(lstStaff.SelectedValue);
                // Store the data into the session object
                Session["StaffID"] = StaffID;
                // Redirect to the delete page
                Response.Redirect("ListStaff.aspx");
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
            // Update the customer
            Update();
        }

        protected void lstStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            // New variable for the primary key
            Int32 StaffID = Convert.ToInt32(lstStaff.SelectedValue);
            // Display the selected customer data
            DisplayStaff(StaffID);
        }

        //protected void btnClear_Click(object sender, EventArgs e)
        //{
        //    {
        //        Set all fields as blank
        //        txtAddressLn1.Text = "";
        //        txtAddressLn2.Text = "";
        //        txtEmailAddress.Text = "";
        //        txtFirstName.Text = "";
        //        txtLastName.Text = "";
        //        txtPhoneNo.Text = "";
        //    }
        //}

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            // Temporary
            Response.Redirect("EditStaff.aspx");
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            // Update the customer
            Update();
            // Temporary
            Response.Redirect("ListStaff.aspx");
        }
    }
}

    