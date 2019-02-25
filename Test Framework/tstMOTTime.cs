using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstMOTTime
    {

        [TestMethod]
        public void InstanceOK()
        {
            // create an instance of the class we want to create
            clsMOTTime AMOTTime = new clsMOTTime();
            // test to see that it exists
            Assert.IsNotNull(AMOTTime);
        }

        [TestMethod]
        public void MOTTimeIDPropertyOK()
        {
            // create an instance of the class we want to create
            clsMOTTime AMOTTime = new clsMOTTime();
            // create some test data to assign to the property
            Int32 MOTTimeID = 1;
            // assign the data to the property
            AMOTTime.MOTTimeID = MOTTimeID;
            // test to see that the values are the same
            Assert.AreEqual(AMOTTime.MOTTimeID, MOTTimeID);
        }

        [TestMethod]
        public void MOTTimePropertyOK()
        {
            // create an instance of the class we want to create
            clsMOTTime AMOTTime = new clsMOTTime();
            // create some test data to assign to the property
            Int32 SomeMOTTime = 1;
            // assign the data to the property
            AMOTTime.MOTTime = SomeMOTTime;
            // test to see that the values are the same
            Assert.AreEqual(AMOTTime.MOTTime, SomeMOTTime);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            // create an instance of the class we want to create
            clsMOTTime AMOTTime = new clsMOTTime();
            // create a string variable to store the result of the validation
            String Error = "";
            // create some test data to test the method
            Int32 SomeMOTTime = 10;
            //create some test data to test the method
            string MOTTime = SomeMOTTime.ToString();
            // invoke the method
            Error = AMOTTime.Valid(MOTTime);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void MOTTimeMinLessOne()     // 9am
        {
            // create an instance of our class clsMOTTime
            clsMOTTime AnAppointment = new clsMOTTime();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to assign to the property
            Int32 SomeMOTTime = 9;
            //create some test data to test the method
            string MOTTime = SomeMOTTime.ToString();
            // assign the data to the property
            Error = AnAppointment.Valid(MOTTime);
            // test to see that the values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void MOTTimeMinBoundary()    // 10am
        {
            // create an instance of our class clsMOTTime
            clsMOTTime AnAppointment = new clsMOTTime();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to assign to the property
            Int32 SomeMOTTime = 10;
            //create some test data to test the method
            string MOTTime = SomeMOTTime.ToString();
            // assign the data to the property
            Error = AnAppointment.Valid(MOTTime);
            // test to see that the values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MOTTimeMinPlusOne()     // 11am
        {
            // create an instance of our class clsMOTTime
            clsMOTTime AnAppointment = new clsMOTTime();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to assign to the property
            Int32 SomeMOTTime = 11;
            //create some test data to test the method
            string MOTTime = SomeMOTTime.ToString();
            // assign the data to the property
            Error = AnAppointment.Valid(MOTTime);
            // test to see that the values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MOTTimeMaxLessOne()          // 15:00 / 3pm
        {
            // create an instance of our class clsMOTTime
            clsMOTTime AnAppointment = new clsMOTTime();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to assign to the property
            Int32 SomeMOTTime = 15;
            //create some test data to test the method
            string MOTTime = SomeMOTTime.ToString();
            // assign the data to the property
            Error = AnAppointment.Valid(MOTTime);
            // test to see that the values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MOTTimeMaxBoundary()     // 16:00  / 4 pm
        {
            // create an instance of our class clsMOTTime
            clsMOTTime AnAppointment = new clsMOTTime();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to assign to the property
            Int32 SomeMOTTime = 16;
            //create some test data to test the method
            string MOTTime = SomeMOTTime.ToString();
            // assign the data to the property
            Error = AnAppointment.Valid(MOTTime);
            // test to see that the values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MOTTimeMaxPlusOne()        // 17:00 / 5 pm
        {
            // create an instance of our class clsMOTTime
            clsMOTTime AnAppointment = new clsMOTTime();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to assign to the property
            Int32 SomeMOTTime = 17;
            //create some test data to test the method
            string MOTTime = SomeMOTTime.ToString();
            // assign the data to the property
            Error = AnAppointment.Valid(MOTTime);
            // test to see that the values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void MOTTimeMid()        // 13:00 / 1pm
        {
            // create an instance of our class clsMOTTime
            clsMOTTime AnAppointment = new clsMOTTime();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to assign to the property
            Int32 SomeMOTTime = 13;
            //create some test data to test the method
            string MOTTime = SomeMOTTime.ToString();
            // assign the data to the property
            Error = AnAppointment.Valid(MOTTime);
            // test to see that the values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MOTTimeExtremeMax()        // 20:00 / 8pm
        {
            // create an instance of our class clsMOTTime
            clsMOTTime AnAppointment = new clsMOTTime();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to assign to the property
            Int32 SomeMOTTime = 20;
            //create some test data to test the method
            string MOTTime = SomeMOTTime.ToString();
            // assign the data to the property
            Error = AnAppointment.Valid(MOTTime);
            // test to see that the values are the same
            Assert.AreNotEqual(Error, "");
        }

       


    }
}
