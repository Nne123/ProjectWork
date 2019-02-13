using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of our class clsStaff
            clsStaff AStaff = new clsStaff();
            //check to see that the class is not null and that it exists
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void FirstNameOK()
        {
            //A new instance of  clsStaff class
            clsStaff AStaff = new clsStaff();
            //new varible to be tested tstFirstName
            String TestFirstName = "";
            AStaff.FirstName = TestFirstName;
            //check to see that the class matches
            Assert.AreEqual(AStaff.FirstName, TestFirstName);
        }

        [TestMethod]
        public void LastNameOK()
        {
            //A new instance of  clsStaff class
            clsStaff AStaff = new clsStaff();
            //new varible to be tested tstFirstName
            String TestLastName = "";
            AStaff.LastName = TestLastName;
            //check to see that the class matches
            Assert.AreEqual(AStaff.LastName, TestLastName);
        }

        [TestMethod]
        public void StaffIDOK()
        {
            //A new instance of  clsStaff class
            clsStaff AStaff = new clsStaff();
            //new varible to be tested tstStaffID
            String TestStaffID = "";
            AStaff.StaffID = TestStaffID;
            //check to see that the class matches
            Assert.AreEqual(AStaff.StaffID, TestStaffID);
        }

        [TestMethod]
        public void EmailOK()
        {
            //A new instance of  clsStaff class
            clsStaff AStaff = new clsStaff();
            //new varible to be tested tstEmail
            String TestEmail = "";
            AStaff.Email = TestEmail;
            //check to see that the class matches
            Assert.AreEqual(AStaff.Email, TestEmail);
        }

        [TestMethod]
        public void PhoneNoOK()
        {
            //
            //A new instance of  clsStaff class
            clsStaff AStaff = new clsStaff();
            //new varible to be tested tstPhoneNo
            String TestPhoneNo = "";
            AStaff.PhoneNo = TestPhoneNo;
            //check to see that the class matches
            Assert.AreEqual(AStaff.PhoneNo, TestPhoneNo);
        }
    }
}
