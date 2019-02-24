using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //test to see if it exists
            Assert.IsNotNull(AllStaffs);
        }

        [TestMethod]
        public void CountOK()
        {
            //create an instance of the class i want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            AllStaffs.Count = TestCount;
            //test to see if it exists
            Assert.AreEqual(AllStaffs.Count, TestCount);
        }
    }
}
