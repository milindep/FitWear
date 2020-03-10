using System;
using FitWear_classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace firwear_testing

{
    [TestClass]
    public class tstOrder
    {


        string CustomerID = "19";
        string OrderDescription = "Hollister sweat";
        string OrderDate = DateTime.Now.Date.ToString();
        string TotalOrderAmount = "25.00";
        string OrderDispatched = "True";



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

        public void CustomerIDOk()
        {
            clsOrderProcessing anOrderProcessing = new clsOrderProcessing();
            Int32 TestData = 1;
            anOrderProcessing.CustomerID = TestData;
            Assert.AreEqual(anOrderProcessing.CustomerID, TestData);

        }

        [TestMethod]

        public void OrderDescriptionOk()
        {
            clsOrderProcessing anOrderProcessing = new clsOrderProcessing();
            string TestData = "some Order Description";
            anOrderProcessing.OrderDescription = TestData;
            Assert.AreEqual(anOrderProcessing.OrderDescription, TestData);
        }


        [TestMethod]

        public void OrderDateOk()
        {
            clsOrderProcessing anOrderProcessing = new clsOrderProcessing();
            DateTime TestData = DateTime.Now.Date;
            anOrderProcessing.OrderDate = TestData;
            Assert.AreEqual(anOrderProcessing.OrderDate, TestData);

        }

        [TestMethod]

        public void TotalOrderAmountOk()
        {
            clsOrderProcessing anOrderProcessing = new clsOrderProcessing();
            double TestData = 9.99;
            anOrderProcessing.TotalOrderAmount = TestData;
            Assert.AreEqual(anOrderProcessing.TotalOrderAmount, TestData);


        }

        [TestMethod]

        public void OrderDispatchedOk()
        {
            clsOrderProcessing anOrderProcessing = new clsOrderProcessing();
            Boolean TestData = true;
            anOrderProcessing.OrderDispatched = TestData;
            Assert.AreEqual(anOrderProcessing.OrderDispatched, TestData);

        }

        [TestMethod]

        public void FindMethodOK()
        {
            clsOrderProcessing anOrderProcessing = new clsOrderProcessing();
            Boolean Found = false;
            Int32 OrderID = 21;
            Found = anOrderProcessing.Find(OrderID);
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestOrderIDFound()
        {
            clsOrderProcessing anOrderProcessing = new clsOrderProcessing();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 21;
            Found = anOrderProcessing.Find(OrderID);
            if (anOrderProcessing.OrderID != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);


        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            clsOrderProcessing anOrderProcessing = new clsOrderProcessing();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 21;
            Found = anOrderProcessing.Find(OrderID);
            if (anOrderProcessing.CustomerID != 19)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestOrderDescriptionFound()
        {
            clsOrderProcessing anOrderProcessing = new clsOrderProcessing();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 21;
            Found = anOrderProcessing.Find(OrderID);
            if (anOrderProcessing.OrderDescription != "Hollister sweat")
            {
                OK = false;

            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderDateFound()
        {
            clsOrderProcessing anOrderProcessing = new clsOrderProcessing();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 21;
            Found = anOrderProcessing.Find(OrderID);
            if (anOrderProcessing.OrderDate != Convert.ToDateTime("03/03/2020"))
            {
                OK = false;

            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTotalOrderAmountFound()
        {
            clsOrderProcessing anOrderProcessing = new clsOrderProcessing();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 21;
            Found = anOrderProcessing.Find(OrderID);
            if (anOrderProcessing.TotalOrderAmount != 25.00)
            {
                OK = false;

            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderDispatchedFound()
        {
            clsOrderProcessing anOrderProcessing = new clsOrderProcessing();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 21;
            Found = anOrderProcessing.Find(OrderID);
            if (anOrderProcessing.OrderDispatched != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void ValidMethodOK()
        {
            clsOrderProcessing anOrderProcessing = new clsOrderProcessing();
            String Error = "";
            Error = anOrderProcessing.Valid(CustomerID, OrderDescription, OrderDate, TotalOrderAmount);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void CustomerIDMinLessOne()
        {
            clsOrderProcessing anOrderProcessing = new clsOrderProcessing();
            String Error = "";
            string CustomerID = "";
            Error = anOrderProcessing.Valid(CustomerID, OrderDescription, OrderDate, TotalOrderAmount);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void CustomerIDMin()
        {
            clsOrderProcessing anOrderProcessing = new clsOrderProcessing();
            String Error = "";
            string CustomerID = "1";
            Error = anOrderProcessing.Valid(CustomerID, OrderDescription, OrderDate, TotalOrderAmount);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void CustomerIDMinPlusOne()
        {
            clsOrderProcessing anOrderProcessing = new clsOrderProcessing();
            String Error = "";
            string CustomerID = "11";
            Error = anOrderProcessing.Valid(CustomerID, OrderDescription, OrderDate, TotalOrderAmount);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void CustomerIDMaxLessOne()
        {
            clsOrderProcessing anOrderProcessing = new clsOrderProcessing();
            String Error = "";
            string CustomerID = "1111";
            Error = anOrderProcessing.Valid(CustomerID, OrderDescription, OrderDate, TotalOrderAmount);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void CustomerIDMax()
        {
            clsOrderProcessing anOrderProcessing = new clsOrderProcessing();
            String Error = "";
            string CustomerID = "11111";
            Error = anOrderProcessing.Valid(CustomerID, OrderDescription, OrderDate, TotalOrderAmount);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void CustomerIDMid()
        {
            clsOrderProcessing anOrderProcessing = new clsOrderProcessing();
            String Error = "";
            string CustomerID = "111";
            Error = anOrderProcessing.Valid(CustomerID, OrderDescription, OrderDate, TotalOrderAmount);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void CustomerIDMaxPlusOne()
        {
            clsOrderProcessing anOrderProcessing = new clsOrderProcessing();
            String Error = "";
            string CustomerID = "1111111";
            Error = anOrderProcessing.Valid(CustomerID, OrderDescription, OrderDate, TotalOrderAmount);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void CustomerIDExtremeMax()
        {
            clsOrderProcessing anOrderProcessing = new clsOrderProcessing();
            String Error = "";
            string CustomerID = "";
            CustomerID = CustomerID.PadRight(500, '1');
            Error = anOrderProcessing.Valid(CustomerID, OrderDescription, OrderDate, TotalOrderAmount);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void OrderDateExtremeMin()
        {
            clsOrderProcessing anOrderProcessing = new clsOrderProcessing();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string OrderDate = TestDate.ToString();
            Error = anOrderProcessing.Valid(CustomerID, OrderDescription, OrderDate, TotalOrderAmount);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void OrderDateMinLessOne()
        {
            clsOrderProcessing anOrderProcessing = new clsOrderProcessing();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string OrderDate = TestDate.ToString();
            Error = anOrderProcessing.Valid(CustomerID, OrderDescription, OrderDate, TotalOrderAmount);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void OrderDateMin()
        {
            clsOrderProcessing anOrderProcessing = new clsOrderProcessing();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string OrderDate = TestDate.ToString();
            Error = anOrderProcessing.Valid(CustomerID, OrderDescription, OrderDate, TotalOrderAmount);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void OrderDateMinPlusOne()
        {
            clsOrderProcessing anOrderProcessing = new clsOrderProcessing();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string OrderDate = TestDate.ToString();
            Error = anOrderProcessing.Valid(CustomerID, OrderDescription, OrderDate, TotalOrderAmount);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void OrderDateExtremeMax()
        {
            clsOrderProcessing anOrderProcessing = new clsOrderProcessing();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string OrderDate = TestDate.ToString();
            Error = anOrderProcessing.Valid(CustomerID, OrderDescription, OrderDate, TotalOrderAmount);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void OrderDateInvalidData()
        {
            clsOrderProcessing anOrderProcessing = new clsOrderProcessing();
            String Error = "";
            string OrderDate = "this is no a date";
            Error = anOrderProcessing.Valid(CustomerID, OrderDescription, OrderDate, TotalOrderAmount);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void OrderDescriptionMinLessOne()
        {
            clsOrderProcessing anOrderProcessing = new clsOrderProcessing();
            String Error = "";
            string OrderDescription = "";
            Error = anOrderProcessing.Valid(CustomerID, OrderDescription, OrderDate, TotalOrderAmount);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]

        public void OrderDescriptionMin()
        {
            clsOrderProcessing anOrderProcessing = new clsOrderProcessing();
            String Error = "";
            string OrderDescription = "a";
            Error = anOrderProcessing.Valid(CustomerID, OrderDescription, OrderDate, TotalOrderAmount);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void OrderDescriptionMinPlusOne()
        {
            clsOrderProcessing anOrderProcessing = new clsOrderProcessing();
            String Error = "";
            string OrderDescription = "aa";
            Error = anOrderProcessing.Valid(CustomerID, OrderDescription, OrderDate, TotalOrderAmount);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void OrderDescriptionMaxLessOne()
        {
            clsOrderProcessing anOrderProcessing = new clsOrderProcessing();
            String Error = "";
            string OrderDescription = "";
            OrderDescription = OrderDescription.PadRight(49, 'a');
            Error = anOrderProcessing.Valid(CustomerID, OrderDescription, OrderDate, TotalOrderAmount);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void OrderDescriptionMax()
        {
            clsOrderProcessing anOrderProcessing = new clsOrderProcessing();
            String Error = "";
            string OrderDescription = "";
            OrderDescription = OrderDescription.PadRight(50, 'a');
            Error = anOrderProcessing.Valid(CustomerID, OrderDescription, OrderDate, TotalOrderAmount);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]

        public void OrderDescriptionMaxPlusOne()
        {
            clsOrderProcessing anOrderProcessing = new clsOrderProcessing();
            String Error = "";
            string OrderDescription = "";
            Error = anOrderProcessing.Valid(CustomerID, OrderDescription, OrderDate, TotalOrderAmount);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void OrderDescriptionMid()
        {
            clsOrderProcessing anOrderProcessing = new clsOrderProcessing();
            String Error = "";
            string OrderDescription = "";
            OrderDescription = OrderDescription.PadRight(25, 'a');
            Error = anOrderProcessing.Valid(CustomerID, OrderDescription, OrderDate, TotalOrderAmount);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalOrderAmountMinLessOne()
        {
            clsOrderProcessing anOrderProcessing = new clsOrderProcessing();
            String Error = "";
            string TotalOrderAmount = "";
            Error = anOrderProcessing.Valid(CustomerID, OrderDescription, OrderDate, TotalOrderAmount);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalOrderAmountMin()
        {
            clsOrderProcessing anOrderProcessing = new clsOrderProcessing();
            String Error = "";
            string TotalOrderAmount = "1";
            Error = anOrderProcessing.Valid(CustomerID, OrderDescription, OrderDate, TotalOrderAmount);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void TotalOrderAmountMinPlusOne()
        {
            clsOrderProcessing anOrderProcessing = new clsOrderProcessing();
            String Error = "";
            string TotalOrderAmount = "11";
            Error = anOrderProcessing.Valid(CustomerID, OrderDescription, OrderDate, TotalOrderAmount);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalOrderAmountMaxLessOne()
        {
            clsOrderProcessing anOrderProcessing = new clsOrderProcessing();
            String Error = "";
            string TotalOrderAmount = "11111111";
            Error = anOrderProcessing.Valid(CustomerID, OrderDescription, OrderDate, TotalOrderAmount);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalOrderAmountMax()
        {
            clsOrderProcessing anOrderProcessing = new clsOrderProcessing();
            String Error = "";
            string TotalOrderAmount = "111111111";
            Error = anOrderProcessing.Valid(CustomerID, OrderDescription, OrderDate, TotalOrderAmount);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalOrderAmountMaxPlusOne()
        {
            clsOrderProcessing anOrderProcessing = new clsOrderProcessing();
            String Error = "";
            string TotalOrderAmount = "1111111111";
            Error = anOrderProcessing.Valid(CustomerID, OrderDescription, OrderDate, TotalOrderAmount);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalOrderAmountMid()
        {
            clsOrderProcessing anOrderProcessing = new clsOrderProcessing();
            String Error = "";
            string TotalOrderAmount = "1111";
            Error = anOrderProcessing.Valid(CustomerID, OrderDescription, OrderDate, TotalOrderAmount);
            Assert.AreEqual(Error, "");
        }


    }


    }

