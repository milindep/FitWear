<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="StockList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ListBox ID="lstStockList" runat="server" Height="400px" OnSelectedIndexChanged="lstStockList_SelectedIndexChanged" Width="200px"></asp:ListBox>
        <div>
        </div>
    </form>
</body>
</html>
