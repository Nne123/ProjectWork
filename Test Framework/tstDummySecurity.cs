using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstDummySecurity
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsDummySecurity dummySecurity = new clsDummySecurity();
            Assert.IsNotNull(dummySecurity);
        }
    }
}
