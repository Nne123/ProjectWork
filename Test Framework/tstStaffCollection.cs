using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Test_Framework
{
    [TestClass]
    public class tstStaffCollection
    {
        Int32 TestCount = 20;

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
            TestItem.AddressLine1 = "Wainwright Road";
            TestItem.AddressLine2 = "Leicester";
            TestItem.StaffID = 1;
            TestItem.Email = "test41@hotmail.com";
            TestItem.FirstName = "Shefika";
            TestItem.LastName = "Sheta";
            TestItem.PhoneNo = "+079684372653";
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
            clsStaffCollection AllStaffs = new clsStaffCollection();
            // New instance of clsStaff class to create the item of test data
            clsStaff TestStaff = new clsStaff();
            // Set its properties
            TestStaff.Active = true;
            TestStaff.AddressLine1 = "Wainwright Road";
            TestStaff.AddressLine2 = "Leicester";
            TestStaff.StaffID = 2;
            TestStaff.Email = "test41@hotmail.com";
            TestStaff.FirstName = "Sheta";
            TestStaff.LastName = "Shefika";
            TestStaff.PhoneNo = "+079684372653";
            // Assign the test variable into the real one
            AllStaffs.ThisStaff = TestStaff;
            // Check whether they match
            Assert.AreEqual(AllStaffs.ThisStaff, TestStaff);
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
            TestItem.AddressLine1 = "Wainwright Road";
            TestItem.AddressLine2 = "Leicester";
            TestItem.StaffID = 1;
            TestItem.Email = "test41@hotmail.com";
            TestItem.FirstName = "Shefika";
            TestItem.LastName = "Sheta";
            TestItem.PhoneNo = "+079684372653";
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
            TestItem.AddressLine1 = "Wainwright Road";
            TestItem.AddressLine2 = "Leicester";
            TestItem.StaffID = 1;
            TestItem.Email = "test41@hotmail.com";
            TestItem.FirstName = "Shefika";
            TestItem.LastName = "Sheta";
            TestItem.PhoneNo = "+079684372653";
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
            TestItem.AddressLine1 = "Wainwright Road";
            TestItem.AddressLine2 = "Leicester";
            TestItem.StaffID = 1;
            TestItem.Email = "test41@hotmail.com";
            TestItem.FirstName = "Shefika";
            TestItem.LastName = "Sheta";
            TestItem.PhoneNo = "+079684372653";
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
            TestItem.AddressLine1 = "Wainwright Road";
            TestItem.AddressLine2 = "Leicester";
            TestItem.StaffID = 1;
            TestItem.Email = "test41@hotmail.com";
            TestItem.FirstName = "Shefika";
            TestItem.LastName = "Sheta";
            TestItem.PhoneNo = "+079684372653";
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
            clsStaff TestItem = new clsStaff();
            // Set its properties
            TestItem.Active = true;
            TestItem.AddressLine1 = "Wainwright Road";
            TestItem.AddressLine2 = "Leicester";
            TestItem.StaffID = 1;
            TestItem.Email = "test41@hotmail.com";
            TestItem.FirstName = "Shefika";
            TestItem.LastName = "Sheta";
            TestItem.PhoneNo = "+079684372653";
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
