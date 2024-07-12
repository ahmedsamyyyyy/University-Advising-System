<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="view instructor with assigned hours.aspx.cs" Inherits="admin.view_instructor_with_assigned_hours" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true"></asp:GridView>
            <br />
            <br />
            <asp:Button ID="back" runat="server"  OnClick="Back" Text="Back" />

            </div>
    </form>
</body>
</html>
