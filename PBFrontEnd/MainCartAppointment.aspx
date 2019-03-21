<%@ Page Title="" Language="C#" MasterPageFile="~/EasyFixBank.Master" AutoEventWireup="true" CodeBehind="MainCartAppointment.aspx.cs" Inherits="PBFrontEnd.MainCartAppointment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p style="height: 386px">
        <asp:Label ID="lblAppointmentReference" runat="server" Font-Bold="True" Font-Size="Larger" Text="Appointment Reference"></asp:Label>
        <br />
        <br />
        <tr>
            <td> Parts Fixing </td>
            <td>
                <a href="AppointmentCartDetailsPrices.aspx"> Details</a>
            </td>
        </tr>   
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnCancel_Click" Width="122px" />
    </p>
</asp:Content>

