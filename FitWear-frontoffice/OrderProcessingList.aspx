<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderProcessingList.aspx.cs" Inherits="OrderProcessingList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 470px">
            <asp:Label ID="Label1" runat="server" Text="Total Order Amount:"></asp:Label>
            <asp:ListBox ID="lstOrderProcessingList" runat="server" Height="339px" OnSelectedIndexChanged="lstOrderProcessingList_SelectedIndexChanged" Width="329px" style="margin-left: 0px; margin-top: 129px"></asp:ListBox>
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
