using System;
using System.Collections.Generic;

namespace Class_Library
{
    public class clsMOTTimeCollection
    {
        private List<clsMOTTime> mAllMOTTimes = new List<clsMOTTime>();

        // public constructor for the class
        public clsMOTTimeCollection()
        {
            // create an is instance of the dataconnecction 
            clsDataConnection DB = new clsDataConnection();
            // execute the stored procedure to get the list of data
            DB.Execute("sproc_tblMOTTime_SelectAll");
            // get the count of records
            Int32 RecordCount = DB.Count;
            // set up the index for the loop
            Int32 Index = 0;
            // while there are records to process
            while (Index < RecordCount)
            {
                // create an instance of the class we want to create
                clsMOTTime AMOTTime = new clsMOTTime();
                // get the mot time
                AMOTTime.MOTTime = Convert.ToInt32(DB.DataTable.Rows[Index]["MOTTime"]);
                // get the primary key
                AMOTTime.MOTTimeID = Convert.ToInt32(DB.DataTable.Rows[Index]["MOTTimeID"]);
                // add the seconf mot time to the private list of MOTTimes
                mAllMOTTimes.Add(AMOTTime);
                // increment the index
                Index++;
            }            
        }

        // public property for Count
        public int Count
        {
            get
            {
                // return the count property of the private list
                return mAllMOTTimes.Count;
            }
            set
            {
                // later
            }
        }
        public List<clsMOTTime> AllMOTTimes
        {
            // getter sends data to requesting code
            get
            {
                // return the private data member
                return mAllMOTTimes;
            }
            // setter accepts data from other objects
            set
            {
                // assign the incoming value to the private data member
                mAllMOTTimes = value;
            }
        
        }

    }
}