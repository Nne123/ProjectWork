using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Test_Framework
{
    [TestClass]
    public class tstStaffCollection
    {
        private Int32 TestCount = 20;
        //private object mStaffList;

        private string TestActiveFound = "";

        public List<clsStaff> StaffList { get; private set; }
        public int Count { get; private set; }
        public clsStaff ThisStaff { get; private set; }

        //private object mStaffList;

        [TestMethod]
        //this is a test class 
        public void InstanceOK()
        {
            //create an instance of the class i want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see if it exists
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        //this is a test class 
        public void TwoRecordsPresent()
        {
            //create an instance of the class i want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see if it exists
            Assert.AreEqual(AllStaff.Count, 28);
        }

        //[TestMethod]
        //public void CountPropertyOK()
        //{
        //    // New instance of clsSatffCollection class
        //    clsStaffCollection AllStaff = new clsStaffCollection();
        //    // Create some list data to assignt to the property
        //    Int32 SomeCount = 0;
        //    //assign the data to the property
        //    AllStaff.Count = SomeCount;
        //    //Test to see that the two values are the same
        //    Assert.AreEqual(AllStaff.Count, SomeCount);
        //}

        [TestMethod]
        public void CountOK()
        {
            // New instance of clsSatffCollection class
            clsStaffCollection AllStaff = new clsStaffCollection();
            // Create a list named TestList
            List<clsStaff> TestList = new List<clsStaff>();
            // New instance of clsStaff class to create the item of test data
            clsStaff TestItem = new clsStaff();
            // Set its properties
            TestItem.Active = true;
            TestItem.AddressLine1 = "TestAddressLine1";
            TestItem.AddressLine2 = "TestAddressLine2";
            TestItem.StaffID = 28;
            TestItem.Email = "TestEmail";
            TestItem.FirstName = "TestFirstName";
            TestItem.LastName = "TestLastName";
            TestItem.PhoneNo = "12345678910";
            // Add the item to the test list
            TestList.Add(TestItem);
            // Assign the test variable into the real one
            AllStaff.StaffList = TestList;
            // Check whether they match
            Assert.AreEqual(AllStaff.Count, TestList.Count);

            ////create an instance of the class i want to create
            //clsStaffCollection AllStaff = new clsStaffCollection();
            //AllStaff.Count = TestCount;
            ////test to see if it exists
            //Assert.AreEqual(AllStaff.Count, TestCount);
        }

        [TestMethod]
        public void ThisStaffOK()
        {
            // New instance of clsStaffCollection class
            clsStaffCollection AllStaff = new clsStaffCollection();
            // New instance of clsStaff class to create the item of test data
            clsStaff TestStaff = new clsStaff();
            // Set its properties
            TestStaff.Active = true;
            TestStaff.AddressLine1 = "TestAddressLine1";
            TestStaff.AddressLine2 = "TestAddressLine2";
            TestStaff.StaffID = 28;
            TestStaff.Email = "TestEmail";
            TestStaff.FirstName = "TestFirstName";
            TestStaff.LastName = "TestLastName";
            TestStaff.PhoneNo = "12345678910";
            // Assign the test variable into the real one
            AllStaff.ThisStaff = TestStaff;
            // Check whether they match
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            // New instance of clsStaffCollection class
            clsStaffCollection AllStaff = new clsStaffCollection();
            // New instance of clsStaff class to create the item of test data
            clsStaff TestStaff = new clsStaff();
            // Set its properties
            TestStaff.Active = true;
            TestStaff.AddressLine1 = "TestAddressLine1";
            TestStaff.AddressLine2 = "TestAddressLine2";
            TestStaff.StaffID = 28;
            TestStaff.Email = "TestEmail";
            TestStaff.FirstName = "TestFirstName";
            TestStaff.LastName = "TestLastName";
            TestStaff.PhoneNo = "12345678910";
            // Assign the test variable into the real one
            AllStaff.ThisStaff = TestStaff;
            // Check whether they match
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            // New instance of clsStaffCollection cls
            clsStaffCollection AllStaffs = new clsStaffCollection();
            // Create a list named TestList
            List<clsStaff> TestList = new List<clsStaff>();
            // New instance of clsCustomer class to create the item of test data
            clsStaff TestItem = new clsStaff();
            // Set its properties
            TestItem.Active = true;
            TestItem.AddressLine1 = "TestAddressLine1";
            TestItem.AddressLine2 = "TestAddressLine2";
            TestItem.StaffID = 28;
            TestItem.Email = "TestEmail";
            TestItem.FirstName = "TestFirstName";
            TestItem.LastName = "TestLastName";
            TestItem.PhoneNo = "12345678910";
            // Add the item to the test list
            TestList.Add(TestItem);
            // Assign the test variable into the real one
            AllStaffs.StaffList = TestList;
            // Check whether they match
            Assert.AreEqual(AllStaffs.StaffList, TestList);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            // New instance of clsSatffCollection class
            clsStaffCollection AllStaff = new clsStaffCollection();
            // Create a list named TestList
            List<clsStaff> TestList = new List<clsStaff>();
            // New instance of clsStaff class to create the item of test data
            clsStaff TestItem = new clsStaff();
            // Set its properties
            TestItem.Active = true;
            TestItem.AddressLine1 = "TestAddressLine1";
            TestItem.AddressLine2 = "TestAddressLine2";
            TestItem.StaffID = 28;
            TestItem.Email = "TestEmail";
            TestItem.FirstName = "TestFirstName";
            TestItem.LastName = "TestLastName";
            TestItem.PhoneNo = "12345678910";
            // Add the item to the test list
            TestList.Add(TestItem);
            // Assign the test variable into the real one
            AllStaff.StaffList = TestList;
            // Check whether they match
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            // New instance of clsSatffCollection class
            clsStaffCollection AllStaff = new clsStaffCollection();
            // Create a list named TestList
            List<clsStaff> TestList = new List<clsStaff>();
            // New instance of clsStaff class to create the item of test data
            clsStaff TestItem = new clsStaff();
            // Set its properties
            TestItem.Active = true;
            TestItem.AddressLine1 = "TestAddressLine1";
            TestItem.AddressLine2 = "TestAddressLine2";
            TestItem.StaffID = 28;
            TestItem.Email = "TestEmail";
            TestItem.FirstName = "TestFirstName";
            TestItem.LastName = "TestLastName";
            TestItem.PhoneNo = "12345678910";
            // Add the item to the test list
            TestList.Add(TestItem);
            // Assign the test variable into the real one
            AllStaff.StaffList = TestList;
            // Check whether they match
            Assert.AreEqual(AllStaff.Count, TestList.Count);

            //// create an instance of the class we want to create
            //clsStaffCollection AllStaff = new clsStaffCollection();
            //// create the item of the test data
            //clsStaff TestItem = new clsStaff();
            //// var to store the primary key
            //Int32 PrimaryKey = 0;
            //// set its properties
            //TestItem.Active = true;
            //TestItem.StaffID = 4;
            //TestItem.FirstName = "Sam";
            //TestItem.LastName = "Gee";
            //TestItem.AddressLine1 = "2 Cloughton Avenueu";
            //TestItem.AddressLine2 = "38 Maidenwell Road";
            //TestItem.PhoneNo = "13787580223";
            //TestItem.Email = "sam@hotmail.com";
            //// set ThisStaff to the test data
            //AllStaff.ThisStaff = TestItem;
            //// add the record
            //PrimaryKey = AllStaff.Add();
            //// set the primary key of the test data
            //TestItem.StaffID = PrimaryKey;
            //// find the record
            //AllStaff.ThisStaff.Find(PrimaryKey);
            //// test to see that the two values are the same
            //Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            // New instance of clsSatffCollection class
            clsStaffCollection AllStaff = new clsStaffCollection();
            // Create a list named TestList
            List<clsStaff> TestList = new List<clsStaff>();
            // New instance of clsStaff class to create the item of test data
            clsStaff TestItem = new clsStaff();
            // Set its properties
            TestItem.Active = true;
            TestItem.AddressLine1 = "TestAddressLine1";
            TestItem.AddressLine2 = "TestAddressLine2";
            TestItem.StaffID = 28;
            TestItem.Email = "TestEmail";
            TestItem.FirstName = "TestFirstName";
            TestItem.LastName = "TestLastName";
            TestItem.PhoneNo = "12345678910";
            // Add the item to the test list
            TestList.Add(TestItem);
            // Assign the test variable into the real one
            AllStaff.StaffList = TestList;
            // Check whether they match
            Assert.AreEqual(AllStaff.Count, TestList.Count);


            //// create an instance of the class we want to create
            //clsStaffCollection AllStaff = new clsStaffCollection();
            //// create the item of the test data
            //clsStaff TestItem = new clsStaff();
            //// var to store the primary key
            //Int32 PrimaryKey = 0;
            //// set its properties
            //TestItem.Active = true;
            //TestItem.StaffID = 1;
            //TestItem.FirstName = "Shefika";
            //TestItem.LastName = "Sheta";
            //TestItem.AddressLine1 = "2 Cloughton Avenue";
            //TestItem.AddressLine2 = "38 Maidenwell Road";
            //TestItem.PhoneNo = "13786580223";
            //TestItem.Email = "shefika@hotmail.com";
            //// set ThisStaff to the test data
            //AllStaff.ThisStaff = TestItem;
            //// add the record
            //PrimaryKey = AllStaff.Add();
            //// set the primary key of the test data
            //TestItem.StaffID = PrimaryKey;
            //// find the record
            //AllStaff.ThisStaff.Find(PrimaryKey);
            //// delete the record
            //AllStaff.Delete();
            //// now find the record
            //Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            //// test to see that the two values are the same
            //Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            // New instance of clsSatffCollection class
            clsStaffCollection AllStaff = new clsStaffCollection();
            // Create a list named TestList
            List<clsStaff> TestList = new List<clsStaff>();
            // New instance of clsStaff class to create the item of test data
            clsStaff TestStaff = new clsStaff();
            // Set its properties
            TestStaff.Active = true;
            TestStaff.AddressLine1 = "TestAddressLine1";
            TestStaff.AddressLine2 = "TestAddressLine2";
            TestStaff.StaffID = 28;
            TestStaff.Email = "TestEmail";
            TestStaff.FirstName = "TestFirstName";
            TestStaff.LastName = "TestLastName";
            TestStaff.PhoneNo = "12345678910";
            // Add the item to the test list
            //TestList.Add(TestStaff);
            // Assign the test variable into the real one
            AllStaff.StaffList = TestList;
            // Check whether they match
            Assert.AreEqual(AllStaff.Count, TestList.Count);

            //// create an instance of the class we want to create
            //clsStaffCollection AllStaff = new clsStaffCollection();
            //// create the item of the test data
            //clsStaff TestItem = new clsStaff();
            //// var to store the primary key
            //Int32 PrimaryKey = 0;
            //// set its properties
            //TestItem.Active = true;
            //TestItem.StaffID = 5;
            //TestItem.FirstName = "Tom";
            //TestItem.LastName = "Mike";
            //TestItem.AddressLine1 = "10 Cloughton Avenue";
            //TestItem.AddressLine2 = "69 Maidenwell Road";
            //TestItem.PhoneNo = "8658055543";
            //TestItem.Email = "Tom@hotmail.com";
            //// set ThisStaff to the test data
            //AllStaff.ThisStaff = TestItem;
            //// add the record
            //PrimaryKey = AllStaff.Add();
            //// set the primary key of the test data
            //TestItem.StaffID = PrimaryKey;
            //// modify the test data
            //TestItem.Active = true;
            //TestItem.StaffID = 2;
            //TestItem.FirstName = "Samsss";
            //TestItem.LastName = "S";
            //TestItem.AddressLine1 = "2 Maidenwell";
            //TestItem.AddressLine2 = "38  Road";
            //TestItem.PhoneNo = "1378653";
            //TestItem.Email = "sh@hotmail.com";
            //// set the record based on the new test data
            //AllStaff.ThisStaff = TestItem;
            //// update the record
            //AllStaff.Update();
            //// find the record
            //AllStaff.ThisStaff.Find(PrimaryKey);
            //// test to see that the two values are the same
            //Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }
    }
}

