using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StockList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(IsPostBack == false)
        {
            DisplayStock();
        }


    }
    void DisplayStock()
    {
        FitWear_classes.clsStockCollection Stock = new FitWear_classes.clsStockCollection();


        lstStockList.DataSource = Stock.StockList;
        lstStockList.DataValueField = "ProductID";
        lstStockList.DataValueField = "Price";
        lstStockList.DataBind();
    }



    protected void lstStockList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}