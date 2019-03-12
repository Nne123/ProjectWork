<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SaveStaff.aspx.cs" Inherits="PBFrontEnd.EditStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Easy Fix</title>
        <link rel="stylesheet" type="text/css" href="EasyFixBank.css" />
</head>
<body>
    <form id="SaveStaff" runat="server">
        <div>
        <center>
            <h1>EasyFix</h1>
                <p style="height: 360px">
        <asp:Label ID="lblAreYouSure" runat="server" Text="Are you sure you want to save new staff?"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnYes" runat="server" Text="Yes" OnClick="btnYes_Click" Width="189px" />
    &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" Text="No" Width="180px" />
    </p>
</asp:Content>
        </div>
    </form>
</body> 
</html>


