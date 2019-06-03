<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="PRESENTACION.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="CSS/Inicio.css" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>  
<body><center>
    <form id="form1" runat="server">


    <nav >
      <ul Height="269px" Width="694px">
          <header> <asp:Label ID="F" runat="server" Text="CineFrenz"></asp:Label>   </header>
          
          <asp:Label ID="CARTELERA" runat="server" Text="CARTELERA"></asp:Label>
          <asp:Label ID="CINES" runat="server" Text="CINES"></asp:Label>
          <asp:Label ID="SNACKS" runat="server" Text="SNACKS"></asp:Label>
                   
         
      </ul>
         </nav>
        <div id="Usuario"> </div>
       
    <footer id="Pie">
      <em>  Derechos reservados  </em>  Grupo 5 ®
    </footer>
    </form>
    </center>
    </body>
</html>

