﻿using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstAppointment
    {
        // good test data
        // create some test data to pass the method
        string carRegNo = "1234 6GH";
        string MOTDate = DateTime.Now.AddDays(1).ToString();
        string MOTTime = Convert.ToString(10);

        string CustomerID = Convert.ToString(1111);
        //Int32 CustomerID2 = Convert.ToInt32("4524");

        string StaffID = Convert.ToString(1111);
        string JobID = Convert.ToString(1111);
        
        
        

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
            string TestData = "123 6GH";
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
        public void MOTTimePropertyOK()
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            // create some test data to assign to the property
            Int32 TestData = 1;
            // assign the data to the property
            AnAppointment.MOTTime = TestData;
            // test to see that the values are the same
            Assert.AreEqual(AnAppointment.MOTTime, TestData);
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
            Error = AnAppointment.Valid(CarRegNo, MOTDate, CustomerID, StaffID, JobID, MOTTime);
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
            Error = AnAppointment.Valid(CarRegNo, MOTDate, CustomerID, StaffID, JobID, MOTTime);
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
        public void MOTDateExtremeMin()
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
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID, MOTTime);
            // test to see that the result is correct
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
            // convert the date variable to a string variable
            string MOTDate = TestDate.ToString();
            // invoke the method
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID, MOTTime);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void MOTDateMinBoundary() // min tomorrow's date
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
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID, MOTTime);
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
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID, MOTTime);
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
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID, MOTTime);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MOTDateMaxPlusOne()      // todays date + 22
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
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID, MOTTime);
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
            TestDate = TestDate.AddDays(100);
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





        [TestMethod]
        public void MOTTimeMinLessOne()     // 9am
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
        public void MOTTimeMinBoundary()    // 10am
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
        public void MOTTimeMinPlusOne()     // 11am
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
        public void MOTTimeMaxLessOne()          // 15:00 / 3pm
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to assign to the property
            Int32 testMOTTime = 15;
            //create some test data to test the method
            string MOTTime = testMOTTime.ToString();
            // assign the data to the property
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID, MOTTime);
            // test to see that the values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MOTTimeMaxBoundary()     // 16:00  / 4 pm
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
        public void MOTTimeMaxPlusOne()        // 17:00 / 5 pm
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
        public void MOTTimeMid()        // 13:00 / 1pm
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to assign to the property
            Int32 testMOTTime = 13;
            //create some test data to test the method
            string MOTTime = testMOTTime.ToString();
            // assign the data to the property
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID, MOTTime);
            // test to see that the values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MOTTimeExtremeMax()        // 20:00 / 8pm
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to assign to the property
            Int32 testMOTTime = 20;
            //create some test data to test the method
            string MOTTime = testMOTTime.ToString();
            // assign the data to the property
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID, MOTTime);
            // test to see that the values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void MOTTimeInvalidData()        // string, datetime etc
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to assign to the property
            string MOTTime = "This is not an integer number!";
            // invoke the method
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID, MOTTime);
            // test to see that the values are the same
            Assert.AreNotEqual(Error, "");
        }







        [TestMethod]
        public void CustomerIDMinLessOne()
        {
            // create an instance of our class clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            //create a string variable to store the result of the validation
            String Error = "";
            // create some test data to assign to the property
            Int32 testCustomerID = Convert.ToInt32(" 1234");
            // create some test data to assign to the property
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
            Int32 CustomerID = Convert.ToInt32("1234");
            //
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
        public void ValidMethodOK()
        {
            // create an instance of clsAppointment
            clsAppointment AnAppointment = new clsAppointment();
            // create a string variable to store the result of the validation
            String Error = "";
            // invoke the method
            Error = AnAppointment.Valid(carRegNo, MOTDate, CustomerID, StaffID, JobID, MOTTime);
            // test to see that the result is OK i.e. there was no error message returned
            Assert.AreEqual(Error, "");
        }

       

       

    }
}
