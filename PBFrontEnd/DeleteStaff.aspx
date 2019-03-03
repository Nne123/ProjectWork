<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditStaff.aspx.cs" Inherits="PBFrontEnd.EditStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Easy Fix</title>
        <link rel="stylesheet" type="text/css" href="EasyFixBank.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <h1>EasyFix</h1>
                <p style="height: 360px">
        <asp:Label ID="lblAreYouSure" runat="server" Text="Are you sure you want to delete staff?"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnYes" runat="server" Text="Yes" OnClick="btnYes_Click" Width="89px" />
    &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" Text="No" Width="80px" />
    </p>
</asp:Content>
        </div>
    </form>
</body> 
</html>
