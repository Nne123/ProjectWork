using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstAppointment
    {
        [TestMethod]
        public void InstanceOK()
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            // check to see that the class is not null
            Assert.IsNotNull(AnAppointment);
        }

        [TestMethod]
        public void AppointmentIDPropertyOK()
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            // create some test data to assign to the property
            Int32 AppointmentID = 1;
            // assign the data to the property
            AnAppointment.AppointmentID = AppointmentID;
            // test to see that the values are the same
            Assert.AreEqual(AnAppointment.AppointmentID, AppointmentID);
        }

        [TestMethod]
        public void CarRegNoOK()
        {
            // create an instance of clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            // create some test data to assign to the property
            string SomeCarRegNo = "123 6GH";
            // assign the data to the property
            AnAppointment.CarRegNo = SomeCarRegNo;
            // test to see that the two values are the same
            Assert.AreEqual(AnAppointment.CarRegNo, SomeCarRegNo);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            // create an instance of clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            // create a string variable to store the result of the validation
            String Error = "";
            // create some test data to test the method
            string CarRegNo = "123 G6H";
            // invoke the method
            Error = AnAppointment.Valid(CarRegNo);
            // test to see that the result is OK i.e. there was no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarRegNoMinLessOne()
        {
            // create an instance of clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            // create a string variable to store the result of the validation
            String Error = "";
            // create some test data to test the method
            string CarRegNo = "";
            // invoke the method
            Error = AnAppointment.Valid(CarRegNo);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }
    }
}
