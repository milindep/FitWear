<%@ Page Language="C#" AutoEventWireup="true" CodeFile="anOrderProcessing.aspx.cs" Inherits="anOrderProcessing" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            OrderID
            <asp:TextBox ID="txtOrderID" runat="server" OnTextChanged="txtOrderID_TextChanged" style="margin-left: 66px" Width="228px"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        </div>
        <p>
            CustomerID<asp:TextBox ID="txtCustomerID" runat="server" OnTextChanged="txtCustomerID_TextChanged" style="margin-left: 47px" Width="229px"></asp:TextBox>
        </p>
        OrderDescription<asp:TextBox ID="txtOrderDescription" runat="server" style="margin-left: 17px" Width="225px"></asp:TextBox>
        <br />
        <br />
        OrderDate<asp:TextBox ID="txtOrderDate" runat="server" style="margin-left: 57px" Width="224px"></asp:TextBox>
        <br />
        <br />
        TotalOrderAmount<asp:TextBox ID="txtTotalOrderAmount" runat="server" OnTextChanged="TextBox5_TextChanged" style="margin-left: 8px" Width="223px"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="chkbxOrderDispatched" runat="server" Text="OrderDispatched" />
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="margin-left: 43px" Text="Cancel" Width="109px" />
    </form>
</body>
</html>
