<%@ Page Title="" Language="C#" MasterPageFile="~/Visual.Master" AutoEventWireup="true" CodeBehind="Compras.aspx.cs" Inherits="PRESENTACION.Compras" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:Image ID="imgPelicula" runat="server" ImageUrl="~/Recursos/1.jpg" style="position:absolute; top: 229px; left: 696px; height: 272px; width: 196px;" />
    <asp:Label ID="lblNombre" runat="server" Text="JOHN WICK 3: PARABELLUM" style="position:absolute;font-family:Calibri;color:white; top: 229px; left: 905px; margin-right:1000px;font-size:x-large" Font-Bold="True"></asp:Label>
    <asp:Label ID="lblFormato" runat="server" Text="3D - Audio Español" style="position:absolute;font-family:Calibri;color:white; top: 330px; left: 905px; font-size:x-large" Font-Bold="False"></asp:Label>
    <asp:Label ID="lblSucursal" runat="server" Text="Unicenter - Sala 8" style="position:absolute;font-family:Calibri;color:white; top: 370px; left: 905px; font-size:x-large" Font-Bold="true"></asp:Label>
    <asp:Label ID="lblFecha" runat="server" Text="Jueves 13 de Junio - 15:30" style="position:absolute;font-family:Calibri;color:white;font-size:x-large; top: 472px; left: 905px"></asp:Label>
    <asp:Label ID="lblEntrada" runat="server" Text="Entrada General x1"  style="position:absolute;font-family:Calibri;color:white;font-size:x-large;top: 512px; left: 696px"></asp:Label>
    <asp:Label ID="lblPrecio" runat="server" Text="$330" style="position:absolute;font-family:Calibri;color:white;font-size:x-large;top: 512px; left: 1080px"></asp:Label>
    <asp:Label ID="lblTotal" runat="server" Text="TOTAL" style="position:absolute;font-family:Calibri;color:white;font-size:xx-large; top: 600px; left: 696px" Font-Bold="true"></asp:Label>
    <asp:Label ID="lblDireccion" runat="server" Text="Paraná 3745, Martínez, Buenos Aires" style="position:absolute;font-family:Calibri;color:white;font-size:x-large; top: 410px; left: 887px; margin-right:200px"></asp:Label>
    <asp:Label ID="lblLinea" runat="server" Text="________________________________________" style="position:absolute;font-family:Calibri;color:white;font-size:x-large; top: 480px; left: 696px"></asp:Label>
<asp:Label ID="lblPrecioFinal" runat="server" Text="$530" style="position:absolute;font-family:Calibri;color:white;font-size:x-large;top: 600px; left: 1080px" Font-Bold="true"></asp:Label>
    
    <asp:Label ID="lblEmail" runat="server" Text="EMAIL" style="position:absolute;font-family:Calibri;color:white;font-size:medium;top: 220px; left: 300px" Font-Bold="true"></asp:Label>
    <asp:TextBox ID="txtEmail" runat="server" style="position:absolute;width:350px;left:300px;top:250px"></asp:TextBox>
    <asp:Label ID="lblNombreTarjeta" runat="server" Text="NOMBRE DEL TITULAR" style="position:absolute;font-family:Calibri;color:white;font-size:medium; top: 280px; left: 300px" Font-Bold="true"></asp:Label>
    <asp:TextBox ID="txtNombreTarjeta" runat="server" style="position:absolute;width:150px;left:300px;top:310px"></asp:TextBox>
    <asp:Label ID="lblDni" runat="server" Text="DNI DEL TITULAR" style="position:absolute;font-family:Calibri;color:white;font-size:medium; top: 280px; left: 500px" Font-Bold="true"></asp:Label>
    <asp:TextBox ID="txtDni" runat="server" style="position:absolute;width:150px;left:500px;top:310px"></asp:TextBox>
    <asp:Label ID="lblNumeroTarjeta" runat="server" Text="NÚMERO DE TARJETA" style="position:absolute;font-family:Calibri;color:white;font-size:medium; top: 345px; left: 300px" Font-Bold="true"></asp:Label>
    <asp:TextBox ID="txtNumeroTarjeta" runat="server" style="position:absolute;width:150px;left:300px;top:376px"></asp:TextBox>
    <asp:Label ID="lblCodigo" runat="server" Text="CODIGO DE SEGURIDAD" style="position:absolute;font-family:Calibri;color:white;font-size:medium; top: 345px; left: 500px" Font-Bold="true"></asp:Label>
    <asp:TextBox ID="txtCodigo" runat="server" style="position:absolute;width:150px;left:500px;top:376px"></asp:TextBox>
    <asp:Label ID="lblFechaVenc" runat="server" Text="FECHA DE VENCIMIENTO" style="position:absolute;font-family:Calibri;color:white;font-size:medium; top: 414px; left: 300px" Font-Bold="true"></asp:Label>
    <asp:DropDownList ID="ddlFechaVenc1" runat="server" style="position:absolute;width:156px;left:300px;top:449px"></asp:DropDownList>
    <asp:DropDownList ID="ddlFechaVenc2" runat="server" style="position:absolute;width:156px;left:500px;top:449px"></asp:DropDownList>
    <asp:Label ID="lblPago" runat="server" Text="MEDIO DE PAGO" style="position:absolute;font-family:Calibri;color:white;font-size:medium;top:487px; left: 300px" Font-Bold="true"></asp:Label>
    <asp:DropDownList ID="ddlPago" runat="server" style="position:absolute;width:356px;left:300px;top:524px"></asp:DropDownList>
    
    <asp:CheckBox ID="cbTerm" runat="server" style="position:absolute; top: 598px; left: 322px;" />
    <asp:LinkButton ID="lbTerm" runat="server" style="position:absolute;font-family:Calibri;font-size:medium;top:600px; left: 492px">Terminos y Condiciones.</asp:LinkButton>
    <asp:Label ID="lblTerm" runat="server" Text="He leido y acepto los " style="position:absolute;font-family:Calibri;color:white;font-size:medium;top:600px; left: 350px"></asp:Label>

    <asp:Button ID="btnVolver" runat="server" Height="26px" Text="VOLVER" style="background-color:#cc0000;position:absolute;width:500px;top:670px;left:170px;height:30px" />
    <asp:Button ID="btnConfirmar" runat="server" Text="CONFIRMAR" style="background-color:#cc0000;position:absolute;top:670px;width:500px;height:30px" Font-Bold="true"/>
    <asp:Label ID="lblPrecioSnack" runat="server" Text="$200" style="position:absolute;font-family:Calibri;color:white;font-size:x-large;top: 552px; left: 1080px"></asp:Label>
    <asp:Label ID="lblSnack" runat="server" Text="Balde de Pochoclos x1" style="position:absolute;font-family:Calibri;color:white;font-size:x-large;top: 552px; left: 696px"></asp:Label>
</asp:Content>
