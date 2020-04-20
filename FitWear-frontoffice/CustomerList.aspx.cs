using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayCustomers();
        }
    }

    void DisplayCustomers()
    {
        FitWear_classes.clsCustomerCollection Customers = new FitWear_classes.clsCustomerCollection();

        lstCustomerList.DataSource = Customers.CustomerList;

        lstCustomerList.DataValueField = "AccountId";

        lstCustomerList.DataTextField = "Address";

        lstCustomerList.DataBind();
    }

    protected void lstCustomerList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}