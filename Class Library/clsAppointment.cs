using System;

namespace Class_Library
{
    public class clsAppointment
    {
        public string CarRegNo { get; set; }
        public int AppointmentID { get; set; }

        public string Valid(string carRegNo)
        {
            // if the carRegNo is not blank
            if (carRegNo != "")
            {
                // return a blank string
                return "";
            }
            else
            {
                // else return an error message
                return "The Car Reg No may not be blank!";
            }
        }
    }
}