﻿using System;
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

        [TestMethod]
        public void AppointmentListOK() // AllAppointmentsOK()
        {
            // create an instance of the class we want to create
            clsAppointmentCollection AllAppointments = new clsAppointmentCollection();
            // create some test data to assign to the property
            // in this case the data needs t be a list of objects
            List<clsAppointment> TestList = new List<clsAppointment>();
            // add an item to the list
            // create the item of the test data
            clsAppointment TestItem = new clsAppointment();
            // set its properties
            TestItem.AppointmentID = 1;
            TestItem.CarRegNo = "1234 9GH";
            TestItem.CustomerID = 1;
            TestItem.StaffID = 1;
            TestItem.JobID = 1;
            TestItem.MOTDate = DateTime.Now.Date.AddDays(1);
            TestItem.MOTTimeID = 10;
            TestItem.Active = true;
            // add the item to the test list
            TestList.Add(TestItem);
            // assign the data to the property
            AllAppointments.AppointmentList = TestList;
            // test to see that the two values are the same
            Assert.AreEqual(AllAppointments.AppointmentList, TestList);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            // create an instance of the class we want to create
            clsAppointmentCollection AllAppointments = new clsAppointmentCollection();
            // create some test data to assign to the property
            Int32 SomeCount = 2;
            // assign the data to the property
            AllAppointments.Count = SomeCount;
            // test to see that the two values are the same
            Assert.AreEqual(AllAppointments.Count, SomeCount);
        }

        //[TestMethod]
        //public void TwoAppointmentsPresent()
        //{
        //    // create an instance of the class we want to create
        //    clsAppointmentCollection AllAppointments = new clsAppointmentCollection();
        //    // test to see that the two values are the same
        //    Assert.AreEqual(AllAppointments.Count, 2);
        //}

        [TestMethod]
        public void CountMatchesList()
        {
            // create an instance of the class we want to create
            clsAppointmentCollection Appointments = new clsAppointmentCollection();
            // create some test data to assign to the property
            // in this case the data needs to be a list of objects
            List<clsAppointment> TestList = new List<clsAppointment>();
            // add an item to the list
            // create the item of tets data
            clsAppointment TestItem = new clsAppointment();
            // set its properties
            TestItem.AppointmentID = 1;
            TestItem.CarRegNo = "1234 9GH";
            TestItem.CustomerID = 1;
            TestItem.StaffID = 1;
            TestItem.JobID = 1;
            TestItem.MOTDate = DateTime.Now.Date.AddDays(1);
            TestItem.MOTTimeID = 10;
            TestItem.Active = true;
            // add the item to the test list
            TestList.Add(TestItem);
            // assign the data to the property
            Appointments.AppointmentList = TestList;
            // test to see that the two values are the same
            Assert.AreEqual(Appointments.Count, TestList.Count);
        }

        [TestMethod]
        public void ThisAppointmentPropertyOK()
        {
            // create an instance of the class we want to create
            clsAppointmentCollection AllAppointments = new clsAppointmentCollection();
            // create some test data to assign to the property
            clsAppointment TestAppointment = new clsAppointment();
            TestAppointment.AppointmentID = 1;
            TestAppointment.CarRegNo = "123 9GH";
            TestAppointment.CustomerID = 1;
            TestAppointment.StaffID = 1;
            TestAppointment.JobID = 1;
            TestAppointment.MOTDate = DateTime.Now.Date;
            TestAppointment.MOTTimeID = 1;
            // assign the data to the property
            AllAppointments.ThisAppointment = TestAppointment;
            // test to see that the two values are the same
            Assert.AreEqual(AllAppointments.ThisAppointment, TestAppointment);
        }
    }
}
