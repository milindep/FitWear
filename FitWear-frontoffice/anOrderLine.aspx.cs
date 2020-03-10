using FitWear_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class anOrderLine : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsOrderLine anOrderLine = new clsOrderLine();
        anOrderLine.OrderLineID = Convert.ToInt32(txtOrderLineID.Text);
        anOrderLine.OrderID = Convert.ToInt32(txtOrderID.Text);
        anOrderLine.ProductID = Convert.ToInt32(txtProductID.Text);
        anOrderLine.Quantity = Convert.ToInt32(txtQuantity.Text);
        Session["anOrderLine"] = anOrderLine;
        Response.Write("OrderLineViewer.aspx");
    }
}

