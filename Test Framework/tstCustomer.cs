using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstCustomer
    {
        // Correct test data
        // New testing variable TestAddressLine1 with blank test data
        String TestAddressLine1 = "Grange 51a";
        // New testing variable TestAddressLine2 with some test data
        String TestAddressLine2 = "Leicester";
        // New testing variable TestCustomerID with some test data
        Int32 TestCustomerID = 1;
        // New testing variable TestEmail with some test data
        String TestEmail = "test@test.com";
        // New testing variable TestFirstName with some test data
        String TestFirstName = "John";
        // New testing variable TestLastName with some test data
        String TestLastName = "Smith";
        // New testing variable TestPhoneNo with some test data
        String TestPhoneNo = "+444656446641";
        // New testing variable TestCarRegNo with some test data
        String TestCarRegNo = "AF3E4E";

        [TestMethod]
        public void InstanceOK()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Check whether the instance exists
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void CarRegNoOK()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Assign the test variable into the real one
            ACustomer.CarRegNo = TestCarRegNo;
            // Check whether they match
            Assert.AreEqual(ACustomer.CarRegNo, TestCarRegNo);
        }

        [TestMethod]
        public void AddressLine1OK()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Assign the test variable into the real one
            ACustomer.AddressLine1 = TestAddressLine1;
            // Check whether they match
            Assert.AreEqual(ACustomer.AddressLine1, TestAddressLine1);
        }

        [TestMethod]
        public void AddressLine2OK()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Assign the test variable into the real one
            ACustomer.AddressLine2 = TestAddressLine2;
            // Check whether they match
            Assert.AreEqual(ACustomer.AddressLine2, TestAddressLine2);
        }

        [TestMethod]
        public void CustomerIDOK()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Assign the test variable into the real one
            ACustomer.CustomerID = TestCustomerID;
            // Check whether they match
            Assert.AreEqual(ACustomer.CustomerID, TestCustomerID);
        }

        [TestMethod]
        public void EmailOK()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Assign the test variable into the real one
            ACustomer.Email = TestEmail;
            // Check whether they match
            Assert.AreEqual(ACustomer.Email, TestEmail);
        }

        [TestMethod]
        public void FirstNameOK()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Assign the test variable into the real one
            ACustomer.FirstName = TestFirstName;
            // Check whether they match
            Assert.AreEqual(ACustomer.FirstName, TestFirstName);
        }

        [TestMethod]
        public void LastNameOK()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Assign the test variable into the real one
            ACustomer.LastName = TestLastName;
            // Check whether they match
            Assert.AreEqual(ACustomer.LastName, TestLastName);
        }

        [TestMethod]
        public void PhoneNoOK()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Assign the test variable into the real one
            ACustomer.PhoneNo = TestPhoneNo;
            // Check whether they match
            Assert.AreEqual(ACustomer.PhoneNo, TestPhoneNo);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreEqual(Error, "");
        }

        //[TestMethod]
        //public void FindMethodOK()
        //{
        //    // New instance of clsCustomer class
        //    clsCustomer ACustomer = new clsCustomer();
        //    // New testing variable TestSearch with blank test data
        //    String TestSearch = "somesearch";
        //    // New variable Error
        //    String Error = "";
        //    // Check if there is an error message returned
        /// <summary>
        ///  SHOULD BE A CUSTOMERID
        /// </summary>
        //    Error = ACustomer.Find(TestSearch);
        //    // Check whether there is an error
        //    Assert.AreEqual(Error, "");
        //}

        [TestMethod]
        public void CarRegNoMinLessOne()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Variable TestCarRegNo with some test data
            TestCarRegNo = "AF3E4";
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CarRegNoMinBoundary()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Variable TestCarRegNo with some test data
            TestCarRegNo = "AF3E4E";
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarRegNoMinPlusOne()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Variable TestCarRegNo with some test data
            TestCarRegNo = "AF3E4E3";
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CarRegNoMaxLessOne()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Variable TestCarRegNo with some test data
            TestCarRegNo = "AF3E4";
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CarRegNoMaxBoundary()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Variable TestCarRegNo with some test data
            TestCarRegNo = "AF3E4E";
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarRegNoMaxPlusOne()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Variable TestCarRegNo with some test data
            TestCarRegNo = "AF3E4E3";
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CarRegNoMid()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Variable TestCarRegNo with some test data
            TestCarRegNo = "AF3";
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CarRegNoExtremeMax()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Variable TestCarRegNo with some test data
            TestCarRegNo = "AF3E4ED69A";
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinLessOne()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Variable TestLastName with some test data
            TestLastName = "a";
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinBoundary()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Variable TestLastName with some test data
            TestLastName = "ab";
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinPlusOne()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Variable TestLastName with some test data
            TestLastName = "abc";
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxLessOne()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Add letter 'a' 39 times to a variable for testing
            TestLastName = TestLastName.PadRight(39, 'a');
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxBoundary()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Add letter 'a' 40 times to a variable for testing
            TestLastName = TestLastName.PadRight(40, 'a');
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Add letter 'a' 41 times to a variable for testing
            TestLastName = TestLastName.PadRight(41, 'a');
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMid()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Add letter 'a' 20 times to a variable for testing
            TestLastName = TestLastName.PadRight(20, 'a');
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameExtremeMax()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Add letter 'a' 5 000 000 times to a variable for testing
            TestLastName = TestLastName.PadRight(5000000, 'a');
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressLine1MinBoundary()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Variable TestAddressLine1 with blank test data
            TestAddressLine1 = "";
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressLine1MinPlusOne()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Variable TestAddressLine1 with some test data
            TestAddressLine1 = "a";
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressLine1MaxLessOne()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Add letter 'a' 49 times to a variable for testing
            TestAddressLine1 = TestAddressLine1.PadRight(49, 'a');
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressLine1MaxBoundary()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Add letter 'a' 50 times to a variable for testing
            TestAddressLine1 = TestAddressLine1.PadRight(50, 'a');
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressLine1MaxPlusOne()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Add letter 'a' 51 times to a variable for testing
            TestAddressLine1 = TestAddressLine1.PadRight(51, 'a');
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressLine1Mid()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Add letter 'a' 25 times to a variable for testing
            TestAddressLine1 = TestAddressLine1.PadRight(25, 'a');
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressLine1ExtremeMax()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Add letter 'a' 2 000 times to a variable for testing
            TestAddressLine1 = TestAddressLine1.PadRight(2000, 'a');
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressLine2MinBoundary()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Variable TestAddressLine2 with blank test data
            TestAddressLine2 = "";
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressLine2MinPlusOne()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Variable TestAddressLine2 with some test data
            TestAddressLine2 = "a";
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressLine2MaxLessOne()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Add letter 'a' 99 times to a variable for testing
            TestAddressLine2 = TestAddressLine2.PadRight(99, 'a');
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressLine2MaxBoundary()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Add letter 'a' 100 times to a variable for testing
            TestAddressLine2 = TestAddressLine2.PadRight(100, 'a');
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressLine2MaxPlusOne()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Add letter 'a' 101 times to a variable for testing
            TestAddressLine2 = TestAddressLine2.PadRight(101, 'a');
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressLine2Mid()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Add letter 'a' 50 times to a variable for testing
            TestAddressLine2 = TestAddressLine2.PadRight(50, 'a');
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressLine2ExtremeMax()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Add letter 'a' 20 000 times to a variable for testing
            TestAddressLine2 = TestAddressLine2.PadRight(20000, 'a');
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinLessOne()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Variable TestEmail with some test data
            TestEmail = "a@a.";
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinBoundary()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Variable TestEmail with some test data
            TestEmail = "a@a.a";
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Variable TestEmail with some test data
            TestEmail = "a@a.aa";
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Add letter 'a' 59 times to a variable for testing
            TestEmail = TestEmail.PadRight(59, 'a');
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxBoundary()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Add letter 'a' 60 times to a variable for testing
            TestEmail = TestEmail.PadRight(60, 'a');
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Add letter 'a' 61 times to a variable for testing
            TestEmail = TestEmail.PadRight(61, 'a');
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMid()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Add letter 'a' 30 times to a variable for testing
            TestEmail = TestEmail.PadRight(30, 'a');
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailExtremeMax()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Add letter 'a' 2 000 times to a variable for testing
            TestEmail = TestEmail.PadRight(2000, 'a');
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinLessOne()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Variable TestFirstName with some test data
            TestFirstName = "a";
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinBoundary()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Variable TestFirstName with some test data
            TestFirstName = "ab";
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Variable TestFirstName with some test data
            TestFirstName = "abc";
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Add letter 'a' 24 times to a variable for testing
            TestFirstName = TestFirstName.PadRight(24, 'a');
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxBoundary()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Add letter 'a' 25 times to a variable for testing
            TestFirstName = TestFirstName.PadRight(25, 'a');
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Add letter 'a' 26 times to a variable for testing
            TestFirstName = TestFirstName.PadRight(26, 'a');
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMid()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Add letter 'a' 12 times to a variable for testing
            TestFirstName = TestFirstName.PadRight(12, 'a');
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameExtremeMax()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Add letter 'a' 5 000 000 times to a variable for testing
            TestFirstName = TestFirstName.PadRight(5000000, 'a');
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMinLessOne()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Variable TestPhoneNo with some test data
            TestPhoneNo = "1234";
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMinBoundary()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Variable TestPhoneNo with some test data
            TestPhoneNo = "12345";
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMinPlusOne()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Variable TestPhoneNo with some test data
            TestPhoneNo = "123456";
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMaxLessOne()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Add letter 'a' 29 times to a variable for testing
            TestPhoneNo = TestPhoneNo.PadRight(29, 'a');
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMaxBoundary()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Add letter 'a' 30 times to a variable for testing
            TestPhoneNo = TestPhoneNo.PadRight(30, 'a');
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMaxPlusOne()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Add letter 'a' 31 times to a variable for testing
            TestPhoneNo = TestPhoneNo.PadRight(31, 'a');
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMid()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Add letter 'a' 15 times to a variable for testing
            TestPhoneNo = TestPhoneNo.PadRight(15, 'a');
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoExtremeMax()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // Add letter 'a' 2 000 times to a variable for testing
            TestPhoneNo = TestPhoneNo.PadRight(2000, 'a');
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestAddressLine1, TestAddressLine2, TestEmail, TestFirstName, TestLastName, TestPhoneNo, TestCarRegNo);
            // Check whether there is an error
            Assert.AreNotEqual(Error, "");
        }
    }
}