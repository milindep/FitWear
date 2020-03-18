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

        [TestMethod]
        public void AddMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestItem = new clsStock();

            Int32 PrimaryKey = 0;

            TestItem.Availability = true;
            TestItem.StockID = 1;
            TestItem.ProductName = "some Stock";
            TestItem.AmountOfStock = 1;
            TestItem.Price = 2.00;
            TestItem.Size = 2;
            TestItem.DateAddedInStock = DateTime.Now.Date;

            AllStock.ThisStock = TestItem;

            PrimaryKey = AllStock.Add();

            TestItem.StockID = PrimaryKey;

            AllStock.ThisStock.Find(PrimaryKey);

            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestItem = new clsStock();

            Int32 PrimaryKey = 0;

            TestItem.Availability = true;
            TestItem.StockID = 1;
            TestItem.ProductName = "some Stock";
            TestItem.AmountOfStock = 1;
            TestItem.Price = 2.00;
            TestItem.Size = 2;
            TestItem.DateAddedInStock = DateTime.Now.Date;

            AllStock.ThisStock = TestItem;

            PrimaryKey = AllStock.Add();
            TestItem.StockID = PrimaryKey;
            AllStock.ThisStock.Find(PrimaryKey);
            AllStock.Delete();
            Boolean Found = AllStock.ThisStock.Find(PrimaryKey);
            Assert.IsFalse(Found);

        }


        [TestMethod]
        public void UpdateMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestItem = new clsStock();

            Int32 PrimaryKey = 0;

            
            TestItem.Availability = true;
            TestItem.ProductName = "some stock";
            TestItem.AmountOfStock = 4;
            TestItem.Price = 4.00;
            TestItem.Size = 4;
            TestItem.DateAddedInStock = DateTime.Now.Date;

            AllStock.ThisStock = TestItem;

            PrimaryKey = AllStock.Add();
            TestItem.StockID = PrimaryKey;

            TestItem.Availability = false;
            TestItem.ProductName = "some stock two";
            TestItem.AmountOfStock = 2;
            TestItem.Price = 3.00;
            TestItem.Size = 3;
            TestItem.DateAddedInStock = DateTime.Now.Date;

            AllStock.ThisStock = TestItem;
            AllStock.Update();
            AllStock.ThisStock.Find(PrimaryKey);
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }
        [TestMethod]
        public void ReportByProductNameMethodOK()
         {
            clsStockCollection AllStocks = new clsStockCollection();
            clsStockCollection FilteredStocks = new clsStockCollection();
            FilteredStocks.ReportByProductName("");
            Assert.AreEqual(AllStocks.Count, FilteredStocks.Count);
        }
        [TestMethod]
        public void ReportByProductNameNoneFound()
        {
            clsStockCollection FilteredStocks = new clsStockCollection();
            FilteredStocks.ReportByProductName("xxx xx");

            Assert.AreEqual(0, FilteredStocks.Count);
        }

        [TestMethod]
        public void ReportByProductNameTestDataFound()
        {
            clsStockCollection FilteredStocks = new clsStockCollection();
            Boolean OK = true;
            FilteredStocks.ReportByProductName("some stock");
            if(FilteredStocks.Count == 2)
            {
                if(FilteredStocks.StockList[0].StockID != 47)
                {
                    OK = false;
                }
                if(FilteredStocks.StockList[1].StockID != 49)
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
