<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Staff.aspx.cs" Inherits="PBFrontEnd.Staff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Easy Fix</title>
    <link rel="stylesheet" type="text/css" href="EasyFixBank.css" />
</head>
<body>
    <center>
        <form id="form1" runat="server">
        <div>
            <h1>EasyFix</h1>
            <br />
            <h2>Sign-in</h2>
            <table>
                <tr>
                    <td><asp:Label ID="lblEmail" runat="server" Text="Email Address"></asp:Label></td>
                    <td><asp:TextBox ID="txtEMail" runat="server" Width="250px" Height="25px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label></td>
                    <td><asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="250px" Height="25px"></asp:TextBox></td>
                </tr>
            </table>
        </div>
            <br />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <br />
        <asp:Button ID="btnSignIn" runat="server" Text="Sign-in" Width="368px" Height="40px" OnClick="btnSignIn_Click"/>
            <br />
            <br />
        <asp:Button ID="btnSignUp" runat="server" Text="Create a new account"/>
        </form>
    </center>
</body>
         <p style="height: 396px">
        <asp:ListBox ID="lstStaff" runat="server" Height="189px" Width="301px"></asp:ListBox>
&nbsp;&nbsp;
        <br />
        <br />
        <asp:Label ID="lblSearchStaff" runat="server" Text="Search Staff"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Width="210px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnOk" runat="server" Text="Ok" Width="130px" OnClick="btnOk_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnListAll" runat="server" Text="List All" Width="165px" />
        <br />
        <br />
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" Width="135px" />
&nbsp;&nbsp;
        <asp:Button ID="btnEdit" runat="server" Text="Edit" Width="133px" OnClick="btnEdit_Click" />
&nbsp;&nbsp;
        <asp:Button ID="btnDelete" runat="server" Text="Delete" Width="135px" OnClick="btnDelete_Click" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="lblError"></asp:Label>
</p>
    <p style="height: 396px">
        <br />
</p>
</html>

