<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Admin_Formatos.aspx.cs" Inherits="PRESENTACION.Admin_Formatos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Administrar Formatos y Precios"></asp:Label>
    </div>
    <div class="Label">
        <asp:GridView ID="grdFormatos" runat="server" AutoGenerateColumns="False" CssClass="tablalistado" AllowPaging="True" AutoGenerateEditButton="True">
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
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Nombre" runat="server" Text='<%# Bind("Nombre_Formato") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Idioma"></asp:TemplateField>
                <asp:TemplateField HeaderText="Subtitulos"></asp:TemplateField>
                <asp:TemplateField HeaderText="Precio"></asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
