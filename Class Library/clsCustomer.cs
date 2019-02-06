using System;

namespace Class_Library
{
    public class clsCustomer
    {
        public int CarRegNo { get; set; }
        public string LastName { get; set; }

        public string Valid(string LastName, int CarRegNo)
        {
            string Error = "";
            // If CarRegNo is not blank
            if (CarRegNo.ToString().Length == 6 || CarRegNo.ToString().Length == 0)
            {
                Error = "";
            }
            if (CarRegNo.ToString().Length > 6 || CarRegNo.ToString().Length < 6)
            {
                // Otherwise return an error message
                Error = "Car registration number must be 6 numbers";
            }
            else if (LastName.Length == 0)
            {
                // Otherwise return an error message
                Error = "Last name cannot be blank.";
            }
            else if (LastName.Length < 2)
            {
                // Otherwise return an error message
                Error = "Last name must be at least 2 characters long";
            }
            else if (LastName.Length > 40)
            {
                // Otherwise return an error message
                Error = "Last name cannot have more than 40 characters";
            }
            return Error;
        }
    }
}