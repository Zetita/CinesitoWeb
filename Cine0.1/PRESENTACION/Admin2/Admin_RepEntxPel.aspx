<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Admin_RepEntxPel.aspx.cs" Inherits="PRESENTACION.RepEntxPel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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

    .menu_user a {
        background-color: #111;
        color: white;
        display: block;
        padding: 12px;
        text-decoration: none;
    }

.menu_user a:hover {
    background-color: #f1f1f1; /* Color para el mouse-over */
    color:black;
}

.menu_user a.active {
background-color: #818181; /* Para marcar el link activo */
color: black;
 }

.contenido{
    background-color: #111;
    color:white;
}

    </style>

<table class="auto-style1">
<tr>
    <td class="auto-style3">
        <div class="user">
            <asp:Label ID="lblUsuario" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="White"></asp:Label> 
            <br />
        </div>
        <div class="menu_user">
           <a href="../Admin/Admin_RepVentas.aspx" >Ventas por Año</a>
           <a href="Admin_RepVentasxSuc.aspx" >Ventas por Sucursal</a>
           <a href="Admin_RepEntxPel.aspx" class="active">Total de Entradas Vendidas por Pelicula</a>
        </div>
    </td>

<td class="auto-style4">
     <div class="contenido">
         <asp:Label ID="Titulos" runat="server" Text="Total de Entradas Vendidas por Pelicula" CssClass="Titulos"></asp:Label>
         <hr class="auto-style8" />
         <br />
         <asp:Label ID="lblSinVentas" runat="server" ForeColor="White" Style="color:#808080;padding-left: 10px; margin: 10px 0px 0px 10px; font-size: xx-large;" Visible="False" ></asp:Label>
         <br />

         <asp:GridView ID="grdEntxPel" runat="server" AutoGenerateColumns="False"  style="position:absolute;top:60px;left:10px;width:98%" AllowPaging="True" OnPageIndexChanging="grdEntxPel_PageIndexChanging" >
             <Columns>
                 <asp:TemplateField HeaderText="Pelicula">
                     <ItemTemplate>
                         <asp:Label ID="lbl_it_Pelicula" runat="server" Text='<%# Bind("Titulo_Pelicula") %>'></asp:Label>
                     </ItemTemplate>
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="Cantidad de entradas Vendidas">
                     <ItemTemplate>
                         <asp:Label ID="lbl_it_Cant" runat="server" Text='<%# Bind("Cantidad") %>'></asp:Label>
                     </ItemTemplate>
                 </asp:TemplateField>
             </Columns>
             
         </asp:GridView>

         <asp:Label ID="lblTotal" runat="server" style="position:absolute;top:330px;left:0px;font-size:x-large"></asp:Label>
  </div>   
    </td>
</tr>
</table>

</asp:Content>

