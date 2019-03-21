using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstAppointment
    {
        // good test data
        // create some test data to pass the method
        string carRegNo = "1234 7G6";
        string MOTDate = DateTime.Now.AddDays(1).ToString();
        string CustomerID = Convert.ToString(25);
        string StaffID = Convert.ToString(35);
        string JobID = Convert.ToString(60);
                

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
        public void CarRegNoPropertyOK()
        {
            // create an instance of clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            // create some test data to assign to the property
            string TestData = "1234 6GH";
            // assign the data to the property
            AnAppointment.CarRegNo = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnAppointment.CarRegNo, TestData);
        }

        [TestMethod]
        public void MOTDatePropertyOK()
        {
            // create an instance of clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            // create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            // assign the data to the property
            AnAppointment.MOTDate = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnAppointment.MOTDate, TestData);
        }

        [TestMethod]
        public void MOTTimeIDPropertyOK()
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            // create some test data to assign to the property
            Int32 TestData = 10;
            // assign the data to the property
            AnAppointment.MOTTimeID = TestData;
            // test to see that the values are the same
            Assert.AreEqual(AnAppointment.MOTTimeID, TestData);
        }

        [TestMethod]
        public void JobIDPropertyOK()   // test that property has been created
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            // create some test data to assign to the property
            Int32 TestData = 1;
            // assign the data to the property
            AnAppointment.JobID = TestData;
            // test to see that the values are the same
            Assert.AreEqual(AnAppointment.JobID, TestData);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            // create some test data to assign to the property
            Int32 TestData = 1;
            // assign the data to the property
            AnAppointment.CustomerID = TestData;
            // test to see that the values are the same
            Assert.AreEqual(AnAppointment.CustomerID, TestData);
        }

        [TestMethod]
        public void StaffIDPropertyOK()
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            // create some test data to assign to the property
            Int32 TestData = 1;
            // assign the data to the property
            AnAppointment.StaffID = TestData;
            // test to see that the values are the same
            Assert.AreEqual(AnAppointment.StaffID, TestData);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            // create an instance of the class we want to create
            clsAppointment AnAppointment = new clsAppointment();
            // create some test data to assign to the property
            Boolean TestData = true;
            // assign the data to the property
            AnAppointment.Active = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnAppointment.Active, TestData);
        }





        //end PropertyOK for TestData

        [TestMethod]
        public void CarRegNoExtremeMin()         // 1 character
        {
            // create an instance of clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            // create a string variable to store the result of the validation
            String Error = "";
            // create some test data to test the method
            string CarRegNo = "a";
            // invoke the method
            Error = AnAppointment.Valid(CarRegNo, MOTDate, CustomerID, StaffID, JobID);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CarRegNoMinLessOne()         // 7 characters
        {
            // create an instance of clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            // create a string variable to store the result of the validation
            String Error = "";
            // create some test data to test the method
            string CarRegNo = "aaaaaaa";
            // invoke the method
            Error = AnAppointment.Valid(CarRegNo, MOTDate, CustomerID, StaffID, JobID);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarRegNoMinBoundary()         // 8 characters
        {
            // create an instance of clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            // create a string variable to store the result of the validation
            String Error = "";
            // create some test data to test the method
            string CarRegNo = "aaaaaaaa";
            // invoke the method
            Error = AnAppointment.Valid(CarRegNo, MOTDate, CustomerID, StaffID, JobID);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarRegNoMinPlusOne()         // 9 characters
        {
            // create an instance of clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            // create a string variable to store the result of the validation
            String Error = "";
            // create some test data to test the method
            string CarRegNo = "aaaaaaaaa";
            // invoke the method
            Error = AnAppointment.Valid(CarRegNo, MOTDate, CustomerID, StaffID, JobID);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CarRegNoExtremeMax()         // 300 characters
        {
            // create an instance of clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            // create a string variable to store the result of the validation
            String Error = "";
            // create some test data to test the method
            string CarRegNo = "";
            // pad the string with characters
            CarRegNo = CarRegNo.PadRight(300, 'a');
            // invoke the method
            Error = AnAppointment.Valid(CarRegNo, MOTDate, CustomerID, StaffID, JobID);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void MOTDateExtremeMin()         // - 100 days
        {
            // create an instance of clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            // string variable to store any error message
            String Error = "";
            // create a variable to store the test data
            DateTime TestDate;
            // set the date to todays date
            TestDate = DateTime.Now.Date;
            // change the date to whatever the date is less one day
            TestDate = TestDate.AddDays(-100);
            // convert the date variable to a string variable
            string MOTDate = TestDate.ToString();
            // invoke the method
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void MOTDateMinLessOne()           // Today
        {
            // create an instance of clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            // string variable to store any error message
            String Error = "";
            // create a variable to store the test data
            DateTime TestDate;
            // set the date to todays date
            TestDate = DateTime.Now.Date;
            // convert the date variable to a string variable
            string MOTDate = TestDate.ToString();
            // invoke the method
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void MOTDateNull()
        {
            DateTime? testDate = null;
            Assert.AreEqual(null, testDate);
        }

        [TestMethod]
        public void MOTDateNulls()
        {
            clsAppointment AnAppointment = new clsAppointment();
            String Error = "";
            DateTime? TestDate;
            TestDate = null;
            string MOTDate = TestDate.ToString();
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID);
            Assert.AreEqual(null, TestDate);
        }

        [TestMethod]
        public void MOTDateMinBoundary() // boundary today + 1
        {
            // create an instance of clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            // string variable to store any error message
            String Error = "";
            // create a variable to store the test data
            DateTime TestDate;
            // set the date to todays date
            TestDate = DateTime.Now.Date;
            // change the date to whatever the date is less one day
            TestDate = TestDate.AddDays(1);
            // convert the date variable to a string variable
            string MOTDate = TestDate.ToString();
            // invoke the method
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MOTDateMinPlusOne() // min todays date + 2
        {
            // create an instance of clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            // string variable to store any error message
            String Error = "";
            // create a variable to store the test data
            DateTime TestDate;
            // set the date to todays date
            TestDate = DateTime.Now.Date;
            // change the date to whatever the date is less one day
            TestDate = TestDate.AddDays(2);
            // convert the date variable to a string variable
            string MOTDate = TestDate.ToString();
            // invoke the method
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void MOTDateMaxLessOne() // max todays date + 20
        {
            // create an instance of clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            // string variable to store any error message
            String Error = "";
            // create a variable to store the test data
            DateTime TestDate;
            // set the date to todays date
            TestDate = DateTime.Now.Date;
            // change the date to whatever the date is less one day
            TestDate = TestDate.AddDays(20);
            // convert the date variable to a string variable
            string MOTDate = TestDate.ToString();
            // invoke the method
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MOTDateMaxBoundary()   // max today + 21
        {
            // create an instance of the class we want to create
            clsAppointment AnAppointment = new clsAppointment();
            // string variable to store any error message
            String Error = "";
            // create a variable to store the test data
            DateTime TestDate;
            // set the date to todays date
            TestDate = DateTime.Now.Date;
            // change the date to whatever the date is less one day
            TestDate = TestDate.AddDays(21);
            // convert the date variable to a string variable
            string MOTDate = TestDate.ToString();
            // invoke the method
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MOTDateMaxPlusOne()      // max todays date + 22
        {
            // create an instance of the class we want to create
            clsAppointment AnAppointment = new clsAppointment();
            // string variable to store any error message
            String Error = "";
            // create a variable to store the test data
            DateTime TestDate;
            // set the date to todays date
            TestDate = DateTime.Now.Date;
            // change the date to whatever the date is less one day
            TestDate = TestDate.AddDays(22);
            // convert the date variable to a string variable
            string MOTDate = TestDate.ToString();
            // invoke the method
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void MOTDateMid()     // middle date, today + 10
        {
            // create an instance of the class we want to create
            clsAppointment AnAppointment = new clsAppointment();
            // string variable to store any error message
            String Error = "";
            // create a variable to store the test data
            DateTime TestDate;
            // set the date to todays date
            TestDate = DateTime.Now.Date;
            // change the date to whatever the date is less one day
            TestDate = TestDate.AddDays(10);
            // convert the date variable to a string variable
            string MOTDate = TestDate.ToString();
            // invoke the method
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MOTDateExtremeMax()      // extreme max date
        {
            // create an instance of the class we want to create
            clsAppointment AnAppointment = new clsAppointment();
            // string variable to store any error message
            String Error = "";
            // create a variable to store the test data
            DateTime TestDate;
            // set the date to todays date
            TestDate = DateTime.Now.Date;
            // change the date to whatever the date is less one day
            TestDate = TestDate.AddDays(100);
            // convert the date variable to a string variable
            string MOTDate = TestDate.ToString();
            // invoke the method
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void MOTDateInvalidData()   // invalid date
        {
            // create an instance of the class we want to create
            clsAppointment AnAppointment = new clsAppointment();
            // string variable to store any error message
            String Error = "";
            // store the error message in the string variable
            string MOTDate = "this is not a date!";
            // invoke the method
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



        // TO DO: fix customer id, staff id and job id.


        [TestMethod]
        public void CustomerIDMinLessOne()
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to assign to the property
            Int32 testCustomerID = 0;
            // create some test data to assign to the property
            string CustomerID = testCustomerID.ToString();
            // assign the data to the property
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID);
            // test to see that the values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMinBoundary()
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to assign to the property
            Int32 testCustomerID = 1;
            // create some test data to assign to the property
            string CustomerID = testCustomerID.ToString();
            // assign the data to the property
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID);
            // test to see that the values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMinPlusOne()
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to assign to the property
            Int32 testCustomerID = 2;
            // create some test data to assign to the property
            string CustomerID = testCustomerID.ToString();
            // assign the data to the property
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID);
            // test to see that the values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMaxLessOne()
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to assign to the property
            Int32 testCustomerID = 599;
            // create some test data to assign to the property
            string CustomerID = testCustomerID.ToString();
            // assign the data to the property
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID);
            // test to see that the values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMaxBoundary()
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to assign to the property
            Int32 testCustomerID = 600;
            // create some test data to assign to the property
            string CustomerID = testCustomerID.ToString();
            // assign the data to the property
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID);
            // test to see that the values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMaxPlusOne()
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to assign to the property
            Int32 testCustomerID = 601;
            // create some test data to assign to the property
            string CustomerID = testCustomerID.ToString();
            // assign the data to the property
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID);
            // test to see that the values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMid()                // mid 300
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to assign to the property
            Int32 testCustomerID = 300;
            // create some test data to assign to the property
            string CustomerID = testCustomerID.ToString();
            // assign the data to the property
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID);
            // test to see that the values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDExtremeMax()         // extreme 6000
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to assign to the property
            Int32 testCustomerID = 6000;
            // create some test data to assign to the property
            string CustomerID = testCustomerID.ToString();
            // assign the data to the property
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID);
            // test to see that the values are the same
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerIDInvalidData()
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            //create a string variable to store the result of the validation
            String Error = "";
            // set the customer id to a no integer value
            string CustomerID = "this is not an integer value!";
            // invoke the method
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }





        [TestMethod]
        public void StaffIDMinLessOne()
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to assign to the property
            Int32 testStaffID = 0;
            //create some test data to test the method
            string StaffID = testStaffID.ToString();
            // assign the data to the property
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID);
            // test to see that the values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMinBoundary()
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to assign to the property
            Int32 testStaffID = 1;
            //create some test data to test the method
            string StaffID = testStaffID.ToString();
            // assign the data to the property
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID);
            // test to see that the values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMinPlusOne()
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to assign to the property
            Int32 testStaffID = 2;
            //create some test data to test the method
            string StaffID = testStaffID.ToString();
            // assign the data to the property
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID);
            // test to see that the values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMaxLessOne()         // 599
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to assign to the property
            Int32 testStaffID = 599;
            //create some test data to test the method
            string StaffID = testStaffID.ToString();
            // assign the data to the property
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID);
            // test to see that the values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMaxBoundary()       // 600
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to assign to the property
            Int32 testStaffID = 600;
            //create some test data to test the method
            string StaffID = testStaffID.ToString();
            // assign the data to the property
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID);
            // test to see that the values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMaxPlusOne()
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to assign to the property
            Int32 testStaffID = 601;
            //create some test data to test the method
            string StaffID = testStaffID.ToString();
            // assign the data to the property
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID);
            // test to see that the values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMid()
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to assign to the property
            Int32 testStaffID = 300;
            //create some test data to test the method
            string StaffID = testStaffID.ToString();
            // assign the data to the property
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID);
            // test to see that the values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDExtremeMax()
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to assign to the property
            Int32 testStaffID = 6000;
            //create some test data to test the method
            string StaffID = testStaffID.ToString();
            // assign the data to the property
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID);
            // test to see that the values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDInvalidData()
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            //create a string variable to store the result of the validation
            String Error = "";
            // set the customer id to a no integer value
            string StaffID = "this is not an integer value!";
            // invoke the method
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void JobIDMinLessOne()
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to assign to the property
            Int32 testJobID = 0;
            //create some test data to test the method
            string JobID = testJobID.ToString();
            // assign the data to the property
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID);
            // test to see that the values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void JobIDMinBoundary()          // 1
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to assign to the property
            Int32 testJobID = 1;
            //create some test data to test the method
            string JobID = testJobID.ToString();
            // assign the data to the property
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID);
            // test to see that the values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void JobIDMinPlusOne()        // 2
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to assign to the property
            Int32 testJobID = 2;
            //create some test data to test the method
            string JobID = testJobID.ToString();
            // assign the data to the property
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID);
            // test to see that the values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void JobIDMaxLessOne()        // 599
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to assign to the property
            Int32 testJobID = 599;
            //create some test data to test the method
            string JobID = testJobID.ToString();
            // assign the data to the property
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID);
            // test to see that the values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void JobIDMaxBoundary()      // 600
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to assign to the property
            Int32 testJobID = 600;
            //create some test data to test the method
            string JobID = testJobID.ToString();
            // assign the data to the property
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID);
            // test to see that the values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void JobIDMaxPlusOne()
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to assign to the property
            Int32 testJobID = 601;
            //create some test data to test the method
            string JobID = testJobID.ToString();
            // assign the data to the property
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID);
            // test to see that the values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void JobIDMid()         // 300
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to assign to the property
            Int32 testJobID = 300;
            //create some test data to test the method
            string JobID = testJobID.ToString();
            // assign the data to the property
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID);
            // test to see that the values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void JobIDExtremeMax()
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to assign to the property
            Int32 testJobID = 6000;
            //create some test data to test the method
            string JobID = testJobID.ToString();
            // assign the data to the property
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID);
            // test to see that the values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void JobIDInvalidData()
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            //create a string variable to store the result of the validation
            String Error = "";
            // set the customer id to a no integer value
            string StaffID = "this is not an integer value!";
            // invoke the method
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            // create an instance of clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            // create a string variable to store the result of the validation
            String Error = "";
            // invoke the method
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID);
            // test to see that the result is OK i.e. there was no error message returned
            Assert.AreEqual(Error, "");
        }       





        /// Methods Below
        /// 


        [TestMethod]
        public void FindMethodOK()
        {
            // create an instance of clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            // boolean variable to store the result of the validation
            Boolean Found = false;
            // create some test data to use with the method
            Int32 AppointmentID = 3;
            // invoke the method
            Found = AnAppointment.Find(AppointmentID);
            // test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestAppointmentIDFound()
        {
            // create an instance of clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            // boolean variable to store the result of the search
            Boolean Found = false;
            // boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 AppointmentID = 3;
            // invoke the method
            Found = AnAppointment.Find(AppointmentID);
            // check the appointment no
            if (AnAppointment.AppointmentID != 3)
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            // create an instance of clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            // boolean variable to store the result of the search
            Boolean Found = false;
            // boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 AppointmentID = 3;
            // invoke the method
            Found = AnAppointment.Find(AppointmentID);
            // check the appointment no
            if (AnAppointment.CustomerID != 3)
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffIDFound()
        {
            // create an instance of clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            // boolean variable to store the result of the search
            Boolean Found = false;
            // boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 AppointmentID = 3;
            // invoke the method
            Found = AnAppointment.Find(AppointmentID);
            // check the appointment no
            if (AnAppointment.StaffID != 3)
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestJobIDFound()
        {
            // create an instance of clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            // boolean variable to store the result of the search
            Boolean Found = false;
            // boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 AppointmentID = 3;
            // invoke the method
            Found = AnAppointment.Find(AppointmentID);
            // check the appointment no
            if (AnAppointment.JobID != 3)
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestMOTTimeIDFound()
        {
            // create an instance of clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            // boolean variable to store the result of the search
            Boolean Found = false;
            // boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 AppointmentID = 3;
            // invoke the method
            Found = AnAppointment.Find(AppointmentID);
            // check the appointment no
            if (AnAppointment.MOTTimeID != 3)
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestMOTDateFound()
        {
            // create an instance of clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            // boolean variable to store the result of the search
            Boolean Found = false;
            // boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 AppointmentID = 3;
            // invoke the method
            Found = AnAppointment.Find(AppointmentID);
            // check the appointment no
            if (AnAppointment.MOTDate != Convert.ToDateTime("23/03/2019"))
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }



        [TestMethod]
        public void TestActiveFound()
        {
            // create an instance of clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            // boolean variable to store the result of the search
            Boolean Found = false;
            // boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 AppointmentID = 5;
            // invoke the method
            Found = AnAppointment.Find(AppointmentID);
            // check the appointment no
            if (AnAppointment.Active != true)
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
