using System;

namespace Class_Library
{
    // cls Staff Variable
    public class clsStaff
    {
        private int mStaffID;
        private string mAddressLine1;
        private string mAddressLine2;
        private string mFirstName;
        private string mLastName;
        private string mPhoneNo;
        private string mEmail;
        private bool mActive;
        private string mThisStaffOK;
        private string mStaffListOK;
        private string mAddMethodOK;
        private string mDeleteMethodOK;
        private string mUpdateMethodOK;

        public string AddressLine1
        {
            get
            {
                // return the private data
                return mAddressLine1;
            }
            set
            {
                // set the value of the private data member
                mAddressLine1 = value;
            }
        }
        public bool Active
        {
            get
            {
                // return the private data
                return mActive;
            }
            set
            {
                // set the value of the private data member
                mActive = value;
            }
        }
        public int StaffID
        {
            get
            {
                // return the private data
                return mStaffID;
            }
            set
            {
                // set the value of the private data member
                mStaffID = value;
            }
        }

        public string AddressLine2
        {
            get
            {
                // return the private data
                return mAddressLine2;
            }
            set
            {
                // set the value of the private data member
                mAddressLine2 = value;
            }
        }

        public string FirstName
        {
            get
            {
                // return the private data
                return mFirstName;
            }
            set
            {
                // set the value of the private data member
                mFirstName = value;
            }
        }


        public string LastName
        {
            get
            {
                // return the private data
                return mLastName;
            }
            set
            {
                // set the value of the private data member
                mLastName = value;
            }
        }


        public string PhoneNo
        {
            get
            {
                // return the private data
                return mPhoneNo;
            }
            set
            {
                // set the value of the private data member
                mPhoneNo = value;
            }
        }

        public string Email
        {
            get
            {
                // return the private data
                return mEmail; 
            }
            set
            {
                // set the value of the private data member
                mEmail = value;
            }
        }

        public string StaffListOK
        {
            get
            {
                // return the private data
                return mStaffListOK;
            }
            set
            {
                // set the value of the private data member
                mStaffListOK = value;
            }
        }

        public string ThisStaffOK
        {
            get
            {
                // return the private data
                return mThisStaffOK;
            }
            set
            {
                // set the value of the private data member
                mThisStaffOK = value;
            }
        }

        public string AddMethodOK
        {
            get
            {
                // return the private data
                return mAddMethodOK;
            }
            set
            {
                // set the value of the private data member
                mAddMethodOK = value;
            }
        }

        public string DeleteMethodOK
        {
            get
            {
                // return the private data
                return mDeleteMethodOK;
            }
            set
            {
                // set the value of the private data member
                mDeleteMethodOK = value;
            }
        }

        public string UpdateMethodOK
        {
            get
            {
                // return the private data
                return mUpdateMethodOK;
            }
            set
            {
                // set the value of the private data member
                mUpdateMethodOK = value;
            }
        }
        //public int StaffID { get; internal set; }

        //// Private data member for the Staff FirstName property
        //public string FirstName { get; set; }
        //// Private data member for the Staff LastName property
        //public string LastName { get; set; }
        //// Private data member for the Staff AddressLine1 property
        //public string AddressLine1 { get; set; }
        //// Private data member for the Staff AddressLine2 property
        //public string AddressLine2 { get; set; }
        //// Private data member for the Staff PhoneNo property
        //public string PhoneNo { get; set; }
        //// Private data member for the Staff Email property
        //public string Email { get; set; }
        //// Private data member for the StaffID property
        //public int StaffID { get; set; }
        //// Private data member for the Error property
        //public string Error { get; private set; }

        public string Valid(string FirstName, string LastName, string AddressLine1, string AddressLine2, string PhoneNo, string Email, int StaffID)
        {
            // string variable to store the error message
            string Error = "";
            //// create a temporary variable to store date values
            //Int32 FirstName;
            //// create a temporary variable to store the customer id
            //Int32 StaffID;
            //// create a temporary variable to store the staff id
            //Int32 LastName;
            //// create a temporary variable to store the staff id
            //Int32 AddressLine1;

            //if (FirstName != "")
            //{
            //    return "";
            //}
            //else
            //{
            //    return "The First Name must not be blank";
            //}

            // If AddressLine1 is more than 50 characters long
            if (AddressLine1.Length > 50)
            {
                // Return an error message
                Error = "AddressLine1 cant have more than 50 characters";
            }
            // If AddressLine2 is more than 100 characters long
            else if (AddressLine2.Length > 100)
            {
                // Return an error message
                Error = "AddressLine2 cant have more than 100 characters";
            }
            // If FirstName is blank
            if (FirstName.Length == 0)
            {
                // Return an error message
                Error = "First Name can't be blank";
            }
            // If FirstName is less than 2 characters long
            else if (FirstName.Length < 2)
            {
                // Return an error message
                Error = "First name must be at least 2 characters long or more";
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
                Error = "Last name must be at least 2 characters long or more";
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
            //if email is less than 5 characters long 
            else if (Email.Length > 5)
            {
                //return an error message saying 
                Error = "Email cant be less than 5 characters long";
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
                Error = "Phone number can't be 25 characters long";
            }
            // Return the result
            return Error;
        }

        public bool Find(int StaffID)
        {
            // create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // add the parameter for the appointment no to search for
            DB.AddParameter("@StaffID", StaffID);
            // execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffID");
            // if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                // set the private data member for the AppointmentID property
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mAddressLine1 = Convert.ToString(DB.DataTable.Rows[0]["AddressLine1"]);
                mAddressLine2 = Convert.ToString(DB.DataTable.Rows[0]["AddressLine2"]);
                mPhoneNo = Convert.ToString(DB.DataTable.Rows[0]["PhoneNo"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                // return that everything worked OK
                return true;
            }
            // if no record was found
            else
            {
                // return false indicating a problem
                return false;
            }
        }

        //public bool Add(int StaffID)
        //{
        //    // create an instance of the data connection
        //    clsDataConnection DB = new clsDataConnection();
        //    // add the parameter for the appointment no to search for
        //    DB.AddParameter("@StaffID", StaffID);
        //    // execute the stored procedure
        //    DB.Execute("sproc_tblStaff_FilterByStaffID");
        //    // if one record is found (there should be either one or zero)
        //    if (DB.Count == 1)
        //    {
        //        // set the private data member for the AppointmentID property
        //        mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
        //        mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
        //        mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
        //        mAddressLine1 = Convert.ToString(DB.DataTable.Rows[0]["AddressLine1"]);
        //        mAddressLine2 = Convert.ToString(DB.DataTable.Rows[0]["AddressLine2"]);
        //        mPhoneNo = Convert.ToString(DB.DataTable.Rows[0]["PhoneNo"]);
        //        mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
        //        mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
        //        // return that everything worked OK
        //        return true;
        //    }
        //    // if no record was found
        //    else
        //    {
        //        // return false indicating a problem
        //        return false;
        //    }
        //}

    }
}







