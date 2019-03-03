<%@ Page Title="" Language="C#" MasterPageFile="~/EasyFixBank.Master" AutoEventWireup="true" CodeBehind="DefaultCustomer_StaffSide.aspx.cs" Inherits="PBFrontEnd.WebForm2" %>

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
    <p>
        <asp:Label ID="lblFirstName" runat="server" Text="First Name:" Width="200px"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblLastName" runat="server" Text="Last Name:" Width="200px"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblAddressLn1" runat="server" Text="Address Line 1:" Width="200px"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblAddressLn2" runat="server" Text="Address Line 2:" Width="200px"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblPhoneNo" runat="server" Text="Phone Number:" Width="200px"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblEmailAddress" runat="server" Text="Email Address:" Width="200px"></asp:Label>
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblCarRegNo" runat="server" Text="Car Registration Number:" Width="200px"></asp:Label>
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
    </p>
    <h4>Actions:</h4>
    <p>
        <asp:Button ID="btnSave" runat="server" Text="Save" Width="300px" Height="30px" />
        <asp:Button ID="btnAddNew" runat="server" Text="Add New" Width="124px" Height="30px" />
        <br />
    </p>
</asp:Content>