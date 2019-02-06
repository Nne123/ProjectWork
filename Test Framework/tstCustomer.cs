using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstCustomer
    {
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
            // New testing variable TestCarRegNo with some test data
            Int32 TestCarRegNo = 123;
            // Assign the test variable into the real one
            ACustomer.CarRegNo = TestCarRegNo;
            // Check whether they match
            Assert.AreEqual(ACustomer.CarRegNo, TestCarRegNo);
        }

        [TestMethod]
        public void LastNameOK()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // New testing variable TestLastName with blank test data
            String TestLastName = "";
            // Assign the test variable into the real one
            ACustomer.LastName = TestLastName;
            // Check whether they match
            Assert.AreEqual(ACustomer.LastName, TestLastName);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // New testing variable TestLastName with some test data
            String TestLastName = "abc";
            // New testing variable TestCarRegNo with some test data
            Int32 TestCarRegNo = 123456;
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestLastName, TestCarRegNo);
            // Check whether there is an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FindMethodOK()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // New testing variable TestCarRegNo with some test data
            Int32 TestCarRegNo = 123456;
            // New variable Error
            String Error = "";
            ///
            ///

            ///
            ///
            Error = ACustomer.Find(TestCarRegNo);
            // Check whether there is an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarRegNoMinLessOne()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // New testing variable TestLastName with blank test data
            String TestLastName = "";
            // New testing variable TestCarRegNo with some test data
            Int32 TestCarRegNo = 12345;
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestLastName, TestCarRegNo);
            // Check whether there is an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CarRegNoMinBoundary()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // New testing variable TestLastName with some test data
            String TestLastName = "abc";
            // New testing variable TestCarRegNo with some test data
            Int32 TestCarRegNo = 123456;
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestLastName, TestCarRegNo);
            // Check whether there is an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarRegNoMinPlusOne()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // New testing variable TestLastName with blank test data
            String TestLastName = "";
            // New testing variable TestCarRegNo with some test data
            Int32 TestCarRegNo = 1234567;
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestLastName, TestCarRegNo);
            // Check whether there is an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CarRegNoMaxLessOne()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // New testing variable TestLastName with blank test data
            String TestLastName = "";
            // New testing variable TestCarRegNo with some test data
            Int32 TestCarRegNo = 12345;
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestLastName, TestCarRegNo);
            // Check whether there is an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CarRegNoMaxBoundary()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // New testing variable TestLastName with some test data
            String TestLastName = "abc";
            // New testing variable TestCarRegNo with some test data
            Int32 TestCarRegNo = 123456;
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestLastName, TestCarRegNo);
            // Check whether there is an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarRegNoMaxPlusOne()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // New testing variable TestLastName with blank test data
            String TestLastName = "";
            // New testing variable TestCarRegNo with some test data
            Int32 TestCarRegNo = 1234567;
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestLastName, TestCarRegNo);
            // Check whether there is an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CarRegNoMid()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // New testing variable TestLastName with blank test data
            String TestLastName = "";
            // New testing variable TestCarRegNo with some test data
            Int32 TestCarRegNo = 123;
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestLastName, TestCarRegNo);
            // Check whether there is an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CarRegNoExtremeMax()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // New testing variable TestLastName with blank test data
            String TestLastName = "";
            // New testing variable TestCarRegNo with some test data
            Int32 TestCarRegNo = 1234567891;
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestLastName, TestCarRegNo);
            // Check whether there is an error
            Assert.AreNotEqual(Error, "");
        }

        // Where the invalid type for CarRegWouldGo

        [TestMethod]
        public void LastNameMinLessOne()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // New testing variable TestLastName with some test data
            String TestLastName = "a";
            // New testing variable TestCarRegNo with some test data
            Int32 TestCarRegNo = 123456;
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestLastName, TestCarRegNo);
            // Check whether there is an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinBoundary()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // New testing variable TestLastName with some test data
            String TestLastName = "ab";
            // New testing variable TestCarRegNo with some test data
            Int32 TestCarRegNo = 123456;
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestLastName, TestCarRegNo);
            // Check whether there is an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinPlusOne()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // New testing variable TestLastName with some test data
            String TestLastName = "abc";
            // New testing variable TestCarRegNo with some test data
            Int32 TestCarRegNo = 123456;
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestLastName, TestCarRegNo);
            // Check whether there is an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxLessOne()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // New testing variable TestLastName with blank test data
            String TestLastName = "";
            // Add letter 'a' 39 times to that variable for testing
            TestLastName = TestLastName.PadRight(39, 'a');
            // New testing variable TestCarRegNo with some test data
            Int32 TestCarRegNo = 123456;
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestLastName, TestCarRegNo);
            // Check whether there is an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxBoundary()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // New testing variable TestLastName with blank test data
            String TestLastName = "";
            // Add letter 'a' 40 times to that variable for testing
            TestLastName = TestLastName.PadRight(40, 'a');
            // New testing variable TestCarRegNo with some test data
            Int32 TestCarRegNo = 123456;
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestLastName, TestCarRegNo);
            // Check whether there is an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // New testing variable TestLastName with blank test data
            String TestLastName = "";
            // Add letter 'a' 41 times to that variable for testing
            TestLastName = TestLastName.PadRight(41, 'a');
            // New testing variable TestCarRegNo with some test data
            Int32 TestCarRegNo = 123456;
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestLastName, TestCarRegNo);
            // Check whether there is an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMid()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // New testing variable TestLastName with blank test data
            String TestLastName = "";
            // Add letter 'a' 20 times to that variable for testing
            TestLastName = TestLastName.PadRight(20, 'a');
            // New testing variable TestCarRegNo with some test data
            Int32 TestCarRegNo = 123456;
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestLastName, TestCarRegNo);
            // Check whether there is an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameExtremeMax()
        {
            // New instance of clsCustomer class
            clsCustomer ACustomer = new clsCustomer();
            // New testing variable TestLastName with blank test data
            String TestLastName = "";
            // Add letter 'a' 5 000 000 times to that variable for testing
            TestLastName = TestLastName.PadRight(5000000, 'a');
            // New testing variable TestCarRegNo with some test data
            Int32 TestCarRegNo = 123456;
            // New variable Error
            String Error = "";
            // Check if there is an error message returned
            Error = ACustomer.Valid(TestLastName, TestCarRegNo);
            // Check whether there is an error
            Assert.AreNotEqual(Error, "");
        }

        // Where the invalid type for LastNameWouldGo

    }
}