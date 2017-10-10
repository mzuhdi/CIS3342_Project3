<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Yelp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Panel ID="Panel1" runat="server">
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
            <br />
            <asp:LinkButton ID="linkRegister" runat="server" PostBackUrl="~/Register.aspx">Register Now</asp:LinkButton>
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" Visible="false">
            <asp:DropDownList ID="ddlUserType" runat="server"></asp:DropDownList>
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Go" OnClick="btnSubmit_Click" />
        </asp:Panel>
    </form>
</body>
</html>
