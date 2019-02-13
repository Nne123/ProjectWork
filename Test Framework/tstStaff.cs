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
    }
}
