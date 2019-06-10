<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Admin_Funciones.aspx.cs" Inherits="PRESENTACION.Admin_Funciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 278px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Administrar Funciones"></asp:Label>
    </div>
    <div class="Label">
        <asp:Label ID="Label2" runat="server" Text="Cargar Funcion"></asp:Label>
        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Pelicula-Formato</td>
                <td>
                    <asp:DropDownList ID="ddlPXF" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Sucursal</td>
                <td>
                    <asp:DropDownList ID="ddlSucursal" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Sala</td>
                <td>
                    <asp:DropDownList ID="ddlSala" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Fecha y hora</td>
                <td>
                    <asp:Calendar ID="calFecha" runat="server"></asp:Calendar>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Horario</td>
                <td>
                    <asp:TextBox ID="txtHorario" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="btnAgregarFuncion" runat="server" Text="Agregar" />
                </td>
            </tr>
        </table>
        <br />
    </div>
</asp:Content>
