using System;
using System.Collections.Generic;

namespace FitWear_classes
{
    public class clsStockCollection
    {
        List<clsStock> mStockList = new List<clsStock>();
        public List<clsStock> StockList {
            get
            {
                return mStockList;
            }
            set
            {
                mStockList = value;
            }
        }
        public int Count
        {
            get
            {
                return mStockList.Count;
            }
            set
            {
            }
        }
        public clsStock ThisStock { get; set; }

        public clsStockCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;

            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblStock_SelectAll");

            RecordCount = DB.Count;

            while (Index < RecordCount)
            {
                clsStock AnStock = new clsStock();
                AnStock.Availability = Convert.ToBoolean(DB.DataTable.Rows[Index]["Availability"]);
                AnStock.StockID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                AnStock.mProductName = Convert.ToString(DB.DataTable.Rows[Index]["ProductName"]);
                AnStock.AmountOfStock = Convert.ToInt32(DB.DataTable.Rows[Index]["AmountInStock"]);
                AnStock.Price = Convert.ToInt32(DB.DataTable.Rows[Index]["Price"]);
                AnStock.Size = Convert.ToInt32(DB.DataTable.Rows[Index]["Size"]);
                AnStock.DateAddedInStock = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAddedInStock"]);

                mStockList.Add(AnStock);
                Index++;
            }

           /* clsStock TestItem = new clsStock();

            TestItem.Availability = true;
            TestItem.StockID = 1;
            TestItem.ProductName = "some stock";
            TestItem.AmountOfStock = 1;
            TestItem.Price = 1.00;
            TestItem.Size = 1;
            TestItem.DateAddedInStock = DateTime.Now.Date;
            mStockList.Add(TestItem);
           

            TestItem = new clsStock();

            TestItem.Availability = true;
            TestItem.StockID = 2;
            TestItem.ProductName = "some stock 2";
            TestItem.AmountOfStock = 2;
            TestItem.Price = 2.00;
            TestItem.Size = 2;
            TestItem.DateAddedInStock = DateTime.Now.Date;
            mStockList.Add(TestItem);*/
        }
    }
}