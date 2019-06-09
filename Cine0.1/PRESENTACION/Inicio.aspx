<%@ Page Title="" Language="C#" MasterPageFile="~/Visual.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="PRESENTACION.Inicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   
    <div  style="text-align:center" >
  <!-- Contenedor de Slideshow -->
<div class="slideshow-container" style="text-align:center">
    <br>
  <!-- IMAGEN Y RESOLUCION DE LA IMAGEN -->
  <div class="mySlides fade" style="text-align:center">
   
    <img src="Slider/JohnWick.jpeg" style="width:70%">
    
  </div>

  <div class="mySlides fade" style="text-align:center">
 
    <img src="Slider/Future.jpg" style="width:70%" >
    
  </div>

    <div id="Control" style="text-align:center">  <!-- Siguiente/Atras buttons -->
      
  <a class="prev" onclick="plusSlides(-1)"><label><</label></a>
  <a class="next" onclick="plusSlides(1)"><label>></label></a>
</div style="text-align:center">
<br>


    </div>
    <div style="text-align:left; display:inline-block">


        <asp:DropDownList ID="Filtro1" runat="server">
        </asp:DropDownList>
        <asp:DropDownList ID="Filtro2" runat="server">
        </asp:DropDownList>


    </div>
    <div style="text-align:center">

        <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1" GroupItemCount="3" OnSelectedIndexChanged="ListView1_SelectedIndexChanged">
            <AlternatingItemTemplate>
                <td runat="server" style="">Titulo_Pelicula:
                    <asp:Label ID="Titulo_PeliculaLabel" runat="server" Text='<%# Eval("Titulo_Pelicula") %>' />
                    <br />ImagenURL:
                    <asp:Label ID="ImagenURLLabel" runat="server" Text='<%# Eval("ImagenURL") %>' />
                    <br /></td>
            </AlternatingItemTemplate>
            <EditItemTemplate>
                <td runat="server" style="">Titulo_Pelicula:
                    <asp:TextBox ID="Titulo_PeliculaTextBox" runat="server" Text='<%# Bind("Titulo_Pelicula") %>' />
                    <br />ImagenURL:
                    <asp:TextBox ID="ImagenURLTextBox" runat="server" Text='<%# Bind("ImagenURL") %>' />
                    <br />
                    <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Actualizar" />
                    <br />
                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancelar" />
                    <br /></td>
            </EditItemTemplate>
            <EmptyDataTemplate>
                <table runat="server" style="text-align:center">
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
                <td runat="server" style="">Titulo_Pelicula:
                    <asp:TextBox ID="Titulo_PeliculaTextBox" runat="server" Text='<%# Bind("Titulo_Pelicula") %>' />
                    <br />ImagenURL:
                    <asp:TextBox ID="ImagenURLTextBox" runat="server" Text='<%# Bind("ImagenURL") %>' />
                    <br />
                    <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insertar" />
                    <br />
                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Borrar" />
                    <br /></td>
            </InsertItemTemplate>
            <ItemTemplate>
                <td runat="server" style="">Titulo_Pelicula:
                    <asp:Label ID="Titulo_PeliculaLabel" runat="server" Text='<%# Eval("Titulo_Pelicula") %>' />
                    <br />ImagenURL:
                    <asp:Label ID="ImagenURLLabel" runat="server" Text='<%# Eval("ImagenURL") %>' />
                    <br /></td>
            </ItemTemplate>
            <LayoutTemplate>
                <table runat="server">
                    <tr runat="server">
                        <td runat="server">
                            <table id="groupPlaceholderContainer" runat="server" border="0" style="">
                                <tr id="groupPlaceholder" runat="server">
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr runat="server">
                        <td runat="server" style=""></td>
                    </tr>
                </table>
            </LayoutTemplate>
            <SelectedItemTemplate>
                <td runat="server" style="">Titulo_Pelicula:
                    <asp:Label ID="Titulo_PeliculaLabel" runat="server" Text='<%# Eval("Titulo_Pelicula") %>' />
                    <br />ImagenURL:
                    <asp:Label ID="ImagenURLLabel" runat="server" Text='<%# Eval("ImagenURL") %>' />
                    <br /></td>
            </SelectedItemTemplate>
        </asp:ListView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CineFrenzConnectionString %>" SelectCommand="SELECT [Titulo_Pelicula], [ImagenURL] FROM [Peliculas]"></asp:SqlDataSource>

    </div>

    </div>
</asp:Content>

