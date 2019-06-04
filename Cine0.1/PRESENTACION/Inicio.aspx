<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="PRESENTACION.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="CSS/Inicio.css" />
    <script src="JS/Slider.js"></script>
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
       <!-- Slideshow container -->
<div class="slideshow-container">

  <!-- Full-width images with number and caption text -->
  <div class="mySlides fade">
    <div class="numbertext">1 / 2</div>
    <img src="Slider/JohnWick.png" style="width:100%">
    
  </div>

  <div class="mySlides fade">
    <div class="numbertext">2 / 2</div>
    <img src="Slider/Aladdin.png" style="width:100%">
    
  </div>


  <!-- Next and previous buttons -->
  <a class="prev" onclick="plusSlides(-1)">&#10094;</a>
  <a class="next" onclick="plusSlides(1)">&#10095;</a>
</div>
<br>

<!-- The dots/circles -->
<div style="text-align:center">
  <span class="dot" onclick="currentSlide(1)"></span> 
  <span class="dot" onclick="currentSlide(2)"></span> 
</div>
       
    <footer id="Pie">
      <em>  Derechos reservados  </em>  Grupo 5 ®
    </footer>
    </form>
    </center>
    </body>
</html>

