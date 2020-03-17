using FitWear_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderProcessingList : System.Web.UI.Page
{
    Int32 OrderID;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderID = Convert.ToInt32(Session["OrderID"]);
        if (IsPostBack == false)
        {
            if (OrderID != -1)
            {
                DisplayOrder();
            }
        }
    }
    void DisplayOrder()
    {

       /*clsOrderCollection OrderBook = new clsOrderCollection();
        OrderBook.ThisOrderProcessing.Find(OrderID);
        txtOrderID.Text = OrderBook.ThisOrderProcessing.OrderID.ToString();
        txtCustomerID.Text = OrderBook.ThisOrderProcessing.CustomerID;
        txtOrderDescription.Text = OrderBook.ThisOrderProcessing.OrderDescription;
        txtOrderDate.Text = OrderBook.ThisOrderProcessing.OrderDate.ToString();
        txtTotalOrderAmount.Text = OrderBook.ThisOrderProcessing.TotalOrderAmount;
        chkOrderDispatched.Text = OrderBook.ThisOrderProcessing.OrderDispatched;*/

        /*FitWear_classes.clsOrderCollection Order = new FitWear_classes.clsOrderCollection();
        lstOrderProcessingList.DataSource = Order.OrderList;
        lstOrderProcessingList.DataValueField = "OrderID";
        lstOrderProcessingList.DataTextField = "TotalOrderAmount";
        lstOrderProcessingList.DataBind();*/
    }

    protected void lstOrderProcessingList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }



    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderID"] = -1;
        Response.Redirect("anOrderProcessing.aspx");
    }



    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 OrderID;
        if (lstOrderProcessingList.SelectedIndex != 1)
        {
            OrderID = Convert.ToInt32(lstOrderProcessingList.SelectedValue);
            Session["OrderID"] = OrderID;
            Response.Redirect("DeleteOrder.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 OrderID;
        if (lstOrderProcessingList.SelectedIndex != 1)
        {
            OrderID = Convert.ToInt32(lstOrderProcessingList.SelectedValue);
            Session["OrderID"] = OrderID;
            Response.Redirect("anOrderProcessing.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }
}
