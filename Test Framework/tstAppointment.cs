﻿using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstAppointment
    {
        // create some test data to pass the method
        string carRegNo = "123 6GH";
        string MOTDate = DateTime.Now.ToString();
        string CustomerID = Convert.ToString(1111);
        string StaffID = Convert.ToString(1111);
        string JobID = Convert.ToString(1111);
        string MOTTime = Convert.ToString(10);

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
        public void MOTDatePropertyOK()
        {
            // create an instance of clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            // create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            // assign te data to the property
            AnAppointment.MOTDate = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnAppointment.MOTDate, TestData);
        }

        [TestMethod]
        public void MOTTimePropertyOK()
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            // create some test data to assign to the property
            Int32 MOTTime = 1;
            // assign the data to the property
            AnAppointment.MOTTime = MOTTime;
            // test to see that the values are the same
            Assert.AreEqual(AnAppointment.MOTTime, MOTTime);
        }

        [TestMethod]
        public void JobIDPropertyOK()   // test that property has been created
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            // create some test data to assign to the property
            Int32 JobID = 1;
            // assign the data to the property
            AnAppointment.JobID = JobID;
            // test to see that the values are the same
            Assert.AreEqual(AnAppointment.JobID, JobID);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            // create some test data to assign to the property
            Int32 CustomerID = 1;
            // assign the data to the property
            AnAppointment.CustomerID = CustomerID;
            // test to see that the values are the same
            Assert.AreEqual(AnAppointment.CustomerID, CustomerID);
        }

        [TestMethod]
        public void StaffIDPropertyOK()
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            // create some test data to assign to the property
            Int32 StaffID = 1;
            // assign the data to the property
            AnAppointment.StaffID = StaffID;
            // test to see that the values are the same
            Assert.AreEqual(AnAppointment.StaffID, StaffID);
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

        [TestMethod]
        public void MOTTimeMinLessOne()
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to assign to the property
            Int32 testMOTTime = 9;
            //create some test data to test the method
            string MOTTime = testMOTTime.ToString();
            // assign the data to the property
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID, MOTTime);
            // test to see that the values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void MOTTimeMinBoundary()
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to assign to the property
            Int32 testMOTTime = 10;
            //create some test data to test the method
            string MOTTime = testMOTTime.ToString();
            // assign the data to the property
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID, MOTTime);
            // test to see that the values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MOTTimeMinPlusOne()
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to assign to the property
            Int32 testMOTTime = 11;
            //create some test data to test the method
            string MOTTime = testMOTTime.ToString();
            // assign the data to the property
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID, MOTTime);
            // test to see that the values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MOTTimeMaxBoundary()
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to assign to the property
            Int32 testMOTTime = 16;
            //create some test data to test the method
            string MOTTime = testMOTTime.ToString();
            // assign the data to the property
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID, MOTTime);
            // test to see that the values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MOTTimeMaxPlusOne()
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to assign to the property
            Int32 testMOTTime = 17;
            //create some test data to test the method
            string MOTTime = testMOTTime.ToString();
            // assign the data to the property
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID, MOTTime);
            // test to see that the values are the same
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
            Int32 testJobID = 123;
            //create some test data to test the method
            string JobID = testJobID.ToString();
            // assign the data to the property
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID, MOTTime);
            // test to see that the values are the same
            Assert.AreNotEqual(Error, "");
        }

        //[TestMethod]
        //public void JobIDMinBoundary() // def. not this one
        //{
        //    // create an instance of our class clsAppointment
        //    clsAppointment AnAppointment = new clsAppointment();
        //    // create some test data to assign to the property
        //    Int32 JobID = 1234;
        //    // assign the data to the property
        //    AnAppointment.JobID = JobID;
        //    // test to see that the values are the same
        //    Assert.AreEqual(AnAppointment.JobID, JobID);
        //}

        //[TestMethod]
        //public void JobIDMinBoundary()
        //{
        //    // create an instance of our class clsAppointment
        //    clsAppointment AnAppointment = new clsAppointment();
        //    // create a string variable to ...
        //    String Error = "";
        //    // create some teset data to test the method
        //    Int32 testJobID = 1111;  // not what I mean
        //    //create some test data to test the method
        //    string JobID = testJobID.ToString();
        //    // invoke the method
        //    Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID);
        //    // test to see ...
        //    Assert.AreEqual(Error, "");
        //}

        [TestMethod]
        public void JobIDMinPlusOne()
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to assign to the property
            Int32 testJobID = 12345;
            //create some test data to test the method
            string JobID = testJobID.ToString();
            // assign the data to the property
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID, MOTTime);
            // test to see that the values are the same
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
            Int32 testStaffID = 123;
            //create some test data to test the method
            string StaffID = testStaffID.ToString();
            // assign the data to the property
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID, MOTTime);
            // test to see that the values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMinBoundary()
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            // create some test data to assign to the property
            Int32 StaffID = 1234;
            // assign the data to the property
            AnAppointment.StaffID = StaffID;
            // test to see that the values are the same
            Assert.AreEqual(AnAppointment.StaffID, StaffID);
        }

        [TestMethod]
        public void StaffIDMinPlusOne()
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to assign to the property
            Int32 testStaffID = 12345;
            //create some test data to test the method
            string StaffID = testStaffID.ToString();
            // assign the data to the property
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID, MOTTime);
            // test to see that the values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMinLessOne()
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            String Error = "";
            // create some test data to assign to the property
            Int32 testCustomerID = 123;
            string CustomerID = testCustomerID.ToString();
            // assign the data to the property
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID, MOTTime);
            // test to see that the values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMinBoundary()
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            // create some test data to assign to the property
            Int32 CustomerID = 1234;
            // assign the data to the property
            AnAppointment.CustomerID = CustomerID;
            // test to see that the values are the same
            Assert.AreEqual(AnAppointment.CustomerID, CustomerID);
        }

        [TestMethod]
        public void CustomerIDMinPlusOne()
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            String Error = "";
            // create some test data to assign to the property
            Int32 testCustomerID = 12345;
            string CustomerID = testCustomerID.ToString();
            // assign the data to the property
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID, MOTTime);
            // test to see that the values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CarRegNoPropertyOK()
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
            Error = AnAppointment.Valid(CarRegNo, MOTDate, CustomerID, StaffID, JobID, MOTTime);
            // test to see that the result is OK i.e. there was no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarRegNoMinLessOne()         // empty
        {
            // create an instance of clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            // create a string variable to store the result of the validation
            String Error = "";
            // create some test data to test the method
            string CarRegNo = "";
            // invoke the method
            Error = AnAppointment.Valid(CarRegNo, MOTDate, CustomerID, StaffID, JobID, MOTTime);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
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
            Error = AnAppointment.Valid(CarRegNo, MOTDate, CustomerID, StaffID, JobID, MOTTime);
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
            Error = AnAppointment.Valid(CarRegNo, MOTDate, CustomerID, StaffID, JobID, MOTTime);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CarRegNoMaxLessOne()         // 49 characters
        {
            // create an instance of clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            // create a string variable to store the result of the validation
            String Error = "";
            // create some test data to test the method
            string CarRegNo = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            // invoke the method
            Error = AnAppointment.Valid(CarRegNo, MOTDate, CustomerID, StaffID, JobID, MOTTime);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CarRegNoMaxBoundary()         // 50 characters
        {
            // create an instance of clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            // create a string variable to store the result of the validation
            String Error = "";
            // create some test data to test the method
            string CarRegNo = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            // invoke the method
            Error = AnAppointment.Valid(CarRegNo, MOTDate, CustomerID, StaffID, JobID, MOTTime);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CarRegNoMaxPlusOne()         // 51 characters
        {
            // create an instance of clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            // create a string variable to store the result of the validation
            String Error = "";
            // create some test data to test the method
            string CarRegNo = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            // invoke the method
            Error = AnAppointment.Valid(CarRegNo, MOTDate, CustomerID, StaffID, JobID, MOTTime);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CarRegNoMid()         // 25 characters
        {
            // create an instance of clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            // create a string variable to store the result of the validation
            String Error = "";
            // create some test data to test the method
            string CarRegNo = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            // invoke the method
            Error = AnAppointment.Valid(CarRegNo, MOTDate, CustomerID, StaffID, JobID, MOTTime);
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
            Error = AnAppointment.Valid(CarRegNo, MOTDate, CustomerID, StaffID, JobID, MOTTime);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void MOTDateMinLessOne()
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
            TestDate = TestDate.AddDays(-1);
            // convert the date variable to a string variable
            string MOTDate = TestDate.ToString();
            // invoke the method
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID, MOTTime);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void MOTDateMinBoundary() // todays date
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
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID, MOTTime);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void MOTDateMinPlusOne() // min todays date + 1
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
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID, MOTTime);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MOTDateMaxLessOne() // max todays date + 19
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
            TestDate = TestDate.AddDays(19);
            // convert the date variable to a string variable
            string MOTDate = TestDate.ToString();
            // invoke the method
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID, MOTTime);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MOTDateMaxBoundary()   // max today + 20
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
            TestDate = TestDate.AddDays(20);
            // convert the date variable to a string variable
            string MOTDate = TestDate.ToString();
            // invoke the method
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID, MOTTime);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MOTDateMaxPlusOne()      // todays date + 21
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
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID, MOTTime);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
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
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID, MOTTime);
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
            TestDate = TestDate.AddDays(300);
            // convert the date variable to a string variable
            string MOTDate = TestDate.ToString();
            // invoke the method
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID, MOTTime);
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
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID, MOTTime);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

    }
}
