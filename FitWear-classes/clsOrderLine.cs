using System;

namespace FitWear_classes
{
    public class clsOrderLine
    {
        private Int32 mOrderLineID;
        public int OrderLineID
        {
            get
            {
                return mOrderLineID;
            }
            set
            {
                mOrderLineID = value;
            }
        }

        private Int32 mOrderID;
        public int OrderID
        {
            get
            {
                return mOrderID;
            }
            set
            {
                mOrderID = value;
            }
        }

        private Int32 mProductID;
        public int ProductID
        {
            get
            {
                return mProductID;
            }
            set
            {
                mProductID = value;
            }
        }

        private Int32 mQuantity;
        public int Quantity
        {
            get
            {
                return mQuantity;
            }
            set
            {
                mQuantity = value;
            }
        }
            

        public bool Find(int OrderLineID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderLineID", OrderLineID);
            DB.Execute("sproc_tblOrderLine_FilterByOrderLineID");
            if (DB.Count == 1)
            {
                mOrderLineID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderLineID"]);
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                return true;
            }
            else
            {
                return true;
            }
            
        }

        public string Valid(string orderID, string productID, string quantity)
        {
            String Error = "";
            if (orderID.Length == 0)
            {
                Error = Error + "The order ID may not be blank :";
            }
            if (orderID.Length > 6)
            {
                Error = Error + "The order ID must be less than 6 digits :";
            }
            if (productID.Length == 0)
            {
                Error = Error + "The product ID may not be blank :";
            }
            if (productID.Length > 6)
            {
                Error = Error + "The product ID must be less than 6 digits :";
            }
            if (quantity.Length == 0)
            {
                Error = Error + "The quantity may not be blank :";
            }
            if (quantity.Length > 6)
            {
                Error = Error + "The quantity must be less than 6 digits :";
            }
            return Error;
        }
    }
}

