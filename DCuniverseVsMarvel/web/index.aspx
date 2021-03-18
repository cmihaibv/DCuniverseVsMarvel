<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="DCuniverseVsMarvel.web.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>DC Universe vs Marvel</title>
    <link href="css/main.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="header" class="container">
        <div id="logo"><a href="index.aspx">DC Universe vs Marvel</a></div>
        <div id="nav-login" class="container">
            <ul>
                <li><a href="index.aspx">LOGIN</a></li> |
                <li><a href="index.aspx">SIGN IN</a></li>
            </ul>
        </div>
    </div>
    <div id="main-container" class="container">
        <div id="main-content">
            <asp:TextBox ID="TextBox1" runat="server" Rows="10" TextMode="MultiLine" Width="600px"></asp:TextBox>
            <ul style="display:inline">              


                

            </ul>
        </div>
    </div>
    </form>
</body>
</html>
