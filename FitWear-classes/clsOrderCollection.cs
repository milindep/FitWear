using System;
using System.Collections.Generic;

namespace FitWear_classes
{
    public class clsOrderCollection
    {
        List<clsOrderProcessing> mOrderList = new List<clsOrderProcessing>();
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
        public clsOrderProcessing ThisOrderProcessing { get; set; }

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

            /*clsOrderProcessing TestItem = new clsOrderProcessing();
            TestItem.OrderID = 1;
            TestItem.CustomerID = 1;
            TestItem.OrderDescription = "some description";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.TotalOrderAmount = 10.00;
            TestItem.OrderDispatched = true;
            mOrderList.Add(TestItem);

            TestItem = new clsOrderProcessing();
            TestItem.OrderID = 2;
            TestItem.CustomerID = 2;
            TestItem.OrderDescription = "another description";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.TotalOrderAmount = 15.00;
            TestItem.OrderDispatched = true;
            mOrderList.Add(TestItem);*/
        }
    }


}