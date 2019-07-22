<%@ Page Title="" Language="C#" MasterPageFile="~/Visual.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="PRESENTACION.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <asp:Label ID="Label1" runat="server" Text="Nombre" ForeColor="White" style="position:absolute; top:200px; left:775px;"></asp:Label>
    <asp:TextBox ID="txtNombre" runat="server"  style="position:absolute; top:220px; left:775px;"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfv1" runat="server" ControlToValidate="txtNombre" ErrorMessage="*" ForeColor="#CC3300" style="position:absolute; top:200px; left:1035px;"></asp:RequiredFieldValidator>
       

    <asp:Label ID="Label2" runat="server" Text="Apellido" ForeColor="White" style="position:absolute; top:200px; left:925px; margin-left:50px;"></asp:Label>
    <asp:TextBox ID="txtApellido" runat="server" style="position:absolute; top:220px; left:925px; margin-left:50px;"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfv2" runat="server" ControlToValidate="txtApellido" ErrorMessage="*" ForeColor="#CC3300" style="position:absolute; top:200px; left:835px;"></asp:RequiredFieldValidator>


    <asp:Label ID="Label3" runat="server" Text="DNI (sin puntos)" ForeColor="White" style="position:absolute; top:250px; left:775px;"></asp:Label>
    <asp:TextBox ID="txtDni" runat="server"  style="position:absolute; top:270px; left:775px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfv3" runat="server" ControlToValidate="txtDni" ErrorMessage="*" ForeColor="#CC3300" style="position:absolute; top:250px; left:805px;"></asp:RequiredFieldValidator>


    <asp:Label ID="Label4" runat="server" Text="Fecha de Nacimiento" ForeColor="White" style="position:absolute; top:250px; left:925px; margin-left:50px;"></asp:Label>
    <asp:TextBox ID="txtNacimiento" runat="server"  style="position:absolute; top:270px; left:925px; margin-left:50px;"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfv4" runat="server" ControlToValidate="txtNacimiento" ErrorMessage="*" ForeColor="#CC3300" style="position:absolute; top:250px; left:1127px;"></asp:RequiredFieldValidator>


     <asp:Label ID="Label5" runat="server" Text="Correo Electronico" ForeColor="White" style="position:absolute; top:300px; left:775px;"></asp:Label>
    <asp:TextBox ID="txtEmail" runat="server"  style="position:absolute; top:320px; left:775px; width: 355px;" TextMode="Email"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfv5" runat="server" ControlToValidate="txtEmail" ErrorMessage="*" ForeColor="#CC3300" style="position:absolute; top:300px; left:912px;"></asp:RequiredFieldValidator>


        <asp:Label ID="Label6" runat="server" Text="Nombre de Usuario" ForeColor="White" style="position:absolute; top:350px; left:775px;"></asp:Label>
    <asp:TextBox ID="txtUsuario" runat="server"  style="position:absolute; top:370px; left:775px;"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfv6" runat="server" ControlToValidate="txtUsuario" ErrorMessage="*" ForeColor="#CC3300" style="position:absolute; top:350px; left:914px;"></asp:RequiredFieldValidator>

        <asp:Label ID="Label8" runat="server" Text="Numero de Telefono" ForeColor="White" style="position:absolute; top:350px; left:920px; margin-left:50px;"></asp:Label>
    <asp:TextBox ID="txtTelefono" runat="server"  style="position:absolute; top:370px; left:920px; margin-left:50px;" TextMode="Phone"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfv8" runat="server" ControlToValidate="txtTelefono" ErrorMessage="*" ForeColor="#CC3300" style="position:absolute; top:400px; left:922px;"></asp:RequiredFieldValidator>


      <asp:Label ID="Label7" runat="server" Text="Contraseña" ForeColor="White" style="position:absolute; top:400px; left:775px;"></asp:Label>
    <asp:TextBox ID="txtContrasenia" runat="server"  style="position:absolute; top:420px; left:775px; width: 355px;" TextMode="Password"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfv7" runat="server" ControlToValidate="txtContrasenia" ErrorMessage="*" ForeColor="#CC3300" style="position:absolute; top:350px; left:1060px;"></asp:RequiredFieldValidator>

    <asp:Label ID="lblError" runat="server" ForeColor="Red" style="position:absolute; top: 450px; left:775px;"></asp:Label>

    <asp:Button ID="BtnRegistrar" runat="server" Text="REGISTRAR" style="position:absolute; top:500px; left:775px; width: 360px; height:30px" BackColor="Black" ForeColor="White" BorderColor="White" BorderStyle="Solid" OnClick="BtnRegistrar_Click" Font-Bold="True" />
    <asp:Label ID="lblAdd" runat="server" Text="" ForeColor="White" style="position:absolute; top:530px; left:821px;"></asp:Label>
    <asp:Label ID="lblAdv" runat="server" Text="" ForeColor="White" style="position:absolute; top:530px; left:820px;"></asp:Label>

   <asp:Label ID="lblLinea" runat="server" Text="_______________________________________________________" ForeColor="White" style="position:absolute; top:335px; left:475px;transform: rotate(-90deg)"></asp:Label>
    <asp:Label ID="lblRegistro" runat="server" Text="Registrarse" ForeColor="White" style="position:absolute; top:120px; left:773px;font-size:xx-large" Font-Bold="true"></asp:Label>
    <asp:Label ID="lblIniciarSesion" runat="server" Text="Iniciar sesión" ForeColor="White" style="position:absolute; top:120px; left:320px;font-size:xx-large" Font-Bold="true"></asp:Label>


    <asp:Button ID="btnInicioSesion" runat="server" text="Iniciar sesion" style="position:absolute; top:220px; left:320px;" CssClass="botones" OnClick="btnInicioSesion_Click"></asp:Button>

    </asp:Content>
