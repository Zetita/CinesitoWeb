﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Admin_Funciones.aspx.cs" Inherits="PRESENTACION.Admin_Funciones" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }

        .auto-style2 {
            width: 314px;
        }

        .auto-style3 {
            width: 362px;
        }

        .auto-style4 {
            width: 314px;
            height: 33px;
        }

        .auto-style5 {
            width: 362px;
            height: 33px;
        }

        .auto-style6 {
            height: 33px;
        }

        .auto-style7 {
            width: 314px;
            height: 29px;
        }

        .auto-style8 {
            width: 362px;
            height: 29px;
        }

        .auto-style9 {
            height: 29px;
        }
        .auto-style10 {
            width: 314px;
            height: 26px;
        }
        .auto-style11 {
            width: 362px;
            height: 26px;
        }
        .auto-style12 {
            height: 26px;
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
        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style7">Pelicula-Formato</td>
                <td class="auto-style8">
                    <asp:DropDownList ID="ddlPeliculas" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlPeliculas_SelectedIndexChanged">
                    </asp:DropDownList>
                    <asp:DropDownList ID="ddlFormatos" runat="server">
                    </asp:DropDownList>
                </td>
                <td class="auto-style9">
                    <asp:RequiredFieldValidator ID="rfv1" runat="server" ControlToValidate="ddlPeliculas" ErrorMessage="Seleccione una pelicula." ForeColor="Red" InitialValue="0" ValidationGroup="add">*</asp:RequiredFieldValidator>
                    &nbsp;<asp:RequiredFieldValidator ID="rfv6" runat="server" ControlToValidate="ddlFormatos" ErrorMessage="Seleccione un formato." ForeColor="Red" InitialValue="0" ValidationGroup="add">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">Sucursal</td>
                <td class="auto-style11">
                    <asp:DropDownList ID="ddlSucursal" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlSucursal_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td class="auto-style12">
                    <asp:RequiredFieldValidator ID="rfv2" runat="server" ControlToValidate="ddlSucursal" ErrorMessage="Seleccione una sucursal." ForeColor="Red" InitialValue="0" ValidationGroup="add">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Sala</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="ddlSala" runat="server" AutoPostBack="True">
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfv3" runat="server" ControlToValidate="ddlSala" ErrorMessage="Seleccione una sala." ForeColor="Red" InitialValue="0" ValidationGroup="add">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Fecha</td>
                <td class="auto-style3">
                    <asp:Calendar ID="calFecha" runat="server" Height="109px" Width="328px"></asp:Calendar>
                </td>
                <td>*</td>
            </tr>
            <tr>
                <td class="auto-style7">Horario(hh:mm)</td>
                <td class="auto-style8">
                    <asp:TextBox ID="txtHorario" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style9">
                    <asp:RequiredFieldValidator ID="rfv5" runat="server" ControlToValidate="txtHorario" ErrorMessage="Seleccione un horario." ForeColor="Red" ValidationGroup="add">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style5">
                    <asp:Button ID="btnAgregarFuncion" runat="server" Text="Agregar" OnClick="btnAgregarFuncion_Click" ValidationGroup="add" />
                </td>
                <td class="auto-style6">
                    <asp:Label ID="lblAg" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">
                    <asp:Label ID="lblAgregado" runat="server"></asp:Label>
                </td>
                <td class="auto-style6">&nbsp;</td>
            </tr>
        </table>
        <asp:Label ID="Label3" runat="server" Text="Listado de Funciones"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:GridView ID="grdFunciones" runat="server" AllowPaging="True" AutoGenerateColumns="False" AutoGenerateDeleteButton="True" AutoGenerateEditButton="True" CssClass="tablalistado" PageSize="5" OnRowCancelingEdit="grdFunciones_RowCancelingEdit" OnRowEditing="grdFunciones_RowEditing" OnRowUpdating="grdFunciones_RowUpdating" OnPageIndexChanging="grdFunciones_PageIndexChanging" OnRowDataBound="grdFunciones_RowDataBound" OnRowDeleting="grdFunciones_RowDeleting">
            <Columns>
                <asp:TemplateField HeaderText="ID">
                    <EditItemTemplate>
                        <asp:Label ID="lbl_eit_IdFuncion" runat="server" Text='<%# Bind("ID_Funcion") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_IdFuncion" runat="server" Text='<%# Bind("ID_Funcion") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Pelicula">
                    <EditItemTemplate>
                        <asp:Label ID="lbl_eit_idpxf" runat="server" Text='<%# Bind("ID_Pelicula") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_IDPelicula" runat="server" Text='<%# Bind("ID_Pelicula") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Formato" AccessibleHeaderText="Formato">
                    <EditItemTemplate>
                        <asp:DropDownList ID="ddl_eit_Formato" runat="server">
                        </asp:DropDownList>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_IDFormato" runat="server" Text='<%# Bind("ID_Formato") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Sucursal">
                    <EditItemTemplate>
                        <asp:DropDownList ID="ddl_eit_Sucursal" runat="server" AutoPostBack="True">
                        </asp:DropDownList>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_idsuc" runat="server" Text='<%# Bind("ID_Sucursal") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Sala">
                    <EditItemTemplate>
                        <asp:DropDownList ID="ddl_eit_Sala" runat="server">
                        </asp:DropDownList>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Idsala" runat="server" Text='<%# Bind("ID_Sala") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Fecha">
                    <EditItemTemplate>
                        <asp:Label ID="Label6" runat="server" Text="Horario(hh:mm)"></asp:Label>
                        <asp:TextBox ID="txt_eit_horario" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfv_eit" runat="server" ControlToValidate="txt_eit_horario" ErrorMessage="*" ForeColor="#CC3300"></asp:RequiredFieldValidator>
                        <asp:Calendar ID="cal_eit_fecha" runat="server"></asp:Calendar>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label5" runat="server" Text='<%# Bind("FechaHora_Funcion") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Estado">
                    <EditItemTemplate>
                        <asp:CheckBox ID="cb_eit_Estado" runat="server" />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="cb_it_Estado" runat="server" Checked='<%# Bind("Estado") %>' Enabled="False" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <br />
    </div>
</asp:Content>
