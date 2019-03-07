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
        public void AddMethodOK()
        {
            // New instance of clsCustomerCollection class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            // New instance of clsCustomer class to create the item of test data
            clsCustomer TestItem = new clsCustomer();
            // New variable for the primary key
            Int32 PrimaryKey = 0;
            // Set its properties
            TestItem.AddressLine1 = "Grange 51a";
            TestItem.AddressLine2 = "Leicester";
            TestItem.CustomerID = 1;
            TestItem.Email = "test@test.com";
            TestItem.FirstName = "John";
            TestItem.LastName = "Smith";
            TestItem.PhoneNo = "+444656446641";
            TestItem.CarRegNo = "AF3E4E";
            // Assign the test variable into the real one
            AllCustomers.ThisCustomer = TestItem;
            // Add the record
            PrimaryKey = AllCustomers.Add();
            // Assign the primary key into the real one
            TestItem.CustomerID = PrimaryKey;
            // Find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            // Check whether they match
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            // New instance of clsCustomerCollection class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            // New instance of clsCustomer class to create the item of test data
            clsCustomer TestItem = new clsCustomer();
            // New variable for the primary key
            Int32 PrimaryKey = 0;
            // Set its properties
            TestItem.AddressLine1 = "Grange 51a";
            TestItem.AddressLine2 = "Leicester";
            TestItem.CustomerID = 1;
            TestItem.Email = "test@test.com";
            TestItem.FirstName = "John";
            TestItem.LastName = "Smith";
            TestItem.PhoneNo = "+444656446641";
            TestItem.CarRegNo = "AF3E4E";
            // Assign the test variable into the real one
            AllCustomers.ThisCustomer = TestItem;
            // Add the record
            PrimaryKey = AllCustomers.Add();
            // Assign the primary key into the real one
            TestItem.CustomerID = PrimaryKey;
            // Find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            // Delete the record
            AllCustomers.Delete();
            // New variable for anything that was found
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            // Check whether the record was not found
            Assert.IsFalse(Found);
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
    }
}