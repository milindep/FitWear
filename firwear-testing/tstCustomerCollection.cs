using System;
using System.Collections.Generic;
using FitWear_classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace firwear_testing
{
    [TestClass]
    public class tstCustomerCollection
    {

        //InstanceOK
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            Assert.IsNotNull(AllCustomers);
        }
        //CustomerListOK
        [TestMethod]
        public void CustomerListOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            List<clsCustomer> TestList = new List<clsCustomer>();

            clsCustomer TestItem = new clsCustomer();

            //populating the testItem
            TestItem.AccountId = 1;
            TestItem.Name = "Cameron Peacock";
            TestItem.PaymentDetails = "0000-0000-0000-0000 / 00-00-00";
            TestItem.Address = "100 Test street, Tester, Testershire, TE57 0AA ";
            TestItem.DateOfCreation = DateTime.Now.Date;
            TestItem.EmailAddress = "email@email.com";
            TestItem.Marketing = true;

            TestList.Add(TestItem);

            AllCustomers.CustomerList = TestList;

            Assert.AreEqual(AllCustomers.CustomerList, TestList);

        }
        //ThisCustomerPropertyOK
        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            clsCustomer TestCustomer = new clsCustomer();

            TestCustomer.AccountId = 1;
            TestCustomer.Name = "Cameron Peacock";
            TestCustomer.PaymentDetails = "0000-0000-0000-0000 / 00-00-00";
            TestCustomer.Address = "100 Test street, Tester, Testershire, TE57 0AA ";
            TestCustomer.DateOfCreation = DateTime.Now.Date;
            TestCustomer.EmailAddress = "email@email.com";
            TestCustomer.Marketing = true;

            AllCustomers.ThisCustomer = TestCustomer;

            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }
        //ListAndCount
        [TestMethod]
        public void ListAndCountOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            List<clsCustomer> TestList = new List<clsCustomer>();

            clsCustomer TestItem = new clsCustomer();

            //populating the testItem
            TestItem.AccountId = 1;
            TestItem.Name = "Cameron Peacock";
            TestItem.PaymentDetails = "0000-0000-0000-0000 / 00-00-00";
            TestItem.Address = "100 Test street, Tester, Testershire, TE57 0AA ";
            TestItem.DateOfCreation = DateTime.Now.Date;
            TestItem.EmailAddress = "email@email.com";
            TestItem.Marketing = true;

            TestList.Add(TestItem);

            AllCustomers.CustomerList = TestList;

            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }
    }
}
