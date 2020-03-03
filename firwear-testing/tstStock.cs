﻿using System;
using FitWear_classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace firwear_testing
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsStock AnStock = new clsStock();

            Assert.IsNotNull(AnStock);
        }

        //testing StockID
        [TestMethod]
        public void StockID()
        {
            clsStock AnStock = new clsStock();
            Int32 TestData = 5;
            AnStock.StockID = TestData;
            Assert.AreEqual(AnStock.StockID, TestData);
        }

        //testing ProductName
        [TestMethod]
        public void ProductName()
        {
            clsStock AnStock = new clsStock();
            string TestData = "Some Stock";
            AnStock.ProductName = TestData;
            Assert.AreEqual(AnStock.ProductName, TestData);
        }

        //test amount of stock
        [TestMethod]
        public void AmountOfStock()
        {
            clsStock AnStock = new clsStock();
            Int32 TestData = 5;
            AnStock.AmountOfStock = TestData;
            Assert.AreEqual(AnStock.AmountOfStock, TestData);
        }

        //test Price
        [TestMethod]
        public void Price()
        {
            clsStock AnStock = new clsStock();
            double TestData = 9.99;
            AnStock.Price = TestData;
            Assert.AreEqual(AnStock.Price, TestData);
        }

        //test size
        [TestMethod]
        public void Size()
        {
            clsStock AnStock = new clsStock();
            Int32 TestData = 1;
            AnStock.Size = TestData;
            Assert.AreEqual(AnStock.Size, TestData);
        }

        //test availability
        [TestMethod]
        public void Availability()
        {
            clsStock AnStock = new clsStock();
            Boolean TestData = true;
            AnStock.Availability = TestData;
            Assert.AreEqual(AnStock.Availability, TestData);
        }

        //test date added in stock
        [TestMethod]
        public void DateAddedInStock()
        {
            clsStock AnStock = new clsStock();
            DateTime TestData = DateTime.Now.Date;
            AnStock.DateAddedInStock = TestData;
            Assert.AreEqual(AnStock.DateAddedInStock, TestData);
        }
        //-------------------------------------------------------------------------------------
        //find method
        [TestMethod]
        public void FindMethodOK()
        {
            clsStock AnStock = new clsStock();

            Boolean Found = false;

            Int32 StockID = 21;

            Found = AnStock.Find(StockID);

            Assert.IsTrue(Found);
        }


        //test StockId
        [TestMethod]
        public void TestStockIDFound()
        {
            clsStock AnStock = new clsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 StockID = 21;

            Found = AnStock.Find(StockID);

            if (AnStock.StockID != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        //test product name
        [TestMethod]

        public void TestProductNameFound()
        {
            clsStock AnStock = new clsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 StockID = 21;

            Found = AnStock.Find(StockID);

            if (AnStock.ProductName != "Test Product Name")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        //Amount in Stock
        [TestMethod]

        public void TestAmountInStock()
        {
            clsStock AnStock = new clsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 StockID = 21;

            Found = AnStock.Find(StockID);

            if (AnStock.AmountOfStock != 20)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        //Price
        [TestMethod]

        public void TestPrice()
        {
            clsStock AnStock = new clsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 StockID = 21;

            Found = AnStock.Find(StockID);

            if (AnStock.Price != 10.00)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        //Size

        [TestMethod]

        public void TestSize()
        {
            clsStock AnStock = new clsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 StockID = 21;

            Found = AnStock.Find(StockID);

            if (AnStock.Size != 10)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        //Availability

        [TestMethod]

        public void TestAvailability()
        {
            clsStock AnStock = new clsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 StockID = 21;

            Found = AnStock.Find(StockID);

            if (AnStock.Availability != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        //Date In Stock

        [TestMethod]

        public void TestDateAddedInStock()
        {
            clsStock AnStock = new clsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 StockID = 21;

            Found = AnStock.Find(StockID);

            if (AnStock.DateAddedInStock != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        //----------------------------------------------------------------------------------------
        //validation
        //valid method ok
        [TestMethod]

        public void ValidMethodOK()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            Error = AnStock.Valid(StockID, ProductName, AmountOfStock, Price, Size, DateAddedInStock);
            Assert.AreEqual(Error, "");
        }


        [TestClass]
        public class tststock
        {
            string StockID = "1";
            string ProductNAme = "some stock";
            string AmountOfStock = "1";
            string Price = "10.00";
            string Size = "1";
            string DateAddedInSTock = DateTime.Now.Date.ToString();
        }

        //StockIDMinLessOne
        [TestMethod]
        public void StockIDMinLessOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            String StockID = "";
            Error = AnStock.Valid(StockID, ProductName, AmountOfStock, Price, Size, DateAddedInStock);
            Assert.AreNotEqual(Error, "");
        }

        //StockIDMinLessOne
        [TestMethod]
        public void StockIDMin()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            String StockID = "1";
            Error = AnStock.Valid(StockID, ProductName, AmountOfStock, Price, Size, DateAddedInStock);
            Assert.AreEqual(Error, "");
        }

        //StockIDMinPlusOne
        [TestMethod]
        public void StockIDMinPlusOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            String StockID = "11";
            Error = AnStock.Valid(StockID, ProductName, AmountOfStock, Price, Size, DateAddedInStock);
            Assert.AreEqual(Error, "");
        }

        //StockIDMaxLessOne
        [TestMethod]
        public void StockIDMaxLessOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            String StockID = "11111";
            Error = AnStock.Valid(StockID, ProductName, AmountOfStock, Price, Size, DateAddedInStock);
            Assert.AreEqual(Error, "");
        }

        //StockIDMax
        [TestMethod]
        public void StockIDMax()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            String StockID = "111111";
            Error = AnStock.Valid(StockID, ProductName, AmountOfStock, Price, Size, DateAddedInStock);
            Assert.AreEqual(Error, "");
        }

        //StockIDMid
        [TestMethod]
        public void StockIDMid()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            String StockID = "111";
            Error = AnStock.Valid(StockID, ProductName, AmountOfStock, Price, Size, DateAddedInStock);
            Assert.AreEqual(Error, "");
        }

        //StockIDMAxPlusOne
        [TestMethod]
        public void StockIDMAxPlusOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            String StockID = "1111111";
            Error = AnStock.Valid(StockID, ProductName, AmountOfStock, Price, Size, DateAddedInStock);
            Assert.AreNotEqual(Error, "");
        }

        //StockIDExtremeMax
        [TestMethod]
        public void StockIDExtremeMax()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            String StockID = "";
            StockID = StockID.PadRight(500, '1');
            Error = AnStock.Valid(StockID, ProductName, AmountOfStock, Price, Size, DateAddedInStock);
            Assert.AreNotEqual(Error, "");
        }


    }
}
