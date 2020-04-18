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

        Customer.Name = txtName.Text;
        Customer.PaymentDetails = txtPaymentDetails.Text;
        Customer.Address = txtAddress.Text;
        Customer.EmailAddress = txtEmailAddress.Text;
        Customer.DateOfCreation = DateTime.Now.Date;
        Session["Customer"] = Customer;
        Response.Write("CustomerViewer.aspx");
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