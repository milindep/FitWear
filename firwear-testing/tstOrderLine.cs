using System;
using FitWear_classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace firwear_testing
{
    [TestClass]
    public class tstOrderLine
    {
        //string OrderLineID = "1";
        string OrderID = "1";
        string ProductID = "123";
        string Quantity = "1";

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
            Int32 OrderLineID = 6;
            Found = anOrderLine.Find(OrderLineID);
            if (anOrderLine.OrderLineID != 6)
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
            Int32 OrderLineID = 6;
            Found = anOrderLine.Find(OrderLineID);
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
            Int32 OrderLineID = 6;
            Found = anOrderLine.Find(OrderLineID);
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
            Int32 OrderLineID = 6;
            Found = anOrderLine.Find(OrderLineID);
            if (anOrderLine.Quantity != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            String Error = "";
            Error = anOrderLine.Valid(OrderID, ProductID, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMinLessOne()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            String Error = "";
            string OrderID = "";
            Error = anOrderLine.Valid(OrderID, ProductID, Quantity);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMin()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            String Error = "";
            string OrderID = "1";
            Error = anOrderLine.Valid(OrderID, ProductID, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMinPlusOne()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            String Error = "";
            string OrderID = "11";
            Error = anOrderLine.Valid(OrderID, ProductID, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMaxLessOne()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            String Error = "";
            string OrderID = "11111";
            Error = anOrderLine.Valid(OrderID, ProductID, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMax()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            String Error = "";
            string OrderID = "111111";
            Error = anOrderLine.Valid(OrderID, ProductID, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMid()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            String Error = "";
            string OrderID = "111";
            Error = anOrderLine.Valid(OrderID, ProductID, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMaxPlusOne()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            String Error = "";
            string OrderID = "1111111";
            Error = anOrderLine.Valid(OrderID, ProductID, Quantity);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDExtremeMax()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            String Error = "";
            string OrderID = "";
            OrderID = OrderID.PadRight(500, '1');
            Error = anOrderLine.Valid(OrderID, ProductID, Quantity);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMinLessOne()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            String Error = "";
            string ProductID = "";
            Error = anOrderLine.Valid(OrderID, ProductID, Quantity);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMin()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            String Error = "";
            string ProductID = "1";
            Error = anOrderLine.Valid(OrderID, ProductID, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMinPlusOne()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            String Error = "";
            string ProductID = "11";
            Error = anOrderLine.Valid(OrderID, ProductID, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMaxLessOne ()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            String Error = "";
            string ProductID = "11111";
            Error = anOrderLine.Valid(OrderID, ProductID, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMax()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            String Error = "";
            string ProductID = "111111";
            Error = anOrderLine.Valid(OrderID, ProductID, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMid()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            String Error = "";
            string ProductID = "111";
            Error = anOrderLine.Valid(OrderID, ProductID, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMaxPlusOne()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            String Error = "";
            string ProductID = "1111111";
            Error = anOrderLine.Valid(OrderID, ProductID, Quantity);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDExtremeMax()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            String Error = "";
            string ProductID = "";
            ProductID = ProductID.PadRight(500, '1');
            Error = anOrderLine.Valid(OrderID, ProductID, Quantity);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinLessOne()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            String Error = "";
            string Quantity= "";
            Error = anOrderLine.Valid(OrderID, ProductID, Quantity);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMin()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            String Error = "";
            string Quantity = "1";
            Error = anOrderLine.Valid(OrderID, ProductID, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinPlusOne()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            String Error = "";
            string Quantity = "11";
            Error = anOrderLine.Valid(OrderID, ProductID, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxLessOne()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            String Error = "";
            string Quantity = "11111";
            Error = anOrderLine.Valid(OrderID, ProductID, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMax()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            String Error = "";
            string Quantity = "111111";
            Error = anOrderLine.Valid(OrderID, ProductID, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMid()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            String Error = "";
            string Quantity = "111";
            Error = anOrderLine.Valid(OrderID, ProductID, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxPlusOne()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            String Error = "";
            string Quantity = "1111111";
            Error = anOrderLine.Valid(OrderID, ProductID, Quantity);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QualityExtremeMax()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            String Error = "";
            string Quantity = "";
            Quantity = Quantity.PadRight(500, '1');
            Error = anOrderLine.Valid(OrderID, ProductID, Quantity);
            Assert.AreNotEqual(Error, "");
        }
    }



}
