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
        <div>
            <h1>EasyFix</h1>
    <h2>Add New Staff:</h2>
    <p>
        <asp:Label ID="StaffID" runat="server" Text="Staff ID:" Width="200px"></asp:Label>
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblFirstName" runat="server" Text="First Name:" Width="200px"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblLastName" runat="server" Text="Last Name:" Width="200px"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblAddressLn1" runat="server" Text="Address Line 1:" Width="200px"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblAddressLn2" runat="server" Text="Address Line 2:" Width="200px"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblPhoneNo" runat="server" Text="Phone Number:" Width="200px"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblEmailAddress" runat="server" Text="Email Address:" Width="200px"></asp:Label>
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <br />
    </p>
    <br />
        <asp:Button ID="btnAdd" runat="server" Text="Add" Width="220px" Height="45px" /> 
            <br />
            <br />
        <asp:Button ID="btnSave" runat="server" Text="Save" Width="220px" Height="45px" />
        <br />
        <br />
</form>
</center>
</body>
</asp:Content>
</html>

