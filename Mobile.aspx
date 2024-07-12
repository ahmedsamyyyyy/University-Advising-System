<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mobile.aspx.cs" Inherits="GUCera.Mobile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Mobile Number:<br />
            <asp:TextBox ID="number" runat="server"></asp:TextBox><br />
        </div>
        <asp:Button ID="back" runat="server" Text="Return to HomePage" OnClick="back_Click" /> <asp:Button ID="add" runat="server" Text="Add" OnClick="add_Click" />
        
    </form>
</body>
</html>
