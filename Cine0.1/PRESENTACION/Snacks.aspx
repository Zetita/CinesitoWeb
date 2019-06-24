<%@ Page Title="" Language="C#" MasterPageFile="~/Visual.Master" AutoEventWireup="true" CodeBehind="Snacks.aspx.cs" Inherits="PRESENTACION.Snacks" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 202px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ListView ID="lstSnacks" runat="server" DataKeyNames="ID_Snack" DataSourceID="sqldsSnacks" GroupItemCount="3" >
        <EditItemTemplate>
            <td runat="server" style="background-color: #000; color: #000080;">ID_Snack:
                <asp:Label ID="ID_SnackLabel1" runat="server" Text='<%# Eval("ID_Snack") %>' />
                <br />Nombre_Snack:
                <asp:TextBox ID="Nombre_SnackTextBox" runat="server" Text='<%# Bind("Nombre_Snack") %>' />
                <br />Precio_Snack:
                <asp:TextBox ID="Precio_SnackTextBox" runat="server" Text='<%# Bind("Precio_Snack") %>' />
                <br />URLImagen_Snack:
                <asp:TextBox ID="URLImagen_SnackTextBox" runat="server" Text='<%# Bind("URLImagen_Snack") %>' />
                <br />
                <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Actualizar" />
                <br />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancelar" />
                <br /></td>
        </EditItemTemplate>
        <EmptyDataTemplate>
            <table runat="server" style="background-color: #000; border-collapse: collapse; border-color: #000; border-style: none; border-width: 1px;">
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
            <td runat="server" style="">ID_Snack:
                <asp:TextBox ID="ID_SnackTextBox" runat="server" Text='<%# Bind("ID_Snack") %>' />
                <br />Nombre_Snack:
                <asp:TextBox ID="Nombre_SnackTextBox" runat="server" Text='<%# Bind("Nombre_Snack") %>' />
                <br />Precio_Snack:
                <asp:TextBox ID="Precio_SnackTextBox" runat="server" Text='<%# Bind("Precio_Snack") %>' />
                <br />URLImagen_Snack:
                <asp:TextBox ID="URLImagen_SnackTextBox" runat="server" Text='<%# Bind("URLImagen_Snack") %>' />
                <br />
                <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insertar" />
                <br />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Borrar" />
                <br /></td>
        </InsertItemTemplate>
        <ItemTemplate>
            <td runat="server" style="background-color: #000;">&nbsp;<asp:Label ID="lbl_Nombre" runat="server" style="color: #ffffff" Font-Bold="True" Text='<%# Eval("Nombre_Snack") %>' />
                <br />
                <asp:ImageButton ID="ImageButton2" runat="server" Horizontal-align="left" ImageUrl='<%# Eval("URLImagen_Snack") %>' Width="200px" Height="170px" />
                <br />
                <asp:Label ID="lbl_Precio" runat="server" style="position:relative;top:0px;color:white"  Font-Bold="True" Text='<%# Eval("Precio_Snack") %>' />
                <br /></td>
        </ItemTemplate>
        <LayoutTemplate>
            <table runat="server" style="height: 180px; width: 176px">
                <tr runat="server">
                    <td runat="server">
                        <table id="groupPlaceholderContainer" runat="server" border="1" style="background-color: #000; border-collapse: collapse; border-color: #000; border-style: none; border-width: 1px; font-family: Verdana, Arial, Helvetica, sans-serif;">
                            <tr id="groupPlaceholder" runat="server">
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr runat="server">
                    <td runat="server" style="text-align: center; background-color: #000; font-family: Verdana, Arial, Helvetica, sans-serif; color: #000;"></td>
                </tr>
            </table>
        </LayoutTemplate>
        <SelectedItemTemplate>
            <td runat="server" style="background-color: #000; font-weight: bold; color: #000000;">ID_Snack:
                <asp:Label ID="ID_SnackLabel" runat="server" Text='<%# Eval("ID_Snack") %>' />
                <br />Nombre_Snack:
                <asp:Label ID="Nombre_SnackLabel" runat="server" Text='<%# Eval("Nombre_Snack") %>' />
                <br />Precio_Snack:
                <asp:Label ID="Precio_SnackLabel" runat="server" Text='<%# Eval("Precio_Snack") %>' />
                <br />URLImagen_Snack:
                <asp:Label ID="URLImagen_SnackLabel" runat="server" Text='<%# Eval("URLImagen_Snack") %>' />
                <br /></td>
        </SelectedItemTemplate>
    </asp:ListView>
    <asp:SqlDataSource ID="sqldsSnacks" runat="server" ConnectionString="<%$ ConnectionStrings:CineFrenzConnectionString %>" SelectCommand="SELECT [ID_Snack], [Nombre_Snack], [Precio_Snack], [URLImagen_Snack] FROM [Snacks]  WHERE [Estado_Snack] =1"></asp:SqlDataSource>
</asp:Content>
