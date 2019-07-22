<%@ Page Title="" Language="C#" MasterPageFile="~/Visual.Master" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="PRESENTACION.User.User" %>
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
        .auto-style5 {
            position: absolute;
            top: 70px;
            right: 30px;
            width: 940px;
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
    
           <a href="User.aspx" class="active">Historial de compras</a>
           <a href="User_Perfil.aspx">Editar datos personales</a>
           <a href="User_Contrasenia.aspx">Cambiar contraseña</a>
           <asp:LinkButton ID="lbCerrar" runat="server" OnClick="lbCerrar_Click" >Cerrar Sesión</asp:LinkButton>
           <asp:LinkButton ID="lbConfig" runat="server" OnClick="lbConfig_Click" ><img src="Recursos/cog.png" width="25" />Administrar datos</asp:LinkButton>


        </div>
    </td>
    <td class="auto-style4">
     <div class="contenido">
         <asp:Label ID="Titulos" runat="server" Text="Mis compras" CssClass="Titulos"></asp:Label>
         <hr class="auto-style8" />
         <br />
         <asp:GridView ID="grdCompras" runat="server" AllowPaging="True" CellPadding="4" ForeColor="#FFFFFF" GridLines="Both" PageSize="8" BackColor="#000000" style="text-align:center" OnPageIndexChanging="grdCompras_PageIndexChanging" CssClass="auto-style5">
           
         </asp:GridView>
     

         <asp:Label ID="lblSinCompras" runat="server" ForeColor="White" Style="color:#808080;padding-left: 10px; margin: 10px 0px 0px 10px; font-size: xx-large;" ></asp:Label>
         <br />

     </div>   
    </td>
</tr>
</table>

</asp:Content>
