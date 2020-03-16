<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderProcessingList.aspx.cs" Inherits="OrderProcessingList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstOrderProcessingList" runat="server" Height="267px" OnSelectedIndexChanged="lstOrderProcessingList_SelectedIndexChanged" Width="313px"></asp:ListBox>
        </div>
    </form>
</body>
</html>
