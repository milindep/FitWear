using System;
using System.Collections.Generic;

namespace FitWear_classes
{
    public class clsCustomerCollection
    {
        //private - list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private - ThisCustomer
        clsCustomer mThisCustomer = new clsCustomer();

        public List<clsCustomer> CustomerList {
            get { return mCustomerList; }
            set { mCustomerList = value; }
        }
        public int Count {
            get { return mCustomerList.Count; }
            set { }
        }
        public clsCustomer ThisCustomer {
            get { return mThisCustomer; }
            set { mThisCustomer = value; }
        }

        public clsCustomerCollection()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblCustomers_SelectAll");

            PopulateArray(DB);
        }
        //Add
        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@Name", mThisCustomer.Name);
            DB.AddParameter("@PaymentDetails", mThisCustomer.PaymentDetails);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@DateOfCreation", mThisCustomer.DateOfCreation);
            DB.AddParameter("@EmailAddress", mThisCustomer.EmailAddress);
            DB.AddParameter("@Marketing", mThisCustomer.Marketing);

            return DB.Execute("sproc_tblCustomers_Insert");
        }
        //Delete
        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@AccountId", mThisCustomer.AccountId);

            DB.Execute("sproc_tblCustomers_Delete");
        }
        //Update
        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@AccountId", mThisCustomer.AccountId);
            DB.AddParameter("@Name", mThisCustomer.Name);
            DB.AddParameter("@PaymentDetails", mThisCustomer.PaymentDetails);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@DateOfCreation", mThisCustomer.DateOfCreation);
            DB.AddParameter("@EmailAddress", mThisCustomer.EmailAddress);
            DB.AddParameter("@Marketing", mThisCustomer.Marketing);

            DB.Execute("sproc_tblCustomers_Update");
        }
        //Report by name
        public void ReportByName(string Name)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@Name", Name);

            DB.Execute("sproc_tblCustomers_FilterByName");

            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;

            Int32 RecordCount;

            RecordCount = DB.Count;

            mCustomerList = new List<clsCustomer>();

            while (Index < RecordCount)
            {
                clsCustomer Customer = new clsCustomer();

                Customer.AccountId = Convert.ToInt32(DB.DataTable.Rows[Index]["AccountId"]);
                Customer.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                Customer.PaymentDetails = Convert.ToString(DB.DataTable.Rows[Index]["PaymentDetails"]);
                Customer.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                Customer.DateOfCreation = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateofCreation"]);
                Customer.EmailAddress = Convert.ToString(DB.DataTable.Rows[Index]["EmailAddress"]);
                Customer.Marketing = Convert.ToBoolean(DB.DataTable.Rows[Index]["Marketing"]);

                mCustomerList.Add(Customer);

                Index++;
            }
        }
    }
}