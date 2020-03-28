using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FitWear_classes;

public partial class Stock : System.Web.UI.Page
{
    Int32 StockID;
    protected void Page_Load(object sender, EventArgs e)
    {
        StockID = Convert.ToInt32(Session["ProductID"]);
        if(IsPostBack == false)
        {
            if(StockID != -1)
            {
                DisplayStock();
            }
        }
       // clsStock AnStock = new clsStock();

       // AnStock = (clsStock)Session["AnStock"];
        //Response.Write(AnStock.StockID);
    }

    void DisplayStock()
    {
        clsStockCollection StockBook = new clsStockCollection();
        StockBook.ThisStock.Find(StockID);

        txtProductID.Text = StockBook.ThisStock.StockID.ToString();
        txtProductName.Text = StockBook.ThisStock.ProductName;
        txtAmountOfStock.Text = StockBook.ThisStock.AmountOfStock.ToString();
        txtPrice.Text = StockBook.ThisStock.Price.ToString();
        txtSize.Text = StockBook.ThisStock.Size.ToString();
        txtDateAddedInStock.Text = StockBook.ThisStock.DateAddedInStock.ToString();
        chkbxAvailability.Checked = StockBook.ThisStock.Availability;


    }


    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStock AnStock = new clsStock();
        //checks the stock ID
        string StockID = txtProductID.Text;
        //checks the product ID
        string ProductName = txtProductName.Text;
        // checks Amount of stock
        string AmountOfStock =txtAmountOfStock.Text;
        //checks price
        string Price = txtPrice.Text;
        //checks Size
        string Size = txtSize.Text;
        //checks date
        string DateAddedInStock = txtDateAddedInStock.Text;


        string Error = "";
        Error = AnStock.Valid( ProductName, AmountOfStock, Price, Size, DateAddedInStock);
        if (Error == "")
        {
            AnStock.StockID = Convert.ToInt32(StockID);
            AnStock.ProductName = ProductName;
            AnStock.AmountOfStock = Convert.ToInt32(AmountOfStock);
            AnStock.Price = Convert.ToDouble(Price);
            AnStock.Size = Convert.ToInt32(Size);
            AnStock.DateAddedInStock = Convert.ToDateTime(DateAddedInStock);

            AnStock.Availability = chkbxAvailability.Checked;

            clsStockCollection StockList = new clsStockCollection();
          //  StockList.ThisStock = AnStock;
          //  StockList.Add();

                if(Convert.ToInt32(StockID) == 000)
                {
                    StockList.ThisStock = AnStock;
                    StockList.Add();
                }
                else
                {
                    StockList.ThisStock.Find(Convert.ToInt32(StockID));
                    StockList.ThisStock = AnStock;
                    StockList.Update();
                }

            //StockList.ThisStock = AnStock;
            //StockList.Add();

            Response.Redirect("StockList.aspx");

         
        }
        else
        {
            lblError.Text = Error;
        }

    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtDateAddedInStock_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtProductID_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtSize_TextChanged(object sender, EventArgs e)
    {

    }

  

    protected void txtDateAddedInStock_TextChanged1(object sender, EventArgs e)
    {

    }



    protected void btnFind_Click(object sender, EventArgs e)
    {

        clsStock AnStock = new clsStock();

        Int32 StockID;

        Boolean Found = false;

        StockID = Convert.ToInt32(txtProductID.Text);

        Found = AnStock.Find(StockID);

        if (Found == true)
        {
            txtProductID.Text = Convert.ToString(AnStock.StockID);
            txtProductName.Text = AnStock.ProductName;
            txtAmountOfStock.Text = Convert.ToString(AnStock.AmountOfStock);
            txtPrice.Text = Convert.ToString(AnStock.Price);
            txtSize.Text = Convert.ToString(AnStock.Size);
            txtDateAddedInStock.Text = AnStock.DateAddedInStock.ToString();
        }
    }


    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}