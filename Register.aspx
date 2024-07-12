<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="GUCera.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please Register<br />
             <div>&nbsp;</div>
            FirstName:<br />
             <asp:TextBox ID="firstname1" runat="server"></asp:TextBox><br />
            LastName:<br />
            <asp:TextBox ID="lastname1" runat="server"></asp:TextBox><br />
            Password:<br />
            <asp:TextBox ID="password1" runat="server"></asp:TextBox><br />
            Faculty:<br />
            <asp:TextBox ID="faculty1" runat="server"></asp:TextBox><br />
            Email:<br />
            <asp:TextBox ID="email1" runat="server"></asp:TextBox><br />
            Major:<br />
            <asp:TextBox ID="major1" runat="server"></asp:TextBox><br />
            Semester:<br />
            <asp:TextBox ID="semester1" runat="server"></asp:TextBox>
        </div>
    <br />
        <asp:Button ID="registerButton" runat="server" Text="Register" OnClick="registerButton_Click" /> <asp:Button ID="login" runat="server" Text="Go To Login Page" OnClick="login_Click" />
    <br />
    </form>
</body>
</html>
