using System;

namespace FitWear_classes
{
    public class clsCustomer
    {
        //private
        private int mAccountId;
        //public
        public int AccountId {
            get
            {
                return mAccountId;
            }
            set
            {
                mAccountId = value;
            }
        }
        //private
        private string mPaymentDetails;
        //public
        public string PaymentDetails {
            get
            {
                return mPaymentDetails;
            }
            set
            {
                mPaymentDetails = value;
            }
        }
        //private
        private string mAddress;
        //public
        public string Address {
            get
            {
                return mAddress;
            }
            set
            {
                mAddress = value;
            }
        }
        //private
        private DateTime mDateOfCreation;
        //public
        public DateTime DateOfCreation { 
        get
            {
                return mDateOfCreation;
            }
            set
            {
                mDateOfCreation = value;
            }
        }
        //private
        private string mEmailAddress;
        //public
        public string EmailAddress {
            get
            {
                return mEmailAddress;
            }
            set
            {
                mEmailAddress = value;
            }
        }
        //private
        private bool mMarketing;
        //public
        public bool Marketing {
            get
            {
                return mMarketing;
            }
            set
            {
                mMarketing = value;
            }
        }
        //private
        private string mName;
        //public
        public string Name {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }

		public bool Find(int AccountId)
		{
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@AccountId", AccountId);

            DB.Execute("sproc_tblCustomers_FilterByAccountId");
            if (DB.Count == 1)
            {
                mAccountId = Convert.ToInt32(DB.DataTable.Rows[0]["AccountId"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mPaymentDetails = Convert.ToString(DB.DataTable.Rows[0]["PaymentDetails"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mDateOfCreation = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfCreation"]);
                mEmailAddress = Convert.ToString(DB.DataTable.Rows[0]["EmailAddress"]);
                mMarketing = Convert.ToBoolean(DB.DataTable.Rows[0]["Marketing"]);
                return true;
            }
            else {
                return false;
            }
		}
        public string Valid(string Name,
                            string PaymentDetails,
                            string Address,
                            string EmailAddress)
        {
            return "";
        }
	}
}