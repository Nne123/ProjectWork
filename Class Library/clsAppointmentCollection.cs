using System;
using System.Collections.Generic;

namespace Class_Library
{
    public class clsAppointmentCollection
    {
        // private data member for the AllAppointments List
        private List<clsAppointment> mAppointmentList = new List<clsAppointment>();
        // private data member thisAppointment
        clsAppointment mThisAppointment = new clsAppointment();
        // private data member to connect to the database
        clsDataConnection myDB = new clsDataConnection();
        //private data member that stores the count of records found
        private Int32 mRecordCount;

        // public constructor for the class
        public clsAppointmentCollection()
        {
            // create an instance of the dataconnection
            clsDataConnection DB = new clsDataConnection();
            // execute the stored procedure to get the list of data
            DB.Execute("sproc_tblAppointment_SelectAll");
            // populate the array list with the data table
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            // populates the array list based on the data table in the parameter DB
            // set up the index for the loop
            Int32 Index = 0;
            // get the count of records
            Int32 RecordCount;
            // get the count of records
            RecordCount = DB.Count;
            // clear the private array list
            mAppointmentList = new List<clsAppointment>();
            // while there are records to process
            while (Index < RecordCount)
            {
                // create an instance of the appointment class to store the appointment
                clsAppointment AnAppointment = new clsAppointment();
                // read in the fields from the current record
                AnAppointment.AppointmentID = Convert.ToInt32(DB.DataTable.Rows[Index]["AppointmentID"]);
                AnAppointment.CarRegNo = Convert.ToString(DB.DataTable.Rows[Index]["CarRegNo"]);
                AnAppointment.MOTDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["MOTDate"]);
                AnAppointment.JobID = Convert.ToInt32(DB.DataTable.Rows[Index]["JobID"]);
                AnAppointment.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnAppointment.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AnAppointment.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnAppointment.MOTTimeID = Convert.ToInt32(DB.DataTable.Rows[Index]["MOTTimeID"]);
                // add the appointment to the private data member
                mAppointmentList.Add(AnAppointment);
                // increment the index
                Index++;
            }

        }
        // public property for AppointmentList
        public List<clsAppointment> AppointmentList
        {
            // getter sends dat to requesting code
            get
            {
                Int32 Index = 0;
                while (Index < myDB.Count)
                {
                    clsAppointment NewAppointment = new clsAppointment();
                    NewAppointment.CarRegNo = Convert.ToString(myDB.DataTable.Rows[Index]["CarRegNo"]);
                    NewAppointment.CustomerID = Convert.ToInt32(myDB.DataTable.Rows[Index]["CustomerID"]);
                    NewAppointment.StaffID = Convert.ToInt32(myDB.DataTable.Rows[Index]["StaffID"]);
                    NewAppointment.JobID = Convert.ToInt32(myDB.DataTable.Rows[Index]["JobID"]);
                    NewAppointment.MOTDate = Convert.ToDateTime(myDB.DataTable.Rows[Index]["MOTDate"]);
                    NewAppointment.MOTTimeID = Convert.ToInt32(myDB.DataTable.Rows[Index]["MOTTimeID"]);
                    NewAppointment.Active = Convert.ToBoolean(myDB.DataTable.Rows[Index]["Active"]);
                    Index++;
                    mAppointmentList.Add(NewAppointment);

                }
                // return the private data member
                return mAppointmentList;
            }
            // setter accepts data from other objects
            set
            {
                // assign the incoming value to the private data member
                mAppointmentList = value;
            }
        }

        // public property for Count
        public int Count
        {
            get
            {
                // return the count property for the private list
                return mAppointmentList.Count; // mAppointmentList.Count;
            }
            set
            {
                
                // we'll come back to
            }
        }

        
        // public property for ThisAppointment
        public clsAppointment ThisAppointment
        {
            get
            {
                // return the private data
                return mThisAppointment;
            }
            set
            {
                // set the private data
                mThisAppointment = value;
            }
        }

        public int Add()
        {
            Int32 PrimaryKey;
            // adds a new record to the database based on the values of mAppointment
            // set the primary key value of the new record
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the stored procedure
            DB.AddParameter("@MOTDate", mThisAppointment.MOTDate);
            DB.AddParameter("@MOTTimeID", mThisAppointment.MOTTimeID);
            DB.AddParameter("@CarRegNo", mThisAppointment.CarRegNo);
            DB.AddParameter("@CustomerID", mThisAppointment.CustomerID);
            DB.AddParameter("@StaffID", mThisAppointment.StaffID);
            DB.AddParameter("@JobID", mThisAppointment.JobID);
            DB.AddParameter("@Active", mThisAppointment.Active);
            // execute the query returing the primary key value
            PrimaryKey = DB.Execute("sproc_tblAppointment_Insert");
            return PrimaryKey;
        }

        public void Update()
        {
            // update an existing record based on the values of this appointment
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the stored procedure
            DB.AddParameter("@AppointmentID", mThisAppointment.AppointmentID);
            DB.AddParameter("@MOTTimeID", mThisAppointment.MOTTimeID);
            DB.AddParameter("@MOTDate", mThisAppointment.MOTDate);
            DB.AddParameter("@CarRegNo", mThisAppointment.CarRegNo);
            DB.AddParameter("@CustomerID", mThisAppointment.CustomerID);
            DB.AddParameter("@StaffID", mThisAppointment.StaffID);
            DB.AddParameter("@JobID", mThisAppointment.JobID);
            DB.AddParameter("@Active", mThisAppointment.Active);
            // execute the stored procedure
            DB.Execute("sproc_tblAppointment_Update");
        }

        public void ReportByMOTDate(DateTime MOTDate)
        {
            // filters the records based on a full or partial code
            //    // in this case for MOT one record to show it can be listed
            //    // unlike strings which can return all

            // connect the MOTDate parameter to the database
            clsDataConnection DB = new clsDataConnection();
            // send the MOTDate parameter to the database
            DB.AddParameter("@StartDate", MOTDate);
            DB.AddParameter("@EndDate", MOTDate);
            // execute the stored procedure
            DB.Execute("sproc_tblAppointment_FilterByMOTDate");
            // populate the array list with the data table
            PopulateArray(DB);
        }

        public void FindAllAppointments()
        {
            //re-set the connection
            myDB = new clsDataConnection();
            //var to store the index
            Int32 Index = 0;
            //var to store the user number of the current record
            Int32 AppointmentID;
            //var to flag that user was found
            Boolean AppointmentFound;
            //execute the stored procedure
            myDB.Execute("sproc_tblAppointment_SelectAll");
            //get the count of records
            mRecordCount = myDB.Count;
            //while there are still records to process
            while (Index < myDB.Count)
            {
                //create an instance of the user class
                clsAppointment NewAppointment = new clsAppointment();
                //get the user number from the database
                AppointmentID = Convert.ToInt32(myDB.DataTable.Rows[Index]["AppointmentID"]);
                //find the user by invoking the find method
                AppointmentFound = NewAppointment.Find(AppointmentID);
                if (AppointmentFound == true)
                {
                    //add the user to the list
                    mAppointmentList.Add(NewAppointment);
                }
                //increment the index
                Index++;
            }
        }
    }
}