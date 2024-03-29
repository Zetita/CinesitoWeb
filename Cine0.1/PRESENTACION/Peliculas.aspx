﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Visual.Master" AutoEventWireup="true" CodeBehind="Peliculas.aspx.cs" Inherits="PRESENTACION.Peliculas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
<div style="color:white; background-color:black">

    <!-- INFO PELICULA -->
        <asp:Image ID="imgPortada" runat="server" style="position:absolute;top:91px;left:75px; height: 387px; width: 256px;"/>
        <b><asp:Label ID="lblNombre" runat="server" style="position:absolute;text-transform:uppercase; top: 86px; left: 346px; margin-right:700px" Font-Size="XX-Large"></asp:Label></b>
        <asp:Label ID="lblSinopsis" runat="server" style="position:absolute; top:186px;left:346px; text-align:justify; margin-right:750px"></asp:Label>
        <asp:Label ID="lblGenero" runat="server" style="position:absolute; top:336px; left:346px"></asp:Label>
        <asp:Label ID="lblDuracion" runat="server" style="position:absolute; top:360px; left:346px"></asp:Label>
        <asp:Label ID="lblTrailer" runat="server" Text="TRAILER" style="position:absolute;top:135px;left:800px;font-size:x-large" Font-Bold="True"></asp:Label>
        <asp:Label ID="lblDirector" runat="server" style="position:absolute; top:386px; left:346px"></asp:Label>
        <asp:Label ID="lblVideo" runat="server"></asp:Label>
    
    <!-- VENTA DE ENTRADAS -->
    <b><asp:Label ID="lblVenta" runat="server" Text="VENTA DE ENTRADAS" style="position:absolute;top:436px;left: 346px" Font-Underline="True"></asp:Label></b>

    <!-- SUCURSAL -->
    <asp:Label ID="lbl_Sucursal" runat="server" Text="Sucursal: " style="position:absolute;top:461px;left:346px"></asp:Label>
    <asp:DropDownList ID="ddlCine" runat="server" style="position:absolute; top:460px;left:425px" AutoPostBack="True" OnSelectedIndexChanged="ddlCine_SelectedIndexChanged">
        <asp:ListItem Value="-">-</asp:ListItem>
    </asp:DropDownList>

    <!-- FORMATO -->
    <asp:Label ID="lblFormato" runat="server" Text="Formato:" style="position:absolute;top:461px;left:567px"></asp:Label>  
    <asp:DropDownList ID="ddlFormato" runat="server" style="position:absolute;top:460px;left:653px" AutoPostBack="True" Enabled="False" OnSelectedIndexChanged="ddlFormato_SelectedIndexChanged">
        <asp:ListItem Value="-">-</asp:ListItem>
    </asp:DropDownList>    

    <!-- DÍA -->
    <asp:Label ID="lblDía" runat="server" Text="Día:" style="position:absolute;top:461px;left:884px"></asp:Label>
    <asp:DropDownList ID="ddlDía" runat="server" style="position:absolute;top:460px;left:926px" AutoPostBack="True" Enabled="False" OnSelectedIndexChanged="ddlDía_SelectedIndexChanged">
        <asp:ListItem Value="-">-</asp:ListItem>
    </asp:DropDownList>

    <!-- HORARIO -->
    <asp:Label ID="lblHorario" runat="server" Text="Horario:" style="position:absolute;top:461px;left:1086px"></asp:Label>
    <asp:DropDownList ID="ddlHorario" runat="server" style="position:absolute;top:460px;left:1157px" AutoPostBack="True" Enabled="False" OnSelectedIndexChanged="ddlHorario_SelectedIndexChanged">
        <asp:ListItem Value="-">-</asp:ListItem>
    </asp:DropDownList>
   
    <!-- BOTONES -->
    <asp:Button ID="btnSeleccionar" runat="server" Font-Bold="True" Text="COMPLETE LOS DATOS NECESARIOS" style="background-color:#003d66;position:absolute;top:527px;left:660px;width:577px;height:30px " OnClick="btnSeleccionar_Click" Enabled="False" />
    <asp:Button ID="btnVolver" runat="server" Text="VOLVER" style="background-color:#003d66;position:absolute;top:527px;left:75px;width:577px;height:30px " OnClick="btnVolver_Click" />

</div>
</asp:Content>
