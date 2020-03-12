﻿using System;
using FitWear_classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace firwear_testing
{
    [TestClass]
    public class tstStock
    {


       string ProductName = "shorts";
       string AmountOfStock = "13";
       string Price = "23.00";
       string Size = "4";
       string DateAddedInStock = DateTime.Now.Date.ToString();
        

        [TestMethod]
        public void InstanceOk()
        {
            clsStock AnStock = new clsStock();

            Assert.IsNotNull(AnStock);
        }

        //testing StockID
        [TestMethod]
        public void StockIDOk()
        {
            clsStock AnStock = new clsStock();
            Int32 TestData = 5;
            AnStock.StockID = TestData;
            Assert.AreEqual(AnStock.StockID, TestData);
        }

        //testing ProductName
        [TestMethod]
        public void ProductNameOk()
        {
            clsStock AnStock = new clsStock();
            string TestData = "Some Stock";
            AnStock.ProductName = TestData;
            Assert.AreEqual(AnStock.ProductName, TestData);
        }

        //test amount of stock
        [TestMethod]
        public void AmountOfStockOk()
        {
            clsStock AnStock = new clsStock();
            Int32 TestData = 5;
            AnStock.AmountOfStock = TestData;
            Assert.AreEqual(AnStock.AmountOfStock, TestData);
        }

        //test Price
        [TestMethod]
        public void PriceOk()
        {
            clsStock AnStock = new clsStock();
            double TestData = 9.99;
            AnStock.Price = TestData;
            Assert.AreEqual(AnStock.Price, TestData);
        }

        //test size
        [TestMethod]
        public void SizeOk()
        {
            clsStock AnStock = new clsStock();
            Int32 TestData = 1;
            AnStock.Size = TestData;
            Assert.AreEqual(AnStock.Size, TestData);
        }

        //test availability
        [TestMethod]
        public void AvailabilityOk()
        {
            clsStock AnStock = new clsStock();
            Boolean TestData = true;
            AnStock.Availability = TestData;
            Assert.AreEqual(AnStock.Availability, TestData);
        }

        //test date added in stock
        [TestMethod]
        public void DateAddedInStockOk()
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
       public void ValidMethodOk()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            Error = AnStock.Valid( ProductName, AmountOfStock, Price, Size, DateAddedInStock);
            Assert.AreEqual(Error, "");
        }

        //-----------------------------------------------------------------------------------------------------------
        //-Date validation
        //DateAddedExtremeMin
        [TestMethod]
        public void DateAddedInStockExtremeMin()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateAddedInStock = TestDate.ToString();
            Error = AnStock.Valid( ProductName, AmountOfStock, Price, Size, DateAddedInStock);
            Assert.AreNotEqual(Error, "");
        }

        //DateAddedInStockMinLessOne
        [TestMethod]
        public void DateAddedInStockMinLessOne()
        {
           
            clsStock AnStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string DateAddedInStock = TestDate.ToString();
            Error = AnStock.Valid( ProductName, AmountOfStock, Price, Size, DateAddedInStock);
            Assert.AreNotEqual(Error, "");
        }

        //DateAddedInStockMin
        [TestMethod]
        public void DateAddedInStockMin()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DateAddedInStock = TestDate.ToString();
            Error = AnStock.Valid( ProductName, AmountOfStock, Price, Size, DateAddedInStock);
            Assert.AreEqual(Error, "");
        }

        //DateAddedInStock
        [TestMethod]
        public void DateAddedInStockMinPlusOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DateAddedInStock = TestDate.ToString();
            Error = AnStock.Valid( ProductName, AmountOfStock, Price, Size, DateAddedInStock);
            Assert.AreNotEqual(Error, "");
        }

        //DateAddedInStockExtremeMax
        [TestMethod]
        public void DateAddedInStockExtremeMax()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DateAddedInStock = TestDate.ToString();
            Error = AnStock.Valid( ProductName, AmountOfStock, Price, Size, DateAddedInStock);
            Assert.AreNotEqual(Error, "");
        }

        //DateAddedInStockInvalidData
        [TestMethod]
        public void DateAddedInStockInvalidData()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string DateAddedInStock = "this is not a date!";
            Error = AnStock.Valid( ProductName, AmountOfStock, Price, Size, DateAddedInStock);
            Assert.AreNotEqual(Error, "");
        }
        //----------------------------------------------------------------------------------------------------------

            //Product Name
        //ProductNameMinLessOne
        [TestMethod]
        public void ProductNameMinLessOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string ProductName = "";
            Error = AnStock.Valid( ProductName, AmountOfStock, Price, Size, DateAddedInStock);
            Assert.AreNotEqual(Error, "");
        }

        //ProductNameMin
        [TestMethod]
        public void ProductNameMin()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string ProductName = "a";
            Error = AnStock.Valid( ProductName, AmountOfStock, Price, Size, DateAddedInStock);
            Assert.AreEqual(Error, "");
        }

        //ProductNameMinPlusOne
        [TestMethod]
        public void ProductNameMinPlusOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string ProductName = "aa";
            Error = AnStock.Valid( ProductName, AmountOfStock, Price, Size, DateAddedInStock);
            Assert.AreEqual(Error, "");
        }

        //ProductNameMaxLessOne
        [TestMethod]
        public void ProductNameMaxLessOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string ProductName = "aaaaaaaa";
            Error = AnStock.Valid( ProductName, AmountOfStock, Price, Size, DateAddedInStock);
            Assert.AreEqual(Error, "");
        }

        //ProductNameMax
        [TestMethod]
        public void ProductNameMax()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string ProductName = "aaaaaaaaa";
            Error = AnStock.Valid( ProductName, AmountOfStock, Price, Size, DateAddedInStock);
            Assert.AreEqual(Error, "");
        }

        //ProductNameMaxPlusOne
        [TestMethod]
        public void ProductNameMaxPlusOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string ProductName = "";
            ProductName = ProductName.PadRight(51, 'a');
            Error = AnStock.Valid( ProductName, AmountOfStock, Price, Size, DateAddedInStock);
            Assert.AreNotEqual(Error, "");
        }

        //ProductNameMid
        [TestMethod]
        public void ProductNameMid()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string ProductName = "aaaa";
            Error = AnStock.Valid( ProductName, AmountOfStock, Price, Size, DateAddedInStock);
            Assert.AreEqual(Error, "");
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------
        //Amount Of Stock
        //AmountOfStockMinLessOne
        [TestMethod]
        public void AmountOfStockMinLessOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string AmountOfStock = "";
            Error = AnStock.Valid( ProductName, AmountOfStock, Price, Size, DateAddedInStock);
            Assert.AreNotEqual(Error, "");
        }

        //AmountOfStockMin
        [TestMethod]
        public void AmountOfStockMin()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string AmountOfStock = "1";
            Error = AnStock.Valid( ProductName, AmountOfStock, Price, Size, DateAddedInStock);
            Assert.AreEqual(Error, "");
        }

        //AmountOfStockMinPlusOne
        [TestMethod]
        public void AmountOfStockMinPlusOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string AmountOfStock = "11";
            Error = AnStock.Valid( ProductName, AmountOfStock, Price, Size, DateAddedInStock);
            Assert.AreEqual(Error, "");
        }

        //AmountOfStockMaxLessOne
        [TestMethod]
        public void AmountOfStockMaxLessOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string AmountOfStock = "11111";
            Error = AnStock.Valid( ProductName, AmountOfStock, Price, Size, DateAddedInStock);
            Assert.AreEqual(Error, "");
        }

        //AmountOfStockMax
        [TestMethod]
        public void AmountOfStockMax()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string AmountOfStock = "111111";
            Error = AnStock.Valid( ProductName, AmountOfStock, Price, Size, DateAddedInStock);
            Assert.AreEqual(Error, "");
        }

        //AmountOfStockMid
        [TestMethod]
        public void AmountOfStockMid()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string AmountOfStock = "111";
            Error = AnStock.Valid( ProductName, AmountOfStock, Price, Size, DateAddedInStock);
            Assert.AreEqual(Error, "");
        }

        //AmountOfStockMaxPlusOne
        [TestMethod]
        public void AmountOfStockMaxPlusOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string AmountOfStock = "1111111";
            Error = AnStock.Valid( ProductName, AmountOfStock, Price, Size, DateAddedInStock);
            Assert.AreNotEqual(Error, "");
        }

        //AmountOfStockExtremeMax
        [TestMethod]
        public void AmountOfStockExtremeMax()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string AmountOfStock = "";
            AmountOfStock = AmountOfStock.PadRight(500, '1');
            Error = AnStock.Valid( ProductName, AmountOfStock, Price, Size, DateAddedInStock);
            Assert.AreNotEqual(Error, "");
        }
        //-------------------------------------------------------------------------------------------------------

        //PriceMinLessOne
        [TestMethod]
        public void PriceMinLessOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string Price = "";
            Error = AnStock.Valid( ProductName, AmountOfStock, Price, Size, DateAddedInStock);
            Assert.AreNotEqual(Error, "");
        }

        //PriceMin
        [TestMethod]
        public void PriceMin()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string Price = "1";
            Error = AnStock.Valid( ProductName, AmountOfStock, Price, Size, DateAddedInStock);
            Assert.AreEqual(Error, "");
        }

        //PricePlusOne
        [TestMethod]
        public void PriceMinPlusOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string Price = "11";
            Error = AnStock.Valid( ProductName, AmountOfStock, Price, Size, DateAddedInStock);
            Assert.AreEqual(Error, "");
        }

        //PriceMaxLessOne
        [TestMethod]
        public void PriceMaxLessOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string Price = "11111";
            Error = AnStock.Valid( ProductName, AmountOfStock, Price, Size, DateAddedInStock);
            Assert.AreEqual(Error, "");
        }

        //PriceMax
        [TestMethod]
        public void PriceMax()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string Price = "111111";
            Error = AnStock.Valid( ProductName, AmountOfStock, Price, Size, DateAddedInStock);
            Assert.AreEqual(Error, "");
        }

        //PriceMid
        [TestMethod]
        public void PriceMid()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string Price = "111";
            Error = AnStock.Valid( ProductName, AmountOfStock, Price, Size, DateAddedInStock);
            Assert.AreEqual(Error, "");
        }

        //PriceMaxPlusOne
        [TestMethod]
        public void PriceMaxPlusOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string Price = "";
            Error = AnStock.Valid( ProductName, AmountOfStock, Price, Size, DateAddedInStock);
            Assert.AreNotEqual(Error, "");
        }

        //PriceExtremeMax
        [TestMethod]
        public void PriceExtremeMax()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string Price = "";
            Error = AnStock.Valid( ProductName, AmountOfStock, Price, Size, DateAddedInStock);
            Assert.AreNotEqual(Error, "");
        }
        //-------------------------------------------------------------------------------------------------------

        //SizeMinLessOne
        [TestMethod]
        public void SizeMinLessOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string Size = "";
            Error = AnStock.Valid( ProductName, AmountOfStock, Price, Size, DateAddedInStock);
            Assert.AreNotEqual(Error, "");
        }

        //SizeMin
        [TestMethod]
        public void SizeMin()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string Size = "1";
            Error = AnStock.Valid( ProductName, AmountOfStock, Price, Size, DateAddedInStock);
            Assert.AreEqual(Error, "");
        }

        //SizePlusOne
        [TestMethod]
        public void SizeMinPlusOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string Size = "11";
            Error = AnStock.Valid( ProductName, AmountOfStock, Price, Size, DateAddedInStock);
            Assert.AreEqual(Error, "");
        }

        //SizeMaxLessOne
        [TestMethod]
        public void SizeMaxLessOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string Size = "11111";
            Error = AnStock.Valid( ProductName, AmountOfStock, Price, Size, DateAddedInStock);
            Assert.AreEqual(Error, "");
        }

        //SizeMax
        [TestMethod]
        public void SizeMax()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string Size = "111111";
            Error = AnStock.Valid( ProductName, AmountOfStock, Price, Size, DateAddedInStock);
            Assert.AreEqual(Error, "");
        }

        //SizeMid
        [TestMethod]
        public void SizeMid()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string Size = "111";
            Error = AnStock.Valid( ProductName, AmountOfStock, Price, Size, DateAddedInStock);
            Assert.AreEqual(Error, "");
        }

        //SizeMaxPlusOne
        [TestMethod]
        public void SizeMaxPlusOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string Size = "";
            Error = AnStock.Valid( ProductName, AmountOfStock, Price, Size, DateAddedInStock);
            Assert.AreNotEqual(Error, "");
        }

        //SizeExtremeMax
        [TestMethod]
        public void SizeExtremeMax()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string Size = "";
            Error = AnStock.Valid( ProductName, AmountOfStock, Price, Size, DateAddedInStock);
            Assert.AreNotEqual(Error, "");
        }

    }
}
