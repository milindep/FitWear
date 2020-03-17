﻿using System;
using FitWear_classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace firwear_testing
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            Assert.IsNotNull(AllOrder);
        }

        [TestMethod]
        public void OrderListOK()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            List<clsOrderProcessing> TestList = new List<clsOrderProcessing>();
            clsOrderProcessing TestItem = new clsOrderProcessing();
            TestItem.OrderID = 1;
            TestItem.CustomerID = 1;
            TestItem.OrderDescription = "some description";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.TotalOrderAmount = 10.00;
            TestItem.OrderDispatched = true;
            TestList.Add(TestItem);
            AllOrder.OrderList = TestList;
            Assert.AreEqual(AllOrder.OrderList, TestList);
        }

        /*[TestMethod]
        public void CountOrderOK()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            Int32 SomeCount = 2;
            AllOrder.Count = SomeCount;
            Assert.AreEqual(AllOrder.Count, SomeCount);

        }*/

        [TestMethod]
        public void ThisOrderOK()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            clsOrderProcessing TestOrderProcessing = new clsOrderProcessing();
            TestOrderProcessing.OrderID = 1;
            TestOrderProcessing.CustomerID = 1;
            TestOrderProcessing.OrderDescription = "some description";
            TestOrderProcessing.OrderDate = DateTime.Now.Date;
            TestOrderProcessing.TotalOrderAmount = 10.00;
            TestOrderProcessing.OrderDispatched = true;
            AllOrder.ThisOrderProcessing = TestOrderProcessing;
            Assert.AreEqual(AllOrder.ThisOrderProcessing, TestOrderProcessing);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            List<clsOrderProcessing> TestList = new List<clsOrderProcessing>();
            clsOrderProcessing TestItem = new clsOrderProcessing();
            TestItem.OrderID = 1;
            TestItem.CustomerID = 1;
            TestItem.OrderDescription = "some description";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.TotalOrderAmount = 10.00;
            TestItem.OrderDispatched = true;
            TestList.Add(TestItem);
            AllOrder.OrderList = TestList;
            Assert.AreEqual(AllOrder.Count, TestList.Count);
        }

        /*[TestMethod]
        public void TwoRecordsPresent()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            Assert.AreEqual(AllOrder.Count, 2);
        }*/

        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            clsOrderProcessing TestItem = new clsOrderProcessing();
            Int32 PrimaryKey = 0;
            TestItem.OrderID = 1;
            TestItem.CustomerID = 1;
            TestItem.OrderDescription = "some description";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.TotalOrderAmount = 10.00;
            TestItem.OrderDispatched = true;
            AllOrder.ThisOrderProcessing = TestItem;
            PrimaryKey = AllOrder.Add();
            TestItem.OrderID = PrimaryKey;
            AllOrder.ThisOrderProcessing.Find(PrimaryKey);
            Assert.AreEqual(AllOrder.ThisOrderProcessing, TestItem);
        }

    }
}
