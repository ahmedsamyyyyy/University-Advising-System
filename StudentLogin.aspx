<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentLogin.aspx.cs" Inherits="GUCera.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please Log In<br />
             <div>&nbsp;</div>
            UserID:<br />
             <asp:TextBox ID="username" runat="server"></asp:TextBox><br />
            Password:<br />
            <asp:TextBox ID="password" runat="server"></asp:TextBox>
        </div>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Back To Main Page" OnClick="back_Click" /> <asp:Button ID="Loginbutton" runat="server" Text="Login" OnClick="Loginbutton_Click" />
        <br />
       
    </form>
    
</body>
</html>
