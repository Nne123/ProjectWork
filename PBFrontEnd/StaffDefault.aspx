<%@ Page Title="" Language="C#" MasterPageFile="~/EasyFixBank.Master" AutoEventWireup="true" CodeBehind="StaffDefault.aspx.cs" Inherits="PBFrontEnd.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<%@ Page AutoEventWireup="true" CodeBehind="Staff.aspx.cs" Inherits="PBFrontEnd.Staff" Language="C#" %>

<!DOCTYPE html>

    <title>Easy Fix</title>
    <link href="EasyFixBank.css" rel="stylesheet" type="text/css" />
    <center>
        <div>
            <h1 style="margin-left: 40px">Sign-in</h1>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="lblEmail" runat="server" Text="Email Address"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEMail" runat="server" Height="25px" Width="250px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server" Height="25px" TextMode="Password" Width="250px"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </div>
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnSignIn" runat="server" Height="41px" OnClick="btnSignIn_Click" Text="Sign-in" Width="202px" />
        </td>
        <td>
        <asp:Button ID="btnSignUp" runat="server" Height="41px" OnClick="btnSignUp_Click" Text="Sign Up" Width="202px" />
        <br />
        </td>
        <td>
    </center>
</asp:Content>

