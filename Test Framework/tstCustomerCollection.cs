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
        public void UpdateMethodOK()
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
            // Modify the properties
            TestItem.AddressLine1 = "Grange 52a";
            TestItem.AddressLine2 = "Leicestershire";
            TestItem.Email = "test@test.com";
            TestItem.FirstName = "Smith";
            TestItem.LastName = "John";
            TestItem.PhoneNo = "+444777736641";
            TestItem.CarRegNo = "BG4F5F";
            // Assign the test variable into the real one
            AllCustomers.ThisCustomer = TestItem;
            // Update the record
            AllCustomers.Update();
            // Find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            // Check whether they match
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void ReportByCarRegNoMethodOK()
        {
            // New instance of clsCustomerCollection class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            // New instance of clsCustomerCollection class
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            // Apply a blank string (should return all records)
            FilteredCustomers.ReportByCarRegNo("");
            // Check whether they match
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByCarRegNoNoneFound()
        {
            // New instance of clsCustomerCollection class
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            // Apply a car registration number that doesn't exist
            FilteredCustomers.ReportByCarRegNo("xxxxxx");
            // Check whether they match
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByCarRegNoTestDataFound()
        {
            // New instance of clsCustomerCollection class
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            // New variable for recording if the data is OK (we assume it is)
            Boolean OK = true;
            // Apply a car registration number that doesn't exist
            FilteredCustomers.ReportByCarRegNo("Test C");
            // Check that the correct number of records are found
            if (FilteredCustomers.Count == 2)
            {
                // Check that the first record is ID 2
                if (FilteredCustomers.CustomerList[0].CustomerID != 2)
                {
                    OK = false;
                }
                // Check that the second record is ID 23
                if (FilteredCustomers.CustomerList[1].CustomerID != 23)
                {
                    OK = false;
                }
                // Check that the first records AddressLine1 data is OK
                if (FilteredCustomers.CustomerList[0].AddressLine1 != "Test AddressLine1                                 ")
                {
                    OK = false;
                }
                // Check that the second records AddressLine1 data is OK
                if (FilteredCustomers.CustomerList[1].AddressLine1 != "Test AddressLine1                                 ")
                {
                    OK = false;
                }
                // Check that the first records AddressLine2 data is OK
                if (FilteredCustomers.CustomerList[0].AddressLine2 != "Test AddressLine2                                                                                   ")
                {
                    OK = false;
                }
                // Check that the second records AddressLine2 data is OK
                if (FilteredCustomers.CustomerList[1].AddressLine2 != "Test AddressLine2                                                                                   ")
                {
                    OK = false;
                }
                // Check that the first records Email data is OK
                if (FilteredCustomers.CustomerList[0].Email != "Test Email                                                  ")
                {
                    OK = false;
                }
                // Check that the second records Email data is OK
                if (FilteredCustomers.CustomerList[1].Email != "Test Email                                                  ")
                {
                    OK = false;
                }
                // Check that the first records FirstName data is OK
                if (FilteredCustomers.CustomerList[0].FirstName != "Test FirstName           ")
                {
                    OK = false;
                }
                // Check that the second records FirstName data is OK
                if (FilteredCustomers.CustomerList[1].FirstName != "Test FirstName           ")
                {
                    OK = false;
                }
                // Check that the first records LastName data is OK
                if (FilteredCustomers.CustomerList[0].LastName != "Test LastName                           ")
                {
                    OK = false;
                }
                // Check that the second records LastName data is OK
                if (FilteredCustomers.CustomerList[1].LastName != "Test LastName                           ")
                {
                    OK = false;
                }
                // Check that the first records PhoneNo data is OK
                if (FilteredCustomers.CustomerList[0].PhoneNo != "+441231442641                 ")
                {
                    OK = false;
                }
                // Check that the second records PhoneNo data is OK
                if (FilteredCustomers.CustomerList[1].PhoneNo != "+441231442641                 ")
                {
                    OK = false;
                }
                // Check that the first records CarRegNo data is OK
                if (FilteredCustomers.CustomerList[0].CarRegNo != "Test C")
                {
                    OK = false;
                }
                // Check that the second records CarRegNo data is OK
                if (FilteredCustomers.CustomerList[1].CarRegNo != "Test C")
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            // Check whether it is true
            Assert.IsTrue(OK);
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