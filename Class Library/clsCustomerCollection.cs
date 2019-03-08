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

        // Adds a new record to the database based on the values of ThisCustomer
        public int Add()
        {
            // New instance of clsDataConnection class
            clsDataConnection DB = new clsDataConnection();
            // Set the parameters for the stored procedure
            DB.AddParameter("@AddressLine1", mThisCustomer.AddressLine1);
            DB.AddParameter("@AddressLine2", mThisCustomer.AddressLine2);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@LastName", mThisCustomer.LastName);
            DB.AddParameter("@PhoneNo", mThisCustomer.PhoneNo);
            DB.AddParameter("@CarRegNo", mThisCustomer.CarRegNo);
            // Execute the query returning the primary key value
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        // Deletes the record pointed to by ThisCustomer
        public void Delete()
        {
            // New instance of clsDataConnection class
            clsDataConnection DB = new clsDataConnection();
            // Set the parameters for the stored procedure
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            // Execute the stored procedure
            DB.Execute("sproc_tblCustomer_Delete");
        }

        // Updates an existing record based on the values of ThisCustomer
        public void Update()
        {
            // New instance of clsDataConnection class
            clsDataConnection DB = new clsDataConnection();
            // Set the parameters for the stored procedure
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.AddParameter("@AddressLine1", mThisCustomer.AddressLine1);
            DB.AddParameter("@AddressLine2", mThisCustomer.AddressLine2);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@LastName", mThisCustomer.LastName);
            DB.AddParameter("@PhoneNo", mThisCustomer.PhoneNo);
            DB.AddParameter("@CarRegNo", mThisCustomer.CarRegNo);
            // Execute the stored procedure
            DB.Execute("sproc_tblCustomer_Update");
        }

        // Public property for the customer
        public clsCustomer ThisCustomer
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