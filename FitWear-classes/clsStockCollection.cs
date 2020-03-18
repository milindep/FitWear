using System;
using System.Collections.Generic;

namespace FitWear_classes
{
    public class clsStockCollection
    {
        List<clsStock> mStockList = new List<clsStock>();
        clsStock mThisStock = new clsStock();
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
        public clsStock ThisStock
        {
            get
            {
                return mThisStock;
            }
            set
            {
                mThisStock = value;
            }
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;

            Int32 RecordCount;

            RecordCount = DB.Count;
            mStockList = new List<clsStock>();

            while (Index < RecordCount)
            {
                clsStock AnStock = new clsStock();
                AnStock.Availability = Convert.ToBoolean(DB.DataTable.Rows[Index]["Availability"]);
                AnStock.StockID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                AnStock.ProductName = Convert.ToString(DB.DataTable.Rows[Index]["ProductName"]);
                AnStock.AmountOfStock = Convert.ToInt32(DB.DataTable.Rows[Index]["AmountInStock"]);
                AnStock.Price = Convert.ToInt32(DB.DataTable.Rows[Index]["Price"]);
                AnStock.Size = Convert.ToInt32(DB.DataTable.Rows[Index]["Size"]);
                AnStock.DateAddedInStock = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAddedInStock"]);

                mStockList.Add(AnStock);
                Index++;
            }
        }


        public clsStockCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStock_SelectAll");
            PopulateArray(DB);

         /*    Int32 Index = 0;
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
             }*/



        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductName", mThisStock.ProductName);
            DB.AddParameter("AmountInStock", mThisStock.AmountOfStock);
            DB.AddParameter("Price", mThisStock.Price);
            DB.AddParameter("Size", mThisStock.Size);
            DB.AddParameter("DateAddedInStock", mThisStock.DateAddedInStock);
            DB.AddParameter("Availability", mThisStock.Availability);

            return DB.Execute("sproc_tblStock_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductID", mThisStock.StockID);
            DB.Execute("sproc_tblStock_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductID", mThisStock.StockID);
            DB.AddParameter("@ProductName", mThisStock.ProductName);
            DB.AddParameter("@AmountInStock", mThisStock.AmountOfStock);
            DB.AddParameter("@Price", mThisStock.Price);
            DB.AddParameter("@Size", mThisStock.Size);
            DB.AddParameter("@DateAddedInStock", mThisStock.DateAddedInStock);
            DB.AddParameter("@Availability", mThisStock.Availability);
            DB.Execute("sproc_tblStock_Update");
        }

        public void ReportByProductName(string ProductName)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductName", ProductName);
            DB.Execute("sproc_tblStock_FilterByProductName");
            PopulateArray(DB);
        }
    }
}