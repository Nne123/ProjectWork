<%@ Page Title="" Language="C#" MasterPageFile="~/EasyFixBank.Master" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="PBFrontEnd.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h4>Your Details:</h4>
    <p>
        First Name: 
        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
        <br />
        <br />
        Last Name: 
        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
        <br />
        <br />
        Address Line 1: 
        <asp:TextBox ID="txtAddressLn1" runat="server"></asp:TextBox>
        <br />
        <br />
        Address Line 2: 
        <asp:TextBox ID="txtAddressLn2" runat="server"></asp:TextBox>
        <br />
        <br />
        Phone Number: 
        <asp:TextBox ID="txtPhoneNo" runat="server"></asp:TextBox>
        <br />
        <br />
        Email Address:
        <asp:TextBox ID="txtEmailAddress" runat="server"></asp:TextBox>
        <br />
        <br />
        Car Registration Number:
        <asp:TextBox ID="txtCarRegNo" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnSave" runat="server" Text="Save" Width="130px" />
        <asp:Button ID="btnReset" runat="server" Text="Reset" Width="130px" />
        <br />
    </p>
</asp:Content>