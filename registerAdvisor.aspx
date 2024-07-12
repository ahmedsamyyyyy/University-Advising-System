<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registerAdvisor.aspx.cs" Inherits="WebApplication1.registerAdvisor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please
            Register<br />
            <br />
        </div>
        Username<p>
            <asp:TextBox ID="username" runat="server"></asp:TextBox>
        </p>
        Password<p>
            <asp:TextBox ID="password" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Register" runat="server" Text="Register" OnClick="Register_Click" />
        </p>
    </form>
</body>
</html>
