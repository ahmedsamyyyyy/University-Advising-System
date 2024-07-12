<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="slot of course.aspx.cs" Inherits="WebApplication.slot_of_course" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="true"></asp:GridView>
            <asp:Label ID="Label5" runat="server" Text="course id:"></asp:Label>
            <asp:TextBox ID="course_id1" runat="server"></asp:TextBox>
            <
            <asp:Label ID="Label1" runat="server" Text="instructor id:"></asp:Label>
            <asp:TextBox ID="instructor_id1" runat="server"></asp:TextBox>
            <asp:Button ID="Button2" runat="server" Text="show graduation plan" OnClick="Button1_Click" />
            <div>&nbsp;</div>
<asp:Button ID="Button1" runat="server" Text="Back" OnClick="Button99_Click" />
        </div>
    </form>
</body>
</html>
