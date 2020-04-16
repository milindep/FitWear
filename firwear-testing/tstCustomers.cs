using System;
using FitWear_classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace firwear_testing
{
    [TestClass]
    public class tstCustomers
    {
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
    }
}
