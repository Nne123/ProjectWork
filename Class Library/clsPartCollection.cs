using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
    public class clspartCollection
    {
        // Private data member for the part list
        List<clsPart> mPartList = new List<clsPart>();
        // Private data member for the customer
        clsPart mThisPart = new clsPart();

        public clspartCollection()
        {
            // New instance of clsDataConnection class
            clsDataConnection DB = new clsDataConnection();
            // Execute the stored procedure
            DB.Execute("sproc_tblpart_SelectAll");
            // Populate the array list with the data table
            PopulateArray(DB);
        }

        // Adds a new record to the database based on the values of ThisCustomer
        public int Add()
        {
            // New instance of clsDataConnection class
            clsDataConnection DB = new clsDataConnection();
            // Set the parameters for the stored procedure
            DB.AddParameter("@FirstName", mThisPart.PartName);
            // Execute the query returning the primary key value
            return DB.Execute("sproc_tblPart_Insert");
        }

        // Deletes the record pointed to by ThisCustomer
        public void Delete()
        {
            // New instance of clsDataConnection class
            clsDataConnection DB = new clsDataConnection();
            // Set the parameters for the stored procedure
            DB.AddParameter("@partID", mThisPart.PartID);
            // Execute the stored procedure
            DB.Execute("sproc_part_Delete");
        }

        // Updates an existing record based on the values of ThisCustomer
        public void Update()
        {
            // New instance of clsDataConnection class
            clsDataConnection DB = new clsDataConnection();
            // Set the parameters for the stored procedure
            DB.AddParameter("@PartID", mThisPart.PartID);
      

            DB.AddParameter("@FirstName", mThisPart.Name);
            DB.AddParameter("@LastName", mThisPart.Name);
            
            // Execute the stored procedure
            DB.Execute("sproc_part_Update");
        }

        // Filters the records based on the values of full or partial CarRegNo
        public void ReportByCarRegNo(string CarRegNo)
        {
            // New instance of clsDataConnection class
            clsDataConnection DB = new clsDataConnection();
            // Set the parameters for the stored procedure
            DB.AddParameter("@CarRegNo", CarRegNo);
            // Execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCarRegNo");
            // Populate the array list with the data table
            PopulateArray(DB);
        }

        // Populates the array list based on the data table in the parameter DB
        void PopulateArray(clsDataConnection DB)
        {
            // New variable for the index
            Int32 Index = 0;
            // New variable to store the record count
            Int32 RecordCount = 0;
            // Get the count of records
            RecordCount = DB.Count;
            // Clear the private array list
            mPart = new List<clsCustomer>();
            // While there are records to process
            while (Index < RecordCount)
            {
                // New instance of clsCustomer class
                clsCustomer ACustomer = new clsCustomer();
                // Read in the fields from the current record
                ACustomer.AddressLine1 = Convert.ToString(DB.DataTable.Rows[Index]["AddressLine1"]);
                ACustomer.AddressLine2 = Convert.ToString(DB.DataTable.Rows[Index]["AddressLine2"]);
                ACustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["PartID"]);
                ACustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                ACustomer.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                ACustomer.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                ACustomer.PhoneNo = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNo"]);
                ACustomer.CarRegNo = Convert.ToString(DB.DataTable.Rows[Index]["CarRegNo"]);
                // Add the record to the private data member
                mPart.Add(ACustomer);
                // Increment the index
                Index++;
            }
        }

        // Public property for the customer
        public clsCustomer ThisCustomer
        {
            get
            {
                // Return the private data
                return mThisPart;
            }
            set
            {
                // Set the private data
                mPart = value;
            }
        }

        // Public property for the customer list
        public List<clsCustomer> CustomerList
        {
            get
            {
                // Return the private data
                return mPart;
            }
            set
            {
                // Set the private data
                mPart = value;
            }
        }

        // Public property for count
        public int Count
        {
            get
            {
                // Return the count of the list
                return mPart.Count;
            }
            set
            {
                // later
            }
        }
    }
}
}
