using System;

namespace FitWear_classes
{
    public class clsOrderProcessing
    {
        private Int32 mOrderID;
        public Int32 OrderID
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

        private Int32 mCustomerID;
        public Int32 CustomerID
        {
            get
            {
                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
            }
        }


        private string mOrderDescription;
        public string OrderDescription
        {
            get
            {
                return mOrderDescription;
            }
            set
            {
                mOrderDescription = value;
            }
        }

        public DateTime mOrderDate;
        public DateTime OrderDate
        {
            get
            {
                return mOrderDate;
            }
            set
            {
                mOrderDate = value;
            }
        }

        public double mTotalOrderAmount;
        public double TotalOrderAmount
        {
            get
            {
                return mTotalOrderAmount;
            }
            set
            {
                mTotalOrderAmount = value;
            }
        }

        private Boolean mOrderDispatched;
        public Boolean OrderDispatched
        {
            get
            {
                return mOrderDispatched;
            }
            set
            {
                mOrderDispatched = value;
            }
        }

        public bool Find(int orderID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", OrderID);
            DB.Execute("sproc_tblOrderProcessing_FilterByOrderID");
            if (DB.Count == 1)
            {
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mOrderDescription = Convert.ToString(DB.DataTable.Rows[0]["OrderDescription"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mTotalOrderAmount = Convert.ToDouble(DB.DataTable.Rows[0]["TotalOrderAmount"]);
                mOrderDispatched = Convert.ToBoolean(DB.DataTable.Rows[0]["OrderDispatched"]);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}