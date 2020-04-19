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
        public string Valid(string name, string paymentDetails, string address, string emailAddress, string dateOfCreation)
        {
            String Error = "";
            DateTime DateTemp;

            if (name.Length == 0)
            {
                Error = Error + "The name cannot be blank : ";
            }
            if (name.Length > 30) {
                Error = Error + "The name cannot exceed 30 characters : ";
            }
            if (paymentDetails.Length == 0)
            {
                Error = Error + "The payment details cannot be blank : ";
            }
            if (paymentDetails.Length > 30)
            {
                Error = Error + "The payment details cannot exceed 30 characters : ";
            }
            if (address.Length == 0)
            {
                Error = Error + "The address cannot be blank : ";
            }
            if (address.Length > 50)
            {
                Error = Error + "The address cannot exceed 50 characters : ";
            }
            if (emailAddress.Length == 0)
            {
                Error = Error + "The email address cannot be blank : ";
            }
            if (emailAddress.Length > 25)
            {
                Error = Error + "The email address cannot exceed 25 characters : ";
            }
            try
            {
                DateTemp = Convert.ToDateTime(dateOfCreation);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past : ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                Error = Error + "The date was not valid : ";
            }
            return Error;
        }
	}
}