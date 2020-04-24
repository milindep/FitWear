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
        //AddMethodOK()
        [TestMethod]
        public void AddMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            clsCustomer TestItem = new clsCustomer();

            Int32 PrimaryKey = 0;

            TestItem.AccountId = 1;
            TestItem.Name = "Cameron Peacock";
            TestItem.PaymentDetails = "0000-0000-0000-0000 / 00-00-00";
            TestItem.Address = "100 Test street, Tester, Testershire, TE57 0AA ";
            TestItem.DateOfCreation = DateTime.Now.Date;
            TestItem.EmailAddress = "email@email.com";
            TestItem.Marketing = true;

            AllCustomers.ThisCustomer = TestItem;

            PrimaryKey = AllCustomers.Add();

            TestItem.AccountId = PrimaryKey;

            AllCustomers.ThisCustomer.Find(PrimaryKey);

            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }
        //DeleteMethodOK
        [TestMethod]
        public void DeleteMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            clsCustomer TestItem = new clsCustomer();

            Int32 PrimaryKey = 0;

            TestItem.AccountId = 1;
            TestItem.Name = "Cameron Peacock";
            TestItem.PaymentDetails = "0000-0000-0000-0000 / 00-00-00";
            TestItem.Address = "100 Test street, Tester, Testershire, TE57 0AA ";
            TestItem.DateOfCreation = DateTime.Now.Date;
            TestItem.EmailAddress = "email@email.com";
            TestItem.Marketing = true;

            AllCustomers.ThisCustomer = TestItem;

            PrimaryKey = AllCustomers.Add();

            TestItem.AccountId = PrimaryKey;

            AllCustomers.ThisCustomer.Find(PrimaryKey);

            AllCustomers.Delete();

            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);

            Assert.IsFalse(Found);
        }
        //UpdateMethodOK
        [TestMethod]
        public void UpdateMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            clsCustomer TestItem = new clsCustomer();

            Int32 PrimaryKey = 0;

            TestItem.Name = "Cameron Peacock";
            TestItem.PaymentDetails = "0000-0000-0000-0000 / 00-00-00";
            TestItem.Address = "100 Test street, Tester, Testershire, TE57 0AA ";
            TestItem.DateOfCreation = DateTime.Now.Date;
            TestItem.EmailAddress = "email@email.com";
            TestItem.Marketing = true;

            AllCustomers.ThisCustomer = TestItem;

            PrimaryKey = AllCustomers.Add();

            TestItem.AccountId = PrimaryKey;
            //Modify the test data
            TestItem.Name = "Charlie Charles";
            TestItem.PaymentDetails = "1111-1111-1111-1111 / 11-11-11";
            TestItem.Address = "200 Test street, Tester, Testershire, TE57 2AA ";
            TestItem.DateOfCreation = DateTime.Now.Date;
            TestItem.EmailAddress = "email@email.co.uk";
            TestItem.Marketing = false;

            AllCustomers.ThisCustomer = TestItem;

            AllCustomers.Update();

            AllCustomers.ThisCustomer.Find(PrimaryKey);

            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }
        //Report By Name
        [TestMethod]
        public void ReportByNameMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();

            FilteredCustomers.ReportByName("");

            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }
        //Report by name, none found
        [TestMethod]
        public void ReportByNameNoneFound()
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();

            FilteredCustomers.ReportByName("X-Y-Z-G-D");

            Assert.AreEqual(0, FilteredCustomers.Count);
        }
        [TestMethod]
        public void ReportByNameTestDataFound()
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();

            Boolean OK = true;

            FilteredCustomers.ReportByName("keith");

            if (FilteredCustomers.Count == 2)
            {
                if (FilteredCustomers.CustomerList[0].AccountId != 23)
                {
                    OK = false;
                }
                if (FilteredCustomers.CustomerList[1].AccountId != 24)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
