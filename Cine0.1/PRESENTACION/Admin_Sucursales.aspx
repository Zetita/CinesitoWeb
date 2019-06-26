<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Admin_Sucursales.aspx.cs" Inherits="PRESENTACION.Admin_Sucursales" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 184px;
        }
        .auto-style3 {
            width: 184px;
            height: 28px;
        }
        .auto-style4 {
            height: 28px;
        }
        .auto-style5 {
            width: 186px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Administrar Sucursales y Salas"></asp:Label>
    </div>
    <div class="Label">
        <asp:Label ID="Label2" runat="server" Text="Cargar Sucursal"></asp:Label>
        <br />
        <br />
        <div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Nombre</td>
                <td>
                    <asp:TextBox ID="txtNombre" runat="server" Width="315px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Direccion</td>
                <td>
                    <asp:TextBox ID="txtDireccion" runat="server" Width="315px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Localidad</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtLocalidad" runat="server" Width="315px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Provincia</td>
                <td>
                    <asp:TextBox ID="txtProvincia" runat="server" Width="315px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">DireccionURL</td>
                <td>
                    <asp:TextBox ID="txtDireccionURL" runat="server" Width="313px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="btnAgregarSuc" runat="server" Text="Agregar" />
                </td>
            </tr>
        </table>
            <br />
        </div>
        <div>


        <asp:Label ID="Label3" runat="server" Text="Cargar Sala"></asp:Label>
            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style5">Sucursal</td>
                    <td>
                        <asp:DropDownList ID="ddlSucusales" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">Sala</td>
                    <td>
                        <asp:TextBox ID="txtSala" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">Butacas </td>
                    <td>
                        <asp:TextBox ID="txtButacas" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td>
                    <asp:Button ID="btnAgregarSala" runat="server" Text="Agregar" />
                    </td>
                </tr>
            </table>
            <br />


        </div>
        <div>


        </div>

    </div>
</asp:Content>
