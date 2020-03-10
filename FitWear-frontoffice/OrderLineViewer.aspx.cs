using FitWear_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderLineViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrderLine anOrderLine = new clsOrderLine();
        anOrderLine = (clsOrderLine)Session["anOrderLine"];
        Response.Write(anOrderLine.OrderLineID);
    }
}