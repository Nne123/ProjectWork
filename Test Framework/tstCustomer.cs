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
            clsCustomer ACustomer = new clsCustomer();
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void CarRegNoOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Int32 TestCarRegNo = 123;
            ACustomer.CarRegNo = TestCarRegNo;
            Assert.AreEqual(ACustomer.CarRegNo, TestCarRegNo);
        }

        [TestMethod]
        public void LastNameOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            String TestLastName = "";
            ACustomer.LastName = TestLastName;
            Assert.AreEqual(ACustomer.LastName, TestLastName);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            String TestLastName = "abc";
            Int32 TestCarRegNo = 123456;
            String Error = "";
            Error = ACustomer.Valid(TestLastName, TestCarRegNo);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarRegNoMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String TestLastName = "";
            Int32 TestCarRegNo = 12345;
            String Error = "";
            Error = ACustomer.Valid(TestLastName, TestCarRegNo);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CarRegNoMinBoundary()
        {
            clsCustomer ACustomer = new clsCustomer();
            String TestLastName = "abc";
            Int32 TestCarRegNo = 123456;
            String Error = "";
            Error = ACustomer.Valid(TestLastName, TestCarRegNo);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarRegNoMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String TestLastName = "";
            Int32 TestCarRegNo = 1234567;
            String Error = "";
            Error = ACustomer.Valid(TestLastName, TestCarRegNo);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CarRegNoMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String TestLastName = "";
            Int32 TestCarRegNo = 12345;
            String Error = "";
            Error = ACustomer.Valid(TestLastName, TestCarRegNo);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CarRegNoMaxBoundary()
        {
            clsCustomer ACustomer = new clsCustomer();
            String TestLastName = "abc";
            Int32 TestCarRegNo = 123456;
            String Error = "";
            Error = ACustomer.Valid(TestLastName, TestCarRegNo);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarRegNoMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String TestLastName = "";
            Int32 TestCarRegNo = 1234567;
            String Error = "";
            Error = ACustomer.Valid(TestLastName, TestCarRegNo);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CarRegNoMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String TestLastName = "";
            Int32 TestCarRegNo = 123;
            String Error = "";
            Error = ACustomer.Valid(TestLastName, TestCarRegNo);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CarRegNoExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String TestLastName = "";
            // Int Has a limit of numbers
            Int32 TestCarRegNo = 1234567891;
            String Error = "";
            Error = ACustomer.Valid(TestLastName, TestCarRegNo);
            Assert.AreNotEqual(Error, "");
        }

        // Where the invalid type for CarRegWouldGo

        [TestMethod]
        public void LastNameMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String TestLastName = "a";
            Int32 TestCarRegNo = 123456;
            String Error = "";
            Error = ACustomer.Valid(TestLastName, TestCarRegNo);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinBoundary()
        {
            clsCustomer ACustomer = new clsCustomer();
            String TestLastName = "ab";
            Int32 TestCarRegNo = 123456;
            String Error = "";
            Error = ACustomer.Valid(TestLastName, TestCarRegNo);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String TestLastName = "abc";
            Int32 TestCarRegNo = 123456;
            String Error = "";
            Error = ACustomer.Valid(TestLastName, TestCarRegNo);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String TestLastName = "";
            TestLastName = TestLastName.PadRight(39, 'a');
            Int32 TestCarRegNo = 123456;
            String Error = "";
            Error = ACustomer.Valid(TestLastName, TestCarRegNo);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxBoundary()
        {
            clsCustomer ACustomer = new clsCustomer();
            String TestLastName = "";
            TestLastName = TestLastName.PadRight(40, 'a');
            Int32 TestCarRegNo = 123456;
            String Error = "";
            Error = ACustomer.Valid(TestLastName, TestCarRegNo);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String TestLastName = "";
            TestLastName = TestLastName.PadRight(41, 'a');
            Int32 TestCarRegNo = 123456;
            String Error = "";
            Error = ACustomer.Valid(TestLastName, TestCarRegNo);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String TestLastName = "";
            TestLastName = TestLastName.PadRight(20, 'a');
            Int32 TestCarRegNo = 123456;
            String Error = "";
            Error = ACustomer.Valid(TestLastName, TestCarRegNo);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String TestLastName = "";
            TestLastName = TestLastName.PadRight(5000000, 'a');
            Int32 TestCarRegNo = 123456;
            String Error = "";
            Error = ACustomer.Valid(TestLastName, TestCarRegNo);
            Assert.AreNotEqual(Error, "");
        }

        // Where the invalid type for LastNameWouldGo

    }
}
