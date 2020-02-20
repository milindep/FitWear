using System;

namespace FitWear_classes
{
    public class clsStock
    {
        //Stock ID
        public Int32 mStockID;
        public Int32 StockID
        {
            get
            {
                return mStockID;
            }
            set
            {
                mStockID = value;
            }
        }

        //Product Name
        public string mProductName;
        public string ProductName
        {
            get
            {
                return mProductName;
            }
            set
            {
                mProductName = value;
            }
        }

        //Amount of Stock
        public Int32 mAmountOfStock;
        public int AmountOfStock
        {
            get
            {
                return mAmountOfStock;
            }
            set
            {
                mAmountOfStock = value;
            }
        }

        //Price
        public double mPrice;
        public double Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }

        //Size
        public Int32 mSize;
        public int Size
        {
            get
            {
                return mSize;
            }
            set
            {
                mSize = value;
            }
        }

        //Availability
        public Boolean mAvailability;
        public bool Availability
        {
            get
            {
                return mAvailability;
            }
            set
            {
                mAvailability = value;
            }
        }

        //Date added In Stock 
        public DateTime mDateAddedInStock;
        public DateTime DateAddedInStock
        {
            get
            {
                return mDateAddedInStock;
            }
            set
            {
                mDateAddedInStock = value;
            }
        }


        public bool Find(int StockID)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@ProductID", StockID);

            DB.Execute("sproc_tblStock_FilterByStockID");

            if(DB.Count == 1)
            {
                mStockID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mProductName = Convert.ToString(DB.DataTable.Rows[0]["ProductName"]);
                mAmountOfStock = Convert.ToInt32(DB.DataTable.Rows[0]["AmountInStock"]);
                mPrice =  Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                mSize = Convert.ToInt32(DB.DataTable.Rows[0]["Size"]);
                mAvailability = Convert.ToBoolean(DB.DataTable.Rows[0]["Availability"]);
                mDateAddedInStock = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAddedInStock"]);

                return true;
            }
            else
            {
                return false;
            }
        }

      
    }
}