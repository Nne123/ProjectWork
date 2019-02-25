using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Test_Framework
{
    [TestClass]
    public class tstMOTTimeCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsMOTTimeCollection AllMOTTimes = new clsMOTTimeCollection();
            // test to see that it exists
            Assert.IsNotNull(AllMOTTimes);
        }

        [TestMethod]
        public void MOTTimeCountPropertyOK()
        {
            //create an instance of the class we want to create
            clsMOTTimeCollection AllMOTTimes = new clsMOTTimeCollection();
            // create some test data to assign to the property
            Int32 SomeCount = 2;
            // assign the data to the property
            AllMOTTimes.Count = SomeCount;
            // test to see that the two values are the same
            Assert.AreEqual(AllMOTTimes.Count, SomeCount);
        }

        [TestMethod]
        public void AllMOTTimesOK()
        {
            //create an instance of the class we want to create
            clsMOTTimeCollection MOTTimes = new clsMOTTimeCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsMOTTime> TestList = new List<clsMOTTime>();
            // add an item to the list
            // create the item of test data
            clsMOTTime TestItem = new clsMOTTime();
            // set its properties
            TestItem.MOTTimeID = 1;
            TestItem.MOTTime = 10;
            // add the item to the list
            TestList.Add(TestItem);
            // assign the data to the property
            MOTTimes.AllMOTTimes = TestList;
            // test to see that the two values are the same
            Assert.AreEqual(MOTTimes.AllMOTTimes, TestList);
        }

        [TestMethod]
        public void CountMatchesList()
        {
            // create an instance of the class we want to create
            clsMOTTimeCollection MOTTimes = new clsMOTTimeCollection();
            // create some test data to assign to the property
            // in this case the data needs to be a list of objects
            List<clsMOTTime> TestList = new List<clsMOTTime>();
            // add an item to the list
            // create the item of tets data
            clsMOTTime TestItem = new clsMOTTime();
            // set its properties
            TestItem.MOTTimeID = 1;
            TestItem.MOTTime = 10;
            // add the item to the test list
            TestList.Add(TestItem);
            // assign the data to the property
            MOTTimes.AllMOTTimes = TestList;
            // test to see that the two values are the same
            Assert.AreEqual(MOTTimes.Count, TestList.Count);
        }

        [TestMethod]
        public void TwoMOTTimesPresent()
        {
            //create an instance of the class we want to create
            clsMOTTimeCollection MOTTimes = new clsMOTTimeCollection();
            //test to see that the two values are the same
            Assert.AreEqual(MOTTimes.Count, 2);
        }

    }
}
