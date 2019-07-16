<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Admin_Snacks.aspx.cs" Inherits="PRESENTACION.Admin_Snacks" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            text-align: left;
        }
        .auto-style2 {
            width: 313px;
        }
        .auto-style3 {
            width: 360px;
        }
        .auto-style4 {
            width: 313px;
            height: 39px;
        }
        .auto-style5 {
            width: 360px;
            height: 39px;
        }
        .auto-style6 {
            height: 39px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    <asp:Label ID="Label1" runat="server" Text="Administrar Snacks"></asp:Label>
    </div>
    <div class="Label">
    <asp:Label ID="Label2" runat="server" Text="Cargar Snack"></asp:Label>
        <br />
        <br />
    </div>
    <div class="tabla">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Nombre Snack</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtSnack" runat="server" Width="300px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfv1" runat="server" ControlToValidate="txtSnack" ErrorMessage="Ingrese un nombre." ForeColor="Red" ValidationGroup="add">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Tipo de Snack</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="ddlTipoSnack" runat="server">
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfv2" runat="server" ControlToValidate="ddlTipoSnack" ErrorMessage="Elija un tipo." ForeColor="Red" InitialValue="-Seleccione algun tipo-" ValidationGroup="add">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Precio Unitario</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtPrecio" runat="server" Width="300px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfv3" runat="server" ControlToValidate="txtPrecio" ErrorMessage="Ingrese un precio." ForeColor="Red" ValidationGroup="add">*</asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="cv1" runat="server" ControlToValidate="txtPrecio" ErrorMessage="¡Ingrese un valor numerico positivo!" ForeColor="Red" Operator="GreaterThan" Type="Integer" ValueToCompare="0" ValidationGroup="add"> </asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Imagen</td>
                <td class="auto-style3">
                    <asp:FileUpload ID="FileImagen" runat="server" Width="300px" />
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfv4" runat="server" ControlToValidate="FileImagen" ErrorMessage="Ingrese una imagen." ForeColor="Red" ValidationGroup="add">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Estado</td>
                <td class="auto-style5">
                    <asp:RadioButtonList ID="rbtnEstado" runat="server">
                        <asp:ListItem Value="1">Disponible</asp:ListItem>
                        <asp:ListItem Value="0">No Disponible</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td class="auto-style6">
                    <asp:RequiredFieldValidator ID="rfv5" runat="server" ControlToValidate="rbtnEstado" ErrorMessage="Seleccione un estado." ForeColor="Red" ValidationGroup="add">*</asp:RequiredFieldValidator>
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
                <td>
                    &nbsp;</td>
            </tr>
        </table>
        <br />
    </div>
    <div class="Label">
    <asp:Label ID="Label3" runat="server" Text="Listado de Snacks"></asp:Label>
    </div>
    <div>

        <asp:GridView ID="grdSnacks" runat="server" AutoGenerateColumns="False" CssClass="tablalistado" AllowPaging="True" AutoGenerateDeleteButton="True" AutoGenerateEditButton="True" OnPageIndexChanging="grdSnacks_PageIndexChanging" OnRowCancelingEdit="grdSnacks_RowCancelingEdit" OnRowDeleting="grdSnacks_RowDeleting" OnRowEditing="grdSnacks_RowEditing" OnRowUpdating="grdSnacks_RowUpdating" PageSize="5">
            <Columns>
                <asp:TemplateField HeaderText="ID">
                    <EditItemTemplate>
                        <asp:Label ID="lbl_eit_IdSnack" runat="server" Text='<%# Bind("ID_Snack") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_IdSnack" runat="server" Text='<%# Bind("ID_Snack") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="NOMBRE">
                    <EditItemTemplate>
                        <asp:TextBox ID="txt_eit_Nombre" runat="server" Text='<%# Bind("Nombre_Snack") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_Nombre" runat="server" Text='<%# Bind("Nombre_Snack") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="TIPO ">
                    <EditItemTemplate>
                        <asp:Label ID="lbl_eit_Tipo" runat="server" Text='<%# Bind("Tipo_Snack") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_Tipo" runat="server" Text='<%# Bind("Tipo_Snack") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="PRECIO">
                    <EditItemTemplate>
                        <asp:TextBox ID="txt_eit_Precio" runat="server" Text='<%# Bind("Precio_Snack") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_Precio" runat="server" Text='<%# Bind("Precio_Snack") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="IMAGEN">
                    <EditItemTemplate>
                        <asp:ImageButton ID="img_it_Imagen" runat="server" Height="100px" ImageUrl='<%# Bind("URLImagen_Snack") %>' />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:ImageButton ID="img_it_Imagen" runat="server" Height="100px" ImageUrl='<%# Bind("URLImagen_Snack") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="ESTADO">
                    <EditItemTemplate>
                        <asp:CheckBox ID="cb_eit_Estado" runat="server" Checked='<%# Bind("Estado_Snack") %>' />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="cboxEstado" runat="server" Checked='<%# Bind("Estado_Snack") %>' Enabled="False" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>

    </div>

</asp:Content>
