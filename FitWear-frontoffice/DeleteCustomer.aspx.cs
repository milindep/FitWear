using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteCustomer : System.Web.UI.Page
{
    Int32 AccountId;

    protected void Page_Load(object sender, EventArgs e)
    {
        AccountId = Convert.ToInt32(Session["AccountId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        FitWear_classes.clsCustomerCollection Customer = new FitWear_classes.clsCustomerCollection();

        Customer.ThisCustomer.Find(AccountId);

        Customer.Delete();

        Response.Redirect("CustomerList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerList.aspx");
    }
}