<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderProcessingList.aspx.cs" Inherits="OrderProcessingList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 714px; width: 1403px;">
            <asp:Label ID="Label1" runat="server" Text="Total Order Amount:"></asp:Label>
            <asp:ListBox ID="lstOrderProcessingList" runat="server" Height="339px" OnSelectedIndexChanged="lstOrderProcessingList_SelectedIndexChanged" Width="329px" style="margin-left: 0px; margin-top: 129px"></asp:ListBox>
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" style="margin-left: 0px" Width="55px" />
            <br />
            <br />
            Enter Order Description
            <asp:TextBox ID="txtFilter" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
            <br />
            <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
        </div>
    </form>
</body>
</html>
