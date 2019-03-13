using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Test_Framework
{
    [TestClass]
    public class tstStaffCollection
    {
        //Int32 TestCount = 20;

        //[TestMethod]
        ////this is a test class 
        //public void InstanceOK()
        //{
        //    //create an instance of the class i want to create
        //    clsStaffCollection AllStaffs = new clsStaffCollection();
        //    //test to see if it exists
        //    Assert.IsNotNull(AllStaffs);
        //}

        //[TestMethod]
        //public void CountOK()
        //{
        //    //create an instance of the class i want to create
        //    clsStaffCollection AllStaffs = new clsStaffCollection();
        //    AllStaffs.Count = TestCount;
        //    //test to see if it exists
        //    Assert.AreEqual(AllStaffs.Count, TestCount);
        //}
        //[TestMethod]
        //public void ThisStaffOK()
        //{
        //    // New instance of clsStaffCollection class
        //    clsStaffCollection AllStaffs = new clsStaffCollection();
        //    // New instance of clsStaff class to create the item of test data
        //    clsStaff TestStaff = new clsStaff();
        //    // Set its properties
        //    TestStaff.AddressLine1 = "Wainwright Road";
        //    TestStaff.AddressLine2 = "Leicester";
        //    TestStaff.StaffID = 2;
        //    TestStaff.Email = "test41@hotmail.com";
        //    TestStaff.FirstName = "Sheta";
        //    TestStaff.LastName = "Shefika";
        //    TestStaff.PhoneNo = "+079684372653";
        //    // Assign the test variable into the real one
        //    AllStaffs.ThisStaff = TestStaff;
        //    // Check whether they match
        //    Assert.AreEqual(AllStaffs.ThisStaff, TestStaff);
        //}

        //[TestMethod]
        //public void StaffListOK()
        //{
        //    // New instance of clsStaffCollection cls
        //    clsStaffCollection AllStaffs = new clsStaffCollection();
        //    // Create a list named TestList
        //    List<clsStaff> TestList = new List<clsStaff>();
        //    // New instance of clsCustomer class to create the item of test data
        //    clsStaff TestItem = new clsStaff();
        //    // Set its properties
        //    TestItem.AddressLine1 = "Wainwright Road";
        //    TestItem.AddressLine2 = "Leicester";
        //    TestItem.StaffID = 1;
        //    TestItem.Email = "test41@hotmail.com";
        //    TestItem.FirstName = "Shefika";
        //    TestItem.LastName = "Sheta";
        //    TestItem.PhoneNo = "+079684372653";
        //    // Add the item to the test list
        //    TestList.Add(TestItem);
        //    // Assign the test variable into the real one
        //    AllStaffs.StaffList = TestList;
        //    // Check whether they match
        //    Assert.AreEqual(AllStaffs.StaffList, TestList);
        //}
        //[TestMethod]
        //public void ListAndCountOK()
        //{
        //    // New instance of clsSatffCollection class
        //    clsStaffCollection AllStaffs = new clsStaffCollection();
        //    // Create a list named TestList
        //    List<clsStaff> TestList = new List<clsStaff>();
        //    // New instance of clsStaff class to create the item of test data
        //    clsStaff TestItem = new clsStaff();
        //    // Set its properties
        //    TestItem.AddressLine1 = "Wainwright Road";
        //    TestItem.AddressLine2 = "Leicester";
        //    TestItem.StaffID = 1;
        //    TestItem.Email = "test41@hotmail.com";
        //    TestItem.FirstName = "Shefika";
        //    TestItem.LastName = "Sheta";
        //    TestItem.PhoneNo = "+079684372653";
        //    // Add the item to the test list
        //    TestList.Add(TestItem);
        //    // Assign the test variable into the real one
        //    AllStaffs.StaffList = TestList;
        //    // Check whether they match
        //    Assert.AreEqual(AllStaffs.Count, TestList.Count);
        //}
    }
}
