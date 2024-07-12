<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="required.aspx.cs" Inherits="GUCera.required" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true"></asp:GridView>
        </div>
        <div>
        <asp:Button runat="server" Text="Back to HomePage" OnClick="Unnamed1_Click"></asp:Button>&nbsp;</div>
    </form>
</body>
</html>
