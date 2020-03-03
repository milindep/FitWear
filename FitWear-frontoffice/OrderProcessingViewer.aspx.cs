using FitWear_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderProcessingViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrderProcessing anOrderProcessing = new clsOrderProcessing();
        anOrderProcessing = (clsOrderProcessing)Session["anOrderProcessing"];
        Response.Write(anOrderProcessing.OrderID);

            
    }
}