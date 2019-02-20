using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstCustomerCollection
    {
        // New testing variable TestCount with some test data
        Int32 TestCount = 10;

        [TestMethod]
        public void InstanceOK()
        {
            // New instance of clsCustomerCollection class
            clsCustomerCollection Customers = new clsCustomerCollection();
            // Check whether the instance exists
            Assert.IsNotNull(Customers);
        }

        [TestMethod]
        public void CountOK()
        {
            // New instance of clsCustomerCollection class
            clsCustomerCollection Customers = new clsCustomerCollection();
            // Assign the test variable into the real one
            Customers.Count = TestCount;
            // Check whether they match
            Assert.AreEqual(Customers.Count, TestCount);
        }

        //[TestMethod]
        //public void AddMethodOK()
        //{
        //    // New instance of clsCustomerCollection class
        //    clsCustomerCollection Customers = new clsCustomerCollection();
        //    // New variable Error
        //    String Error = "";
        //    // Check if there is an error message returned
        //    Error = Customers.Add(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
        //    // Check whether there is an error
        //    Assert.AreEqual(Error, "");
        //}

        //[TestMethod]
        //public void UpdateMethodOK()
        //{
        //    // New instance of clsCustomerCollection class
        //    clsCustomerCollection Customers = new clsCustomerCollection();
        //    // New variable Error
        //    String Error = "";
        //    // Check if there is an error message returned
        //    Error = Customers.Update(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
        //    // Check whether there is an error
        //    Assert.AreEqual(Error, "");
        //}
    }
}