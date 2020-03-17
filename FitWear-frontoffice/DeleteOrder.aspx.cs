using FitWear_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteOrder : System.Web.UI.Page
{
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderID = Convert.ToInt32(Session["OrderID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsOrderCollection OrderBook = new clsOrderCollection();
        OrderBook.ThisOrderProcessing.Find(OrderID);
        OrderBook.Delete();
        Response.Redirect("OrderProcessingList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {

    }

    protected void btnNo_Click1(object sender, EventArgs e)
    {

    }
}