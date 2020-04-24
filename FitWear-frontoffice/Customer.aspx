<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Customer.aspx.cs" Inherits="Customer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: Calibri; font-weight: normal; font-style: normal; font-variant: normal; background-color: #213458; color: #887575;">
            <asp:Image ID="Image1" runat="server" Height="290px" ImageAlign="Right" ImageUrl="~/Bin/fitwear.png" />
            <asp:Label ID="lblAccountId" runat="server" Text=" "></asp:Label>
            <br />
            <br />
            What is your Name?:&nbsp;&nbsp;&nbsp;
            <br />
            <asp:TextBox ID="txtName" runat="server" OnTextChanged="txtFirstName_TextChanged"></asp:TextBox>
            <br />
            <br />
            What are your payment details?:&nbsp;<br />
            <asp:TextBox ID="txtPaymentDetails" runat="server" Width="320px"></asp:TextBox>
            <br />
            <br />
            What is your address?:&nbsp;&nbsp;&nbsp;<br />
            <asp:TextBox ID="txtAddress" runat="server" Width="450px"></asp:TextBox>
            <br />
            <br />
            What is your email address:?&nbsp;&nbsp;&nbsp; 
            <br />
            <asp:TextBox ID="txtEmailAddress" runat="server" Width="320px"></asp:TextBox>
            <br />
            <br />
            Date Of Creation (set automatically): <br />
            <asp:TextBox ID="txtDateOfCreation" runat="server" Width="165px"></asp:TextBox>
            <br />
            <br />
            Would you like to be opted into our marketing program?&nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="chkbxMarketing" runat="server" Text=" " />
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
            <br />
            <br />
            Find details through AccountId:<br />
            <asp:TextBox ID="txtAccountId" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" Text=" "></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
