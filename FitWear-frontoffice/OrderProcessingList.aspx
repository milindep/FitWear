<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderProcessingList.aspx.cs" Inherits="OrderProcessingList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 611px">
            <asp:Label ID="Label1" runat="server" Text="Total Order Amount:"></asp:Label>
            <asp:ListBox ID="lstOrderProcessingList" runat="server" Height="339px" OnSelectedIndexChanged="lstOrderProcessingList_SelectedIndexChanged" Width="329px" style="margin-left: 0px; margin-top: 129px"></asp:ListBox>
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" style="margin-left: 73px" Width="85px" />
            <br />
            <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
