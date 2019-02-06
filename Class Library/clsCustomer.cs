using System;

namespace Class_Library
{
    public class clsCustomer
    {
        // Private?
        public int CarRegNo { get; set; }
        public string LastName { get; set; }

        public string Valid(string LastName, int CarRegNo)
        {
            // New variable Error
            string Error = "";
            // If CarRegNo is blank or 6 characters long
            if (CarRegNo.ToString().Length == 6 || CarRegNo.ToString().Length == 0)
            {
                // Return error message as blank
                Error = "";
            }
            // If CarRegNo is more than 6 characters long or less than 6 characters long
            if (CarRegNo.ToString().Length > 6 || CarRegNo.ToString().Length < 6)
            {
                // Return an error message
                Error = "Car registration number must be 6 numbers";
            }
            // If LastName is blank
            else if (LastName.Length == 0)
            {
                // Return an error message
                Error = "Last name cannot be blank";
            }
            // If LastName is less than 2 characters long
            else if (LastName.Length < 2)
            {
                // Return an error message
                Error = "Last name must be at least 2 characters long";
            }
            // If LastName is more than 40 characters long
            else if (LastName.Length > 40)
            {
                // Return an error message
                Error = "Last name cannot have more than 40 characters";
            }
            // Return the result
            return Error;
        }

        public string Find(int CarRegNo)
        {
            return "";
        }
    }
}