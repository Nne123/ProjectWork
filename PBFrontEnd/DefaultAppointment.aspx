<%@ Page Title="" Language="C#" MasterPageFile="~/EasyFixBank.Master" AutoEventWireup="true" CodeBehind="DefaultAppointment.aspx.cs" Inherits="PBFrontEnd.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p style="height: 396px">
        <asp:ListBox ID="lstAppointments" runat="server" Height="189px" Width="301px"></asp:ListBox>
&nbsp;&nbsp;
        <br />
        <br />
        <asp:Label ID="lblSearchMOTDate" runat="server" Text="Search MOT Date"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Width="210px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnApply" runat="server" Text="Apply" Width="130px" OnClick="btnApply_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnDisplayAll" runat="server" Text="Display All" Width="125px" />
        <br />
        <br />
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" Width="75px" />
&nbsp;&nbsp;
        <asp:Button ID="btnEdit" runat="server" Text="Edit" Width="73px" OnClick="btnEdit_Click" />
&nbsp;&nbsp;
        <br />
        <br />
        <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
</p>
    <p style="height: 396px">
        <br />
</p>
</asp:Content>
