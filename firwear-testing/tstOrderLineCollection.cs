using System;
using System.Collections.Generic;
using FitWear_classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace firwear_testing
{
    [TestClass]
    public class tstOrderLineCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderLineCollection AllOrderLine = new clsOrderLineCollection();
            Assert.IsNotNull(AllOrderLine);
        }

        [TestMethod]
        public void OrderlineListOK()
        {
            clsOrderLineCollection AllOrderLine = new clsOrderLineCollection();
            List<clsOrderLine> TestList = new List<clsOrderLine>();
            clsOrderLine TestItem = new clsOrderLine();
            TestItem.OrderLineID = 1;
            TestItem.OrderID = 1;
            TestItem.ProductID = 123;
            TestItem.Quantity = 1;
            TestList.Add(TestItem);
            AllOrderLine.OrderLineList = TestList;
            Assert.AreEqual(AllOrderLine.OrderLineList, TestList);
        }

        [TestMethod]
        public void CountOrderLineOK()
        {
            clsOrderLineCollection AllOrderLine = new clsOrderLineCollection();
            Int32 SomeCount = 0;
            AllOrderLine.Count = SomeCount;
            Assert.AreEqual(AllOrderLine.Count, SomeCount);
        }

        [TestMethod]
        public void ThisOrderLinePropertyOK()
        {
            clsOrderLineCollection AllOrderLine = new clsOrderLineCollection();
            clsOrderLine TestOrderLine = new clsOrderLine();
            TestOrderLine.OrderLineID = 1;
            TestOrderLine.OrderID = 1;
            TestOrderLine.ProductID = 123;
            TestOrderLine.Quantity = 1;
            AllOrderLine.ThisOrderLine = TestOrderLine;
            Assert.AreEqual(AllOrderLine.ThisOrderLine, TestOrderLine);
        }

        [TestMethod]
        public void ListandCountOK()
        {
            clsOrderLineCollection AllOrderLine = new clsOrderLineCollection();
            List<clsOrderLine> TestList = new List<clsOrderLine>();
            clsOrderLine TestItem = new clsOrderLine();
            TestItem.OrderLineID = 1;
            TestItem.OrderID = 1;
            TestItem.ProductID = 123;
            TestItem.Quantity = 1;
            TestList.Add(TestItem);
            AllOrderLine.OrderLineList = TestList;
            Assert.AreEqual(AllOrderLine.OrderLineList, TestList);
        }

        [TestMethod]
        public void TwoRecordsPresent()
        {
            clsOrderLineCollection AllOrderLine = new clsOrderLineCollection();
            Assert.AreEqual(AllOrderLine.Count, 2);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderLineCollection AllOrderLine = new clsOrderLineCollection();
            clsOrderLine TestItem = new clsOrderLine();
            Int32 PrimaryKey = 0;
            TestItem.OrderLineID = 1;
            TestItem.OrderID = 1;
            TestItem.ProductID = 123;
            TestItem.Quantity = 1;
            AllOrderLine.ThisOrderLine = TestItem;
            PrimaryKey = AllOrderLine.Add();
            TestItem.OrderLineID = PrimaryKey;
            AllOrderLine.ThisOrderLine.Find(PrimaryKey);
            Assert.AreEqual(AllOrderLine.ThisOrderLine, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsOrderLineCollection AllOrderLine = new clsOrderLineCollection();
            clsOrderLine TestItem = new clsOrderLine();
            Int32 PrimaryKey = 0;
            TestItem.OrderLineID = 1;
            TestItem.OrderID = 1;
            TestItem.ProductID = 123;
            TestItem.Quantity = 1;
            AllOrderLine.ThisOrderLine = TestItem;
            PrimaryKey = AllOrderLine.Add();
            TestItem.OrderLineID = PrimaryKey;
            AllOrderLine.ThisOrderLine.Find(PrimaryKey);
            AllOrderLine.Delete();
            Boolean Found = AllOrderLine.ThisOrderLine.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsOrderLineCollection AllOrderLine = new clsOrderLineCollection();
            clsOrderLine TestItem = new clsOrderLine();
            Int32 PrimaryKey = 0;
            TestItem.OrderLineID = 1;
            TestItem.OrderID = 1;
            TestItem.ProductID = 123;
            TestItem.Quantity = 1;
            AllOrderLine.ThisOrderLine = TestItem;
            PrimaryKey = AllOrderLine.Add();
            TestItem.OrderLineID = PrimaryKey;

            TestItem.OrderLineID = 9;
            TestItem.OrderID = 9;
            TestItem.ProductID = 132;
            TestItem.Quantity = 2;
            AllOrderLine.ThisOrderLine = TestItem;
            AllOrderLine.Update();
            AllOrderLine.ThisOrderLine.Find(PrimaryKey);
            Assert.AreEqual(AllOrderLine.ThisOrderLine, TestItem);
        }

        [TestMethod]
        public void ReportByOrderIDMethodOK()
        {
            clsOrderLineCollection AllOrderLine = new clsOrderLineCollection();
            clsOrderLineCollection FilteredOrderLine = new clsOrderLineCollection();
            FilteredOrderLine.ReportbyOrderID("");
            Assert.AreEqual(AllOrderLine.Count, FilteredOrderLine.Count);

        }

        [TestMethod]
        public void ReportByOrderIDNoneFound()
        {
            clsOrderLineCollection FilteredOrderLine = new clsOrderLineCollection();
            FilteredOrderLine.ReportbyOrderID("90");
            Assert.AreEqual(0, FilteredOrderLine.Count);
        }

        [TestMethod]
        public void ReportByOrderIDTestDataFound()
        {
            clsOrderLineCollection FilteredOrderLine = new clsOrderLineCollection();
            Boolean OK = true;
            FilteredOrderLine.ReportbyOrderID("909");
            if (FilteredOrderLine.Count == 2)
            {
                if (FilteredOrderLine.OrderLineList[0].OrderLineID != 91)
                {
                    OK = false;
                }
                if (FilteredOrderLine.OrderLineList[1].OrderLineID != 92) 

                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
    }
}

