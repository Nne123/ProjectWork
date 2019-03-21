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
            <asp:ListBox ID="lstStaff" runat="server" Height="189px" Width="301px" OnSelectedIndexChanged="lstStaff_SelectedIndexChanged"></asp:ListBox>
            &nbsp;&nbsp;
            <br />
            <asp:Label ID="lblError" runat="server" Width="432px" Font-Bold="True" ForeColor="Red" Font-Size="Small"></asp:Label>
            <br />
            <asp:Label ID="lblSearchStaff" runat="server" Text="Search Staff :"></asp:Label>             &nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Width="310px" Height="25"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text="Ok" Width="130px" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnLDisplayAll" runat="server" Text="Display All" Width="165px" OnClick="btnDisplayAll_Click" />
        <asp:Button ID="btnShowAll" runat="server" Text="Show All" Width="135px" OnClick="btnShowAll_Click" Height="53px" />
    &nbsp;<asp:Button ID="btnClear" runat="server" Text="Clear Fields" Width="142px" Height="43px" OnClick="btnClear_Click" />
            <br />
            <br />
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" Width="135px" />
            &nbsp;&nbsp;
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" Width="133px" />
            &nbsp;&nbsp;
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" Width="135px" />
            <br />
            <br />
            <asp:Label ID="lblSuccess" runat="server" Font-Bold="True" ForeColor="Green" Font-Size="Small"></asp:Label>
</p>
            <p style="height: 396px">
                <br />
            </p>
        </div>
    </form>
</body>
</html>
