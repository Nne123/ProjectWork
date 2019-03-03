<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListStaff.aspx.cs" Inherits="PBFrontEnd.ListStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Easy Fix</title>
    <link rel="stylesheet" type="text/css" href="EasyFixBank.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <p>&nbsp;
            <center>
            <h1>EasyFix</h1>
            </p>
            <br />
            <h2>List Of Staff</h2>
            <asp:ListBox ID="lstStaff" runat="server" Height="189px" Width="301px"></asp:ListBox>
            &nbsp;&nbsp;
            <br />
            <br />
            <asp:Label ID="lblSearchStaff" runat="server" Text="Search Staff :"></asp:Label>             &nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Width="310px" Height="30"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text="Ok" Width="130px" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnListAll" runat="server" Text="List All" Width="165px" />
            <br />
            <br />
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" Width="135px" />
            &nbsp;&nbsp;
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" Width="133px" />
            &nbsp;&nbsp;
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" Width="135px" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="lblError"></asp:Label>
</p>
            <p style="height: 396px">
                <br />
            </p>
        </div>
    </form>
</body>
</html>
