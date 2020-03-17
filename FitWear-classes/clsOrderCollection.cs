using System;
using System.Collections.Generic;

namespace FitWear_classes
{
    public class clsOrderCollection
    {
        List<clsOrderProcessing> mOrderList = new List<clsOrderProcessing>();
        clsOrderProcessing mThisOrderProcessing = new clsOrderProcessing();
        public List<clsOrderProcessing> OrderList
        {
            get
            {
                return mOrderList;

            }
            set
            {
                mOrderList = value;
            }
        }
        public int Count
        {
            get
            {
                return mOrderList.Count;
            }
            set
            {
                //worry later
            }
        }
        public clsOrderProcessing ThisOrderProcessing
        {
            get
            {
                return mThisOrderProcessing;

            }
            set
            {
                mThisOrderProcessing = value;
            }
        }

        public clsOrderCollection()
        {

            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrderProcessing_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
                {
                clsOrderProcessing anOrderProcessing = new clsOrderProcessing();
                anOrderProcessing.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                anOrderProcessing.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                anOrderProcessing.OrderDescription = Convert.ToString(DB.DataTable.Rows[Index]["OrderDescription"]);
                anOrderProcessing.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                anOrderProcessing.TotalOrderAmount = Convert.ToDouble(DB.DataTable.Rows[Index]["TotalOrderAmount"]);
                anOrderProcessing.OrderDispatched = Convert.ToBoolean(DB.DataTable.Rows[Index]["OrderDispatched"]);

                mOrderList.Add(anOrderProcessing);
                Index++;
            }

           
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", mThisOrderProcessing.CustomerID);
            DB.AddParameter("@OrderDescription", mThisOrderProcessing.OrderDescription);
            DB.AddParameter("@OrderDate", mThisOrderProcessing.OrderDate);
            DB.AddParameter("@TotalOrderAmount", mThisOrderProcessing.TotalOrderAmount);
            DB.AddParameter("@OrderDispatched", mThisOrderProcessing.OrderDispatched);
            return DB.Execute("sproc_tblOrderProcessing_Insert");
            
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", mThisOrderProcessing.OrderID);
            DB.Execute("sproc_tblOrderProcessing_Delete");
          
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", mThisOrderProcessing.CustomerID);
            DB.AddParameter("@OrderDescription", mThisOrderProcessing.OrderDescription);
            DB.AddParameter("@OrderDate", mThisOrderProcessing.OrderDate);
            DB.AddParameter("@TotalOrderAmount", mThisOrderProcessing.TotalOrderAmount);
            DB.AddParameter("@OrderDispatched", mThisOrderProcessing.OrderDispatched);
            DB.Execute("sproc_tblOrderProcessing_Update");
        }
    }


}