using System;
using System.Collections.Generic;

namespace Class_Library
{
    public class clsAppointmentCollection
    {
        // private data member for the AllAppointments List
        private List<clsAppointment> mAppointmentList = new List<clsAppointment>();

        // public constructor for the class
        public clsAppointmentCollection()
        {
            // set up the index for the loop
            Int32 Index = 0;
            // get the count of records
            Int32 RecordCount = 0;           
            // create an instance of the dataconnection
            clsDataConnection DB = new clsDataConnection();
            // execute the stored procedure to get the list of data
            DB.Execute("sproc_tblAppointment_SelectAll");
            // get the count of records
            RecordCount = DB.Count;
            // while there are records to process
            while (Index < RecordCount)
            {
                // create an instance of the appointment class to store the appointment
                clsAppointment AnAppointment = new clsAppointment();
                // read in the fields from the current record
                AnAppointment.AppointmentID = Convert.ToInt32(DB.DataTable.Rows[Index]["AppointmentID"]);
                AnAppointment.CarRegNo = Convert.ToString( DB.DataTable.Rows[Index]["CarRegNo"]);
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

        
        
        public clsAppointment ThisAppointment { get; set; }        
           
            

            
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