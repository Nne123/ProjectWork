<%@ Page Title="" Language="C#" MasterPageFile="~/EasyFixBank.Master" AutoEventWireup="true" CodeBehind="Customer_StaffSide.aspx.cs" Inherits="PBFrontEnd.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h4>Search:</h4>
    <p>
        <asp:ListBox ID="lstCustomers" runat="server" Height="99px" Width="432px" OnSelectedIndexChanged="lstCustomers_SelectedIndexChanged" AutoPostBack="true"></asp:ListBox>
        <br />
        Currently showing:
        <asp:Label ID="lblCurrentCount" runat="server" Width="200px" Font-Bold="True"></asp:Label>
        <br />
        <br />
        Enter car registration number to search:
        <br />
        <asp:TextBox ID="txtSearchField" runat="server" Width="235px"></asp:TextBox>
        <asp:Button ID="btnSearch" runat="server" Text="Search" Width="92px" OnClick="btnSearch_Click" />
        <asp:Button ID="btnShowAll" runat="server" Text="Show All" Width="92px" OnClick="btnShowAll_Click" />
    </p>
    <h4>Details:</h4>
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
    <h4>Actions:</h4>
    <p>
        <asp:Button ID="btnSave" runat="server" Text="Save" Width="124px" Height="30px" OnClick="btnSave_Click" />
        <asp:Button ID="btnAddNew" runat="server" Text="Add New" Width="124px" Height="30px" OnClick="btnAddNew_Click" />
        <asp:Button ID="btnClear" runat="server" Text="Clear Fields" Width="124px" Height="30px" OnClick="btnClear_Click" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" Width="100px" Height="30px" ForeColor="Red" OnClick="btnDelete_Click" />
        <br />
    </p>
</asp:Content>