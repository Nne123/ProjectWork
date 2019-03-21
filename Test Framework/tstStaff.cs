using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;

namespace Test_Framework
{
    [TestClass]
    public class tstStaff
    {
        // good test data
        // create some test data to pass the method
        string AddressLine1 = "TestAddressLine1";
        string AddressLine2 = "TestAddressLine2";
        string FirstName = "TestFirstName";
        string StaffID = "9";
        string LastName = "TestLastName";
        string Email = "TestEmail";
        string PhoneNo = "12345678910";

        public string TestStaff;
        // this is a test string for address 1
        String TestAddressLine1 = "TestAddressLine1";
        // this is a test string for address 2
        String TestAddressLine2 = "TestAddressLine2";
        // this is a test string for first name
        String TestFirstName = "TestFirstName";
        // this is a test string for last name
        String TestLastName = "TestLastName";
        // this is a test string for staff ID
        Int32 TestStaffID = 9;
        // this is a test string for Email
        String TestEmail = "TestEmail";
        // this is a test string for PhoneNo
        String TestPhoneNo = "12345678910";

        public string Shefika { get; private set; }
        //public string AddressLine2 { get; private set; }
        //public string FirstName { get; private set; }
        //public string LastName { get; private set; }

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
        public void FirstNameNoOK()
        {
            //A new instance of  clsStaff class
            clsStaff AStaff = new clsStaff();
            //new varible to be tested tstFirstName
            String TestData = Shefika;
            AStaff.FirstName = TestData;
            //check to see that the class matches
            Assert.AreEqual(AStaff.FirstName, TestData);
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
            Int32 TestStaffID = 9;
            AStaff.StaffID = TestStaffID;
            //check to see that the class matches
            Assert.AreEqual(AStaff.StaffID, TestStaffID);
        }

        [TestMethod]
        public void StaffIDPropertyOK()
        {
            //A new instance of  clsStaff class
            clsStaff AStaff = new clsStaff();
            //new varible to be tested tstStaffID
            Int32 TestStaffID = 9;
            AStaff.StaffID = TestStaffID;
            //check to see that the class matches
            Assert.AreEqual(AStaff.StaffID, TestStaffID);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            //A new instance of  clsStaff class
            clsStaff AStaff = new clsStaff();
            //new varible to be tested tstEmail
            String TestEmail = "TestEmai";
            AStaff.Email = TestEmail;
            //check to see that the class matches
            Assert.AreEqual(AStaff.Email, TestEmail);
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
            //A new instance of clsStaff class
            clsStaff AStaff = new clsStaff();
            //new varible to be tested tstPhoneNo
            string TestPhoneNo = "";
            AStaff.PhoneNo = TestPhoneNo;
            //check to see that the class matches
            Assert.AreEqual(AStaff.PhoneNo, TestPhoneNo);
        }

        [TestMethod]
        public void PhoneNoPropertyOK()
        {
            //A new instance of clsStaff class
            clsStaff AStaff = new clsStaff();
            //new varible to be tested tstPhoneNo
            string TestPhoneNo = "12345678910";
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
        public void AddressLine1PropertyOK()
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
        public void AddressLine2PropertyOK()
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
            Error = AStaff.Valid(TestAddressLine1, TestAddressLine2, TestFirstName, TestLastName, TestPhoneNo, TestEmail, TestStaffID);
            // Check whether there is an error
            Assert.AreEqual(Error, ""); //"Email cant be less than 5 characters long"
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //New instance of clsStaff class
            clsStaff AStaff = new clsStaff();
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = AStaff.Valid(TestAddressLine1, TestAddressLine2, TestFirstName, TestLastName, TestPhoneNo, TestEmail, TestStaffID);
            // Check whether there is an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //New instance of clsStaff class
            clsStaff AStaff = new clsStaff();
            // New variable Error
            Boolean TestData = true;
            // assign the data to the property
            AStaff.Active = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AStaff.Active, TestData);
        }

