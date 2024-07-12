<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="graduation plan.aspx.cs" Inherits="WebApplication.graduation_plan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <div>
            <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="true"></asp:GridView>
            
            <asp:Button ID="Button1" runat="server" Text="show graduation plan" OnClick="Button1_Click" />

            <div>&nbsp;</div>
<asp:Button ID="Button2" runat="server" Text="Back" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>
