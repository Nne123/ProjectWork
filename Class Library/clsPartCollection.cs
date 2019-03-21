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
        private List<clsPart> mPart;

        public clspartCollection()
        {
            // New instance of clsDataConnection class
            clsDataConnection DB = new clsDataConnection();
            // Execute the stored procedure
            DB.Execute("sproc_tblPart_SelectAll");
            // Populate the array list with the data table
            PopulateArray(DB);
        }

        // Adds a new record to the database based on the values of ThisCustomer
        public int Add()
        {
            // New instance of clsDataConnection class
            clsDataConnection DB = new clsDataConnection();
            // Set the parameters for the stored procedure
            DB.AddParameter("@FirstName", mThisPart.PartType);
            // Execute the query returning the primary key value
            return DB.Execute("sproc_tblPart_Insert");
        }

        // Deletes the record pointed to by ThisPart
        public void Delete()
        {
            // New instance of clsDataConnection class
            clsDataConnection DB = new clsDataConnection();
            // Set the parameters for the stored procedure
            DB.AddParameter("@partID", mThisPart.PartID);
            // Execute the stored procedure
            DB.Execute("sproc_part_Delete");
        }

        // Updates an existing record based on the values of ThisPart
        public void Update()
        {
            // New instance of clsDataConnection class
            clsDataConnection DB = new clsDataConnection();
            // Set the parameters for the stored procedure
            DB.AddParameter("@PartID", mThisPart.PartID);
      

            DB.AddParameter("@PartType", mThisPart.PartType);
            DB.AddParameter("@Active", mThisPart.Active);
            
            // Execute the stored procedure
            DB.Execute("sproc_part_Update");
        }

        // Filters the records based on the values of full or partial Part ID
        public void ReportByPartID(string PartID)
        {
            // New instance of clsDataConnection class
            clsDataConnection DB = new clsDataConnection();
            // Set the parameters for the stored procedure
            DB.AddParameter("@CarRegNo", PartID);
            // Execute the stored procedure
            DB.Execute("sproc_tblPart_FilterByPartID");
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
            mPart = new List<clsPart>();
            // While there are records to process
            while (Index < RecordCount)
            {
                // New instance of clsCustomer class
                clsPart APart = new clsPart();
                // Read in the fields from the current record

                APart.PartID = Convert.ToInt32(DB.DataTable.Rows[Index]["PartID"]);
                APart.PartType = Convert.ToString(DB.DataTable.Rows[Index]["PartType"]);
                APart.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                
                // Add the record to the private data member
                mPart.Add(APart);
                // Increment the index
                Index++;
            }
        }

        //// Public property for the customer
        //public clsPart ThisPart
        //{
        //    get
        //    {
        //        // Return the private data
        //        return mThisPart;
        //    }
        //    set =>
        //        // Set the private data
        //        mPart = value;
        //}

        // Public property for the customer list
        public List<clsPart> PartList
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

