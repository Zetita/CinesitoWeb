﻿
<%@ Page Title="" Language="C#" MasterPageFile="~/Visual.Master" AutoEventWireup="true" CodeBehind="Peliculas.aspx.cs" Inherits="PRESENTACION.Peliculas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
<div style="color:white; background-color:black">

    <!-- INFO PELICULA -->
        <asp:Image ID="imgPortada" runat="server" style="position:absolute;top:155px;left:75px; height: 387px; width: 256px;"/>
        <b><asp:Label ID="lblNombre" runat="server" style="position:absolute;text-transform:uppercase; top: 150px; left: 346px; margin-right:700px" Font-Size="XX-Large"></asp:Label></b>
        <asp:Label ID="lblSinopsis" runat="server" style="position:absolute; top:250px;left:346px; text-align:justify; margin-right:700px"></asp:Label>
        <asp:Label ID="lblGenero" runat="server" style="position:absolute; top:400px; left:346px"></asp:Label>
        <asp:Label ID="lblDuracion" runat="server" style="position:absolute; top:425px; left:346px"></asp:Label>
        <asp:Label ID="lblTrailer" runat="server" Text="TRAILER" style="position:absolute;top:150px;left:800px;font-size:xx-large" Font-Bold="True"></asp:Label>
        <asp:Label ID="lblDirector" runat="server" style="position:absolute; top:450px; left:346px"></asp:Label>
        <asp:Label ID="lblVideo" runat="server"  ></asp:Label>
    
    <!-- VENTA DE ENTRADAS -->
    <b><asp:Label ID="lblVenta" runat="server" Text="VENTA DE ENTRADAS" style="position:absolute;top:500px;left: 346px" Font-Underline="True"></asp:Label></b>

    <!-- SUCURSAL -->
    <asp:Label ID="lbl_Sucursal" runat="server" Text="Sucursal: " style="position:absolute;top:525px;left:346px"></asp:Label>
    <asp:DropDownList ID="ddlCine" runat="server" style="position:absolute; top:524px;left:425px" AutoPostBack="True" OnSelectedIndexChanged="ddlCine_SelectedIndexChanged">
    </asp:DropDownList>

    <!-- FORMATO -->
    <asp:Label ID="lblFormato" runat="server" Text="Formato:" style="position:absolute;top:525px;left:525px"></asp:Label>  
    <asp:DropDownList ID="ddlFormato" runat="server" style="position:absolute;top:524px;left:602px" AutoPostBack="True" Enabled="False" OnSelectedIndexChanged="ddlFormato_SelectedIndexChanged">
    </asp:DropDownList>    

    <!-- DÍA -->
    <asp:Label ID="lblDía" runat="server" Text="Día:" style="position:absolute;top:525px;left:780px"></asp:Label>
    <asp:DropDownList ID="ddlDía" runat="server" style="position:absolute;top:524px;left:822px" AutoPostBack="True" Enabled="False" OnSelectedIndexChanged="ddlDía_SelectedIndexChanged">
    </asp:DropDownList>

    <!-- HORARIO -->
    <asp:Label ID="lblHorario" runat="server" Text="Horario:" style="position:absolute;top:525px;left:985px"></asp:Label>
    <asp:DropDownList ID="ddlHorario" runat="server" style="position:absolute;top:524px;left:1057px" AutoPostBack="True" Enabled="False">
    </asp:DropDownList>
   
    <!-- BOTONES -->
    <asp:Button ID="btnSeleccionar" runat="server" Font-Bold="True" Text="Seleccionar butacas" style="background-color:#b30000;position:absolute;top:565px;left:346px;width:776px;height:30px " />

</div>
</asp:Content>
