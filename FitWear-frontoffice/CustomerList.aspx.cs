using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FitWear_classes;

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

        lstCustomerList.DataTextField = "Name";

        lstCustomerList.DataBind();
    }

    protected void lstCustomerList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["AccountId"] = -1;

        Response.Redirect("Customer.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 AccountId;

        if (lstCustomerList.SelectedIndex != -1)
        {
            AccountId = Convert.ToInt32(lstCustomerList.SelectedValue);

            Session["AccountId"] = AccountId;

            Response.Redirect("DeleteCustomer.aspx");
        } else {
            lblError.Text = "Please Select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 AccountId;

        if (lstCustomerList.SelectedIndex != -1)
        {
            AccountId = Convert.ToInt32(lstCustomerList.SelectedValue);

            Session["AccountId"] = AccountId;

            Response.Redirect("Customer.aspx");
        }
        else
        {
            lblError.Text = "Please Select a record to edit from the list";
        }
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsCustomerCollection Customers = new clsCustomerCollection();

        Customers.ReportByName("");

        txtFilter.Text = "";

        lstCustomerList.DataValueField = "AccountId";

        lstCustomerList.DataTextField = "Name";

        lstCustomerList.DataBind();
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsCustomerCollection Customers = new clsCustomerCollection();

        Customers.ReportByName(txtFilter.Text);

        lstCustomerList.DataSource = Customers.CustomerList;

        lstCustomerList.DataValueField = "AccountId";

        lstCustomerList.DataTextField = "Name";

        lstCustomerList.DataBind();
    }
}