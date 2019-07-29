<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Admin_RepVentas.aspx.cs" Inherits="PRESENTACION.R_Recaudaciones" %>
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
           <a href="Admin_RepVentas.aspx" class="active">Ventas por Año</a>
           <a href="Admin_RepVenxSuc.aspx">Ventas por Sucursal</a>
           <a href="Admin_EntxPel.aspx">Total de Entradas Vendidas por Pelicula</a>
        </div>
    </td>

<td class="auto-style4">
     <div class="contenido">
         <asp:Label ID="Titulos" runat="server" Text="Ventas por Año" CssClass="Titulos"></asp:Label>
         <hr class="auto-style8" />
         <br />
         <asp:GridView ID="grdVentas" runat="server" AutoGenerateColumns="False"  style="position:absolute;top:120px;left:10px;width:98%" AllowPaging="True" OnPageIndexChanging="grdVentas_PageIndexChanging" PageSize="8">
             <Columns>
                 <asp:TemplateField HeaderText="ID VENTA">
                     <ItemTemplate>
                         <asp:Label ID="lbl_it_ID" runat="server" Text='<%# Bind("ID_Venta") %>'></asp:Label>
                     </ItemTemplate>
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="ID USUARIO">
                     <ItemTemplate>
                         <asp:Label ID="lbl_it_IDUser" runat="server" Text='<%# Bind("IDUsuario_Venta") %>'></asp:Label>
                     </ItemTemplate>
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="NOMBRE USUARIO">
                     <ItemTemplate>
                         <asp:Label ID="lbl_it_User" runat="server" Text='<%# Bind("Usuario_Venta") %>'></asp:Label>
                     </ItemTemplate>
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="FECHA Y HORA">
                     <ItemTemplate>
                         <asp:Label ID="lbl_it_FyH" runat="server" Text='<%# Bind("FechaHora_Venta") %>'></asp:Label>
                     </ItemTemplate>
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="CANTIDAD DE ENTRADAS">
                     <ItemTemplate>
                         <asp:Label ID="lbl_it_Cant" runat="server" Text='<%# Bind("CantEntradas_Venta") %>'></asp:Label>
                     </ItemTemplate>
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="TOTAL VENTA">
                     <ItemTemplate>
                         <asp:Label ID="lbl_it_Precio" runat="server" Text='<%# Bind("PrecioFinal_Venta") %>'></asp:Label>
                     </ItemTemplate>
                 </asp:TemplateField>
             </Columns>
         </asp:GridView>
     

         <asp:DropDownList ID="ddlAños" runat="server" style="position:absolute;top:82px;width:200px;left:305px;text-align:center">
         </asp:DropDownList>

         <asp:Label ID="lblSinVentas" runat="server" ForeColor="White" Style="color:#808080;padding-left: 10px; margin: 10px 0px 0px 10px; font-size: xx-large;" ></asp:Label>
         <br />
         <asp:Button ID="btnFiltrar" runat="server" OnClick="btnFiltrar_Click" Text="Filtrar" style="position:absolute;top:81px;width:200px;right:290px"/>
         <asp:Label ID="lblRecaudacion" runat="server" style="position:absolute;left:180px;top:349px;font-size:x-large"> </asp:Label>

     </div>   
    </td>
    

</tr>
    </table>


</asp:Content>
