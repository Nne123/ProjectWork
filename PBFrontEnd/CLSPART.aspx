<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PBFrontEnd.Default1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>EasyFix</title>
    <link rel="stylesheet" type="text/css" href="EasyFixBank.css" />
    <style type="text/css">
        #form1 {
            height: 455px;
            width: 1513px;
        }
    </style>
</head>
<body>
    <center>
        <form id="form1" runat="server">
        <div>
            <h1>EasyFix</h1>
            <br />
        </div>
            <h2>List Of Parts</h2>
            <asp:ListBox ID="lstPart" runat="server" Height="189px" Width="301px"></asp:ListBox>
                    <br />
        <br />
             <asp:Button ID="btnYes" runat="server" Text="Add" OnClick="btnAdd
                 _Click" Width="189px" />
             <br />
        <br />
             <asp:Button ID="Button1" runat="server" Text="Edit" OnClick="btnAdd
                 _Click" Width="189px" />
             <br />
                    <br />
             <asp:Button ID="Button2" runat="server" Text="Delete" OnClick="btnAdd
                 _Click" Width="189px" />
             <br />

        </form>
    </center>
</body>
</html>