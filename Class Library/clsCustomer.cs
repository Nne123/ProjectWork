using System;

namespace Class_Library
{
    public class clsCustomer
    {
        // Private data member for the CustomerID property
        private Int32 mCustomerID;
        // Private data member for the CarRegNo property
        private String mCarRegNo;
        // Private data member for the LastName property
        private String mLastName;
        // Private data member for the AddressLine1 property
        private String mAddressLine1;
        // Private data member for the AddressLine2 property
        private String mAddressLine2;
        // Private data member for the Email property
        private String mEmail;
        // Private data member for the FirstName property
        private String mFirstName;
        // Private data member for the PhoneNo property
        private String mPhoneNo;

        public string Valid(string AddressLine1, string AddressLine2, string Email, string FirstName, string LastName, string PhoneNo, string CarRegNo)
        {
            // New variable for the Error
            String Error = "";
            // If CarRegNo is not 6 characters long
            if (CarRegNo.ToString().Length > 6 || CarRegNo.ToString().Length < 6)
            {
                // Return an error message
                Error = Error + "Car registration number must be 6 characters long. ";
            }
            // If AddressLine1 is more than 50 characters long
            if (AddressLine1.Length > 50)
            {
                // Return an error message
                Error = Error + "Address Line 1 cannot have more than 50 characters. ";
            }
            // If AddressLine2 is more than 100 characters long
            if (AddressLine2.Length > 100)
            {
                // Return an error message
                Error = Error + "Address Line 2 cannot have more than 100 characters. ";
            }
            // If Email is more than 60 characters long
            if (Email.Length > 60)
            {
                // Return an error message
                Error = Error + "Email cannot have more than 60 characters. ";
            }
            // If Email is less than 5 characters long
            if (Email.Length < 5)
            {
                // Return an error message
                Error = Error + "Email must be at least 5 characters long. ";
            }
            // If FirstName is blank
            if (FirstName.Length == 0)
            {
                // Return an error message
                Error = Error + "First name cannot be blank. ";
            }
            // If FirstName is less than 2 characters long
            if (FirstName.Length < 2)
            {
                // Return an error message
                Error = Error + "First name must be at least 2 characters long. ";
            }
            // If FirstName is more than 40 characters long
            if (FirstName.Length > 25)
            {
                // Return an error message
                Error = Error + "First name cannot have more than 25 characters. ";
            }
            // If LastName is blank
            if (LastName.Length == 0)
            {
                // Return an error message
                Error = Error + "Last name cannot be blank. ";
            }
            // If LastName is less than 2 characters long
            if (LastName.Length < 2)
            {
                // Return an error message
                Error = Error + "Last name must be at least 2 characters long. ";
            }
            // If LastName is more than 40 characters long
            if (LastName.Length > 40)
            {
                // Return an error message
                Error = Error + "Last name cannot have more than 40 characters. ";
            }
            // If PhoneNo is blank
            if (PhoneNo.Length == 0)
            {
                // Return an error message
                Error = Error + "Phone number cannot be blank. ";
            }
            // If PhoneNo is less than 5 characters long
            if (PhoneNo.Length < 5)
            {
                // Return an error message
                Error = Error + "Phone number must be at least 5 characters long. ";
            }
            // If PhoneNo is more than 30 characters long
            if (PhoneNo.Length > 30)
            {
                // Return an error message
                Error = Error + "Phone number cannot have more than 30 characters. ";
            }
            // Return the result
            return Error;
        }

        public bool Find(int CustomerID)
        {
            // New instance of clsDataConnection class
            clsDataConnection DB = new clsDataConnection();
            // Add the parameter for the CustomerID to search for
            DB.AddParameter("@CustomerID", CustomerID);
            // Execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            // If one record is found (should be either one or zero)
            if (DB.Count == 1)
            {
                // Copy the data from the database to the private data members
                mAddressLine1 = Convert.ToString(DB.DataTable.Rows[0]["AddressLine1"]);
                mAddressLine2 = Convert.ToString(DB.DataTable.Rows[0]["AddressLine2"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mPhoneNo = Convert.ToString(DB.DataTable.Rows[0]["PhoneNo"]);
                mCarRegNo = Convert.ToString(DB.DataTable.Rows[0]["CarRegNo"]);
                // Return that everything worked OK
                return true;
            }
            // If no record was found (should be either one or zero)
            else
            {
                // Return false indicating a problem
                return false;
            }
        }

        // Public property for the customer id
        public int CustomerID
        {
            get
            {
                // Return the private data
                return mCustomerID;
            }
            set
            {
                // Set the private data
                mCustomerID = value;
            }
        }

        // Public property for the car registration number
        public string CarRegNo
        {
            get
            {
                // Return the private data
                return mCarRegNo;
            }
            set
            {
                // Set the private data
                mCarRegNo = value;
            }
        }

        // Public property for the last name
        public string LastName
        {
            get
            {
                // Return the private data
                return mLastName;
            }
            set
            {
                // Set the private data
                mLastName = value;
            }
        }

        // Public property for the address line 1
        public string AddressLine1
        {
            get
            {
                // Return the private data
                return mAddressLine1;
            }
            set
            {
                // Set the private data
                mAddressLine1 = value;
            }
        }

        // Public property for the address line 2
        public string AddressLine2
        {
            get
            {
                // Return the private data
                return mAddressLine2;
            }
            set
            {
                // Set the private data
                mAddressLine2 = value;
            }
        }

        // Public property for the email
        public string Email
        {
            get
            {
                // Return the private data
                return mEmail;
            }
            set
            {
                // Set the private data
                mEmail = value;
            }
        }

        // Public property for the first name
        public string FirstName
        {
            get
            {
                // Return the private data
                return mFirstName;
            }
            set
            {
                // Set the private data
                mFirstName = value;
            }
        }

        // Public property for the phone number
        public string PhoneNo
        {
            get
            {
                // Return the private data
                return mPhoneNo;
            }
            set
            {
                // Set the private data
                mPhoneNo = value;
            }
        }
    }
}