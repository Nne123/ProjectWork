<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddStaff.aspx.cs" Inherits="PBFrontEnd.AddStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Easy Fix</title>
        <link rel="stylesheet" type="text/css" href="EasyFixBank.css" />
</head>
<body>
    <center>
        <form id="form1" runat="server">
        <div/>
    <h1>EasyFix</h1>
                <p>
            <h1>Edit Staff:</h1>
    <p>
        <asp:ListBox ID="lstStaff" runat="server" Height="299px" Width="432px"></asp:ListBox>
        <br />
        <br />
        Enter staff to search:<br />
        <asp:TextBox ID="txtSearchField" runat="server" Width="332px" Height= "45px"></asp:TextBox>      
                        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSearch" runat="server" Text="Search" Width="132px" Height= "45px" OnClick="btnSearch_Click" />
        <br />
        <br />
        <asp:Button ID="btnDisplayAll" runat="server" Text="Display All" Width="220px" Height="45px" />
                        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnAdd" runat="server" Text="Add" Width="220px" Height="45px" /> 
                        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSave" runat="server" Text="Save" Width="220px" Height="45px" />
        <br />
        <br />
</form>
</center>
</body>
</asp:Content>
</html>