        [TestMethod]
        public void FirstNameMinLessOne()
        {
            // New instance of clsStaff class
            clsStaff AStaff = new clsStaff();
            // Variable TestLastName with some test data
            TestFirstName = "S";
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = AStaff.Valid(TestFirstName, TestLastName, TestAddressLine1, TestAddressLine2, TestPhoneNo, TestEmail, TestStaffID);
            // Check whether there is an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinBoundary()         // 9 characters
        {
            // create an instance of clsStaff
            clsStaff AStaff = new clsStaff();
            // create a string variable to store the result of the validation
            String Error = "";
            // create some test data to test the method
            string FirstName = "";
            // Check if there is an error message returned
            Error = AStaff.Valid(TestFirstName, TestLastName, TestAddressLine1, TestAddressLine2, TestPhoneNo, TestEmail, TestStaffID);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinPlusOne()         // 10 characters
        {
            // create an instance of clsStaff
            clsStaff AStaff = new clsStaff();
            // create a string variable to store the result of the validation
            String Error = "";
            // create some test data to test the method
            string FirstName = "a";
            // invoke the method
            Error = AStaff.Valid(TestFirstName, TestLastName, TestAddressLine1, TestAddressLine2, TestPhoneNo, TestEmail, TestStaffID);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxLessOne()         // 49 characters
        {
            // create an instance of clsStaff
            clsStaff AStaff = new clsStaff();
            // Add letter 'a' 49 times to a variable for testing
            TestFirstName = TestFirstName.PadRight(49, 'a');
            //create a string variable to store the result of the validation
            String Error = "";
            // Check if there is an error message returned
            Error = AStaff.Valid(TestFirstName, TestLastName, TestAddressLine1, TestAddressLine2, TestPhoneNo, TestEmail, TestStaffID);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxBoundary()         // 50 characters
        {
            // create an instance of clsStaff
            clsStaff AStaff = new clsStaff();

            // Add letter 'a' 50 times to a variable for testing
            TestFirstName = FirstName.PadRight(50, 'a');
            // New variable for the Error
            String Error = "";
            // Check if there is an error message returned
            Error = AStaff.Valid(TestFirstName, TestLastName, TestAddressLine1, TestAddressLine2, TestPhoneNo, TestEmail, TestStaffID);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreEqual(Error, "");
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
            Assert.AreEqual(Error, "");
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
            Assert.AreEqual(Error, "");
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
            Assert.AreEqual(Error, "");
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
            Assert.AreEqual(Error, "");
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
            Assert.AreEqual(Error, "");
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
            Assert.AreEqual(Error, "");
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
            Assert.AreEqual(Error, "");
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
            Assert.AreEqual(Error, "");
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
            Assert.AreEqual(Error, "");
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
            Assert.AreEqual(Error, "");
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
            Assert.AreEqual(Error, "");
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
            Assert.AreEqual(Error, "");
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
            Assert.AreEqual(Error, "");
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
            Assert.AreEqual(Error, "");
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
            Assert.AreEqual(Error, "");
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
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailinLessOne()
        {
            // New instance of clsStaff class
            clsStaff AStaff = new clsStaff();
            // Variable TestLastName with some test data
            TestEmail = "test41@hotmail.com";
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = AStaff.Valid(TestFirstName, TestLastName, TestAddressLine1, TestAddressLine2, TestPhoneNo, TestEmail, TestStaffID);
            // Check whether there is an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinBoundary()         // 9 characters
        {
            // create an instance of clsStaff
            clsStaff AStaff = new clsStaff();
            // create a string variable to store the result of the validation
            String Error = "";
            // create some test data to test the method
            string TestEmail = "aaaaaaaaa";
            // Check if there is an error message returned
            Error = AStaff.Valid(TestFirstName, TestLastName, TestAddressLine1, TestAddressLine2, TestPhoneNo, TestEmail, TestStaffID);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinPlusOne()         // 10 characters
        {
            // create an instance of clsStaff
            clsStaff AStaff = new clsStaff();
            // create a string variable to store the result of the validation
            String Error = "";
            // create some test data to test the method
            string TestEmail = "aaaaaaaaaa";
            // invoke the method
            Error = AStaff.Valid(TestFirstName, TestLastName, TestAddressLine1, TestAddressLine2, TestPhoneNo, TestEmail, TestStaffID);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxLessOne()         // 49 characters
        {
            // create an instance of clsStaff
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to test the method
            string TestEmail = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            // invoke the method
            Error = AStaff.Valid(TestFirstName, TestLastName, TestAddressLine1, TestAddressLine2, TestPhoneNo, TestEmail, TestStaffID);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxBoundary()         // 50 characters
        {
            // create an instance of clsStaff
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to test the method
            string TestEmail = "";
            TestEmail = TestEmail.PadRight(50, 'a');//aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            // invoke the method
            Error = AStaff.Valid(TestFirstName, TestLastName, TestAddressLine1, TestAddressLine2, TestPhoneNo, TestEmail, TestStaffID);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()         // 51 characters
        {
            // create an instance of clsStaff
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to test the method
            string TestEmail = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            // invoke the method
            Error = AStaff.Valid(TestFirstName, TestLastName, TestAddressLine1, TestAddressLine2, TestPhoneNo, TestEmail, TestStaffID);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMid()         // 25 characters
        {
            // create an instance of clsStaff
            clsStaff AStaff = new clsStaff();
            // create a string variable to store the result of the validation
            String Error = "";
            // create some test data to test the method
            string TestEmail = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            // invoke the method
            Error = AStaff.Valid(TestFirstName, TestLastName, TestAddressLine1, TestAddressLine2, TestPhoneNo, TestEmail, TestStaffID);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMinLessOne()
        {
            // New instance of clsStaff class
            clsStaff AStaff = new clsStaff();
            // Variable TestLastName with some test data
            TestPhoneNo = "";
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = AStaff.Valid(TestFirstName, TestLastName, TestAddressLine1, TestAddressLine2, TestPhoneNo, TestEmail, TestStaffID);
            // Check whether there is an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMinBoundary()         // 9 characters
        {
            // create an instance of clsStaff
            clsStaff AStaff = new clsStaff();
            // create a string variable to store the result of the validation
            String Error = "";
            // create some test data to test the method
            string TestPhoneNo = "aaaaaaaaa";
            // Check if there is an error message returned
            Error = AStaff.Valid(TestFirstName, TestLastName, TestAddressLine1, TestAddressLine2, TestPhoneNo, TestEmail, TestStaffID);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMinPlusOne()         // 10 characters
        {
            // create an instance of clsStaff
            clsStaff AStaff = new clsStaff();
            // create a string variable to store the result of the validation
            String Error = "";
            // create some test data to test the method
            string TestEmail = "aaaaaaaaaa";
            // invoke the method
            Error = AStaff.Valid(TestFirstName, TestLastName, TestAddressLine1, TestAddressLine2, TestPhoneNo, TestEmail, TestStaffID);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMaxLessOne()         // 49 characters
        {
            // create an instance of clsStaff
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to test the method
            string TestPhoneNo = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            // invoke the method
            Error = AStaff.Valid(TestFirstName, TestLastName, TestAddressLine1, TestAddressLine2, TestPhoneNo, TestEmail, TestStaffID);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMaxBoundary()         // 50 characters
        {
            // create an instance of clsStaff
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to test the method
            string TestPhoneNo = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            // invoke the method
            Error = AStaff.Valid(TestFirstName, TestLastName, TestAddressLine1, TestAddressLine2, TestPhoneNo, TestEmail, TestStaffID);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMaxPlusOne()         // 51 characters
        {
            // create an instance of clsStaff
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to test the method
            string TestPhoneNo = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            // invoke the method
            Error = AStaff.Valid(TestFirstName, TestLastName, TestAddressLine1, TestAddressLine2, TestPhoneNo, TestEmail, TestStaffID);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMid()         // 25 characters
        {
            // create an instance of clsStaff
            clsStaff AStaff = new clsStaff();
            // create a string variable to store the result of the validation
            String Error = "";
            // create some test data to test the method
            string TestPhoneNo = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            // invoke the method
            Error = AStaff.Valid(TestFirstName, TestLastName, TestAddressLine1, TestAddressLine2, TestPhoneNo, TestEmail, TestStaffID);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FindMethodOK()
        {
            // create an instance of clsStaff
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the results of the validation
            Boolean Found = true;
            // create some test data to test the method
            Int32 StaffID = 1;
            //Int32 
            // invoke the method
            Found = AStaff.Find(StaffID);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            // create an instance of clsStaff
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the search
            Boolean Found = false;
            // boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 StaffID = 9;
            // invoke the method
            Found = AStaff.Find(StaffID);
            // check the staff id
            if (AStaff.Active != true)
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffIDFound()
        {
            // create an instance of clsStaff
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the search
            Boolean Found = false;
            // boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 StaffID = 9;
            // invoke the method
            Found = AStaff.Find(StaffID);
            // check the appointment no
            if (AStaff.StaffID != 9)
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressLine1Found()
        {
            // New instance of clsStaff class
            clsStaff AStaff = new clsStaff();
            // New variable for anything that was found
            Boolean Found = false;
            // New variable for recording if the data is OK (we assume it is)
            Boolean OK = true;
            // Variable TestStaffID with some test data
            Int32 TestStaffID = 9;
            // Check if there is anything found
            Found = AStaff.Find(TestStaffID);
            // Check the property
            if (AStaff.AddressLine1 != "TestAddressLine1")
            {
                OK = false;
            }
            // Check whether it is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressLine2Found()
        {
            // New instance of clsStaff class
            clsStaff AStaff = new clsStaff();
            // New variable for anything that was found
            Boolean Found = false;
            // New variable for recording if the data is OK (we assume it is)
            Boolean OK = true;
            // Variable TestStaffID with some test data
            TestStaffID = 9;
            // Check if there is anything found
            Found = AStaff.Find(TestStaffID);
            // Check the property
            if (AStaff.AddressLine2 != "TestAddressLine2")
            {
                OK = false;
            }
            // Check whether it is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            // New instance of clsStaff class
            clsStaff AStaff = new clsStaff();
            // New variable for anything that was found
            Boolean Found = false;
            // New variable for recording if the data is OK (we assume it is)
            Boolean OK = true;
            // Variable TestStaffID with some test data
            Int32 TestStaffID = 9;
            // Check if there is anything found
            Found = AStaff.Find(TestStaffID);
            // Check the property
            if (AStaff.Email != "TestEmail")
            {
                OK = false;
            }
            // Check whether it is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFirstNameFound()
        {
            // New instance of clsStaff class
            clsStaff AStaff = new clsStaff();
            // New variable for anything that was found
            Boolean Found = false;
            // New variable for recording if the data is OK (we assume it is)
            Boolean OK = true;
            // Variable TestStaffID with some test data
            Int32 TestStaffID = 9;
            // Check if there is anything found
            Found = AStaff.Find(TestStaffID);
            // Check the property
            if (AStaff.FirstName != "TestFirstName")
            {
                OK = false;
            }
            // Check whether it is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLastNameFound()
        {
            // New instance of clsStaff class
            clsStaff AStaff = new clsStaff();
            // New variable for anything that was found
            Boolean Found = false;
            // New variable for recording if the data is OK (we assume it is)
            Boolean OK = true;
            // Variable TestStaffID with some test data
            TestStaffID = 9;
            // Check if there is anything found
            Found = AStaff.Find(TestStaffID);
            // Check the property
            if (AStaff.LastName != "TestLastName")
            {
                OK = false;
            }
            // Check whether it is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneNoFound()
        {
            // New instance of clsStaff class
            clsStaff AStaff = new clsStaff();
            // New variable for anything that was found
            Boolean Found = false;
            // Boolean variable for recording if the data is OK (we assume it is)
            Boolean OK = true;
            // Variable TestStaffID with some test data
            Int32 StaffID = 9;
            // Check if there is anything found
            Found = AStaff.Find(TestStaffID);
            // Check the property
            if (AStaff.PhoneNo != "12345678910")
            {
                OK = false;
            }
            // Check whether it is true
            Assert.IsTrue(OK);
        }
    }
}
