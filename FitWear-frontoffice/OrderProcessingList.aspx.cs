using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderProcessingList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayOrder();
        }
    }
    void DisplayOrder()
    {
        FitWear_classes.clsOrderCollection Order = new FitWear_classes.clsOrderCollection();
        lstOrderProcessingList.DataSource = Order.OrderList;
        lstOrderProcessingList.DataValueField = "OrderID";
        lstOrderProcessingList.DataTextField = "TotalOrderAmount";
        lstOrderProcessingList.DataBind();
    }

    protected void lstOrderProcessingList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}