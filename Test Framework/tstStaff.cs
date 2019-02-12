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
            clsStaff AnStaff = new clsStaff();
            //check to see that the class is not null
            Assert.IsNotNull(AnStaff);
        }
    }
}
