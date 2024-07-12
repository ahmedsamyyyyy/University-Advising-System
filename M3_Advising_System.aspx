<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="M3_Advising_System.aspx.cs" Inherits="GUCera.M3_Advising_System" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>&nbsp;</div>
        <div>
            Welcome to Advising System<br />

        </div>
        <div>&nbsp;</div>
        <div>&nbsp;</div>
        For Registration:<br />
        <div>&nbsp;</div>
        <asp:Button ID="Button1" runat="server" Text="Contiue As A Student" OnClick="Button1_Click" /> <asp:Button ID="Button2" runat="server" Text="Continue As An Advisor " OnClick="Button2_Click" />
        <div>&nbsp;</div>
        To Login:<br />
        <div>&nbsp;</div>
        <asp:Button ID="Button3" runat="server" Text="Login As A Student" OnClick="Button3_Click" /> <asp:Button ID="Button4" runat="server" Text="Login As An Advisor" OnClick="Button4_Click" /> <asp:Button ID="Button5" runat="server" Text="Login As An Admin" OnClick="Button5_Click" />


    </form>
</body>
</html>
