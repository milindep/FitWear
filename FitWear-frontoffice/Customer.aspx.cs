using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FitWear_classes;

public partial class Customer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }







    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsCustomer Customer = new clsCustomer();

        string Name = txtName.Text;
        string PaymentDetails = txtPaymentDetails.Text;
        string Address = txtAddress.Text ;
        string EmailAddress = txtEmailAddress.Text;
        string DateOfCreation = Convert.ToString(DateTime.Now.Date);

        string Error = "";
        Error = Customer.Valid(Name, PaymentDetails, Address, EmailAddress, DateOfCreation);

        if (Error == "")
        {
            Customer.Name = Name;
            Customer.PaymentDetails = PaymentDetails;
            Customer.Address = Address;
            Customer.EmailAddress = EmailAddress;
            Customer.DateOfCreation = Convert.ToDateTime(DateOfCreation);

            Session["Customer"] = Customer;
            Response.Write("CustomerViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void txtFirstName_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCustomer Customer = new clsCustomer();

        Int32 AccountId;

        Boolean Found = false;

        AccountId = Convert.ToInt32(txtAccountId.Text);

        Found = Customer.Find(AccountId);

        if (Found == true) {
            txtName.Text = Customer.Name;
            txtPaymentDetails.Text = Customer.PaymentDetails;
            txtAddress.Text = Customer.Address;
            txtEmailAddress.Text = Customer.EmailAddress;
            txtDateOfCreation.Text = Convert.ToString(Customer.DateOfCreation);
        }
    }
}