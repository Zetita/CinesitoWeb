<%@ Page Title="" Language="C#" MasterPageFile="~/Visual.Master" AutoEventWireup="true" CodeBehind="User_Contrasenia.aspx.cs" Inherits="PRESENTACION.User_Contrasenia" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

<style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            width: 290px;
            height: 92px;
        }
        .auto-style4 {
            height: 92px;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
<table class="auto-style1">
<tr>
    <td class="auto-style3">
        <div class="usuario">
            <asp:Label ID="lblUsuario" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="White"></asp:Label> 
            <br />
        </div>
        <div class="menu_user">
    
           <a href="User.aspx">Historial de compras</a>
           <a href="User_Perfil.aspx">Editar datos personales</a>
           <a href="User_Contrasenia" class="active">Cambiar contraseña</a>
           <asp:LinkButton ID="lbCerrar" runat="server" OnClick="lbCerrar_Click" >Cerrar Sesión</asp:LinkButton>
           <asp:LinkButton ID="lbConfig" runat="server" OnClick="lbConfig_Click" ><img src="Recursos/cog.png" width="25" />Administrar datos</asp:LinkButton>


        </div>
    </td>
    <td class="auto-style4">
     <div class="contenido">
         <asp:Label ID="Titulo" runat="server" Text="Cambio de Contraseña" CssClass="Titulos"></asp:Label>
         <asp:Label ID="lblVieja" runat="server" Text="Contraseña Vieja: " style="color:white;font-size:x-large;position:relative;top:100px;right:112px"></asp:Label>
         <asp:Label ID="lblNueva" runat="server" Text="Contraseña Nueva: " style="color:white;font-size:x-large;position:relative;top:150px;right:300px"></asp:Label>
         <asp:Label ID="lblConfirmar" runat="server" Text="Confirmar Contraseña: "  style="color:white;font-size:x-large;position:relative;top:200px;right:502px"></asp:Label></asp:Label>
         <asp:Button ID="btnGuardar" runat="server" BackColor="#303030" Font-Bold="True" ForeColor="White" Text="GUARDAR" style="position:relative;top:270px;left:850px" />
         <asp:TextBox ID="txtVieja" runat="server" style="font-size:x-large;position:relative;top:60px;left:420px" TextMode="Password"></asp:TextBox>
         <asp:TextBox ID="txtNueva" runat="server" style="font-size:x-large;position:relative;top:110px;left:155px" TextMode="Password"></asp:TextBox>
         <asp:TextBox ID="txtConfirmar" runat="server" style="font-size:x-large;position:relative;top:160px;right:109px" TextMode="Password"></asp:TextBox>
     </div>   
    </td>
</tr>
</table>


</asp:Content>
