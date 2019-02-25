using System;

namespace Class_Library
{
    public class clsAppointment
    {
        // private data member for the the properties
        private Int32 mAppointmentID;
        private string mCarRegNo;
        private Int32 mCustomerID;
        private Int32 mStaffID;
        private Int32 mJobID;
        private DateTime mMOTDate;
        private Int32 mMOTTimeID;
        private Boolean mActive;

        public string CarRegNo
        {
            get
            {
                // return the private data
                return mCarRegNo;
            }
            set
            {
                // set the value of the private data member
                mCarRegNo = value;
            }
        }
        public int AppointmentID
        {
            get
            {
                // return the private data
                return mAppointmentID;
            }
            set
            {
                // set the value of the private data member
                mAppointmentID = value;
            }
        }
        public DateTime MOTDate
        {
            get
            {
                // return the private data
                return mMOTDate;
            }
            set
            {
                // set the value of the private data member
                mMOTDate = value;
            }
        }
        public int JobID
        {
            get
            {
                // return the private data
                return mJobID;
            }
            set
            {
                // set the value of the private data member
                mJobID = value;
            }
        }
        public int CustomerID
        {
            get
            {
                // return the private data
                return mCustomerID;
            }
            set
            {
                // set the value of the private data member
                mCustomerID = value;
            }
        }
        public int StaffID
        {
            get
            {
                // return the private data
                return mStaffID;
            }
            set
            {
                // set the value of the private data member
                mStaffID = value;
            }
        }
        public int MOTTimeID
        {
            get
            {
                // return the private data
                return mMOTTimeID;
            }
            set
            {
                // set the value of the private data member
                mMOTTimeID = value;
            }
        }
        public bool Active
        {
            get
            {
                // return the private data
                return mActive;
            }
            set
            {
                // set the value of the private data member
                mActive = value;
            }
        }

        public string Valid(string carRegNo, string mOTDate, string CustomerID, string StaffID, string JobID)
        {
            // string variable to store the error message
            string Error = "";
            // create a temporary variable to store date values
            DateTime DateTemp;
            // create a temporary variable to store the customer id
            Int32 CustomerIDTemp;
            // create a temporary variable to store the staff id
            Int32 StaffIDTemp;
            // create a temporary variable to store the staff id
            Int32 JobIDTemp;            


            // if the name of the car reg no is not blank
            if (carRegNo.Length > 8)
            {
                // return an error message
                Error = "The car reg no cannot have more than 8 characters";
            }

            // if the name of the car reg no is not blank
            if (carRegNo.Length < 7)
            {
                // return an error message
                Error = "The car reg no cannot have more than 8 characters";
            }

            if (carRegNo.Length == 0)
            {
                // return an error message
                Error = "The car reg no may not be blank";
            }


            try
            {
                CustomerIDTemp = Convert.ToInt32(CustomerID);
                if (CustomerIDTemp < 1)
                {
                    Error = Error + "The CustomerID must be four digits : ";
                }
                if (CustomerIDTemp > 600)
                {
                    Error = Error + "The CustomerID must be four digits : ";
                }
            }
            catch
            {
                Error = Error + "The Customer ID was not valid";
            }

            try
            {
                StaffIDTemp = Convert.ToInt32(StaffID);
                if (StaffIDTemp < 1)
                {
                    Error = Error + "The Staff ID must be four digits : ";
                }
                if (StaffIDTemp > 600)
                {
                    Error = Error + "The Staff ID must be four digits : ";
                }
            }
            catch
            {
                Error = Error + "The Staff ID was not valid";
            }

            try
            {
                JobIDTemp = Convert.ToInt32(JobID);
                if (JobIDTemp < 1)
                {
                    Error = Error + "The Job ID must be four digits : ";
                }
                if (JobIDTemp > 600)
                {
                    Error = Error + "The Job ID must be four digits : ";
                }
            }
            catch
            {
                Error = Error + "The Job ID was not valid";
            }

            try
            {
                DateTemp = Convert.ToDateTime(mOTDate);

                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past : ";
                }

                if (DateTemp == DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be today : ";
                }

                if (DateTemp > DateTime.Now.Date.AddDays(21))
                {
                    Error = "The date cannot be more than 21 days ";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date : ";
            }

            return Error;
        }

        public bool Find(int AppointmentID)
        {
            // set the private data member for the AppointmentID property
            mAppointmentID = 3;
            mCarRegNo = "4352 7GF";
            mCustomerID = 34;
            mStaffID = 2;
            mJobID = 6;
            mMOTDate = Convert.ToDateTime("26/03/2019");
            mMOTTimeID = 13;
            mActive = true;
            // always return true
            return true;
        }
    }
}