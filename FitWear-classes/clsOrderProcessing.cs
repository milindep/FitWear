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

 

        public bool Find(int OrderID)
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

        public string Valid(Action customerID, Action orderDescription, Action orderDate, Action totalOrderAmount)
        {
            return "";
        }

        public string Valid(string customerID, string orderDescription, string orderDate, string totalOrderAmount)
        {
            String Error = "";
            DateTime DateTemp;
            if (customerID.Length == 0)
            {
                Error = Error + "he Customer ID may not be blank: ";
            }

            if (customerID.Length > 6)
            {
                Error = Error + "The Customer ID must be less than 6 digits: ";
            }
            try
            {

                DateTemp = Convert.ToDateTime(orderDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past : ";
                }

                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date caanot be in the future: ";
                }

            }
            catch
            {
                Error = Error + "The date was not valid date : ";
            }

            if (orderDescription.Length == 0)
            {
                Error = Error + "The order Description must not be blanked : "; 
            }
            if (orderDescription.Length > 50)
            {
                Error = Error + "The order Description must be less than 50 characters :";
            }

            if (totalOrderAmount.Length == 0.00)
            {
                Error = Error + "The total order amount may not be left blank : ";
            }

            if (totalOrderAmount.Length > 9)
            {
                Error = Error + "The total order amount must be less than 9 : ";
            }
            return Error;

        }
    }
}