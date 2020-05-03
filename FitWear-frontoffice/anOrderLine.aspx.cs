using FitWear_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class anOrderLine : System.Web.UI.Page
{
    Int32 OrderLineID;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderLineID = Convert.ToInt32(Session["OrderLineID"]);
        if (IsPostBack == false)
        {
            if (OrderLineID != 1)
            {
                DisplayOrderLine();
            }
        }
    }

    void DisplayOrderLine()
    {
        clsOrderLineCollection OrderLineBook = new clsOrderLineCollection();
        OrderLineBook.ThisOrderLine.Find(OrderLineID);
        txtOrderLineID.Text = OrderLineBook.ThisOrderLine.OrderLineID.ToString();
        txtOrderID.Text = OrderLineBook.ThisOrderLine.OrderID.ToString();
        txtProductID.Text = OrderLineBook.ThisOrderLine.ProductID.ToString();
        txtQuantity.Text = OrderLineBook.ThisOrderLine.Quantity.ToString();
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsOrderLine anOrderLine = new clsOrderLine();
        
        string OrderID = txtOrderID.Text;
        string ProductID = txtProductID.Text;
        string Quantity = txtQuantity.Text;
        string Error = "";
        Error = anOrderLine.Valid(OrderID, ProductID, Quantity);
        if (Error == "")
        {
            anOrderLine.OrderLineID = Convert.ToInt32(txtOrderLineID.Text);
            anOrderLine.OrderID = Convert.ToInt32(txtOrderID.Text);
            anOrderLine.ProductID = Convert.ToInt32(txtProductID.Text);
            anOrderLine.Quantity = Convert.ToInt32(txtQuantity.Text);
            clsOrderLineCollection OrderLineList = new clsOrderLineCollection();
            if (OrderLineID == -1)
            {
                OrderLineList.ThisOrderLine = anOrderLine;
                OrderLineList.Add();
            }
            else
            {
                OrderLineList.ThisOrderLine.Find(OrderLineID);
                OrderLineList.ThisOrderLine = anOrderLine;
                OrderLineList.Update();
            }
            Response.Redirect("OrderLineList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
        
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrderLine anOrderLine = new clsOrderLine();
        Int32 OrderLineID;
        Boolean Found = false;
        OrderLineID = Convert.ToInt32(txtOrderLineID.Text);
        Found = anOrderLine.Find(OrderLineID);
        if (Found == true)
        {
            txtOrderLineID.Text = Convert.ToString(anOrderLine.OrderLineID);
            txtOrderID.Text = Convert.ToString(anOrderLine.OrderID);
            txtProductID.Text = Convert.ToString(anOrderLine.ProductID);
            txtQuantity.Text = Convert.ToString(anOrderLine.Quantity);
        }
    }
}

