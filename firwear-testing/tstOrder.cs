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
        Error = anOrderProcessing.Valid(OrderID, CustomerID, OrderDescription, OrderDate, TotalOrderAmount, OrderDispatched);
        Assert.AreEqual(Error, "");
    }

    [TestMethod]

    public void OrderIDMinLessOne()
        {
            clsOrderProcessing anOrderProcessing = new clsOrderProcessing();
            String Error = "";
            string OrderID = "";
            Error = anOrderProcessing.Valid(CustomerID, OrderDescription, OrderDate, TotalOrderAmount, OrderDispatched)
        }

    
    }
}

