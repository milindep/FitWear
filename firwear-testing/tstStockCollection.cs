using System;
using FitWear_classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace firwear_testing
{
    [TestClass]
    public class tstStockCollection
    {
        //InstanceOK
        [TestMethod]
        public void InstanceOk()
        {
            clsStockCollection AllStock = new clsStockCollection();
            Assert.IsNotNull(AllStock);
        }

        //StockListOK
        [TestMethod]
        public void StockListOK()
        {
            clsStockCollection AllStock = new clsStockCollection();

            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();

            TestItem.Availability = true;
            TestItem.StockID = 1;
            TestItem.ProductName = "some stock";
            TestItem.AmountOfStock = 1;
            TestItem.Price = 1.00;
            TestItem.Size = 1;
            TestItem.DateAddedInStock = DateTime.Now.Date;

            TestList.Add(TestItem);

            AllStock.StockList = TestList;
            Assert.AreEqual(AllStock.StockList, TestList);
        }
    /*    [TestMethod]
        public void CountProductOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            Int32 SomeCount = 2;
            AllStock.Count = SomeCount;
            Assert.AreEqual(AllStock.Count, SomeCount);
        }*/

        //ThisStockProductOK
        [TestMethod]
        public void ThisStockProductOK()
        {
            clsStockCollection AllStock = new clsStockCollection();

            clsStock TestStock = new clsStock();

            TestStock.Availability = true;
            TestStock.StockID = 1;
            TestStock.ProductName = "some stock";
            TestStock.AmountOfStock = 1;
            TestStock.Price = 1.00;
            TestStock.Size = 1;
            TestStock.DateAddedInStock = DateTime.Now.Date;

            AllStock.ThisStock = TestStock;

            Assert.AreEqual(AllStock.ThisStock, TestStock);

        }

        //ListAndCountOK
        [TestMethod]
        public void ListAndCountOK()
        {
            clsStockCollection AllStock = new clsStockCollection();

            List<clsStock> TestList = new List<clsStock>();

            clsStock TestItem = new clsStock();

            TestItem.Availability = true;
            TestItem.StockID = 1;
            TestItem.ProductName = "some stock";
            TestItem.AmountOfStock = 1;
            TestItem.Price = 1.00;
            TestItem.Size = 1;
            TestItem.DateAddedInStock = DateTime.Now.Date;

            TestList.Add(TestItem);
            AllStock.StockList = TestList;
            Assert.AreEqual(AllStock.Count, TestList.Count);
        }
      /*  [TestMethod]
        public void twoRecordsPresent()
        {
            clsStockCollection AllStock = new clsStockCollection();
            Assert.AreEqual(AllStock.Count, 2);
        }*/

    }
}
