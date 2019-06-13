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
      
  <a class="prev" onclick="plusSlides(-1)"><label style="color:white;"><</label></a>
  <a class="next" onclick="plusSlides(1)"><label style="color:white;">></label></a>
</div style="text-align:center">
    #L<br>


    </div>
    <div style="text-align:left; display:inline-block">


    </div>
        <div id="Peliculas">
            <asp:Label ID="Label1" runat="server" Text="-PELICULAS"></asp:Label>
        </div>
        
        <div id="Lista">
    <div >

        <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource2" GroupItemCount="5">
            <AlternatingItemTemplate>
                <td runat="server" style="background-color: #FAFAD2;color: #284775;">&nbsp;<asp:Label ID="Titulo_PeliculaLabel" runat="server" Text='<%# Eval("Titulo_Pelicula") %>' />
                    <br />
                    <asp:ImageButton ID="ImageButton5" runat="server" ImageUrl='<%# Eval("ImagenURL") %>' />
                    <br /></td>
            </AlternatingItemTemplate>
            <EditItemTemplate>
                <td runat="server" style="background-color: #FFCC66;color: #000080;">Titulo_Pelicula:
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
                <table runat="server" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
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
                <td runat="server" style="background-color: #FFFBD6; color: #333333;">&nbsp;<asp:Label ID="Titulo_PeliculaLabel" runat="server" Text='<%# Eval("Titulo_Pelicula") %>'></asp:Label>
                    <br />
                    <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl='<%# Eval("ImagenURL") %>' />
                    <br /></td>
            </ItemTemplate>
            <LayoutTemplate>
                <table runat="server">
                    <tr runat="server">
                        <td runat="server">
                            <table id="groupPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                                <tr id="groupPlaceholder" runat="server">
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr runat="server">
                        <td runat="server" style="text-align: center;background-color: #FFCC66;font-family: Verdana, Arial, Helvetica, sans-serif;color: #333333;"></td>
                    </tr>
                </table>
            </LayoutTemplate>
            <SelectedItemTemplate>
                <td runat="server" style="background-color: #FFCC66;font-weight: bold;color: #000080;">Titulo_Pelicula:
                    <asp:Label ID="Titulo_PeliculaLabel" runat="server" Text='<%# Eval("Titulo_Pelicula") %>' />
                    <br />ImagenURL:
                    <asp:Label ID="ImagenURLLabel" runat="server" Text='<%# Eval("ImagenURL") %>' />
                    <br /></td>
            </SelectedItemTemplate>
        </asp:ListView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:CineFrenzConnectionString3 %>" SelectCommand="SELECT [Titulo_Pelicula], [ImagenURL] FROM [Peliculas]"></asp:SqlDataSource>

    </div>
            </div>

    </div>
</asp:Content>

