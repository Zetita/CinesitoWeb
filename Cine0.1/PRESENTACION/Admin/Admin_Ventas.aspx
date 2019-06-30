<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Admin_Ventas.aspx.cs" Inherits="PRESENTACION.Admin_Ventas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:Label ID="Label1" runat="server" Text="Pelicula"  style="position:absolute; top:150px; "></asp:Label>
    <asp:DropDownList ID="DdpPelicula" runat="server" style="position:absolute; top:150px; left:800px; "></asp:DropDownList>

    <asp:Label ID="Label2" runat="server" Text="Formato"  style="position:absolute; top:210px;"></asp:Label>
    <asp:DropDownList ID="DdpFormato" runat="server" style="position:absolute; top:210px; left:800px; "></asp:DropDownList>

    <asp:Label ID="Label3" runat="server" Text="Fecha" style="position:absolute; top:270px;"></asp:Label>
    <asp:DropDownList ID="DdpFecha" runat="server" style="position:absolute; top:270px; left:800px;"></asp:DropDownList>

    <asp:Label ID="Label4" runat="server" Text="Horario" style="position:absolute; top:330px;"></asp:Label>
    <asp:DropDownList ID="DdpHorario" runat="server" style="position:absolute; top:330px; left:800px;"></asp:DropDownList>

    <asp:Label ID="Label5" runat="server" Text="Cantidad" style="position:absolute; top:390px;"></asp:Label>
    <asp:TextBox ID="TxtCantidad" runat="server" style="position:absolute; top:390px; left:800px"></asp:TextBox>

    <asp:Label ID="Label6" runat="server" Text="Precio Final" style="position:absolute; top:450px;"></asp:Label>
    <asp:TextBox ID="Txtprecio" runat="server" style="position:absolute; top:460px; left:800px;"></asp:TextBox>

    <asp:Label ID="Label7" runat="server" Text="Butacas" style="position:absolute; top:510px;"></asp:Label>
    <asp:TextBox ID="TextBox7" runat="server" style="position:absolute; top:510px; left:800px;"></asp:TextBox>

    

    <asp:Button ID="Button1" runat="server" Text="Agregar Venta"  style="position:absolute; top:540px; "/>
</asp:Content>
