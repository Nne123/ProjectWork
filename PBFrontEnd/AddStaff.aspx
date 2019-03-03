<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddStaff.aspx.cs" Inherits="PBFrontEnd.AddStaff" %>

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
            <h2>Add Staff</h2>
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
</asp:Content>
</html>

