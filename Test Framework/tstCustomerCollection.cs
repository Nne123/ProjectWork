using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            // New instance of clsCustomerCollection class
            clsCustomerCollection Customers = new clsCustomerCollection();
            // Check whether the instance exists
            Assert.IsNotNull(Customers);
        }
    }
}
