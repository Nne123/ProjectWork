<%@ Page Title="" Language="C#" MasterPageFile="~/EasyFixBank.Master" AutoEventWireup="true" CodeBehind="DeleteAppointment.aspx.cs" Inherits="PBFrontEnd.DeleteAppointment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p style="height: 360px">
        <asp:Label ID="lblAreYouSure" runat="server" Text="Are you sure you want to delete this appointment?"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnYes" runat="server" Text="Yes" OnClick="btnYes_Click" Width="89px" />
    &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" Text="No" Width="80px" />
    </p>
</asp:Content>
