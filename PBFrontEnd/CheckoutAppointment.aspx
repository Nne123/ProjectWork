<%@ Page Title="" Language="C#" MasterPageFile="~/EasyFixBank.Master" AutoEventWireup="true" CodeBehind="CheckoutAppointment.aspx.cs" Inherits="PBFrontEnd.MainCheckoutAppointment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p style="height: 300px">
        <br />
        <asp:Label ID="lblCreditCardNo" runat="server" Text="Credit Card No"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtCreditCardNo" runat="server" Width="220px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnCheckOut" runat="server" Text="Check Out" OnClick="btnCheckOut_Click" Width="132px" />
    </p>
</asp:Content>
