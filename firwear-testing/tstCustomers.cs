using System;
using FitWear_classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace firwear_testing
{
    [TestClass]
    public class tstCustomers
    {

        //good test data
        string Name = "cameron peacock";
        string PaymentDetails = "details";
        string Address = "address";
        string EmailAddress = "email@email.com";
        string DateOfCreation = DateTime.Now.Date.ToString();

        //Testing Instance
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer Customer = new clsCustomer();
            Assert.IsNotNull(Customer);
        }
        //Testing AccountID
        [TestMethod]
        public void AccountIdOK()
        {
            clsCustomer Customer = new clsCustomer();
            int testData = 3;
            Customer.AccountId = testData;
            Assert.AreEqual(Customer.AccountId, testData);
        }

        //Testing Name
        [TestMethod]
        public void NameOK()
        {
            clsCustomer Customer = new clsCustomer();
            string testData = "Cameron";
            Customer.Name = testData;
            Assert.AreEqual(Customer.Name, testData);
        }

        //Testing PaymentDetails
        [TestMethod]
        public void PaymentDetailsOK()
        {
            clsCustomer Customer = new clsCustomer();
            string testData = "4583 2345 3634 0982, visa Debit, 257, 04/26";
            Customer.PaymentDetails = testData;
            Assert.AreEqual(Customer.PaymentDetails, testData);
        }
        //Testing Address
        [TestMethod]
        public void AddressOK()
        {
            clsCustomer Customer = new clsCustomer();
            string testData = "159, test street, testershire";
            Customer.Address = testData;
            Assert.AreEqual(Customer.Address, testData);
        }
        //Testing DateOfCreation
        [TestMethod]
        public void DateOfCreationOK()
        {
            clsCustomer Customer = new clsCustomer();
            DateTime testData = DateTime.Now.Date;
            Customer.DateOfCreation = testData;
            Assert.AreEqual(Customer.DateOfCreation, testData);
        }
        //Testing EmailAddress
        [TestMethod]
        public void EmailAddressOK()
        {
            clsCustomer Customer = new clsCustomer();
            string testData = "test4573@testmail.com";
            Customer.EmailAddress = testData;
            Assert.AreEqual(Customer.EmailAddress, testData);
        }
        //Testing Marketing
        [TestMethod]
        public void MarketingOK()
        {
            clsCustomer Customer = new clsCustomer();
            Boolean testData = true;
            Customer.Marketing = testData;
            Assert.AreEqual(Customer.Marketing, testData);
        }
        //Testing Find
        [TestMethod]
        public void FindMethodOK()
        {
            clsCustomer Customer = new clsCustomer();
            //boolean to store result
            Boolean Found = false;
            //create testData
            Int32 AccountId = 21;
            //invoke method
            Found = Customer.Find(AccountId);
            //test
            Assert.IsTrue(Found);
        }
        //FindAccountId
        [TestMethod]
        public void AccountIdFound()
        {
            clsCustomer customer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 AccountId = 21;
            Found = customer.Find(AccountId);
            if (customer.AccountId != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        //FindPaymentDetails
        [TestMethod]
        public void PaymentDetailsFound()
        {
            clsCustomer customer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 AccountId = 21;
            Found = customer.Find(AccountId);
            if (customer.PaymentDetails != "details")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        //FindAddress
        [TestMethod]
        public void AddressFound()
        {
            clsCustomer customer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 AccountId = 21;
            Found = customer.Find(AccountId);
            if (customer.Address != "address")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        //FindDateOfCreation
        [TestMethod]
        public void DateOfCreationFound()
        {
            clsCustomer customer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 AccountId = 21;
            Found = customer.Find(AccountId);
            if (customer.DateOfCreation != Convert.ToDateTime("19/11/1999"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        //FindEmailAddress
        [TestMethod]
        public void EmailAddressFound()
        {
            clsCustomer customer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 AccountId = 21;
            Found = customer.Find(AccountId);
            if (customer.EmailAddress != "email@email.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        //FindMarketing
        [TestMethod]
        public void MarketingFound()
        {
            clsCustomer customer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 AccountId = 21;
            Found = customer.Find(AccountId);
            if (customer.Marketing != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        //FindName
        [TestMethod]
        public void NameFound()
        {
            clsCustomer customer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 AccountId = 21;
            Found = customer.Find(AccountId);
            if (customer.Name != "cameron peacock")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";

            Error = Customer.Valid(Name, PaymentDetails, Address, EmailAddress, DateOfCreation);
            Assert.AreEqual(Error, "");
        }

        //Validation methods ---------------------------------------------------------
        //Name
        [TestMethod]
        public void NameMinLessOne()
        {
            clsCustomer Customer = new clsCustomer();

            String Error = "";

            string Name = "";

            Error = Customer.Valid(Name, PaymentDetails, Address, EmailAddress, DateOfCreation);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void NameMin()
        {
            clsCustomer Customer = new clsCustomer();

            String Error = "";

            string Name = "a";

            Error = Customer.Valid(Name, PaymentDetails, Address, EmailAddress, DateOfCreation);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameMinPlusOne()
        {
            clsCustomer Customer = new clsCustomer();

            String Error = "";

            string Name = "aa";

            Error = Customer.Valid(Name, PaymentDetails, Address, EmailAddress, DateOfCreation);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameMaxLessOne()
        {
            clsCustomer Customer = new clsCustomer();

            String Error = "";

            string Name = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

            Error = Customer.Valid(Name, PaymentDetails, Address, EmailAddress, DateOfCreation);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameMax()
        {
            clsCustomer Customer = new clsCustomer();

            String Error = "";

            string Name = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

            Error = Customer.Valid(Name, PaymentDetails, Address, EmailAddress, DateOfCreation);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameMaxPlusOne()
        {
            clsCustomer Customer = new clsCustomer();

            String Error = "";

            string Name = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

            Error = Customer.Valid(Name, PaymentDetails, Address, EmailAddress, DateOfCreation);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void NameMid()
        {
            clsCustomer Customer = new clsCustomer();

            String Error = "";

            string Name = "aaaaaaaaaaaaaaa";

            Error = Customer.Valid(Name, PaymentDetails, Address, EmailAddress, DateOfCreation);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameExtremeMax()
        {
            clsCustomer Customer = new clsCustomer();

            String Error = "";

            string Name = "";
            Name = Name.PadRight(500, 'a');

            Error = Customer.Valid(Name, PaymentDetails, Address, EmailAddress, DateOfCreation);
            Assert.AreNotEqual(Error, "");
        }
        //Payment Details
        [TestMethod]
        public void PaymentDetailsMinLessOne()
        {
            clsCustomer Customer = new clsCustomer();

            String Error = "";

            string PaymentDetails = "";

            Error = Customer.Valid(Name, PaymentDetails, Address, EmailAddress, DateOfCreation);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PaymentDetailsMin()
        {
            clsCustomer Customer = new clsCustomer();

            String Error = "";

            string PaymentDetails = "a";

            Error = Customer.Valid(Name, PaymentDetails, Address, EmailAddress, DateOfCreation);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PaymentDetailsMinPlusOne()
        {
            clsCustomer Customer = new clsCustomer();

            String Error = "";

            string PaymentDetails = "aa";

            Error = Customer.Valid(Name, PaymentDetails, Address, EmailAddress, DateOfCreation);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PaymentDetailsMaxLessOne()
        {
            clsCustomer Customer = new clsCustomer();

            String Error = "";

            string PaymentDetails = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

            Error = Customer.Valid(Name, PaymentDetails, Address, EmailAddress, DateOfCreation);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PaymentDetailsMax()
        {
            clsCustomer Customer = new clsCustomer();

            String Error = "";

            string PaymentDetails = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

            Error = Customer.Valid(Name, PaymentDetails, Address, EmailAddress, DateOfCreation);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PaymentDetailsMaxPlusOne()
        {
            clsCustomer Customer = new clsCustomer();

            String Error = "";

            string PaymentDetails = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

            Error = Customer.Valid(Name, PaymentDetails, Address, EmailAddress, DateOfCreation);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PaymentDetailsMid()
        {
            clsCustomer Customer = new clsCustomer();

            String Error = "";

            string PaymentDetails = "aaaaaaaaaaaaaaa";

            Error = Customer.Valid(Name, PaymentDetails, Address, EmailAddress, DateOfCreation);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PaymentDetailsExtremeMax()
        {
            clsCustomer Customer = new clsCustomer();

            String Error = "";

            string PaymentDetails = "";
            PaymentDetails = PaymentDetails.PadRight(500, 'a');

            Error = Customer.Valid(Name, PaymentDetails, Address, EmailAddress, DateOfCreation);
            Assert.AreNotEqual(Error, "");
        }
        //Address
        [TestMethod]
        public void AddressMinLessOne()
        {
            clsCustomer Customer = new clsCustomer();

            String Error = "";

            string Address = "";

            Error = Customer.Valid(Name, PaymentDetails, Address, EmailAddress, DateOfCreation);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AddressMin()
        {
            clsCustomer Customer = new clsCustomer();

            String Error = "";

            string Address = "a";

            Error = Customer.Valid(Name, PaymentDetails, Address, EmailAddress, DateOfCreation);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMinPlusOne()
        {
            clsCustomer Customer = new clsCustomer();

            String Error = "";

            string Address = "aa";

            Error = Customer.Valid(Name, PaymentDetails, Address, EmailAddress, DateOfCreation);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMaxLessOne()
        {
            clsCustomer Customer = new clsCustomer();

            String Error = "";

            string Address = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

            Error = Customer.Valid(Name, PaymentDetails, Address, EmailAddress, DateOfCreation);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMax()
        {
            clsCustomer Customer = new clsCustomer();

            String Error = "";

            string Address = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

            Error = Customer.Valid(Name, PaymentDetails, Address, EmailAddress, DateOfCreation);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMaxPlusOne()
        {
            clsCustomer Customer = new clsCustomer();

            String Error = "";

            string Address = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

            Error = Customer.Valid(Name, PaymentDetails, Address, EmailAddress, DateOfCreation);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AddressMid()
        {
            clsCustomer Customer = new clsCustomer();

            String Error = "";

            string Address = "aaaaaaaaaaaaaaaaaaaaaaaaa";

            Error = Customer.Valid(Name, PaymentDetails, Address, EmailAddress, DateOfCreation);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressExtremeMax()
        {
            clsCustomer Customer = new clsCustomer();

            String Error = "";

            string Address = "";
            Address = Address.PadRight(500, 'a');

            Error = Customer.Valid(Name, PaymentDetails, Address, EmailAddress, DateOfCreation);
            Assert.AreNotEqual(Error, "");
        }
        //EmailAddress
        [TestMethod]
        public void EmailAddressMinLessOne()
        {
            clsCustomer Customer = new clsCustomer();

            String Error = "";

            string EmailAddress = "";

            Error = Customer.Valid(Name, PaymentDetails, Address, EmailAddress, DateOfCreation);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailAddressMin()
        {
            clsCustomer Customer = new clsCustomer();

            String Error = "";

            string EmailAddress = "a";

            Error = Customer.Valid(Name, PaymentDetails, Address, EmailAddress, DateOfCreation);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailAddressMinPlusOne()
        {
            clsCustomer Customer = new clsCustomer();

            String Error = "";

            string EmailAddress = "aa";

            Error = Customer.Valid(Name, PaymentDetails, Address, EmailAddress, DateOfCreation);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailAddressMaxLessOne()
        {
            clsCustomer Customer = new clsCustomer();

            String Error = "";

            string EmailAddress = "aaaaaaaaaaaaaaaaaaaaaaaa";

            Error = Customer.Valid(Name, PaymentDetails, Address, EmailAddress, DateOfCreation);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailAddressMax()
        {
            clsCustomer Customer = new clsCustomer();

            String Error = "";

            string EmailAddress = "aaaaaaaaaaaaaaaaaaaaaaaaa";

            Error = Customer.Valid(Name, PaymentDetails, Address, EmailAddress, DateOfCreation);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailAddressMaxPlusOne()
        {
            clsCustomer Customer = new clsCustomer();

            String Error = "";

            string EmailAddress = "aaaaaaaaaaaaaaaaaaaaaaaaaa";

            Error = Customer.Valid(Name, PaymentDetails, Address, EmailAddress, DateOfCreation);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailAddressMid()
        {
            clsCustomer Customer = new clsCustomer();

            String Error = "";

            string EmailAddress = "aaaaaaaaaaaaa";

            Error = Customer.Valid(Name, PaymentDetails, Address, EmailAddress, DateOfCreation);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailAddressExtremeMax()
        {
            clsCustomer Customer = new clsCustomer();

            String Error = "";

            string EmailAddress = "";
            EmailAddress = EmailAddress.PadRight(500, 'a');

            Error = Customer.Valid(Name, PaymentDetails, Address, EmailAddress, DateOfCreation);
            Assert.AreNotEqual(Error, "");
        }
        //DateOfCreation
        [TestMethod]
        public void DateOfCreationExtremeMin()
        {
            clsCustomer Customer = new clsCustomer();

            String Error = "";

            DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateOfCreation = TestDate.ToString();

            Error = Customer.Valid(Name, PaymentDetails, Address, EmailAddress, DateOfCreation);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateOfCreationMinLessOne()
        {
            clsCustomer Customer = new clsCustomer();

            String Error = "";

            DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string DateOfCreation = TestDate.ToString();

            Error = Customer.Valid(Name, PaymentDetails, Address, EmailAddress, DateOfCreation);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateOfCreationMin()
        {
            clsCustomer Customer = new clsCustomer();

            String Error = "";

            DateTime TestDate = DateTime.Now.Date;
            string DateOfCreation = TestDate.ToString();

            Error = Customer.Valid(Name, PaymentDetails, Address, EmailAddress, DateOfCreation);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateOfCreationMinPlusOne()
        {
            clsCustomer Customer = new clsCustomer();

            String Error = "";

            DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(+1);
            string DateOfCreation = TestDate.ToString();

            Error = Customer.Valid(Name, PaymentDetails, Address, EmailAddress, DateOfCreation);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateOfCreationExtremeMax()
        {
            clsCustomer Customer = new clsCustomer();

            String Error = "";

            DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(+100);
            string DateOfCreation = TestDate.ToString();

            Error = Customer.Valid(Name, PaymentDetails, Address, EmailAddress, DateOfCreation);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateOfCreationInvalidData()
        {
            clsCustomer Customer = new clsCustomer();

            String Error = "";

            string DateOfCreation = "not a date";

            Error = Customer.Valid(Name, PaymentDetails, Address, EmailAddress, DateOfCreation);
            Assert.AreNotEqual(Error, "");
        }
    }
}
