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
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    <asp:Label ID="Label1" runat="server" Text="Administrar Snacks"></asp:Label>
    </div>
    <div class="Label">
    <asp:Label ID="Label2" runat="server" Text="Cargar Snack"></asp:Label>
    </div>
    <div class="tabla">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Nombre Snack</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtSnack" runat="server" Width="300px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfv1" runat="server" ControlToValidate="txtSnack" ErrorMessage="Campo requerido." ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Tipo de Snack</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="ddlTipoSnack" runat="server">
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfv2" runat="server" ControlToValidate="ddlTipoSnack" ErrorMessage="Campo requerido." ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Precio Unitario</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtPrecio" runat="server" Width="300px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfv3" runat="server" ControlToValidate="txtPrecio" ErrorMessage="Campo requerido." ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Imagen</td>
                <td class="auto-style3">
                    <asp:FileUpload ID="FileImagen" runat="server" Width="300px" />
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfv4" runat="server" ControlToValidate="FileImagen" ErrorMessage="Campo requerido." ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Estado</td>
                <td class="auto-style3">
                    <asp:RadioButtonList ID="rbtnEstado" runat="server">
                        <asp:ListItem Value="1">Disponible</asp:ListItem>
                        <asp:ListItem Value="0">No Disponible</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfv5" runat="server" ControlToValidate="rbtnEstado" ErrorMessage="Campo requerido." ForeColor="Red"></asp:RequiredFieldValidator>
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
                    <asp:Label ID="lblAgregado" runat="server" Text="Label"></asp:Label>
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

        <asp:GridView ID="grdSnacks" runat="server" AutoGenerateColumns="False" DataKeyNames="ID_Snack" DataSourceID="SqlDataSource1" CssClass="tablalistado">
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
                <asp:TemplateField HeaderText="ID Snack" SortExpression="ID_Snack">
                    <EditItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("ID_Snack") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("ID_Snack") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Nombre" SortExpression="Nombre_Snack">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Nombre_Snack") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("Nombre_Snack") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Tipo" SortExpression="Tipo_Snack">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Tipo_Snack") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("Tipo_Snack") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Precio" SortExpression="Precio_Snack">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("Precio_Snack") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("Precio_Snack") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Imagen" SortExpression="URLImagen_Snack">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("URLImagen_Snack") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl='<%# Eval("URLImagen_Snack") %>' Width="80px" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Disponibilidad" SortExpression="Estado_Snack">
                    <EditItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" Checked='<%# Bind("Estado_Snack") %>' />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" Checked='<%# Bind("Estado_Snack") %>' Enabled="false" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CineFrenzConnectionString %>" SelectCommand="SELECT * FROM [Snacks]"></asp:SqlDataSource>

    </div>

</asp:Content>
