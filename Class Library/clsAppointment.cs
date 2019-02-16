using System;

namespace Class_Library
{
    public class clsAppointment
    {
        public string CarRegNo { get; set; }
        public int AppointmentID { get; set; }
        public DateTime MOTDate { get; set; }

        public string Valid(string carRegNo)
        {
            // string variable to store the error message
            string Error = "";
            // create a temporary variable to store date values
            //DateTime DateTemp;
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

            return Error;
        }
    }
}