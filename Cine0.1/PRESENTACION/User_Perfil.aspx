<%@ Page Title="" Language="C#" MasterPageFile="~/Visual.Master" AutoEventWireup="true" CodeBehind="User_Perfil.aspx.cs" Inherits="PRESENTACION.User_Perfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        
        .auto-style3 {
            width: 290px;
            height: 92px;
        }
        
        .auto-style5 {
            width: 619px;
        }
        .auto-style6 {
            width: 361px;
        }
        .auto-style7 {
            width: 326px;
            color: white;
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
           <a href="User_Perfil.aspx" class="active">Editar datos personales</a>
           <a href="User_Contrasenia.aspx">Cambiar contraseña</a>
           <asp:LinkButton ID="lbCerrar" runat="server" OnClick="lbCerrar_Click" >Cerrar Sesión</asp:LinkButton>
            <asp:LinkButton ID="lbConfig" runat="server" OnClick="lbConfig_Click" ><img src="Recursos/cog.png" width="25" />Administrar datos</asp:LinkButton>

        </div>
    </td>
    
    <td class="auto-style4">

     <div class="contenido">
         <asp:Label ID="Titulos" runat="server" Text="Mis datos" CssClass="Titulos"></asp:Label>
         <hr class="auto-style8" />
         <br />
         <table class="tabla">
             <tr>
                 <td class="auto-style7">NOMBRE
                 </td>
                 <td class="auto-style6">
                     <asp:TextBox ID="txtNombre" runat="server" BackColor="#03285B" Width="274px" ForeColor="Silver"></asp:TextBox>
                 </td>
                 <td class="auto-style5">&nbsp;</td>
             </tr>
             <tr>
                 <td class="auto-style7">APELLIDO</td>
                 <td class="auto-style6">
                     <asp:TextBox ID="txtApellido" runat="server" BackColor="#03285b" Width="274px" ForeColor="Silver"></asp:TextBox>
                 </td>
                 <td class="auto-style5">&nbsp;</td>
             </tr>
             <tr>
                 <td class="auto-style7">DNI</td>
                 <td class="auto-style6">
                     <asp:TextBox ID="txtDNI" runat="server" BackColor="#03285b" Width="274px" ForeColor="Silver"></asp:TextBox>
                 </td>
                 <td class="auto-style5">&nbsp;</td>
             </tr>
             <tr>
                 <td class="auto-style7">CORREO ELECTRONICO</td>
                 <td class="auto-style6">
                     <asp:TextBox ID="txtEmail" runat="server" BackColor="#03285b" TextMode="Email" Width="274px" ForeColor="Silver"></asp:TextBox>
                 </td>
                 <td class="auto-style5">&nbsp;</td>
             </tr>
             <tr>
                 <td class="auto-style7">TELEFONO</td>
                 <td class="auto-style6">
                     <asp:TextBox ID="txtTelefono" runat="server" BackColor="#03285b" TextMode="Phone" Width="274px" ForeColor="Silver"></asp:TextBox>
                 </td>
                 <td class="auto-style5">&nbsp;</td>
             </tr>
             <tr>
                 <td class="auto-style7">IMAGEN</td>
                 <td class="auto-style6">
                     <asp:FileUpload ID="flImagen" runat="server" />
                 </td>
                 <td class="auto-style5">&nbsp;</td>
             </tr>
             <tr>
                 <td class="auto-style7">&nbsp;</td>
                 <td class="auto-style6">
                     &nbsp;</td>
                 <td class="auto-style5">
                     <asp:Button ID="btnGuardar" runat="server" BackColor="#303030" Font-Bold="True" ForeColor="White" OnClick="btnGuardar_Click" Text="GUARDAR" />
                 </td>
             </tr>
             <tr>
                 <td class="auto-style7">&nbsp;</td>
                 <td class="auto-style6">
                     <asp:Label ID="lblEd" runat="server"></asp:Label>
                 </td>
                 <td class="auto-style5">&nbsp;</td>
             </tr>
             
         </table>

     </div>   
    </td>
</tr>
</table>

</asp:Content>
