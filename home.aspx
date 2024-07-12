<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="GUCera.courses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Home Page<br />
            <div>&nbsp;</div>
            <asp:Button ID="mobilenumber" runat="server" Text="Add Telephone Number" OnClick="mobilenumber_Click" /> <asp:Button ID="optionalcourse" runat="server" Text="View Optional Courses" OnClick="optionalcourse_Click" /> <asp:Button ID="availablecourse" runat="server" Text="View Available Courses" OnClick="availablecourse_Click" /> <asp:Button ID="requiredcourse" runat="server" Text="View Required Courses" OnClick="requiredcourse_Click" />  <asp:Button ID="missingcourse" runat="server" Text="View Missing Courses" OnClick="missingcourse_Click" />
            <div>&nbsp;</div>
            Current Semester <asp:TextBox ID="currentsems" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Apply" OnClick="Button1_Click" />
            <div>&nbsp;</div>
            <div>&nbsp;</div>
            Send Course Request<br />
            CourseID<asp:TextBox ID="course1" runat="server"></asp:TextBox><br />
            Type<asp:TextBox ID="type1" runat="server"></asp:TextBox><br />
            Comment<asp:TextBox ID="comment1" runat="server"></asp:TextBox><br />
            <asp:Button ID="Button2" runat="server" Text="Send" OnClick="Button2_Click" />
            <div>&nbsp;</div>
            Send Extra CreditHours Request<br />
            Credit Hours<asp:TextBox ID="credit2" runat="server"></asp:TextBox><br />
            Type<asp:TextBox ID="type2" runat="server"></asp:TextBox><br />
            Comment<asp:TextBox ID="comment2" runat="server"></asp:TextBox><br />
            <asp:Button ID="Credithours" runat="server" Text="Send" OnClick="Credithours_Click" />
            <div>&nbsp;</div>
            <asp:Button ID="Button4" runat="server" Text="View More Options" OnClick="Button4_Click" />
            <div>&nbsp;</div>
            <asp:Button ID="Button3" runat="server" Text="Back To Login Page" OnClick="Button3_Click" />

        </div>
        

    </form>
</body>
</html>
