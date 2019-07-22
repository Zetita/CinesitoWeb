<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Admin_Peliculas.aspx.cs" Inherits="PRESENTACION.Admin_Peliculas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            width: 137px;
            color: black;
        }
        .auto-style6 {
            width: 137px;
            height: 29px;
        }
        .auto-style9 {
            width: 166px;
        }
        .auto-style10 {
            width: 166px;
            height: 29px;
        }
        .auto-style11 {
            width: 37px;
            color: black;
        }
        .auto-style12 {
            width: 37px;
            height: 29px;
        }
        .auto-style13 {
            width: 37px;
        }
        .auto-style14 {
            width: 37px;
            color: black;
            height: 29px;
        }
        .auto-style15 {
            width: 137px;
            color: black;
            height: 29px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    <asp:Label ID="Label1" runat="server" Text="Administrar Peliculas"></asp:Label>
    </div>
    <div class="Label">
    <asp:Label ID="Label2" runat="server" Text="Cargar Pelicula"></asp:Label>
        <br />
        <div class="tabla">
        <table class="auto-style1">
            <tr>
                <td class="auto-style9">Titulo</td>
                <td class="auto-style13">
                    <asp:TextBox ID="txtTitulo" runat="server" Width="300px"></asp:TextBox>
                </td>
                <td class="auto-style11">
                    <asp:RequiredFieldValidator ID="rfv1" runat="server" ControlToValidate="txtTitulo" ErrorMessage="*" ForeColor="Red" ValidationGroup="add"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style3">
                    Cargar Pelicula xFormato</td>
            </tr>
            <tr>
                <td class="auto-style10">Genero/s</td>
                <td class="auto-style12">
                    <asp:TextBox ID="txtGeneros" runat="server" Width="300px"></asp:TextBox>
                </td>
                <td class="auto-style14">
                    <asp:RequiredFieldValidator ID="rfv2" runat="server" ControlToValidate="txtGeneros" ErrorMessage="*" ForeColor="Red" ValidationGroup="add"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style15">
                    Pelicula:</td>
            </tr>
            <tr>
                <td class="auto-style9">Clasificación</td>
                <td class="auto-style13">
                    <asp:DropDownList ID="ddlClasificacion" runat="server" AutoPostBack="True">
                    </asp:DropDownList>
                </td>
                <td class="auto-style11">
                    <asp:RequiredFieldValidator ID="rfv3" runat="server" ControlToValidate="ddlClasificacion" ErrorMessage="*" ForeColor="Red" ValidationGroup="add"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style3">
                    <asp:DropDownList ID="ddlPeliculas" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">Fecha Estreno</td>
                <td class="auto-style13">
                    <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px" SelectedDate="2010-10-10">
                        <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                        <NextPrevStyle VerticalAlign="Bottom" />
                        <OtherMonthDayStyle ForeColor="#808080" />
                        <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                        <SelectorStyle BackColor="#CCCCCC" />
                        <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                        <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                        <WeekendDayStyle BackColor="#FFFFCC" />
                    </asp:Calendar>
                </td>
                <td class="auto-style11">
                    *</td>
                <td class="auto-style3">
                    <asp:CheckBoxList ID="cboxlistFormatos" runat="server" AutoPostBack="True">
                    </asp:CheckBoxList>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">Director/es</td>
                <td class="auto-style13">
                    <asp:TextBox ID="txtDirector" runat="server" Width="300px"></asp:TextBox>
                </td>
                <td class="auto-style11">
                    <asp:RequiredFieldValidator ID="rfv4" runat="server" ControlToValidate="txtDirector" ErrorMessage="*" ForeColor="Red" ValidationGroup="add"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style3">
                    <asp:Button ID="btnCargarPelxFor" runat="server" Text="Cargar" OnClick="btnCargarPelxFor_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style9">Sinopsis</td>
                <td class="auto-style13">
                    <asp:TextBox ID="txtSinopsis" runat="server" Height="67px" Width="300px" TextMode="MultiLine"></asp:TextBox>
                </td>
                <td class="auto-style11">
                    <asp:RequiredFieldValidator ID="rfv5" runat="server" ControlToValidate="txtSinopsis" ErrorMessage="*" ForeColor="Red" ValidationGroup="add"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style3">
                    <asp:Label ID="lblCargado" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">Imagen</td>
                <td class="auto-style13">
                    <asp:FileUpload ID="fileImagen" runat="server" Width="300px" />
                </td>
                <td class="auto-style11">
                    <asp:RequiredFieldValidator ID="rfv6" runat="server" ControlToValidate="fileImagen" ErrorMessage="*" ForeColor="Red" ValidationGroup="add"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style3">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10">Duración(HH:MM)</td>
                <td class="auto-style12">
                    <asp:TextBox ID="txtDuracion" runat="server" Width="300px"></asp:TextBox>
                </td>
                <td class="auto-style12">
                    <asp:RequiredFieldValidator ID="rfv7" runat="server" ControlToValidate="txtDuracion" ErrorMessage="*" ForeColor="Red" ValidationGroup="add"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style6">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10">TrailerURL</td>
                <td class="auto-style12">
                    <asp:TextBox ID="txtTrailerURL" runat="server" Width="300px"></asp:TextBox>
                </td>
                <td class="auto-style12">
                    <asp:RequiredFieldValidator ID="rfv8" runat="server" ControlToValidate="txtTrailerURL" ErrorMessage="*" ForeColor="Red" ValidationGroup="add"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style6">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10">Estado</td>
                <td class="auto-style12">
                    <asp:RadioButtonList ID="rbtnEstado" runat="server" Width="182px">
                        <asp:ListItem Value="1">Disponible</asp:ListItem>
                        <asp:ListItem Value="0">No Disponible</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td class="auto-style12">
                    <asp:RequiredFieldValidator ID="rfv9" runat="server" ControlToValidate="rbtnEstado" ErrorMessage="Seleccione un estado." ForeColor="Red" ValidationGroup="add">*</asp:RequiredFieldValidator>
                </td>
                <td class="auto-style6">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style13">
                    <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
                </td>
                <td class="auto-style11">
                    <asp:Label ID="lblAg" runat="server" ForeColor="Red"></asp:Label>
                </td>
                <td class="auto-style3">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style13">
                    <asp:Label ID="lblAgregado" runat="server"></asp:Label>
                </td>
                <td class="auto-style11">
                    &nbsp;</td>
                <td class="auto-style3">
                    &nbsp;</td>
            </tr>
        </table>
        </div>
    </div>
    <div class="Label">
    <asp:Label ID="Label3" runat="server" Text="Listado de Peliculas"></asp:Label>
        <br />
        <asp:GridView ID="grdPeliculas" runat="server" AutoGenerateColumns="False" AutoGenerateDeleteButton="True" AutoGenerateEditButton="True" CssClass="tablalistado" OnPageIndexChanging="grdPeliculas_PageIndexChanging" OnRowDeleting="grdPeliculas_RowDeleting" OnRowCancelingEdit="grdPeliculas_RowCancelingEdit" OnRowEditing="grdPeliculas_RowEditing" OnRowUpdating="grdPeliculas_RowUpdating">
            <Columns>
                <asp:TemplateField HeaderText="ID">
                    <EditItemTemplate>
                        <asp:Label ID="lbl_eit_IDPelicula" runat="server" Text='<%# Bind("ID_Pelicula") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_IDPelicula" runat="server" Text='<%# Bind("ID_Pelicula") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Titulo">
                    <EditItemTemplate>
                        <asp:TextBox ID="txt_eit_Titulo" runat="server" Text='<%# Bind("Titulo_Pelicula") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Titulo" runat="server" Text='<%# Bind("Titulo_Pelicula") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Genero/s">
                    <EditItemTemplate>
                        <asp:TextBox ID="txt_eit_Genero" runat="server" Text='<%# Bind("Genero_Pelicula") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Generos" runat="server" Text='<%# Bind("Genero_Pelicula") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Clasificacion">
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Clasificacion" runat="server" Text='<%# Bind("Clasificacion_Pelicula") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Fecha de Estreno">
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Estreno" runat="server" Text='<%# Bind("FechaEstreno_Pelicula") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Director/es">
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Directores" runat="server" Text='<%# Bind("Director_Pelicula") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Sinopsis">
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Sinopsis" runat="server" Text='<%# Bind("Sinopsis_Pelicula") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Imagen">
                    <EditItemTemplate>
                        <asp:ImageButton ID="img_eit_Imagen" runat="server" Height="100px" ImageUrl='<%# Bind("ImagenURL") %>' />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:ImageButton ID="img_it_Imagen" runat="server" Height="100px" ImageUrl='<%# Bind("ImagenURL") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Duración">
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Duracion" runat="server" Text='<%# Bind("Duracion") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="TrailerURL">
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Trailer" runat="server" Text='<%# Bind("TrailerURL") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>

</asp:Content>
