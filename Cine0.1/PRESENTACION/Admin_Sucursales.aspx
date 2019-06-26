﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Admin_Sucursales.aspx.cs" Inherits="PRESENTACION.Admin_Sucursales" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 311px;
        }
        .auto-style3 {
            width: 311px;
            height: 28px;
        }
        .auto-style4 {
            height: 28px;
        }
        .auto-style6 {
            width: 359px;
        }
        .auto-style7 {
            height: 28px;
            width: 359px;
        }
        .auto-style8 {
            width: 312px;
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
                <td class="auto-style6">
                    <asp:TextBox ID="txtNombre" runat="server" Width="315px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfv1" runat="server" ControlToValidate="txtNombre" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Direccion</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtDireccion" runat="server" Width="315px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfv2" runat="server" ControlToValidate="txtDireccion" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Localidad</td>
                <td class="auto-style7">
                    <asp:TextBox ID="txtLocalidad" runat="server" Width="315px"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:RequiredFieldValidator ID="rfv3" runat="server" ControlToValidate="txtLocalidad" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Provincia</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtProvincia" runat="server" Width="315px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfv4" runat="server" ControlToValidate="txtProvincia" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">DireccionURL</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtDireccionURL" runat="server" Width="313px" TextMode="Url"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfv5" runat="server" ControlToValidate="txtDireccionURL" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style6">
                    <asp:Button ID="btnAgregarSuc" runat="server" Text="Agregar" OnClick="btnAgregarSuc_Click" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style6">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
            <br />
        </div>
        <div>


        <asp:Label ID="Label3" runat="server" Text="Cargar Sala"></asp:Label>
            <br />
            <div class="tabla">
            <table class="auto-style1">
                <tr>
                    <td class="auto-style8">Sucursal</td>
                    <td class="auto-style6">
                        <asp:DropDownList ID="ddlSucursales" runat="server">
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="rfv6" runat="server" ControlToValidate="ddlSucursales" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">Sala</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtSala" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="rfv7" runat="server" ControlToValidate="txtSala" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">Butacas </td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtButacas" runat="server" TextMode="Number"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="rfv8" runat="server" ControlToValidate="txtButacas" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style6">
                    <asp:Button ID="btnAgregarSala" runat="server" Text="Agregar" />
                    </td>
                    <td>
                    <asp:Label ID="lblAg" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style6">
                    <asp:Label ID="lblAgregado" runat="server"></asp:Label>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
            </div>
            <br />
        <asp:Label ID="Label4" runat="server" Text="Listado de Sucursales y Salas"></asp:Label>
            <br />
            <asp:GridView ID="grdSucursales" runat="server" AllowCustomPaging="True" AutoGenerateColumns="False" AutoGenerateDeleteButton="True" AutoGenerateEditButton="True" CssClass="tablalistado" PageSize="5">
                <Columns>
                    <asp:TemplateField HeaderText="ID">
                        <EditItemTemplate>
                            <asp:Label ID="lbl_eit_IDSucursal" runat="server" Text='<%# Bind("ID_Sucursal") %>'></asp:Label>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_IDSucursal" runat="server" Text='<%# Bind("ID_Sucursal") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Nombre">
                        <EditItemTemplate>
                            <asp:TextBox ID="txt_eit_Nombre" runat="server" Text='<%# Bind("Nombre_Sucursal") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_Nombre" runat="server" Text='<%# Bind("Nombre_Sucursal") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Direccion">
                        <EditItemTemplate>
                            <asp:TextBox ID="txt_eit_Direccion" runat="server" Text='<%# Bind("Direccion_Sucursal") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_Direccion" runat="server" Text='<%# Bind("Direccion_Sucursal") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Localidad">
                        <EditItemTemplate>
                            <asp:TextBox ID="txt_eit_Localidad" runat="server" Text='<%# Bind("Localidad_Sucursal") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_Localidad" runat="server" Text='<%# Bind("Localidad_Sucursal") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Provincia">
                        <EditItemTemplate>
                            <asp:TextBox ID="txt_eit_Provincia" runat="server" Text='<%# Bind("Provincia_Sucursal") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_Provincia" runat="server" Text='<%# Bind("Provincia_Sucursal") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="DireccionURL">
                        <EditItemTemplate>
                            <asp:TextBox ID="txt_eit_DireccionURL" runat="server" Text='<%# Bind("DireccionURL") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_DireccionURL" runat="server" Text='<%# Bind("DireccionURL") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <br />
            <asp:GridView ID="grdSalas" runat="server" AllowCustomPaging="True" AutoGenerateColumns="False" AutoGenerateDeleteButton="True" AutoGenerateEditButton="True" CssClass="tablalistado" PageSize="5">
            </asp:GridView>
            <br />


        </div>

    </div>
</asp:Content>
