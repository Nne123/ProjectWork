<%@ Page Title="" Language="C#" MasterPageFile="~/EasyFixBank.Master" AutoEventWireup="true" CodeBehind="AnAppointment.aspx.cs" Inherits="PBFrontEnd.AddAppointment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p style="height: 378px">
&nbsp;
        <asp:Label ID="lblMOTDate" runat="server" Text="MOT Date"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtMOTDate" runat="server" Width="161px"></asp:TextBox>
        <br />
        &nbsp;
        <asp:Label ID="lblMOTTime" runat="server" Text="MOT Time"></asp:Label>
    &nbsp;&nbsp;
    &nbsp;&nbsp;
        <asp:DropDownList ID="ddlMOTTime" runat="server" Height="17px" Width="166px">
        </asp:DropDownList>
        <br />
        &nbsp;
        <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID"></asp:Label>
    &nbsp;&nbsp;
        <asp:TextBox ID="txtCustomerID" runat="server" Width="158px"></asp:TextBox>
        <br />
        &nbsp;
        <asp:Label ID="lblCarRegNo" runat="server" Text="CarRegNo"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCarRegNo" runat="server" Width="157px"></asp:TextBox>
        <br />
        &nbsp;
        <asp:Label ID="lblStaffID" runat="server" Text="Staff ID"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtStaffID" runat="server" Width="158px"></asp:TextBox>
        <br />
        &nbsp;
        <asp:Label ID="lblJobID" runat="server" Text="Job ID"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtJobID" runat="server" Width="158px"></asp:TextBox>
        <br />
        &nbsp;
        <asp:Label ID="lblActive" runat="server" Text="Active"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:CheckBox ID="chkActive" runat="server" />
        <br />
        <br />
        &nbsp;
        <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
        <br />
        <br />
        &nbsp;
        <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" Width="77px" />
    </p>
</asp:Content>
