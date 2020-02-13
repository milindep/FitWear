<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Stock.aspx.cs" Inherits="Stock" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        &nbsp;Product ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtProductID" runat="server" OnTextChanged="txtProductID_TextChanged"></asp:TextBox>
            <br />
&nbsp;Product Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtProductName" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
            <br />
            Amount of Stock&nbsp;&nbsp; <asp:TextBox ID="txtAmountOfStock" runat="server"></asp:TextBox>
            <br />
            Price&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
            <br />
            Size&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtSize" runat="server" OnTextChanged="txtSize_TextChanged"></asp:TextBox>
            <br />
            Date added in Stock
            <asp:TextBox ID="txtDateAddedInStock" runat="server"></asp:TextBox>
            <br />
&nbsp;<asp:CheckBox ID="chkbxAvailability" runat="server" Text="Availability" />
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" Text="OK" Width="49px" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </div>
    </form>
</body>
</html>
