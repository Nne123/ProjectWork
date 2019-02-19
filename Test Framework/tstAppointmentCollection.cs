using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Test_Framework
{
    [TestClass]
    public class tstAppointmentCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            // create an instance of the class we want to create
            clsAppointmentCollection AllAppointments = new clsAppointmentCollection();
            // test to see that it exists
            Assert.IsNotNull(AllAppointments);
        }
    

    }
}
