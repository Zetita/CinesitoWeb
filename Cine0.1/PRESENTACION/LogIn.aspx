<%@ Page Title="" Language="C#" MasterPageFile="~/Visual.Master" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="PRESENTACION.LogIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


   <asp:Label ID="lblLinea" runat="server" Text="_______________________________________________________" ForeColor="White" style="position:absolute; top:335px; left:475px;transform: rotate(-90deg)"></asp:Label>
    <asp:Label ID="lblRegistro" runat="server" Text="Registrarse" ForeColor="White" style="position:absolute; top:120px; left:773px;font-size:xx-large" Font-Bold="true"></asp:Label>
    <asp:Label ID="lblIniciarSesion" runat="server" Text="Iniciar sesión" ForeColor="White" style="position:absolute; top:120px; left:320px;font-size:xx-large" Font-Bold="true"></asp:Label>

    <asp:Label ID="lblUsuario2" runat="server" Text="Nombre de Usuario" ForeColor="White" style="position:absolute; top:220px; left:320px;font-size:x-large"></asp:Label>
    <asp:TextBox ID="txtUsuario" runat="server"  style="position:absolute; top:269px; left:320px;font-size:x-large;width:360px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfv1" runat="server" ControlToValidate="txtUsuario" ErrorMessage="*" ForeColor="#CC3300" style="position:absolute; top:220px; left:539px;"></asp:RequiredFieldValidator>


      <asp:Label ID="lblContrasenia2" runat="server" Text="Contraseña" ForeColor="White" style="position:absolute; top:329px; left:320px; font-size:x-large"></asp:Label>
    <asp:TextBox ID="txtContrasenia" runat="server"  style="position:absolute; top:374px; left:320px; font-size:x-large;width:360px" TextMode="Password"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfv2" runat="server" ControlToValidate="txtContrasenia" ErrorMessage="*" ForeColor="#CC3300" style="position:absolute; top:328px; left:455px;"></asp:RequiredFieldValidator>

    <asp:Button ID="btnIniciar" runat="server" Text="INICIAR SESIÓN" style="position:absolute; top:480px; left:320px; width: 360px; height:30px" BackColor="Black" ForeColor="White" BorderColor="White" BorderStyle="Solid" Font-Bold="True" OnClick="btnIniciar_Click" />
    <asp:Label ID="lblAdv2" runat="server" Text="" ForeColor="White" style="position:absolute; top:530px; left:351px;"></asp:Label>

    <asp:Button ID="btnRegistro" runat="server" text="Registrarse" style="position:absolute; top:220px; left:775px;" CssClass="botones" OnClick="btnRegistro_Click"></asp:Button>


</asp:Content>
