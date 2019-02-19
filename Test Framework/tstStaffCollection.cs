using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class i want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //test to see if it exists
            Assert.IsNotNull(AllStaffs);
        }
    }
}
