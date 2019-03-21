<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductName.aspx.cs" Inherits="PBFrontEnd.Default1" %>

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
            <asp:ListBox ID="lstPart" runat="server" Height="189px" Width="301px" OnSelectedIndexChanged="lstPart_SelectedIndexChanged"></asp:ListBox>
              <ul style="list-style-type:disc;">
  <li>engine</li>

  <li>tyre</li>


  <li>breakpad</li>



<li>lights</li>


  <li>exaust</li>

  <li>alternator</li>

<li>oil</li>

  <li>alloweel </li>

  <li>battery</li>

<li>break disc</li>

  <li>front lights</li>

  <li>starters</li>




</ul>

</body>
</html>