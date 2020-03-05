using FitWear_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class anOrderProcessing : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrderProcessing anOrderProcessing = new clsOrderProcessing();
       // anOrderProcessing = (clsOrderProcessing)Session["anOrderProcessing"];
        Response.Write(anOrderProcessing.OrderID);
    }

    

    protected void txtOrderID_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtCustomerID_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsOrderProcessing anOrderProcessing = new clsOrderProcessing();

        anOrderProcessing.OrderID = Convert.ToInt32(txtOrderID.Text);

        anOrderProcessing.CustomerID = Convert.ToInt32(txtCustomerID.Text);

        anOrderProcessing.OrderDescription = txtOrderDescription.Text;

        anOrderProcessing.OrderDate = Convert.ToDateTime(txtOrderDate.Text);

        anOrderProcessing.TotalOrderAmount = Convert.ToDouble(txtTotalOrderAmount.Text);



        Session["anOrderProcessing"] = anOrderProcessing;
        Response.Redirect("OrderProcessingViewer.aspx");
    }

    protected void TextBox5_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrderProcessing anOrderProcessing = new clsOrderProcessing();
        Int32 OrderID;
        Boolean Found = false;
        OrderID = Convert.ToInt32(txtOrderID.Text);
        Found = anOrderProcessing.Find(OrderID);
        if (Found == true)
        {
            txtCustomerID.Text = anOrderProcessing.CustomerID;
            txtOrderDescription.Text = anOrderProcessing.OrderDescription;
            txtOrderDate.Text = anOrderProcessing.OrderDate;#
            txtTotalOrderAmount.Text = anOrderProcessing.TotalOrderAmount;
            



        }
            }
}
