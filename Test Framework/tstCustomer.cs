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

        //[TestMethod]
        //public void CarRegNoOK()
        //{
        //    clsCustomer ACustomer = new clsCustomer();
        //    Int32 TestCarRegNo = 123;
        //    ACustomer.CarRegNo = TestCarRegNo;
        //    Assert.AreEqual(ACustomer.CarRegNo, TestCarRegNo);
        //}

        //[TestMethod]
        //public void LastNameOK()
        //{
        //    clsCustomer ACustomer = new clsCustomer();
        //    String TestLastName = "";
        //    ACustomer.LastName = TestLastName;
        //    Assert.AreEqual(ACustomer.LastName, TestLastName);
        //}

        //[TestMethod]
        //public void ValidMethodOK()
        //{
        //    clsCustomer ACustomer = new clsCustomer();
        //    String TestLastName = "abc";
        //    Int32 TestCarRegNo = 123456;
        //    String Error = "";
        //    Error = ACustomer.Valid(TestLastName, TestCarRegNo);
        //    Assert.AreEqual(Error, "");
        //}

        //[TestMethod]
        //public void CarRegNoMinLessOne()
        //{
        //    clsCustomer ACustomer = new clsCustomer();
        //    String TestLastName = "";
        //    Int32 TestCarRegNo = 12345;
        //    String Error = "";
        //    Error = ACustomer.Valid(TestLastName, TestCarRegNo);
        //    Assert.AreNotEqual(Error, "");
        //}

        //[TestMethod]
        //public void CarRegNoMinBoundary()
        //{
        //    clsCustomer ACustomer = new clsCustomer();
        //    String TestLastName = "abc";
        //    Int32 TestCarRegNo = 123456;
        //    String Error = "";
        //    Error = ACustomer.Valid(TestLastName, TestCarRegNo);
        //    Assert.AreEqual(Error, "");
        //}

        //[TestMethod]
        //public void CarRegNoMinPlusOne()
        //{
        //    clsCustomer ACustomer = new clsCustomer();
        //    String TestLastName = "";
        //    Int32 TestCarRegNo = 1234567;
        //    String Error = "";
        //    Error = ACustomer.Valid(TestLastName, TestCarRegNo);
        //    Assert.AreNotEqual(Error, "");
        //}
    }
}
