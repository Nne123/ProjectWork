using System;
using System.Collections.Generic;

namespace Class_Library
{
    //this is a test class for clsStaffCollection
    public class clsStaffCollection
    {
        public clsStaff ThisStaff { get; set; }

        public clsStaffCollection()
        {
            // New variable for the index
            Int32 Index = 0;
            // New variable to store the record count
            Int32 RecordCount = 0;
            // New instance of clsDataConnection class
            clsDataConnection DB = new clsDataConnection();
            // Execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            // Get the count of records
            RecordCount = DB.Count;
            // While there are records to process
            while (Index < RecordCount)
            {
                // New instance of clsStaff class
                clsStaff AStaff = new clsStaff();
                // Read in the fields from the current record
                AStaff.AddressLine1 = Convert.ToString(DB.DataTable.Rows[Index]["AddressLine1"]);
                AStaff.AddressLine2 = Convert.ToString(DB.DataTable.Rows[Index]["AddressLine2"]);
                AStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AStaff.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AStaff.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                AStaff.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                AStaff.PhoneNo = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNo"]);
                // Add the record to the private data member Staff
                mStaffList.Add(AStaff);
                // Increment the index
                Index++;
            }
        }

        // Private data member for the list Staff
        List<clsStaff> mStaffList = new List<clsStaff>();

        // Public property for the Staff list
        public List<clsStaff> StaffList
        {
            get
            {
                // Return the private data
                return mStaffList;
            }
            set
            {
                // Set the private data
                mStaffList = value;
            }
        }

        // Public property for count
        public int Count
        {
            get
            {
                // Return the count of the list
                return mStaffList.Count;
            }
            set
            {
                // later
            }
        }
    }
}

