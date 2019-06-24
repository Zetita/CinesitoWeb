<%@ Page Title="" Language="C#" MasterPageFile="~/Visual.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="PRESENTACION.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <asp:Label ID="Label1" runat="server" Text="Nombre" ForeColor="White" style="position:absolute; top:100px; left:570px;"></asp:Label>
    <asp:TextBox ID="txtNombre" runat="server"  style="position:absolute; top:120px; left:570px;"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfv1" runat="server" ControlToValidate="txtNombre" ErrorMessage="*" ForeColor="#CC3300" style="position:absolute; top:100px; left:630px;"></asp:RequiredFieldValidator>
       

    <asp:Label ID="Label2" runat="server" Text="Apellido" ForeColor="White" style="position:absolute; top:100px; left:720px; margin-left:50px;"></asp:Label>
    <asp:TextBox ID="txtApellido" runat="server" style="position:absolute; top:120px; left:720px; margin-left:50px;"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfv2" runat="server" ControlToValidate="txtApellido" ErrorMessage="*" ForeColor="#CC3300" style="position:absolute; top:100px; left:830px;"></asp:RequiredFieldValidator>


    <asp:Label ID="Label3" runat="server" Text="DNI" ForeColor="White" style="position:absolute; top:150px; left:570px;"></asp:Label>
    <asp:TextBox ID="txtDni" runat="server"  style="position:absolute; top:170px; left:570px;"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfv3" runat="server" ControlToValidate="txtDni" ErrorMessage="*" ForeColor="#CC3300" style="position:absolute; top:150px; left:600px;"></asp:RequiredFieldValidator>


    <asp:Label ID="Label4" runat="server" Text="Fecha de Nacimiento" ForeColor="White" style="position:absolute; top:150px; left:720px; margin-left:50px;"></asp:Label>
    <asp:TextBox ID="txtNacimiento" runat="server"  style="position:absolute; top:170px; left:720px; margin-left:50px;"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfv4" runat="server" ControlToValidate="txtNacimiento" ErrorMessage="*" ForeColor="#CC3300" style="position:absolute; top:150px; left:920px;"></asp:RequiredFieldValidator>


     <asp:Label ID="Label5" runat="server" Text="Correo Electronico" ForeColor="White" style="position:absolute; top:200px; left:570px;"></asp:Label>
    <asp:TextBox ID="txtEmail" runat="server"  style="position:absolute; top:220px; left:570px; width: 317px;"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfv5" runat="server" ControlToValidate="txtEmail" ErrorMessage="*" ForeColor="#CC3300" style="position:absolute; top:200px; left:710px;"></asp:RequiredFieldValidator>


        <asp:Label ID="Label6" runat="server" Text="Nombre de Usuario" ForeColor="White" style="position:absolute; top:250px; left:570px;"></asp:Label>
    <asp:TextBox ID="txtUsuario" runat="server"  style="position:absolute; top:270px; left:570px;"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfv6" runat="server" ControlToValidate="txtUsuario" ErrorMessage="*" ForeColor="#CC3300" style="position:absolute; top:250px; left:710px;"></asp:RequiredFieldValidator>


      <asp:Label ID="Label7" runat="server" Text="Contraseña" ForeColor="White" style="position:absolute; top:250px; left:720px; margin-left:50px;"></asp:Label>
    <asp:TextBox ID="txtContrasenia" runat="server"  style="position:absolute; top:270px; left:720px; margin-left:50px;"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfv7" runat="server" ControlToValidate="txtContrasenia" ErrorMessage="*" ForeColor="#CC3300" style="position:absolute; top:250px; left:860px;"></asp:RequiredFieldValidator>


        <asp:Label ID="Label8" runat="server" Text="Numero de Telefono" ForeColor="White" style="position:absolute; top:300px; left:570px;"></asp:Label>
    <asp:TextBox ID="txtTelefono" runat="server"  style="position:absolute; top:320px; left:570px; width: 317px;"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfv8" runat="server" ControlToValidate="txtTelefono" ErrorMessage="*" ForeColor="#CC3300" style="position:absolute; top:300px; left:720px;"></asp:RequiredFieldValidator>

    <asp:Button ID="BtnRegistrar" runat="server" Text="REGISTRAR" style="position:absolute; top:370px; left:570px; width: 350px;" BackColor="Black" ForeColor="White" BorderColor="White" BorderStyle="Solid" OnClick="BtnRegistrar_Click" />
      <asp:Label ID="lblAdd" runat="server" Text="" ForeColor="White" style="position:absolute; top:400px; left:660px;"></asp:Label>
    <asp:Label ID="lblAdv" runat="server" Text="" ForeColor="White" style="position:absolute; top:375px; left:950px;"></asp:Label>

   

</asp:Content>
