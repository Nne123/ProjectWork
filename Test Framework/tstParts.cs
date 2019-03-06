using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstParts
    {
        [TestMethod]
        public void InstanceOK()
        {
            // create an instance of our class clsAppointment
            clsPart AnPart = new clsPart();
            // check to see that the class is not null
            Assert.IsNotNull(AnPart);
        }

        [TestMethod]
        public void InStockPropertyOK()
        {
            // create an instance of the class we want to create
            clsPart AnPart = new clsPart();
            // create some test data to assign to the property
            Boolean TestData = true;
            // assign the data to the property
            AnPart.Active = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnPart.Active, TestData);
        }

        [TestMethod]
        public void PartIDPropertyOK()
        {
            // create an instance of our class clsAppointment
            clsPart AnPart = new clsPart();
            // create some test data to assign to the property
            Int32 TestData = 1;
            // assign the data to the property
            AnPart.PartID = TestData;
            // test to see that the values are the same
            Assert.AreEqual(AnPart.PartID, TestData);
        }

        public void PartTypePropertyOK()
        {
            // create an instance of clsAppointment
            clsPart AnPart = new clsPart();
            // create some test data to assign to the property
            string TestData = "BREAKPAD";
            // assign the data to the property
            AnPart.PartType = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnPart.PartType, TestData);
        }

    }
}
