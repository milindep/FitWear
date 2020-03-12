<%@ Page Language="C#" AutoEventWireup="true" CodeFile="anOrderLine.aspx.cs" Inherits="anOrderLine" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            OrderLineID<asp:TextBox ID="txtOrderLineID" runat="server"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
            <br />
            OrderID<asp:TextBox ID="txtOrderID" runat="server"></asp:TextBox>
            <br />
            ProductID<asp:TextBox ID="txtProductID" runat="server"></asp:TextBox>
            <br />
            Quantity<asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text="Ok" />
            <asp:Button ID="btnCancel" runat="server" style="margin-left: 70px" Text="Cancel" Width="77px" />
        </div>
    </form>
</body>
</html>
