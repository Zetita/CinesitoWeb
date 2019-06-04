<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="PRESENTACION.LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" type="text/css" href="CSS/Login.css" />
    <title></title>
</head>
<body><center>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
&nbsp;LOGIN</p>
        <p>
            <asp:Login ID="Login1" runat="server" LoginButtonText="LogIn" OnAuthenticate="Login1_Authenticate">
            </asp:Login>
        </p>
    </form>
    </center>
    </body>
</html>
