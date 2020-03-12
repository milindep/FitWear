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

            if (DB.Count == 1)
            {
                mStockID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mProductName = Convert.ToString(DB.DataTable.Rows[0]["ProductName"]);
                mAmountOfStock = Convert.ToInt32(DB.DataTable.Rows[0]["AmountInStock"]);
                mPrice = Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
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

        public string Valid(string productName, string amountOfStock, string price, string size, string dateAddedInStock)
        {
            String Error = "";


            //Product Name
            if (productName.Length == 0)
            {
                Error = Error + "The Product Name may not be blank : ";
            }
            if (productName.Length > 50)
            {
                Error = Error + "The Product Name must be less than 50 characters : ";
            }

            //Amount Of Stock
            if (amountOfStock.Length == 0)
            {
                Error = Error + "The Amount Of Stock may not be blank : ";
            }
            if (amountOfStock.Length > 6)
            {
                Error = Error + "The Amount Of Stock must be less than 6 numbers : ";
            }
            try
            {
                Convert.ToInt32(amountOfStock);
            }
            catch
            {
                Error += "Amount of Stock is not a valid number : ";
            }

            //Price
            if (price.Length == 0.00)
            {
                Error = Error + "The Price may not be blank : ";
            }
            if (price.Length > 6)
            {
                Error = Error + "The Price must be less than 6 numbers : ";
            }
            try
            {
                Convert.ToDouble(price);
            }
            catch
            {
                Error += "Price is not a valid number : ";
            }

            //Size
            if (size.Length == 0)
            {
                Error = Error + "The Size may not be blank : ";
            }
            if (size.Length > 20)
            {
                Error = Error + "The Size must be less than 20 numbers : ";
            }
            try
            {
                Convert.ToInt32(size);
            }
            catch
            {
                Error += "Size is not a valid number : ";
            }

            //date added in stock
            try
            {
                DateTime DateTemp;
                DateTemp = Convert.ToDateTime(dateAddedInStock);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The Date cannot be in the past :";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The Date cannot be in the future : ";
                }
            }
            catch
            {
                Error = Error + "The Date was not a valid date :";
            }
            return Error;
        }
    }



       
       
}