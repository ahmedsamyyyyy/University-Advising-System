<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="admin.admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="ADMIN "></asp:Label>
            <br />
            <asp:Button ID="advisor" runat="server"  OnClick="Button2_Click" Text="list advisor" />
            <br />
            <br />
            <asp:Button ID="student" runat="server"  OnClick="Button3_Click" Text="show student and advisor" />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server"  OnClick="Button4_Click" Text="pending request" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server"  OnClick="Button5_Click" Text="add semster" />

            start date :    <asp:TextBox ID="startdate" runat="server"></asp:TextBox>
            end date:       <asp:TextBox ID="enddate" runat="server"></asp:TextBox>
            semester code:  <asp:TextBox ID="semester_code" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button3" runat="server"  OnClick="Button6_Click" Text="add course" />

            major :    <asp:TextBox ID="major" runat="server"></asp:TextBox>
            semster:       <asp:TextBox ID="semester" runat="server"></asp:TextBox>
            credit hours:  <asp:TextBox ID="credit_hours" runat="server"></asp:TextBox>
            course name :    <asp:TextBox ID="course_name" runat="server"></asp:TextBox>
            <br />
            offered:       <asp:TextBox ID="offered" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button4" runat="server"  OnClick="Button7_Click" Text="link instructor to course" />
            instructor_id :    <asp:TextBox ID="instructor_id" runat="server"></asp:TextBox>
            course id :       <asp:TextBox ID="course_id" runat="server"></asp:TextBox>
            slot id :  <asp:TextBox ID="slot_id" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button5" runat="server"  OnClick="Button8_Click" Text="link student to advisor" />
            student id :    <asp:TextBox ID="student_id" runat="server"></asp:TextBox>
            advisor id :       <asp:TextBox ID="advisor_id" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button6" runat="server"  OnClick="Button9_Click" Text="link student to course with advisor" />
            instructor_id :    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            student id :    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            course id :       <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            semester code :  <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button7" runat="server"  OnClick="Button10_Click" Text="view instructor with assigned hours" />
            <br />
            <br />
            <asp:Button ID="Button8" runat="server"  OnClick="Button11_Click" Text="view all semster with offered hours" /> 
            






            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="Label91" runat="server" Text="Delete a Course  (enter course id)        "></asp:Label>
            <asp:TextBox ID="TextBox91" runat="server"></asp:TextBox>
            <asp:Button ID="Button91" runat="server"  OnClick="Button91_Click" Text="Delete" />
            <br />
            <br />
            <asp:Label ID="Label92" runat="server" Text="Delete a Slot of Course  (enter current_semester)"></asp:Label>
            <asp:TextBox ID="TextBox92" runat="server"></asp:TextBox>
            <asp:Button ID="Button92" runat="server"  OnClick="Button92_Click" Text="Delete" />
            <br />
            <br />
            <asp:Label ID="Label93" runat="server" Text="Add makeup exam for a certain Course (enter exam type then date then course id)"></asp:Label>
            <asp:TextBox ID="TextBox931" runat="server"></asp:TextBox><asp:TextBox ID="TextBox932" runat="server"></asp:TextBox><asp:TextBox ID="TextBox933" runat="server"></asp:TextBox>
            <asp:Button ID="Button93" runat="server"  OnClick="Button93_Click" Text="Add" />
            <br />
            <br />
            <asp:Label ID="Label94" runat="server" Text="View details for all payments along with their corresponding students."></asp:Label>
            <asp:Button ID="Button94" runat="server"  OnClick="Button94_Click" Text="View" />
            <br />
            <br />
            <asp:Label ID="Label95" runat="server" Text=" Issue installments as per the number of installments for a certain payment.(enter payment id)"></asp:Label>
            <asp:TextBox ID="TextBox94" runat="server"></asp:TextBox>
            <asp:Button ID="Button95" runat="server"  OnClick="Button95_Click" Text="Issue" />
            <br />
            <br />
            <asp:Label ID="Label96" runat="server" Text="Update a student status based on financial status.(enter student id)"></asp:Label>
            <asp:TextBox ID="TextBox95" runat="server"></asp:TextBox>
            <asp:Button ID="Button96" runat="server"  OnClick="Button96_Click" Text="Update" />
            <br />
            <br />
            <asp:Label ID="Label97" runat="server" Text="Fetch details for all Active students."></asp:Label>
            <asp:Button ID="Button97" runat="server"  OnClick="Button97_Click" Text="Fetch" />
            <br />
            <br />
            <asp:Label ID="Label98" runat="server" Text="View all graduation plans along with their initiated advisors."></asp:Label>
            <asp:Button ID="Button98" runat="server"  OnClick="Button98_Click" Text="view" />
            <br />
            <br />
            <asp:Label ID="Label99" runat="server" Text="View all students transcript details."></asp:Label>
            <asp:Button ID="Button99" runat="server"  OnClick="Button99_Click" Text="View" />
            <br />
            <br />
            <asp:Label ID="Label910" runat="server" Text="Fetch all semesters along with their offered courses"></asp:Label>
            <asp:Button ID="Button910" runat="server"  OnClick="Button910_Click" Text="Fetch" />
            <div>&nbsp;</div>
            <asp:Button ID="Button" runat="server" OnClick="Button999_Click" Text="Back To Login Page" />

            






        </div>
    </form>
</body>
</html>
