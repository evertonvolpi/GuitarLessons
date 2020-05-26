<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SongsChosen.aspx.cs" Inherits="GuitarLessons.SongsChosen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>GuitarLessons4Life</h1>
    <h2>Songs Selection</h2>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <asp:DropDownList ID="DropDownListStudents" runat="server" OnSelectedIndexChanged="EventStudentSelected" AutoPostBack="true">
                <asp:ListItem Value="empty" Selected="True"></asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator 
                ControlToValidate="DropDownListStudents"
                ID="DropDownListValidator"
                ErrorMessage="Please select a student."
                InitialValue="empty"
                runat="server"></asp:RequiredFieldValidator>
        </div>
        <div>
            <asp:Literal ID="LiteralStudentStatus" runat="server"></asp:Literal>
        </div>
        <div>
            <asp:CheckBoxList ID="CheckBoxListSongs" runat="server"></asp:CheckBoxList>
        </div>
        <asp:Button ID="ButtonSongs" runat="server" Text="Add" OnClick="ButtonSongs_Click" />
        <asp:HyperLink ID="HyperLinkStudents" runat="server" NavigateUrl="~/StudentRegistration.aspx">Go to Students Registration</asp:HyperLink>
    </form>
</body>
</html>
