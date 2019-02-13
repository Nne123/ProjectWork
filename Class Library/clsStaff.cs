namespace Class_Library
{
    public class clsStaff
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string StaffID { get; set; }

        public string Valid(string FirstName, string LastName)
        {
            string Error = "";
            if (LastName.ToString().Length == 15 || LastName.ToString().Length == 0)
            {
                Error = "";
            }
            if (LastName.ToString().Length > 4 || LastName.ToString().Length < 4)
            {
                Error = "LasttName must be 4 letters long";
            }
            //if firstName is blank
            else if (FirstName.Length == 0)
            {
                //return an error message
                Error = "First Name cant be blank";
            }
            //if FirstName is less than 4 characters long, display error message
            else if (FirstName.Length < 4)
            {
                //display an error message
                Error = "First Name must be at least 4 characters long or more";
            }
            //if first name is more than 50 characters display an error message
            else if (FirstName.Length > 50)
            {
                //display an error message
                Error = "First Name can't have 50 characters, too long.";
            }
            //return the results
            return Error;
        }
        public string Find(string Search)
        {
            string Error = "";
            if (LastName.ToString().Length == 15 || LastName.ToString().Length == 0)
            {
                Error = "";
            }
            if (LastName.ToString().Length > 4 || LastName.ToString().Length < 4)
            {
                Error = "LasttName must be 4 letters long";
            }


            //if firstName is blank
            else if (FirstName.Length == 0)
            {
                //return an error message
                Error = "First Name cant be blank";
            }
            //if FirstName is less than 4 characters long, display error message
            else if (FirstName.Length < 4)
            {
                //display an error message
                Error = "First Name must be at least 4 characters long or more";
            }
            //if first name is more than 50 characters display an error message
            else if (FirstName.Length > 50)
            {
                //display an error message
                Error = "First Name can't have 50 characters, too long.";
            }


            else if (PhoneNo.Length == 0)
            {
                //return an error message
                Error = "PhoneNo cant be blank";
            }
            //if FirstName is less than 4 characters long, display error message
            else if (PhoneNo.Length < 4)
            {
                //display an error message
                Error = "PhoneNo must be at least 4 characters long or more";
            }
            //if first name is more than 50 characters display an error message
            else if (PhoneNo.Length > 50)
            {
                //display an error message
                Error = "PhoneNo can't have 50 characters, too long.";
            }


            else if (Email.Length == 0)
            {
                //return an error message
                Error = "Email can't be blank";
            }
            //if Email is less than 4 characters long, display error message
            else if (Email.Length < 4)
            {
                //display an error message
                Error = "Email must be at least 4 characters long or more";
            }
            //if Email is more than 50 characters display an error message
            else if (Email.Length > 50)
            {
                //display an error message
                Error = "Email can't have 50 characters, too long.";
            }
            else if (Search.ToString().Length == 0)
            {
                Error = "The search field has to contain something";
            }

            else if (StaffID.Length == 0)
            {
                //return an error message
                Error = "StaffID cant be blank";
            }
            //if StaffID is less than 4 characters long, display error message
            else if (StaffID.Length < 6)
            {
                //display an error message
                Error = "StaffID must be at least 6 characters long or more";
            }
            //if first name is more than 50 characters display an error message
            else if (StaffID.Length > 50)
            {
                //display an error message
                Error = "StaffID can't have 50 characters, too long.";
            }
            //return the results
            //
            return Error;
        }

         public string Add(string StaffID)
         {
            string Error = "";
            if (StaffID.ToString().Length == 0)
            {
                Error = "The StaffID can't be blank";
            }
            return Error;
        }
    }
}