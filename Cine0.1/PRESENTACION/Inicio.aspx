<%@ Page Title="" Language="C#" MasterPageFile="~/Visual.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="PRESENTACION.Inicio" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 420px;
        }
    </style>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" type="text/css" href="CSS/Slider.css" />
<div class="slider" >
<figure>
    
<asp:Image ID="imgSlider1" runat="server" ImageUrl="~/img/slider/1.jpg"/>
<asp:Image ID="imgSlider2" runat="server" ImageUrl="~/img/slider/2.jpg"/>
<asp:Image ID="imgSlider3" runat="server" ImageUrl="~/img/slider/3.png"/>
</figure>
</div>
    <div>
        <br />
        <asp:Label ID="lbl_Cartelera" runat="server" class="Cartelera" Font-Bold="True" Text="CARTELERA" Font-Underline="True" />
        <br />
        <br />
        <br />
        <asp:ListView ID="lstPeliculas" runat="server" DataSourceID="sqldsFuente" GroupItemCount="4">
    
        <EditItemTemplate>
            <td runat="server" style="background-color: #FFCC66;color: #000080;">ImagenURL:
                <asp:TextBox ID="ImagenURLTextBox" runat="server" Text='<%# Bind("ImagenURL") %>' />
                <br />Column1:
                <asp:TextBox ID="Column1TextBox" runat="server" Text='<%# Bind("Column1") %>' />
                <br />
                <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Actualizar" />
                <br />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancelar" />
                <br /></td>
        </EditItemTemplate>
        <EmptyDataTemplate>
            <table runat="server" style="background-color: #000;border-collapse: collapse;border-color: #000;border-style:none;border-width:1px;">
                <tr>
                    <td>No se han devuelto datos.</td>
                </tr>
            </table>
        </EmptyDataTemplate>
        <EmptyItemTemplate>
<td runat="server" />
        </EmptyItemTemplate>
        <GroupTemplate>
            <tr id="itemPlaceholderContainer" runat="server">
                <td id="itemPlaceholder" runat="server"></td>
            </tr>
        </GroupTemplate>
        <InsertItemTemplate>
            <td runat="server" style="">ImagenURL:
                <asp:TextBox ID="ImagenURLTextBox" runat="server" Text='<%# Bind("ImagenURL") %>' />
                <br />Column1:
                <asp:TextBox ID="Column1TextBox" runat="server" Text='<%# Bind("Column1") %>' />
                <br />
                <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insertar" />
                <br />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Borrar" />
                <br /></td>
        </InsertItemTemplate>
        <ItemTemplate>
            <td runat="server" style="background-color: #000; color: #000;width:470px">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:ImageButton ID="imgbtn_Pelicula" runat="server" Height="400px" ImageUrl='<%# Bind("ImagenURL") %>' Width="300px" ImageAlign="Middle" CommandName='<%# Eval("ID_Pelicula") %>' OnCommand="imgbtn_Pelicula_Command1"/>
                &nbsp;<br />
                <asp:Label ID="lbl_Titulo" runat="server" Font-Bold="True" style="text-align:center;color:white;float:right;width:100%" Text='<%# Eval("Column1") %>'></asp:Label>
                <br /></td>
        </ItemTemplate>
        <LayoutTemplate>
            <table runat="server">
                <tr runat="server">
                    <td runat="server" class="auto-style1">
                        <table id="groupPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                            <tr id="groupPlaceholder" runat="server">
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr runat="server">
                    <td runat="server" style="text-align: center;background-color: #000;font-family: Verdana, Arial, Helvetica, sans-serif;color: #000;" class="auto-style1">
                    </td>
                </tr>
            </table>
        </LayoutTemplate>
        <SelectedItemTemplate>
            <td runat="server" style="background-color: #000;font-weight: bold;color: #000080;">ImagenURL:
                <asp:Label ID="ImagenURLLabel" runat="server" Text='<%# Eval("ImagenURL") %>' />
                <br />Column1:
                <asp:Label ID="Column1Label" runat="server" Text='<%# Eval("Column1") %>' />
                <br /></td>
        </SelectedItemTemplate>
    </asp:ListView>
        <asp:SqlDataSource ID="sqldsFuente" runat="server" ConnectionString="<%$ ConnectionStrings:CineFrenzConnectionString5 %>" SelectCommand="SELECT [ImagenURL], LTRIM(RTRIM([Titulo_Pelicula])),[ID_Pelicula] FROM [Peliculas] WHERE [Estado]='True'"></asp:SqlDataSource>
    </div>
    <div style="margin-top:70px"></div>
</asp:Content>

