using System;

namespace Class_Library
{
    public class clsStaff
    {
        // Private data member for the Staff FirstName property
        public string FirstName { get; set; }
        // Private data member for the Staff LastName property
        public string LastName { get; set; }
        // Private data member for the Staff AddressLine1 property
        public string AddressLine1 { get; set; }
        // Private data member for the Staff AddressLine2 property
        public string AddressLine2 { get; set; }
        // Private data member for the Staff PhoneNo property
        public string PhoneNo { get; set; }
        // Private data member for the Staff Email property
        public string Email { get; set; }
        // Private data member for the StaffID property
        public int StaffID { get; set; }
        // Private data member for the Error property
        public string Error { get; private set; }

        public string Valid(string FirstName, string LastName, string AddressLine1, string AddressLine2, string PhoneNo, string Email, int StaffID)
        {
            //new variable Error
            string Error = "";
            // If AddressLine1 is more than 50 characters long
            if (AddressLine1.Length > 50)
            {
                // Return an error message
                Error = "AddressLine1 cant have more than 50 characters";
            }
            // If AddressLine2 is more than 100 characters long
           else  if (AddressLine2.Length > 100)
            {
                // Return an error message
                Error = "AddressLine2 cant have more than 100 characters";
            }
            // If FirstName is blank
            if (FirstName.Length == 0)
            {
                // Return an error message
                Error = "First name cant be blank";
            }
            // If FirstName is less than 2 characters long
            else if (FirstName.Length < 2)
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
            if (LastName.Length == 0)
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
            //if email is more than 40 characters long 
            if (Email.Length > 40)
            {
                //return an error message saying 
                Error = "Email cant be 40 characters long";
            }
            //if email is less than 6 characters long 
            else if (Email.Length > 6)
            {
                //return an error message saying 
                Error = "Email cant be less than 6 characters long";
            }
            //if phone number is blank
            if (PhoneNo.Length == 0)
            {
                //return an error message saying 
                Error = "Phone Number cant be blank";
            }
            //if phone number is less than 11 characters long 
            else if (PhoneNo.Length < 11)
            {
                //return an error message saying 
                Error = "Phone number must be at least 11 characters long";
            }
            //if phone number is more than 25 characters long 
            else if (PhoneNo.Length > 25)
            {
                //return an error message saying 
                Error = "Phone number cant be 25 characters long";
            }
            // Return the result
            return Error;
        }
    }
}