<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="StockList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="List of Products"></asp:Label>
        <br />
        <asp:ListBox ID="lstStockList" runat="server" Height="203px" OnSelectedIndexChanged="lstStockList_SelectedIndexChanged" Width="170px"></asp:ListBox>
        
        <br />
        
        <br />
        
        <div style="width: 320px">
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            &nbsp;
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
            &nbsp;
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
            <br />
        <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            Filter by Product Name: <asp:TextBox ID="txtFilter" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply" />
            &nbsp;
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
        </div>
    </form>
</body>
</html>
