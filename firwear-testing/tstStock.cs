using System;
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
            clsStock anStock = new clsStock();
            Int32 TestData = 5;
            anStock.StockID = TestData;
            Assert.AreEqual(anStock.StockID, TestData);
        }

        //testing ProductName
        [TestMethod]
        public void ProductName()
        {
            clsStock anStock = new clsStock();
            string TestData = "Some Stock";
            anStock.ProductName = TestData;
            Assert.AreEqual(anStock.ProductName, TestData);
        }

        //test amount of stock
        [TestMethod]
        public void AmountOfStock()
        {
            clsStock anStock = new clsStock();
            Int32 TestData = 5;
            anStock.AmountOfStock = TestData;
            Assert.AreEqual(anStock.AmountOfStock, TestData);
        }

        //test Price
        [TestMethod]
        public void Price()
        {
            clsStock anStock = new clsStock();
            double TestData = 9.99;
            anStock.Price = TestData;
            Assert.AreEqual(anStock.Price, TestData);
        }

        //test size
        [TestMethod]
        public void Size()
        {
            clsStock anStock = new clsStock();
            Int32 TestData = 1;
            anStock.Size = TestData;
            Assert.AreEqual(anStock.Size, TestData);
        }

        //test availability
        [TestMethod]
        public void Availability()
        {
            clsStock anStock = new clsStock();
            Boolean TestData = true;
            anStock.Availability = TestData;
            Assert.AreEqual(anStock.Availability, TestData);
        }
       

    }

    
}
