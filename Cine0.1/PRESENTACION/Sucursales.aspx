<%@ Page Title="" Language="C#" MasterPageFile="~/Visual.Master" AutoEventWireup="true" CodeBehind="Sucursales.aspx.cs" Inherits="PRESENTACION.Sucursales" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DropDownList ID="DdlSucursal" runat="server" AutoPostBack="true"  OnSelectedIndexChanged="DdlSucursal_SelectedIndexChanged" style="position:absolute; top:100px;" ></asp:DropDownList>
    
    <asp:Label ID="lblDireccion" runat="server" ForeColor="White" style="position:absolute; top:200px;" ></asp:Label>
    <asp:Label ID="lblLocalidad" runat="server" ForeColor="White" style="position:absolute; top:200px; left:110px;" ></asp:Label>
    
    <asp:Label ID="lblProvincia" runat="server" ForeColor="White" style="position:absolute; top:200px; left:190px;"></asp:Label>
    
    </asp:Content>
