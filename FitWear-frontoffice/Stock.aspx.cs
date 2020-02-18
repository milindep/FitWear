using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FitWear_classes;

public partial class Stock : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStock AnStock = new clsStock();

       // AnStock = (clsStock)Session["AnStock"];
        Response.Write(AnStock.StockID);
    }



    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStock AnStock = new clsStock();
        //checks the stock ID
        AnStock.StockID = Convert.ToInt32(txtProductID.Text);
        //checks the product ID
        AnStock.ProductName = txtProductName.Text;
        // checks Amount of stock
        AnStock.AmountOfStock = Convert.ToInt32(txtAmountOfStock.Text);
        //checks price
        AnStock.Price = Convert.ToDouble(txtPrice.Text);
        //checks Size
        AnStock.Size = Convert.ToInt32(txtSize.Text);
        //checks date
        AnStock.DateAddedInStock = Convert.ToDateTime(txtDateAddedInStock.Text);

        //store the stock in the session object
        Session["AnStock"] = AnStock;
        //redirect to the viewer page
        Response.Redirect("StockViewer.aspx");


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
}