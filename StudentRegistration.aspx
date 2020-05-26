<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentRegistration.aspx.cs" Inherits="GuitarLessons.StudentRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>GuitarLessons4Life</h1>
    <h2>Students Registration</h2>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LblStudentName" runat="server" Text="Student:"></asp:Label>
            <asp:TextBox ID="TextBoxStudentName" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="LblCourseType" runat="server" Text="Course:"></asp:Label>
            <asp:DropDownList ID="DropDownListCourseType" runat="server">
                <asp:ListItem Value="empty" Selected="True">Select...</asp:ListItem>
                <asp:ListItem Value="one">One day/week</asp:ListItem>
                <asp:ListItem Value="two">Two days/week</asp:ListItem>
                <asp:ListItem Value="three">Three days/week</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div>
            <asp:RequiredFieldValidator 
                ControlToValidate="TextBoxStudentName"
                ID="RequiredFieldValidatorStudentName"
                ErrorMessage="Please enter the student's name."
                runat="server"></asp:RequiredFieldValidator>

            <asp:RequiredFieldValidator 
                ControlToValidate="DropDownListCourseType"
                ID="DropDownCourseTypeListValidator"
                ErrorMessage="Please select a course type."
                InitialValue="empty"
                runat="server"></asp:RequiredFieldValidator>
        </div>
        <asp:Button ID="ButtonStudents" runat="server" Text="Register" OnClick="ButtonStudents_Click" />
        <asp:Table ID="TableStudents" runat="server">
            <asp:TableHeaderRow>
                <asp:TableHeaderCell>ID</asp:TableHeaderCell>
                <asp:TableHeaderCell>Name</asp:TableHeaderCell>
                <asp:TableHeaderCell>Course</asp:TableHeaderCell>
            </asp:TableHeaderRow>
            <asp:TableRow ID="TableRowNoStudents">
                <asp:TableCell>-</asp:TableCell>
                <asp:TableCell>No students yet</asp:TableCell>
                <asp:TableCell>-</asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <asp:HyperLink ID="HyperLinkStudents" runat="server" NavigateUrl="~/SongsChosen.aspx">Go to Songs Selection</asp:HyperLink>
    </form>
</body>
</html>
