using System;

namespace Class_Library
{
    public class clsCustomer
    {
        public string CarRegNo { get; set; }
        public string LastName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string PhoneNo { get; set; }
        public int CustomerID { get; set; }

        public string Valid(string AddressLine1, string AddressLine2, string Email, string FirstName, string LastName, string PhoneNo, string CarRegNo)
        {
            // New variable for the Error
            String Error = "";
            // If CarRegNo is not 6 characters long
            if (CarRegNo.ToString().Length > 6 || CarRegNo.ToString().Length < 6)
            {
                // Return an error message
                Error = "Car registration number must be 6 characters long.";
            }
            // If AddressLine1 is more than 50 characters long
            if (AddressLine1.Length > 50)
            {
                // Return an error message
                Error = "Address Line 1 cannot have more than 50 characters.";
            }
            // If AddressLine2 is more than 100 characters long
            if (AddressLine2.Length > 100)
            {
                // Return an error message
                Error = "Address Line 2 cannot have more than 100 characters.";
            }
            // If Email is more than 60 characters long
            if (Email.Length > 60)
            {
                // Return an error message
                Error = "Email cannot have more than 60 characters";
            }
            // If Email is less than 5 characters long
            if (Email.Length < 5)
            {
                // Return an error message
                Error = "Email must be at least 5 characters long.";
            }
            // If FirstName is blank
            if (FirstName.Length == 0)
            {
                // Return an error message
                Error = "First name cannot be blank.";
            }
            // If FirstName is less than 2 characters long
            if (FirstName.Length < 2)
            {
                // Return an error message
                Error = "First name must be at least 2 characters long.";
            }
            // If FirstName is more than 40 characters long
            if (FirstName.Length > 25)
            {
                // Return an error message
                Error = "First name cannot have more than 25 characters.";
            }
            // If LastName is blank
            if (LastName.Length == 0)
            {
                // Return an error message
                Error = "Last name cannot be blank.";
            }
            // If LastName is less than 2 characters long
            if (LastName.Length < 2)
            {
                // Return an error message
                Error = "Last name must be at least 2 characters long.";
            }
            // If LastName is more than 40 characters long
            if (LastName.Length > 40)
            {
                // Return an error message
                Error = "Last name cannot have more than 40 characters.";
            }
            // If PhoneNo is blank
            if (PhoneNo.Length == 0)
            {
                // Return an error message
                Error = "Phone number cannot be blank.";
            }
            // If PhoneNo is less than 5 characters long
            if (PhoneNo.Length < 5)
            {
                // Return an error message
                Error = "Phone number must be at least 5 characters long.";
            }
            // If PhoneNo is more than 30 characters long
            if (PhoneNo.Length > 30)
            {
                // Return an error message
                Error = "Phone number cannot have more than 30 characters.";
            }
            // Return the result
            return Error;
        }
    }
}