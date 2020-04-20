using System;
using System.Collections.Generic;

namespace FitWear_classes
{
    public class clsCustomerCollection
    {
        //private
        List<clsCustomer> mCustomerList = new List<clsCustomer>();

        public List<clsCustomer> CustomerList {
            get { return mCustomerList; }
            set { mCustomerList = value; }
        }
        public int Count {
            get { return mCustomerList.Count; }
            set { }
        }
        public clsCustomer ThisCustomer { get; set; }

        public clsCustomerCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;

            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblCustomers_SelectAll");

            RecordCount =  DB.Count;

            while (Index < RecordCount)
            {
                clsCustomer ACustomer = new clsCustomer();

                //populating the customer
                ACustomer.AccountId = Convert.ToInt32(DB.DataTable.Rows[Index]["AccountId"]);
                ACustomer.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                ACustomer.PaymentDetails = Convert.ToString(DB.DataTable.Rows[Index]["PaymentDetails"]);
                ACustomer.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                ACustomer.DateOfCreation = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateofCreation"]);
                ACustomer.EmailAddress = Convert.ToString(DB.DataTable.Rows[Index]["EmailAddress"]);
                ACustomer.Marketing = Convert.ToBoolean(DB.DataTable.Rows[Index]["Marketing"]);

                mCustomerList.Add(ACustomer);

                Index++;

            }
        }
    }
}