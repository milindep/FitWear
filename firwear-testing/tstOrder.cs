using System;
using FitWear_classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace firwear_testing
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderProcessing anOrderProcessing = new clsOrderProcessing();
            Assert.IsNotNull(anOrderProcessing);

        }
        
        [TestMethod]
        public void OrderID()
        {
            clsOrderProcessing anOrderProcessing = new clsOrderProcessing();
            Int32 TestData = 1;
            anOrderProcessing.OrderID = TestData;
            Assert.AreEqual(anOrderProcessing.OrderID, TestData);
        }
        [TestMethod]

        public void CustomerID()
        {
            clsOrderProcessing anOrderProcessing = new clsOrderProcessing();
            Int32 TestData = 1;
            anOrderProcessing.CustomerID = TestData;
            Assert.AreEqual(anOrderProcessing.CustomerID, TestData);

        }
    }
}

