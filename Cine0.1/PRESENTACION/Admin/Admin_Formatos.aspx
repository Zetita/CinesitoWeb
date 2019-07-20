<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Admin_Formatos.aspx.cs" Inherits="PRESENTACION.Admin_Formatos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 316px;
        }
        .auto-style3 {
            width: 366px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Administrar Formatos y Precios"></asp:Label>
    </div>
    <div class="Label">
        <asp:GridView ID="grdFormatos" runat="server" AutoGenerateColumns="False" CssClass="tablalistado" AllowPaging="True" AutoGenerateEditButton="True" OnPageIndexChanging="grdFormatos_PageIndexChanging" OnRowCancelingEdit="grdFormatos_RowCancelingEdit" OnRowEditing="grdFormatos_RowEditing" OnRowUpdating="grdFormatos_RowUpdating">
            <Columns>
                <asp:TemplateField HeaderText="ID">
                    <EditItemTemplate>
                        <asp:Label ID="lbl_eit_IDFormato" runat="server" Text='<%# Bind("ID_Formato") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_IDFormato" runat="server" Text='<%# Bind("ID_Formato") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Nombre">
                    <EditItemTemplate>
                        <asp:TextBox ID="txt_eit_Nombre" runat="server" Text='<%# Bind("Nombre_Formato") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Nombre" runat="server" Text='<%# Bind("Nombre_Formato") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Idioma">
                    <EditItemTemplate>
                        <asp:TextBox ID="txt_eit_Idioma" runat="server" Text='<%# Bind("Idioma_Formato") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Idioma" runat="server" Text='<%# Bind("Idioma_Formato") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Subtitulos">
                    <EditItemTemplate>
                        <asp:CheckBox ID="cb_eit_Subtitulos" runat="server" Checked='<%# Bind("Subtitulos_Formato") %>' />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="cb_it_Subtitulos" runat="server" Checked='<%# Bind("Subtitulos_Formato") %>' Enabled="False" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Precio">
                    <EditItemTemplate>
                        <asp:TextBox ID="txt_eit_Precio" runat="server" Text='<%# Bind("Precio_Formato") %>' TextMode="Number"></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Precio" runat="server" Text='<%# Bind("Precio_Formato") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <br />
    <asp:Label ID="Label2" runat="server" Text="Cargar Formato"></asp:Label>
        <br />
        <br />
        <div class="tabla">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Nombre </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtNombre" runat="server" Width="300px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfv1" runat="server" ControlToValidate="txtNombre" ErrorMessage="Ingrese un nombre." ForeColor="Red" ValidationGroup="add">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Idioma</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtIdioma" runat="server" Width="300px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfv2" runat="server" ControlToValidate="txtIdioma" ErrorMessage="Ingrese un idioma." ForeColor="Red" ValidationGroup="add">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Subtitulos</td>
                <td class="auto-style3">
                    <asp:RadioButtonList ID="rblSubs" runat="server">
                        <asp:ListItem Value="1">Si</asp:ListItem>
                        <asp:ListItem Value="0">No</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfv3" runat="server" ControlToValidate="rblSubs" ErrorMessage="Escoga una opción." ForeColor="Red" ValidationGroup="add">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Precio</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtPrecio" runat="server" TextMode="Number" Width="106px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfv4" runat="server" ControlToValidate="txtPrecio" ErrorMessage="Ingrese un precio." ForeColor="Red" ValidationGroup="add">*</asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="cv1" runat="server" ControlToValidate="txtPrecio" ErrorMessage="¡Ingrese un valor numerico positivo!" ForeColor="Red" Operator="GreaterThan" Type="Integer" ValueToCompare="0" ValidationGroup="add"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
                </td>
                <td>
                    <asp:Label ID="lblAg" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Label ID="lblAgregado" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        </div>
        <br />
    </div>
</asp:Content>
