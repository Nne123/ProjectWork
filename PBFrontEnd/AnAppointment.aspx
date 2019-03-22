<%@ Page Title="" Language="C#" MasterPageFile="~/EasyFixBank.Master" AutoEventWireup="true" CodeBehind="AnAppointment.aspx.cs" Inherits="PBFrontEnd.AddAppointment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p style="height: 651px">
&nbsp;

        <asp:Label ID="lblAppointmentDetails" runat="server" Font-Bold="True" Font-Size="Larger" Text="Appointment Details"></asp:Label>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblMOTDate" runat="server" Text="MOT Date" Font-Bold="True"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtMOTDate" runat="server" Width="161px"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblMOTTime" runat="server" Text="MOT Time" Font-Bold="True"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlMOTTime" runat="server" Height="17px" Width="166px">
        </asp:DropDownList>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID" Font-Bold="True"></asp:Label>
    &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCustomerID" runat="server" Width="158px"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblCarRegNo" runat="server" Text="CarRegNo" Font-Bold="True"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCarRegNo" runat="server" Width="157px"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblStaffID" runat="server" Text="Staff ID" Font-Bold="True"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtStaffID" runat="server" Width="158px"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblJobID" runat="server" Text="Job ID" Font-Bold="True"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtJobID" runat="server" Width="158px"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblActive" runat="server" Text="Active" Font-Bold="True"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:CheckBox ID="chkActive" runat="server" />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
        &nbsp;&nbsp;
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" Width="77px" Font-Bold="True" Height="54px" />
    &nbsp;&nbsp;
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" Font-Bold="True" Height="52px" />
    &nbsp;&nbsp;&nbsp;
        &nbsp;<asp:Button ID="btnReset" runat="server" Height="51px" OnClick="btnClearFields_Click" Text="Reset" Width="86px" Font-Bold="True" />
    &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnStaffReference" runat="server" OnClick="btnStaffIDs_Click" Text="Staff Reference" Width="128px" Font-Bold="True" Height="51px" />
    </p>
</asp:Content>
