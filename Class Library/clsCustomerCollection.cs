using System;
using System.Collections.Generic;

namespace Class_Library
{
    public class clsCustomerCollection
    {
        // Private data member for the customer list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        // Private data member for the customer
        clsCustomer mThisCustomer = new clsCustomer();

        public clsCustomer ThisCustomer { get; set; }

        public clsCustomerCollection()
        {
            // New variable for the index
            Int32 Index = 0;
            // New variable to store the record count
            Int32 RecordCount = 0;
            // New instance of clsDataConnection class
            clsDataConnection DB = new clsDataConnection();
            // Execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            // Get the count of records
            RecordCount = DB.Count;
            // While there are records to process
            while (Index < RecordCount)
            {
                // New instance of clsCustomer class
                clsCustomer ACustomer = new clsCustomer();
                // Read in the fields from the current record
                ACustomer.AddressLine1 = Convert.ToString(DB.DataTable.Rows[Index]["AddressLine1"]);
                ACustomer.AddressLine2 = Convert.ToString(DB.DataTable.Rows[Index]["AddressLine2"]);
                ACustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                ACustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                ACustomer.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                ACustomer.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                ACustomer.PhoneNo = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNo"]);
                ACustomer.CarRegNo = Convert.ToString(DB.DataTable.Rows[Index]["CarRegNo"]);
                // Add the record to the private data member
                mCustomerList.Add(ACustomer);
                // Increment the index
                Index++;
            }
        }

        public int Add()
        {
            mThisCustomer.CustomerID = 3;
            return mThisCustomer.CustomerID;
        }

        // Public property for the customer
        public clsCustomer Customer
        {
            get
            {
                // Return the private data
                return mThisCustomer;
            }
            set
            {
                // Set the private data
                mThisCustomer = value;
            }
        }

        // Public property for the customer list
        public List<clsCustomer> CustomerList
        {
            get
            {
                // Return the private data
                return mCustomerList;
            }
            set
            {
                // Set the private data
                mCustomerList = value;
            }
        }

        // Public property for count
        public int Count
        {
            get
            {
                // Return the count of the list
                return mCustomerList.Count;
            }
            set
            {
                // later
            }
        }
    }
}