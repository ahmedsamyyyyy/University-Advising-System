<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentPart2.aspx.cs" Inherits="WebApplication.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <form id="form1" runat="server">
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="choose instructor " Width="225px" />
        <asp:Label ID="Label1" runat="server" Text="username:"></asp:Label>
        <asp:TextBox ID="username" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text=" instructor id :"></asp:Label>
        <asp:TextBox ID="instructorid" runat="server"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text=" couse id:"></asp:Label>
        <asp:TextBox ID="courseid" runat="server"></asp:TextBox>
        <asp:Label ID="Label4" runat="server" Text="semestercode:"></asp:Label>
        <asp:TextBox ID="semestercode" runat="server"></asp:TextBox>
        </br>
        </br>
        <asp:Button ID="Button2" runat="server" onclick="graduatonplan" Text="graduation plan" />
       
        </br>
        </br>
        <asp:Button ID="Button3" runat="server" Text="unpaid installment" OnClick="Button3_Click" />
       
        </br>
        </br>
        <asp:Button ID="Button4" OnClick="firstmakeup" runat="server" Text="first makeup registeration" />
        <asp:Label ID="Label7" runat="server" Text="student id:"></asp:Label>
        <asp:TextBox ID="student_id3" runat="server"></asp:TextBox>
        <asp:Label ID="Label8" runat="server" Text="course id:"></asp:Label>
        <asp:TextBox ID="course_id" runat="server"></asp:TextBox>
        <asp:Label ID="Label9" runat="server" Text="semester code:"></asp:Label>
        <asp:TextBox ID="semestercode1" runat="server"></asp:TextBox>
        
        </br>
        </br>
        <asp:Button ID="Button5" OnClick="secondmakeup" runat="server" Text="second makeup registeration" />
        <asp:Label ID="Label12" runat="server" Text="student id:"></asp:Label>
        <asp:TextBox ID="student_id" runat="server"></asp:TextBox>
        <asp:Label ID="Label13" runat="server" Text="course id:"></asp:Label>
        <asp:TextBox ID="course_id11" runat="server"></asp:TextBox>
        <asp:Label ID="Label14" runat="server" Text="semester code:"></asp:Label>
        <asp:TextBox ID="semestercde" runat="server"></asp:TextBox>
       
        </br>
        </br>
        <asp:Button ID="Button6" runat="server" OnClick="viewexam" Text="courses with exam details" />
        </br>
        </br>
        <asp:Button ID="Button7" runat="server" OnClick="slot_course" Text="slot of a certain course" />
        </br>
        </br>
        <asp:Button ID="Button8" runat="server" OnClick="view_Course" Text="course details" />
        </br>
        </br>
        <asp:Button ID="Button9" runat="server" OnClick="course" Text="courses with slots details"  />
        </br>
        </br>
        <div>&nbsp;</div>
        <asp:Button ID="Button10" runat="server" Text="Back" OnClick="Button10_Click" />









    </form>
    
    

</body>
</html>
