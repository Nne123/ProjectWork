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
        
        // public property for AppointmentList
        public List<clsAppointment> AppointmentList
        {
            // getter sends dat to requesting code
            get
            {
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
                return mAppointmentList.Count;
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
            return DB.Execute("sproc_tblAppointment_Insert");
        }

        public void Delete()
        {
            // deletes the record poined to by thisAppointment
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the stored proecdure
            DB.AddParameter("@AppointmentID", mThisAppointment.AppointmentID);
            // execute the stored procedure
            DB.Execute("sproc_tblAppointment_Delete");
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
            // in this case for MOT one record to show it can be listed
            // unlike strings which can return all

            // connect the MOTDate parameter to the database
            clsDataConnection DB = new clsDataConnection();
            // send the MOTDate parameter to the database
            DB.AddParameter("@MOTDate", MOTDate);
            // execute the stored procedure
            DB.Execute("sproc_tblAppointment_FilterByMOTDate");
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


        //// set the car reg no to 1234 GHY
        //AnAppointment.CarRegNo = "1234 6GH";
        //// add the appointment to the private list of appointments
        //mAppointmentList.Add(AnAppointment);
        //// re initialise the AnAppointment object to accept a new item
        //AnAppointment = new clsAppointment();
        //// set the appointment to 4321 6FG
        //AnAppointment.CarRegNo = "4321 6FG";
        //// add the seconf appointment to the private list of appointments
        //mAppointmentList.Add(AnAppointment);
        //// the private list now contains to appointments
        //// this assumes we have a working database that contains a table called tblAppointment


    }
}