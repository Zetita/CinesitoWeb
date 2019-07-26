<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Admin_Usuarios.aspx.cs" Inherits="PRESENTACION.Admin_Usuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 337px;
        }
        .auto-style3 {
            width: 378px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="lblTitulo" runat="server" Text="Administrar Usuarios"></asp:Label>
    </div>
    <div class="Label">
        <asp:Label ID="lblSubtitulo" runat="server" Text="Cargar Usuario"></asp:Label>
        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Usuario</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtUsuario" runat="server" Width="302px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfv1" runat="server" ControlToValidate="txtUsuario" ErrorMessage="Ingrese una contraseña" ForeColor="Red" ValidationGroup="add">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Contraseña</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtContrasenia" runat="server" Width="302px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfv2" runat="server" ControlToValidate="txtContrasenia" ErrorMessage="Ingrese una contraseña" ForeColor="Red" ValidationGroup="add">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Email</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" Width="302px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfv3" runat="server" ControlToValidate="txtEmail" ErrorMessage="Ingrese un email" ForeColor="Red" ValidationGroup="add">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Apellidos</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtApellidos" runat="server" Width="302px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfv4" runat="server" ControlToValidate="txtApellidos" ErrorMessage="Ingrese un apellido" ForeColor="Red" ValidationGroup="add">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Nombre</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtNombres" runat="server" Width="302px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfv5" runat="server" ControlToValidate="txtNombres" ErrorMessage="Ingrese un nombre" ForeColor="Red" ValidationGroup="add">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">DNI</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtDni" runat="server" TextMode="Number" Width="300px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfv6" runat="server" ControlToValidate="txtDni" ErrorMessage="Ingrese un DNI" ForeColor="Red" ValidationGroup="add">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Telefono</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtTelefono" runat="server" TextMode="Phone" Width="161px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfv7" runat="server" ControlToValidate="txtTelefono" ErrorMessage="Ingrese un telefono" ForeColor="Red" ValidationGroup="add">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Fecha de nacimiento(MM/DD/AAAA)</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtFecNac" runat="server" TextMode="DateTime" Width="161px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfv8" runat="server" ControlToValidate="txtFecNac" ErrorMessage="Ingrese una fecha" ForeColor="Red" ValidationGroup="add">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Administrador</td>
                <td class="auto-style3">
                    <asp:RadioButtonList ID="rbtnAdmin" runat="server">
                        <asp:ListItem Value="1">Si</asp:ListItem>
                        <asp:ListItem Value="0">No</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfv9" runat="server" ControlToValidate="rbtnAdmin" ErrorMessage="Seleccione una opción" ForeColor="Red" ValidationGroup="add">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" Text="Agregar" ValidationGroup="add" />
                </td>
                <td>
                    <asp:Label ID="lblAg" runat="server" ForeColor="Red" ValidationGroup="add" ></asp:Label>
                </td>
            </tr>
            <tr >
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3" >
                    <asp:Label ID="lblAgregado" runat="server" ValidationGroup="add"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <br />
        <asp:Label ID="lblListado" runat="server" Text="Listado de Usuarios"></asp:Label>
        <br />
        <asp:Button ID="btnCargarTodos" runat="server" OnClick="btnCargarTodos_Click" Text="Todos" />
&nbsp;&nbsp;
        <asp:Button ID="btnUsuarios" runat="server" OnClick="btnUsuarios_Click" Text="Usuarios" />
&nbsp;&nbsp;
        <asp:Button ID="btnAdmins" runat="server" OnClick="btnAdmins_Click" Text="Administradores" />
        <br />
        <asp:GridView ID="grdUsuarios" runat="server" AllowPaging="True" AutoGenerateColumns="False" AutoGenerateDeleteButton="True" AutoGenerateEditButton="True" CssClass="tablalistado" PageSize="5" OnRowDeleting="grdUsuarios_RowDeleting" OnRowEditing="grdUsuarios_RowEditing" OnRowCancelingEdit="grdUsuarios_RowCancelingEdit" OnRowUpdating="grdUsuarios_RowUpdating" OnPageIndexChanging="grdUsuarios_PageIndexChanging">
            <Columns>
                <asp:TemplateField HeaderText="ID">
                    <EditItemTemplate>
                        <asp:Label ID="lbl_eit_IDUsuario" runat="server" Text='<%# Bind("ID_Usuario") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_IDUsuario" runat="server" Text='<%# Bind("ID_Usuario") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="USUARIO">
                    <EditItemTemplate>
                        <asp:Label ID="lbl_eit_Usuario" runat="server" Text='<%# Bind("Usuario") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Usuario" runat="server" Text='<%# Bind("Usuario") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="CONTRASEÑA">
                    <EditItemTemplate>
                        <asp:TextBox ID="txt_eit_Contrasenia" runat="server" Text='<%# Bind("Contrasenia") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Contrasenia" runat="server" Text='<%# Bind("Contrasenia") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="EMAIL">
                    <EditItemTemplate>
                        <asp:TextBox ID="txt_eit_Email" runat="server" Text='<%# Bind("Email_Usuario") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Email" runat="server" Text='<%# Bind("Email_Usuario") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="APELLIDOS">
                    <EditItemTemplate>
                        <asp:TextBox ID="txt_eit_Apellidos" runat="server" Text='<%# Bind("Apellidos_Usuario") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Apellidos" runat="server" Text='<%# Bind("Apellidos_Usuario") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="NOMBRES">
                    <EditItemTemplate>
                        <asp:TextBox ID="txt_eit_Nombres" runat="server" Text='<%# Bind("Nombres_Usuario") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Nombres" runat="server" Text='<%# Bind("Nombres_Usuario") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="DNI">
                    <EditItemTemplate>
                        <asp:TextBox ID="txt_eit_DNI" runat="server" Text='<%# Bind("DNI_Usuario") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_DNI" runat="server" Text='<%# Bind("DNI_Usuario") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="TELEFONO">
                    <EditItemTemplate>
                        <asp:TextBox ID="txt_eit_Telefono" runat="server" Text='<%# Bind("Telefono_Usuario") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Telefono" runat="server" Text='<%# Bind("Telefono_Usuario") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="FECHA DE NAC">
                    <EditItemTemplate>
                        <asp:TextBox ID="txt_eit_FecNac" runat="server" Text='<%# Bind("FechaNac_Usuario", "{0:d}" ) %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_FecNac" runat="server" Text='<%# Bind("FechaNac_Usuario", "{0:d}" ) %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="ADMINISTRADOR">
                    <EditItemTemplate>
                        <asp:CheckBox ID="cb_eit_Admin" runat="server" Checked='<%# Bind("Administrador") %>' />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="cbox_it_Admin" runat="server" Checked='<%# Bind("Administrador") %>' Enabled="False" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="ESTADO">
                    <EditItemTemplate>
                        <asp:CheckBox ID="cb_eit_Activo" runat="server" Checked='<%# Bind("Activo") %>' />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="cbox_it_Activo" runat="server" Checked='<%# Bind("Activo") %>' Enabled="False" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
