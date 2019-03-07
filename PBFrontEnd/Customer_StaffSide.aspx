<%@ Page Title="" Language="C#" MasterPageFile="~/EasyFixBank.Master" AutoEventWireup="true" CodeBehind="Customer_StaffSide.aspx.cs" Inherits="PBFrontEnd.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h4>Search:</h4>
    <p>
        <asp:ListBox ID="lstCustomers" runat="server" Height="99px" Width="432px"></asp:ListBox>
        <br />
        Enter details to search:<br />
        <asp:TextBox ID="txtSearchField" runat="server" Width="332px"></asp:TextBox>
        <asp:Button ID="btnSearch" runat="server" Text="Search" Width="92px" />
        <br />
        <br />
        <asp:Button ID="btnDisplayAll" runat="server" Text="Display All" Width="432px" />
    </p>
    <h4>Details:</h4>
    <table style="width: 864px;">
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
        <br />
        <br />
        </td>
        <td>
        <asp:Label ID="lblError" runat="server" Width="432px" Font-Bold="True" ForeColor="Red"></asp:Label>
        </td>
    </tr>
    </table>
    <h4>Actions:</h4>
    <p>
        <asp:Button ID="btnSave" runat="server" Text="Save" Width="300px" Height="30px" />
        <asp:Button ID="btnAddNew" runat="server" Text="Add New" Width="124px" Height="30px" OnClick="btnAddNew_Click" />
        <br />
    </p>
</asp:Content>