using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstStaff
    {
        public string TestStaff;

        String TestAddressLine1 = "";
        String TestAddressLine2 = "";
        String TestFirstName = "";
        String TestLastName = "";
        Int32 TestStaffID = 1;
        String TestEmail = "";
        String TestPhoneNo = "";



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
            Int32 TestStaffID = 1;
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
            //A new instance of clsStaff class
            clsStaff AStaff = new clsStaff();
            //new varible to be tested tstPhoneNo
            String TestPhoneNo = "";
            AStaff.PhoneNo = TestPhoneNo;
            //check to see that the class matches
            Assert.AreEqual(AStaff.PhoneNo, TestPhoneNo);
        }

        [TestMethod]
        public void AddressLine1OK()
        {
            // New instance of clsStaff class
            clsStaff AStaff = new clsStaff();
            string TestAddressLine1 = null;
            // Assign the test variable into the real one
            AStaff.AddressLine1 = TestAddressLine1;
            // Check whether they match
            Assert.AreEqual(AStaff.AddressLine1, TestAddressLine1);
        }

        [TestMethod]
        public void AddressLine2OK()
        {
            // New instance of clsStaff class
            clsStaff AStaff = new clsStaff();
            string TestAddressLine2 = null;
            // Assign the test variable into the real one
            AStaff.AddressLine2 = TestAddressLine2;
            // Check whether they match
            Assert.AreEqual(AStaff.AddressLine2, TestAddressLine2);
        }

         [TestMethod]
        public void ValidMethodOK()
        {
         //New instance of clsStaff class
          clsStaff AStaff = new clsStaff();
        // New variable Error
        String Error = "";
        // Check if there is an error message returned
        Error = AStaff.Valid(TestFirstName, TestLastName, TestAddressLine1, TestAddressLine2, TestPhoneNo, TestEmail, TestStaffID);
        // Check whether there is an error
        Assert.AreEqual(TestFirstName, TestLastName, TestAddressLine1, TestAddressLine2, TestPhoneNo, TestEmail, TestStaffID);
        }

        [TestMethod]
        public void FirstNameMinLessOne()         
        {
           // New instance of clsStaff class
            clsStaff AStaff = new clsStaff();
            // Variable TestLastName with some test data
            TestFirstName = "a";
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
             Error = AStaff.Valid(TestFirstName, TestLastName, TestAddressLine1, TestAddressLine2, TestPhoneNo, TestEmail, TestStaffID);
            // Check whether there is an error
            Assert.AreNotEqual(Error, "");
        }

         [TestMethod]
         public void FirstNameMinBoundary()         // 9 characters
        {
            // create an instance of clsStaff
            clsStaff AStaff = new clsStaff();
            // create a string variable to store the result of the validation
            String Error = "";
            // create some test data to test the method
            string FirstName = "aaaaaaaaa";
            // Check if there is an error message returned
            Error = AStaff.Valid(TestFirstName, TestLastName, TestAddressLine1, TestAddressLine2, TestPhoneNo, TestEmail, TestStaffID);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

         [TestMethod]
         public void FirstNameMinPlusOne()         // 10 characters
         {
        // create an instance of clsStaff
           clsStaff AStaff = new clsStaff();
        // create a string variable to store the result of the validation
        String Error = "";
        // create some test data to test the method
          string FirstName = "aaaaaaaaaa";
        // invoke the method
           Error = AStaff.Valid(TestFirstName, TestLastName, TestAddressLine1, TestAddressLine2, TestPhoneNo, TestEmail, TestStaffID);
        //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

           [TestMethod]
         public void FirstNameMaxLessOne()         // 49 characters
         {
            // create an instance of clsStaff
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to test the method
            string FirstName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            // invoke the method
            Error = AStaff.Valid(TestFirstName, TestLastName, TestAddressLine1, TestAddressLine2, TestPhoneNo, TestEmail, TestStaffID);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
          }

         [TestMethod]
        public void FirstNameMaxBoundary()         // 50 characters
         {
        // create an instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //create a string variable to store the result of the validation
        String Error = "";
        // create some test data to test the method
        string FirstName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
        // invoke the method
        Error = AStaff.Valid(TestFirstName, TestLastName, TestAddressLine1, TestAddressLine2, TestPhoneNo, TestEmail, TestStaffID);
        //test to see that the result is NOT OK i.e there should be an error message
           Assert.AreNotEqual(Error, "");
          }

    [TestMethod]
     public void FirstNameMaxPlusOne()         // 51 characters
    {
            // create an instance of clsStaff
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to test the method
            string FirstName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            // invoke the method
            Error = AStaff.Valid(TestFirstName, TestLastName, TestAddressLine1, TestAddressLine2, TestPhoneNo, TestEmail, TestStaffID);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

         [TestMethod]
         public void FirstNameMid()         // 25 characters
         {
            // create an instance of clsStaff
            clsStaff AStaff = new clsStaff();
            // create a string variable to store the result of the validation
            String Error = "";
            // create some test data to test the method
            string FirstName = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            // invoke the method
            Error = AStaff.Valid(TestFirstName, TestLastName, TestAddressLine1, TestAddressLine2, TestPhoneNo, TestEmail, TestStaffID);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void LastNameMinLessOne()
        {
            // New instance of clsStaff class
            clsStaff AStaff = new clsStaff();
            // Variable TestLastName with some test data
            TestLastName = "a";
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = AStaff.Valid(TestFirstName, TestLastName, TestAddressLine1, TestAddressLine2, TestPhoneNo, TestEmail, TestStaffID);
            // Check whether there is an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinBoundary()         // 9 characters
        {
            // create an instance of clsStaff
            clsStaff AStaff = new clsStaff();
            // create a string variable to store the result of the validation
            String Error = "";
            // create some test data to test the method
            string LastName = "aaaaaaaaa";
            // Check if there is an error message returned
            Error = AStaff.Valid(TestFirstName, TestLastName, TestAddressLine1, TestAddressLine2, TestPhoneNo, TestEmail, TestStaffID);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastMinPlusOne()         // 10 characters
        {
            // create an instance of clsStaff
            clsStaff AStaff = new clsStaff();
            // create a string variable to store the result of the validation
            String Error = "";
            // create some test data to test the method
            string LastName = "aaaaaaaaaa";
            // invoke the method
            Error = AStaff.Valid(TestFirstName, TestLastName, TestAddressLine1, TestAddressLine2, TestPhoneNo, TestEmail, TestStaffID);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxLessOne()         // 49 characters
        {
            // create an instance of clsStaff
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to test the method
            string LastName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            // invoke the method
            Error = AStaff.Valid(TestFirstName, TestLastName, TestAddressLine1, TestAddressLine2, TestPhoneNo, TestEmail, TestStaffID);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxBoundary()         // 50 characters
        {
            // create an instance of clsStaff
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to test the method
            string LastName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            // invoke the method
            Error = AStaff.Valid(TestFirstName, TestLastName, TestAddressLine1, TestAddressLine2, TestPhoneNo, TestEmail, TestStaffID);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxPlusOne()         // 51 characters
        {
            // create an instance of clsStaff
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to test the method
            string LastName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            // invoke the method
            Error = AStaff.Valid(TestFirstName, TestLastName, TestAddressLine1, TestAddressLine2, TestPhoneNo, TestEmail, TestStaffID);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMid()         // 25 characters
        {
            // create an instance of clsStaff
            clsStaff AStaff = new clsStaff();
            // create a string variable to store the result of the validation
            String Error = "";
            // create some test data to test the method
            string LastName = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            // invoke the method
            Error = AStaff.Valid(TestFirstName, TestLastName, TestAddressLine1, TestAddressLine2, TestPhoneNo, TestEmail, TestStaffID);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMinLessOne()
        {
            // New instance of clsStaff class
            clsStaff AStaff = new clsStaff();
            // Variable TestLastName with some test data
            TestStaffID = 1;
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = AStaff.Valid(TestFirstName, TestLastName, TestAddressLine1, TestAddressLine2, TestPhoneNo, TestEmail, TestStaffID);
            // Check whether there is an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMinBoundary()         // 9 characters
        {
            // create an instance of clsStaff
            clsStaff AStaff = new clsStaff();
            // create a string variable to store the result of the validation
            String Error = "";
            // create some test data to test the method
            string StaffID = "aaaaaaaaa";
            // Check if there is an error message returned
            Error = AStaff.Valid(TestFirstName, TestLastName, TestAddressLine1, TestAddressLine2, TestPhoneNo, TestEmail, TestStaffID);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMinPlusOne()         // 10 characters
        {
            // create an instance of clsStaff
            clsStaff AStaff = new clsStaff();
            // create a string variable to store the result of the validation
            String Error = "";
            // create some test data to test the method
            string StaffID = "aaaaaaaaaa";
            // invoke the method
            Error = AStaff.Valid(TestFirstName, TestLastName, TestAddressLine1, TestAddressLine2, TestPhoneNo, TestEmail, TestStaffID);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMaxLessOne()         // 49 characters
        {
            // create an instance of clsStaff
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to test the method
            string StaffID = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            // invoke the method
            Error = AStaff.Valid(TestFirstName, TestLastName, TestAddressLine1, TestAddressLine2, TestPhoneNo, TestEmail, TestStaffID);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMaxBoundary()         // 50 characters
        {
            // create an instance of clsStaff
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to test the method
            string StaffID = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            // invoke the method
            Error = AStaff.Valid(TestFirstName, TestLastName, TestAddressLine1, TestAddressLine2, TestPhoneNo, TestEmail, TestStaffID);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMaxPlusOne()         // 51 characters
        {
            // create an instance of clsStaff
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to test the method
            string StaffID = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            // invoke the method
            Error = AStaff.Valid(TestFirstName, TestLastName, TestAddressLine1, TestAddressLine2, TestPhoneNo, TestEmail, TestStaffID);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMid()         // 25 characters
        {
            // create an instance of clsStaff
            clsStaff AStaff = new clsStaff();
            // create a string variable to store the result of the validation
            String Error = "";
            // create some test data to test the method
            string StaffID = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            // invoke the method
            Error = AStaff.Valid(TestFirstName, TestLastName, TestAddressLine1, TestAddressLine2, TestPhoneNo, TestEmail, TestStaffID);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

    }
}
