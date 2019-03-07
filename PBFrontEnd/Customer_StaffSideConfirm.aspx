<%@ Page Title="" Language="C#" MasterPageFile="~/EasyFixBank.Master" AutoEventWireup="true" CodeBehind="Customer_StaffSideConfirm.aspx.cs" Inherits="PBFrontEnd.Customer_StaffSideConfirm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h4>Are you sure you want to delete this customer?</h4>
    <p>
        <asp:Button ID="btnYes" runat="server" Text="Yes" Width="100px" OnClick="btnYes_Click" />
        <asp:Button ID="btnNo" runat="server" Text="No" Width="100px" OnClick="btnNo_Click" />
        <br />
    </p>
</asp:Content>