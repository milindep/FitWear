<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Stock.aspx.cs" Inherits="Stock" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        &nbsp;Product ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:TextBox ID="txtProductID" runat="server" OnTextChanged="txtProductID_TextChanged" style="margin-left: 0px"></asp:TextBox>
            <asp:Button ID="txtFind" runat="server" OnClick="txtFind_Click" Text="Find" Width="47px" />
            <br />
&nbsp;Product Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:TextBox ID="txtProductName" runat="server" OnTextChanged="TextBox2_TextChanged" style="margin-left: 0px"></asp:TextBox>
            <br />
            Amount of Stock&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtAmountOfStock" runat="server" style="margin-left: 0px"></asp:TextBox>
            <br />
            Price&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtPrice" runat="server" style="margin-left: 1px"></asp:TextBox>
            <br />
            Size&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:TextBox ID="txtSize" runat="server" OnTextChanged="txtSize_TextChanged" style="margin-left: 3px"></asp:TextBox>
            <br />
            Date added in Stock&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtDateAddedInStock" runat="server" style="margin-left: 0px"></asp:TextBox>
            <br />
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
