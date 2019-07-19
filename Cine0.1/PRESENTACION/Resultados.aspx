<%@ Page Title="" Language="C#" MasterPageFile="~/Visual.Master" AutoEventWireup="true" CodeBehind="Resultados.aspx.cs" Inherits="PRESENTACION.Resultados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:Label ID="lblResultado" runat="server" Font-Size="XX-Large" style="position:absolute;top:90px;left:20px" ForeColor="White" Font-Bold="True"></asp:Label>
    <br />
    <br />
    <br />
    <br />
    <asp:ListView ID="lstPeliculas" runat="server" DataSourceID="sqldsFuente" GroupItemCount="3" style="position:absolute;top:150px">
    
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
                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("ImagenURL") %>' />
                <br />Column1:
                <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Column1") %>' />
                <br />
                <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insertar" />
                <br />
                <asp:Button ID="Button1" runat="server" CommandName="Cancel" Text="Borrar" />
                <br /></td>
        </InsertItemTemplate>
        <ItemTemplate>
            <td runat="server" style="background-color: #000; color: #000;width:270px">
                <asp:ImageButton ID="imgbtn_Pelicula" runat="server" Height="300px" ImageUrl='<%# Bind("ImagenURL") %>' Width="200px" style="position:relative;align-items:center; top: 0px; left: 0px; width: 270px;" ImageAlign="AbsMiddle" CommandName='<%# Eval("ID_Pelicula") %>' OnCommand="imgbtn_Pelicula_Command1"/>
                <asp:Label ID="lbl_Titulo" runat="server" style="text-align:center;color:white;float:right;width:100%" Font-Bold="True" Text='<%# Eval("Column1") %>'  />
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
                    <td runat="server" style="text-align: center;background-color: #000;font-family: Verdana, Arial, Helvetica, sans-serif;color: #000;">
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
        <asp:SqlDataSource ID="sqldsFuente" runat="server" ConnectionString="<%$ ConnectionStrings:CineFrenzConnectionString5 %>" ></asp:SqlDataSource>
    
</asp:Content>
