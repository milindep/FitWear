using System;

namespace FitWear_classes
{
    public class clsCustomer
    {
        public int AccountId { get; set; }
        public string PaymentDetails { get; set; }
        public string Address { get; set; }
        public DateTime DateOfCreation { get; set; }
        public string EmailAddress { get; set; }
        public bool Marketing { get; set; }
        public string Name { get; set; }
    }
}