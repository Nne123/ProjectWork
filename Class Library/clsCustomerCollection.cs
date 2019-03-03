using System.Collections.Generic;

namespace Class_Library
{
    public class clsCustomerCollection
    {
        public clsCustomer ThisCustomer { get; set; }
        // Private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        // Public property for the customer list
        public List<clsCustomer> CustomerList
        {
            get
            {
                // Return the private data
                return mCustomerList;
            }
            set
            {
                // Set the private data
                mCustomerList = value;
            }
        }

        // Public property for count
        public int Count
        {
            get
            {
                // Return the count of the list
                return mCustomerList.Count;
            }
            set
            {
                // later
            }
        }
    }
}