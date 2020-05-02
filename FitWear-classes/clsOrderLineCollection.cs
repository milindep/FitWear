using System;
using System.Collections.Generic;
namespace FitWear_classes
{
    public class clsOrderLineCollection
    {
        List<clsOrderLine> mOrderLineList = new List<clsOrderLine>();
        clsOrderLine mThisOrderLine = new clsOrderLine();
        public List<clsOrderLine> OrderLineList
        {
            get
            {
                return mOrderLineList;
            }
            set
            {
                mOrderLineList = value;
            }
        }

        public int Count
        {
            get
            {
                return mOrderLineList.Count;
            }
            set
            {
                //later 
            }
        }
        public clsOrderLine ThisOrderLine
        {
            get
            {
                return mThisOrderLine;
            }
            set
            {
                mThisOrderLine = value;
            }
        }


        public clsOrderLineCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrderLine_SelectAll");
            PopulateArray(DB);
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", mThisOrderLine.OrderID);
            DB.AddParameter("@ProductID", mThisOrderLine.ProductID);
            DB.AddParameter("@Quantity", mThisOrderLine.Quantity);
            return DB.Execute("sproc_tblOrderLine_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("OrderLineID", mThisOrderLine.OrderLineID);
            DB.Execute("sproc_tblOrderLine_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderLineID", mThisOrderLine.OrderLineID);
            DB.AddParameter("@OrderID", mThisOrderLine.OrderID);
            DB.AddParameter("@ProductID", mThisOrderLine.ProductID);
            DB.AddParameter("@Quantity", mThisOrderLine.Quantity);
            DB.Execute("sproc_tblOrderLine_Update");
        }

        public void ReportbyOrderID(string OrderID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", OrderID);
            DB.Execute("sproc_tblOrderLine_FilterByOrderID");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mOrderLineList = new List<clsOrderLine>();
            while (Index < RecordCount)
            {
                clsOrderLine AnOrderLine = new clsOrderLine();
                AnOrderLine.OrderLineID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderLineID"]);
                AnOrderLine.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrderLine.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                AnOrderLine.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                mOrderLineList.Add(AnOrderLine);
                Index++;
            }
        }
    }
}