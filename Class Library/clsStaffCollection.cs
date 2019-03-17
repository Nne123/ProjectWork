using System;
using System.Collections.Generic;

namespace Class_Library
{
    //this is a test class for clsStaffCollection
    public class clsStaffCollection
    {
        // Private data member for the list Staff
        private List<clsStaff> mStaffList = new List<clsStaff>();
        //private data member for thisStaff
        clsStaff mThisStaff = new clsStaff();
        // private data member to connect to the database
        private clsDataConnection myDB = new clsDataConnection();
        //private data member that stores the count of records found
        private Int32 mRecordCount;

        //public clsStaff ThisStaff { get; set; }

        //public constructor for the class
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

        // Public property for the Staff list
        public List<clsStaff> StaffList
        {
            // getter sends data to requesting code
            get
            {
                // Return the private data
                return mStaffList;
            }
            // setter accepts data from other objects
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




        // public property for ThisStaff
        public clsStaff ThisStaff
        {
            get
            {
                // return the private data
                return mThisStaff;
            }
            set
            {
                // set the private data
                mThisStaff = value;
            }
        }

        public int Add()
        {
            // adds a new record to the database based on the values of mStaff
            // set the primary key value of the new record
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the stored procedure
            DB.AddParameter("@FirstName", mThisStaff.FirstName);
            DB.AddParameter("@LastName", mThisStaff.LastName);
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            DB.AddParameter("@AddressLine1", mThisStaff.AddressLine1);
            DB.AddParameter("@AddressLine2", mThisStaff.AddressLine2);
            DB.AddParameter("@Email", mThisStaff.Email);
            DB.AddParameter("@PhoneNo", mThisStaff.PhoneNo);
            DB.AddParameter("@Active", mThisStaff.Active);
            // execute the query returing the primary key value
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Delete()
        {
            // deletes the record poined to by thisStaff
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the stored proecdure
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            // execute the stored procedure
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void Update()
        {
            // update an existing record based on the values of this staff
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the stored procedure
            DB.AddParameter("@FirstName", mThisStaff.FirstName);
            DB.AddParameter("@LastName", mThisStaff.LastName);
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            DB.AddParameter("@AddressLine1", mThisStaff.AddressLine1);
            DB.AddParameter("@AddressLine2", mThisStaff.AddressLine2);
            DB.AddParameter("@Email", mThisStaff.Email);
            DB.AddParameter("@PhoneNo", mThisStaff.PhoneNo);
            DB.AddParameter("@Active", mThisStaff.Active);
            // execute the stored procedure
            DB.Execute("sproc_tblStaff_Update");
        }

        public void FindAllStaff()
        {
            //re-set the connection
            myDB = new clsDataConnection();
            //var to store the index
            Int32 Index = 0;
            //var to store the user number of the current record
            Int32 StaffID;
            //var to flag that user was found
            Boolean StaffFound;
            //execute the stored procedure
            myDB.Execute("sproc_tblStaff_SelectAll");
            //get the count of records
            mRecordCount = myDB.Count;
            //while there are still records to process
            while (Index < myDB.Count)
            {
                //create an instance of the user class
                clsStaff NewStaff = new clsStaff();
                //get the user number from the database
                StaffID = Convert.ToInt32(myDB.DataTable.Rows[Index]["StaffID"]);
                //find the user by invoking the find method
                StaffFound = NewStaff.Find(StaffID);
                if (StaffFound == true)
                {
                    //add the user to the list
                    mStaffList.Add(NewStaff);
                }
                //increment the index
                Index++;
            }
        }
    }
}

