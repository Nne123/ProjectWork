using System;

namespace Class_Library
{
    public class clsStaff
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public int StaffID { get; set; }
        public string Error { get; private set; }

        public string Valid(string FirstName, string LastName, string AddressLine1, string AddressLine2, string PhoneNo, string Email, int StaffID)
        {
            // If AddressLine1 is more than 50 characters long
            if (AddressLine1.Length > 50)
            {
                // Return an error message
                Error = "AddressLine1 cannot have more than 50 characters";
            }
            // If AddressLine2 is more than 100 characters long
            if (AddressLine2.Length > 100)
            {
                // Return an error message
                Error = "AddressLine2 cannot have more than 100 characters";
            }
            // If FirstName is blank
            else if (FirstName.Length == 0)
            {
                // Return an error message
                Error = "First name cannot be blank";
            }
            // If FirstName is less than 2 characters long
            else if (FirstName.Length < 9)
            {
                // Return an error message
                Error = "First name must be at least 2 characters long";
            }
            // If FirstName is more than 40 characters long
            else if (FirstName.Length > 40)
            {
                // Return an error message
                Error = "First name cannot have more than 40 characters";
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

        public string Valid()
        {
            throw new NotImplementedException();
        }

        public string Valid(string firstName)
        {
            throw new NotImplementedException();
        }
    }
}