<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Admin_RepResultados.aspx.cs" Inherits="PRESENTACION.R_Recaudaciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<style type="text/css">
        

    </style>

<table class="auto-style1">
<tr>
    <td class="auto-style3">
        <div class="admin">
            <asp:Label ID="lblUsuario" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="White"></asp:Label> 
            <br />
        </div>
        <div class="menu_admin">
           <a href="User.aspx">Historial de compras</a>
           <a href="User_Perfil.aspx" class="active">Editar datos personales</a>
           <a href="User_Contrasenia.aspx">Cambiar contraseña</a>
        </div>
    </td>

</tr>
    <br />

    <asp:GridView ID="grdRecaudaciones" runat="server"></asp:GridView>

</div>



</asp:Content>
