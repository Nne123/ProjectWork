using System;

namespace Class_Library
{
    public class clsAppointment
    {
        public string CarRegNo { get; set; }
        public int AppointmentID { get; set; }
        public DateTime MOTDate { get; set; }
        public int JobID { get; set; }
        public int CustomerID { get; set; }
        public int StaffID { get; set; }
        public int MOTTime { get; set; }
        public bool Active { get; set; }

        public string Valid(string carRegNo, string mOTDate, string CustomerID, string StaffID, string JobID, string MOTTime)
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
            // create a temporary variable to store the staff id
            Int32 MOTTimeTemp;


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
                if (CustomerIDTemp > 1111)
                {
                    Error = Error + "The CustomerID must be four digits : ";
                }
                if (CustomerIDTemp < 1111)
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
                if (StaffIDTemp > 1111)
                {
                    Error = Error + "The Staff ID must be four digits : ";
                }
                if (StaffIDTemp < 1111)
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
                if (JobIDTemp > 1111)
                {
                    Error = Error + "The Job ID must be four digits : ";
                }
                if (JobIDTemp < 1111)
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
                MOTTimeTemp = Convert.ToInt32(MOTTime);
                if (MOTTimeTemp < 10)
                {
                    Error = Error + "The MOT Time must be 10 or later ";
                }
                if (MOTTimeTemp > 16)
                {
                    Error = Error + "The MOT Time must be four digits : ";
                }
            }
            catch
            {
                Error = Error + "The MOT Time was not valid";
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
    }
}