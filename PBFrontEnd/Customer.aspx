<%@ Page Title="" Language="C#" MasterPageFile="~/EasyFixBank.Master" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="PBFrontEnd.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h4>Your Details:</h4>
    <table>
        <tr>
            <td>
                <asp:Label ID="lblFirstName" runat="server" Text="First Name:" Width="200px"></asp:Label>
                <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="lblLastName" runat="server" Text="Last Name:" Width="200px"></asp:Label>
                <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="lblAddressLn1" runat="server" Text="Address Line 1:" Width="200px"></asp:Label>
                <asp:TextBox ID="txtAddressLn1" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="lblAddressLn2" runat="server" Text="Address Line 2:" Width="200px"></asp:Label>
                <asp:TextBox ID="txtAddressLn2" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="lblPhoneNo" runat="server" Text="Phone Number:" Width="200px"></asp:Label>
                <asp:TextBox ID="txtPhoneNo" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="lblEmailAddress" runat="server" Text="Email Address:" Width="200px"></asp:Label>
                <asp:TextBox ID="txtEmailAddress" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="lblCarRegNo" runat="server" Text="Car Registration Number:" Width="200px"></asp:Label>
                <asp:TextBox ID="txtCarRegNo" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="lblError" runat="server" Width="432px" Font-Bold="True" ForeColor="Red" Font-Size="Small"></asp:Label>
            </td>
        </tr>
    </table>
    <br />
    <asp:Label ID="lblSuccess" runat="server" Font-Bold="True" ForeColor="Green" Font-Size="Small"></asp:Label>
    <p>
        <asp:Button ID="btnSave" runat="server" Text="Save" Width="182px" OnClick="btnSave_Click" />
        <asp:Button ID="btnReset" runat="server" Text="Reset" Width="181px" OnClick="btnReset_Click" />
        <br />
    </p>
</asp:Content>