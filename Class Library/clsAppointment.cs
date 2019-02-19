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

        public string Valid(string carRegNo, string mOTDate)
        {
            // string variable to store the error message
            string Error = "";
            // create a temporary variable to store date values
            DateTime DateTemp;
            // if the name of the car reg no is not blank
            if (carRegNo.Length > 8)
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