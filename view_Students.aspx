<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="view_Students.aspx.cs" Inherits="admin.view_Students" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView92" runat="server" AutoGenerateColumns="true"></asp:GridView>
            <br />
            <br />
            <asp:Button ID="back" runat="server"  OnClick="Back" Text="Back" />

        </div>
    </form>
</body>
</html>
