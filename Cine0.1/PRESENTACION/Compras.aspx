<%@ Page Title="" Language="C#" MasterPageFile="~/Visual.Master" AutoEventWireup="true" CodeBehind="Compras.aspx.cs" Inherits="PRESENTACION.Compras" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <!-- LBLS, TXTS Y DDLS DE PAGO -->
    <!-- EMAIL -->
    <asp:Label ID="lblEmail" runat="server" Text="EMAIL" style="position:absolute;font-family:Calibri;color:white;font-size:medium;top: 86px; left: 300px" Font-Bold="true"></asp:Label>
    <asp:TextBox ID="txtEmail" runat="server" style="position:absolute;width:350px;left:300px;top:107px"></asp:TextBox>
    
    <!-- TITULAR DE LA TARJETA -->
    <asp:Label ID="lblNombreTarjeta" runat="server" Text="NOMBRE DEL TITULAR" style="position:absolute;font-family:Calibri;color:white;font-size:medium; top: 137px; left: 300px" Font-Bold="true"></asp:Label>
    <asp:TextBox ID="txtNombreTarjeta" runat="server" style="position:absolute;width:150px;left:300px;top:167px"></asp:TextBox>
    
    <!-- DNI DE TITULAR -->
    <asp:Label ID="lblDni" runat="server" Text="DNI DEL TITULAR" style="position:absolute;font-family:Calibri;color:white;font-size:medium; top: 137px; left: 500px" Font-Bold="true"></asp:Label>
    <asp:TextBox ID="txtDni" runat="server" style="position:absolute;width:150px;left:500px;top:167px"></asp:TextBox>
    
    <!-- NUMERO DE LA TARJETA -->
    <asp:Label ID="lblNumeroTarjeta" runat="server" Text="NÚMERO DE TARJETA" style="position:absolute;font-family:Calibri;color:white;font-size:medium; top: 197px; left: 300px" Font-Bold="true"></asp:Label>
    <asp:TextBox ID="txtNumeroTarjeta" runat="server" style="position:absolute;width:150px;left:300px;top:226px"></asp:TextBox>
    
    <!-- CODIGO DE LA TARJETA -->
    <asp:Label ID="lblCodigo" runat="server" Text="CODIGO DE SEGURIDAD" style="position:absolute;font-family:Calibri;color:white;font-size:medium; top: 197px; left: 500px" Font-Bold="true"></asp:Label>
    <asp:TextBox ID="txtCodigo" runat="server" style="position:absolute;width:150px;left:500px;top:226px"></asp:TextBox>
    
    <!-- FECHA DE VENCIMIENTO -->
    <asp:Label ID="lblFechaVenc" runat="server" Text="FECHA DE VENCIMIENTO" style="position:absolute;font-family:Calibri;color:white;font-size:medium; top: 255px; left: 300px" Font-Bold="true"></asp:Label>
    <asp:DropDownList ID="ddlFechaVenc1" runat="server" style="position:absolute;width:156px;left:301px;top:284px"></asp:DropDownList>
    <asp:DropDownList ID="ddlFechaVenc2" runat="server" style="position:absolute;width:156px;left:501px;top:284px"></asp:DropDownList>
    
    <!-- MEDIO DE PAGO -->
    <asp:Label ID="lblPago" runat="server" Text="MEDIO DE PAGO" style="position:absolute;font-family:Calibri;color:white;font-size:medium;top:311px; left: 300px" Font-Bold="true"></asp:Label>
    <asp:DropDownList ID="ddlPago" runat="server" style="position:absolute;width:356px;left:301px;top:340px"></asp:DropDownList>
    <!-- FIN LBLS, TXTS Y DDLS DE PAGO -->

    <!-- INFO PELICULA -->
    <asp:Image ID="imgPelicula" runat="server" ImageUrl="~/Recursos/1.jpg" style="position:absolute; top: 86px; left: 696px; height: 272px; width: 196px;" />
    <asp:Label ID="lblNombre" runat="server" Text="JOHN WICK 3: PARABELLUM" style="position:absolute;font-family:Calibri;color:white; top: 86px; left: 905px; margin-right:1000px;font-size:x-large" Font-Bold="True"></asp:Label>
    
    <!-- INFO COMPRA -->
    <asp:Label ID="lblEntrada" runat="server" Text="Entrada General x1"  style="position:absolute;font-family:Calibri;color:white;font-size:x-large;top: 369px; left: 696px"></asp:Label>
    <asp:Label ID="lblPrecio" runat="server" Text="$330" style="position:absolute;font-family:Calibri;color:white;font-size:x-large;top: 369px; left: 1080px"></asp:Label>
    <asp:Label ID="lblFormato" runat="server" Text="3D - Audio Español" style="position:absolute;font-family:Calibri;color:white; top: 187px; left: 905px; font-size:x-large" Font-Bold="False"></asp:Label>
    <asp:Label ID="lblFecha" runat="server" Text="Jueves 13 de Junio - 15:30" style="position:absolute;font-family:Calibri;color:white;font-size:x-large; top: 329px; left: 905px"></asp:Label>
    <asp:Label ID="lblTotal" runat="server" Text="TOTAL" style="position:absolute;font-family:Calibri;color:white;font-size:xx-large; top: 457px; left: 696px" Font-Bold="true"></asp:Label>
    <asp:Label ID="lblPrecioFinal" runat="server" Text="$530" style="position:absolute;font-family:Calibri;color:white;font-size:x-large;top: 457px; left: 1080px" Font-Bold="true"></asp:Label>
    <asp:Label ID="lblPrecioSnack" runat="server" Text="$200" style="position:absolute;font-family:Calibri;color:white;font-size:x-large;top: 409px; left: 1080px"></asp:Label>
    <asp:Label ID="lblSnack" runat="server" Text="Balde de Pochoclos x1" style="position:absolute;font-family:Calibri;color:white;font-size:x-large;top: 409px; left: 696px"></asp:Label>
    
    <!-- INFO SUCURSAL -->
    <asp:Label ID="lblSucursal" runat="server" Text="Unicenter - Sala 8" style="position:absolute;font-family:Calibri;color:white; top: 227px; left: 905px; font-size:x-large" Font-Bold="true"></asp:Label>
    <asp:Label ID="lblDireccion" runat="server" Text="Paraná 3745, Martínez, Buenos Aires" style="position:absolute;font-family:Calibri;color:white;font-size:x-large; top: 267px; left: 905px; margin-right:200px"></asp:Label>
    
    <!-- BOLUDECES -->
    <asp:Label ID="lblLinea" runat="server" Text="________________________________________" style="position:absolute;font-family:Calibri;color:white;font-size:x-large; top: 337px; left: 696px"></asp:Label>
    <asp:CheckBox ID="cbTerm" runat="server" style="position:absolute; top: 428px; left: 322px;" />
    <asp:LinkButton ID="lbTerm" runat="server" style="position:absolute;font-family:Calibri;font-size:medium;top:430px; left: 492px">Terminos y Condiciones.</asp:LinkButton>
    <asp:Label ID="lblTerm" runat="server" Text="He leido y acepto los " style="position:absolute;font-family:Calibri;color:white;font-size:medium;top:430px; left: 350px"></asp:Label>

    <!-- BOTONES -->
    <asp:Button ID="btnVolver" runat="server" Height="26px" Text="VOLVER" style="background-color:#cc0000;position:absolute;width:500px;top:527px;left:170px;height:30px" />
    <asp:Button ID="btnConfirmar" runat="server" Text="CONFIRMAR" style="background-color:#cc0000;position:absolute;top:527px;width:500px;height:30px;left:680px" Font-Bold="true"/>
    
</asp:Content>
