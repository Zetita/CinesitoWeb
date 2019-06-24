<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Admin_Peliculas.aspx.cs" Inherits="PRESENTACION.Admin_Peliculas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 133px;
        }
        .auto-style3 {
            width: 137px;
        }
        .auto-style5 {
            width: 133px;
            height: 29px;
        }
        .auto-style6 {
            width: 137px;
            height: 29px;
        }
        .auto-style8 {
            width: 69px;
            height: 29px;
        }
        .auto-style9 {
            width: 69px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    <asp:Label ID="Label1" runat="server" Text="Administrar Peliculas"></asp:Label>
    </div>
    <div class="Label">
    <asp:Label ID="Label2" runat="server" Text="Cargar Pelicula"></asp:Label>
        <div class="tabla">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Titulo</td>
                <td class="auto-style9">
                    <asp:TextBox ID="txtTitulo" runat="server" Width="300px"></asp:TextBox>
                </td>
                <td class="auto-style3">
                    <asp:RequiredFieldValidator ID="rfv1" runat="server" ControlToValidate="txtTitulo" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Genero/s</td>
                <td class="auto-style9">
                    <asp:TextBox ID="txtGeneros" runat="server" Width="300px"></asp:TextBox>
                </td>
                <td class="auto-style3">
                    <asp:RequiredFieldValidator ID="rfv2" runat="server" ControlToValidate="txtGeneros" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Clasificación</td>
                <td class="auto-style9">
                    <asp:DropDownList ID="ddlClasificacion" runat="server">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem>ATP</asp:ListItem>
                        <asp:ListItem>SAM13</asp:ListItem>
                        <asp:ListItem>SAM16</asp:ListItem>
                        <asp:ListItem>SAM18</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style3">
                    <asp:RequiredFieldValidator ID="rfv3" runat="server" ControlToValidate="ddlClasificacion" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Fecha Estreno</td>
                <td class="auto-style9">
                    <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
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
                <td class="auto-style3">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Director/es</td>
                <td class="auto-style9">
                    <asp:TextBox ID="txtDirector" runat="server" Width="300px"></asp:TextBox>
                </td>
                <td class="auto-style3">
                    <asp:RequiredFieldValidator ID="rfv4" runat="server" ControlToValidate="txtDirector" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Sinopsis</td>
                <td class="auto-style9">
                    <asp:TextBox ID="txtSinopsis" runat="server" Height="67px" Width="300px"></asp:TextBox>
                </td>
                <td class="auto-style3">
                    <asp:RequiredFieldValidator ID="rfv5" runat="server" ControlToValidate="txtSinopsis" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Imagen</td>
                <td class="auto-style9">
                    <asp:FileUpload ID="fileImagen" runat="server" Width="300px" />
                </td>
                <td class="auto-style3">
                    <asp:RequiredFieldValidator ID="rfv6" runat="server" ControlToValidate="fileImagen" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Duración</td>
                <td class="auto-style8">
                    <asp:TextBox ID="txtDuracion" runat="server" Width="300px" TextMode="Time"></asp:TextBox>
                </td>
                <td class="auto-style6">
                    <asp:RequiredFieldValidator ID="rfv7" runat="server" ControlToValidate="txtDuracion" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">TrailerURL</td>
                <td class="auto-style8">
                    <asp:TextBox ID="txtTrailerURL" runat="server" Width="300px"></asp:TextBox>
                </td>
                <td class="auto-style6">
                    <asp:RequiredFieldValidator ID="rfv8" runat="server" ControlToValidate="txtTrailerURL" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style9">
                    <asp:Button ID="btnAgregar" runat="server" Text="Agregar" />
                </td>
                <td class="auto-style3">
                    <asp:Label ID="lblAg" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style9">
                    <asp:Label ID="lblAgregado" runat="server"></asp:Label>
                </td>
                <td class="auto-style3">
                    &nbsp;</td>
            </tr>
        </table>
        </div>
    </div>
    <div class="Label">
    <asp:Label ID="Label3" runat="server" Text="Listado de Peliculas"></asp:Label>
    </div>

</asp:Content>
