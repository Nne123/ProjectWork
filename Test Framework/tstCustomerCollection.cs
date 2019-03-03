using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Test_Framework
{
    [TestClass]
    public class tstCustomerCollection
    {
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
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            // Variable SomeCount with some test data
            Int32 SomeCount = 0;
            // Assign the test variable into the real one
            AllCustomers.Count = SomeCount;
            // Check whether they match
            Assert.AreEqual(AllCustomers.Count, SomeCount);
        }

        [TestMethod]
        public void ThisCustomerOK()
        {
            // New instance of clsCustomerCollection class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            // New instance of clsCustomer class to create the item of test data
            clsCustomer TestCustomer = new clsCustomer();
            // Set its properties
            TestCustomer.AddressLine1 = "Grange 51a";
            TestCustomer.AddressLine2 = "Leicester";
            TestCustomer.CustomerID = 1;
            TestCustomer.Email = "test@test.com";
            TestCustomer.FirstName = "John";
            TestCustomer.LastName = "Smith";
            TestCustomer.PhoneNo = "+444656446641";
            TestCustomer.CarRegNo = "AF3E4E";
            // Assign the test variable into the real one
            AllCustomers.ThisCustomer = TestCustomer;
            // Check whether they match
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            // New instance of clsCustomerCollection class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            // Create a list named TestList
            List<clsCustomer> TestList = new List<clsCustomer>();
            // New instance of clsCustomer class to create the item of test data
            clsCustomer TestItem = new clsCustomer();
            // Set its properties
            TestItem.AddressLine1 = "Grange 51a";
            TestItem.AddressLine2 = "Leicester";
            TestItem.CustomerID = 1;
            TestItem.Email = "test@test.com";
            TestItem.FirstName = "John";
            TestItem.LastName = "Smith";
            TestItem.PhoneNo = "+444656446641";
            TestItem.CarRegNo = "AF3E4E";
            // Add the item to the test list
            TestList.Add(TestItem);
            // Assign the test variable into the real one
            AllCustomers.CustomerList = TestList;
            // Check whether they match
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            // New instance of clsCustomerCollection class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            // Create a list named TestList
            List<clsCustomer> TestList = new List<clsCustomer>();
            // New instance of clsCustomer class to create the item of test data
            clsCustomer TestItem = new clsCustomer();
            // Set its properties
            TestItem.AddressLine1 = "Grange 51a";
            TestItem.AddressLine2 = "Leicester";
            TestItem.CustomerID = 1;
            TestItem.Email = "test@test.com";
            TestItem.FirstName = "John";
            TestItem.LastName = "Smith";
            TestItem.PhoneNo = "+444656446641";
            TestItem.CarRegNo = "AF3E4E";
            // Add the item to the test list
            TestList.Add(TestItem);
            // Assign the test variable into the real one
            AllCustomers.CustomerList = TestList;
            // Check whether they match
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
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