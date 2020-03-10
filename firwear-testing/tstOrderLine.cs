using System;
using FitWear_classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace firwear_testing
{
    [TestClass]
    public class tstOrderLine
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            Assert.IsNotNull(anOrderLine);
        }

        [TestMethod]

        public void OrderLineIDPropertyOk()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            Int32 TestData = 1;
            anOrderLine.OrderLineID = TestData;
            Assert.AreEqual(anOrderLine.OrderLineID, TestData);
        }

        [TestMethod]

        public void OrderIDPropertyOk()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            Int32 TestData = 1;
            anOrderLine.OrderID = TestData;
            Assert.AreEqual(anOrderLine.OrderID, TestData);
        }

        [TestMethod]

        public void ProductIDPropertyOk()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            Int32 TestData = 1;
            anOrderLine.ProductID = TestData;
            Assert.AreEqual(anOrderLine.ProductID, TestData);
        }

        [TestMethod]

        public void QuantityPropertyOk()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            Int32 TestData = 1;
            anOrderLine.Quantity = TestData;
            Assert.AreEqual(anOrderLine.Quantity, TestData);
        }

        [TestMethod]
        public void FindMethodOk()
        {
            clsOrderLine anOrderline = new clsOrderLine();
            Boolean Found = false;
            Int32 OrderLineID = 1;
            Found = anOrderline.Find(OrderLineID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderLineIDFound()
        {
            clsOrderLine anOrderLine= new clsOrderLine();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderLineID = 1;
            Found = anOrderLine.Find(OrderLineID);
            if (anOrderLine.OrderLineID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderIDFound()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 1;
            Found = anOrderLine.Find(OrderID);
            if (anOrderLine.OrderID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductIDFound()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 1;
            Found = anOrderLine.Find(ProductID);
            if (anOrderLine.ProductID != 123)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestQuantityFound()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Quantity = 1;
            Found = anOrderLine.Find(Quantity);
            if (anOrderLine.Quantity != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }





    }
}
