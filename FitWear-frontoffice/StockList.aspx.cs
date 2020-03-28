using FitWear_classes;
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

            DisplayStocks();
        }


    }
    void DisplayStocks()
    {
        FitWear_classes.clsStockCollection Stock = new FitWear_classes.clsStockCollection();


        lstStockList.DataSource = Stock.StockList;
        lstStockList.DataValueField = "StockID";
        lstStockList.DataTextField = "ProductName";
        lstStockList.DataBind();
    }


  

    protected void lstStockList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }



    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["StockID"] = 000;

        Response.Redirect("Stock.aspx");
    }


    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 StockID;
        if (lstStockList.SelectedIndex != -1)
        {
            StockID = Convert.ToInt32(lstStockList.SelectedValue);
            Session["ProductID"] = StockID;
            Response.Redirect("DeleteStock.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 StockID;
        if(lstStockList.SelectedIndex != -1)
        {
            StockID = Convert.ToInt32(lstStockList.SelectedValue);
            Session["ProductID"] = StockID;

            Response.Redirect("Stock.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to be edit from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsStockCollection Stocks = new clsStockCollection();
        Stocks.ReportByProductName(txtFilter.Text);
        lstStockList.DataSource = Stocks.StockList;
        lstStockList.DataValueField = "StockID";
        lstStockList.DataTextField = "ProductName";
        lstStockList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsStockCollection Stocks = new clsStockCollection();
        Stocks.ReportByProductName("");
        txtFilter.Text = "";
        lstStockList.DataSource = Stocks.StockList;
        lstStockList.DataValueField = "StockID";
        lstStockList.DataTextField = "ProductName";
        lstStockList.DataBind();
    }
}