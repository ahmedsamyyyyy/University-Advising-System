<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="admin.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label2" runat="server" Text="Please log in :"></asp:Label>
            <br />
            username:
            <br />
            <asp:TextBox ID="username" runat="server"></asp:TextBox>
            <br />
            password:
            <br />
            <asp:TextBox ID="password" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server"  OnClick="Button1_Click" Text="Back To Main Page" /> <asp:Button ID="Button2" runat="server"  OnClick="Button2_Click" Text="Login" />
        </div>
    </form>
</body>
</html>
