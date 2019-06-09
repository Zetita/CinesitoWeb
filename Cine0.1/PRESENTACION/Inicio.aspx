<%@ Page Title="" Language="C#" MasterPageFile="~/Visual.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="PRESENTACION.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   
  <!-- Contenedor de Slideshow -->
<div class="slideshow-container">
    <br>
  <!-- IMAGEN Y RESOLUCION DE LA IMAGEN -->
  <div class="mySlides fade">
   
    <img src="Slider/JohnWick.jpeg" style="width:70%">
    
  </div>

  <div class="mySlides fade">
 
    <img src="Slider/Future.jpg" style="width:70%" >
    
  </div>

    <div id="Control">  <!-- Siguiente/Atras buttons -->
      
  <a class="prev" onclick="plusSlides(-1)"><label><</label></a>
  <a class="next" onclick="plusSlides(1)"><label>></label></a>
</div>
<br>


    </div>
    <div style="text-align:left; display:inline-block">


        <asp:DropDownList ID="Filtro1" runat="server">
        </asp:DropDownList>
        <asp:DropDownList ID="Filtro2" runat="server">
        </asp:DropDownList>


    </div>
    <div>

        <asp:ListView ID="ListView1" runat="server" OnSelectedIndexChanged="ListView1_SelectedIndexChanged">
        </asp:ListView>

    </div>


</asp:Content>

