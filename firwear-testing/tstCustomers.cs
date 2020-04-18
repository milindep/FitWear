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

            Error = Customer.Valid(Name, PaymentDetails, Address, EmailAddress);
            Assert.AreEqual(Error, "");
        }
    }
}
