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
         <asp:Label ID="Titulos" runat="server" Text="Cambiar contraseña" CssClass="Titulos"></asp:Label>
         <hr class="auto-style8" />
         <br />

         <asp:TextBox ID="txtVieja" runat="server" TextMode="Password" CssClass="Contrasenias"></asp:TextBox>
         <br />
         <asp:Label ID="lblOldPassIncorrecta" runat="server" CssClass="Error"></asp:Label>
         <br />
         <asp:TextBox ID="txtNueva" runat="server" TextMode="Password" CssClass="Contrasenias"></asp:TextBox>
         <br />
         <asp:Label ID="lblNewPassRepetida" runat="server" CssClass="Error"></asp:Label>
         <br />
         <asp:TextBox ID="txtConfirmar" runat="server" TextMode="Password" CssClass="Contrasenias"></asp:TextBox>
         <br />
         <asp:Label ID="lblNewPassDiferente" runat="server" CssClass="Error"></asp:Label>
         <br />
         <asp:Button ID="btnGuardar" runat="server" BackColor="#303030" Font-Bold="True" ForeColor="White" Text="GUARDAR" CssClass="Guardar" OnClick="btnGuardar_Click" />
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Label ID="lblGuardado" runat="server" Text="" Visible="false" ></asp:Label>
     </div>   
    </td>
</tr>
</table>


</asp:Content>
