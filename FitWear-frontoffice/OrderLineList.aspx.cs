﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderLineList : System.Web.UI.Page
{
    Int32 OrderLineID;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            if (OrderLineID != -1)
            {

                DisplayOrderLine();
            }
        }
    }

    void DisplayOrderLine()
    {
        FitWear_classes.clsOrderLineCollection OrderLine = new FitWear_classes.clsOrderLineCollection();
        lstOrderLineList.DataSource = OrderLine.OrderLineList;
        lstOrderLineList.DataValueField = "OrderLineID";
        lstOrderLineList.DataValueField = "OrderID";
        lstOrderLineList.DataBind();
    }
    protected void lstOrderLineList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderLineID"] = -1;
        Response.Redirect("anOrderLine.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 OrderLineID;
        if (lstOrderLineList.SelectedIndex != -1)
        {
            OrderLineID = Convert.ToInt32(lstOrderLineList.SelectedValue);
            Session["OrderLineID"] = OrderLineID;
            Response.Redirect("DeleteOrderLine.aspx");
        }
       else
        {
            lblError.Text = "Please select a record to delete";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 OrderLineID;
        if (lstOrderLineList.SelectedIndex != -1)
        {
            OrderLineID = Convert.ToInt32(lstOrderLineList.SelectedValue);
            Session["OrderLineID"] = OrderLineID;
            Response.Redirect("anOrderLine.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
}