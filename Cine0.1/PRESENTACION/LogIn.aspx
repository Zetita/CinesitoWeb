<%@ Page Title="" Language="C#" MasterPageFile="~/Visual.Master" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="PRESENTACION.LogIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    <a style="color:white";>USUARIO</a><br />
   

    <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
    <br />
    <a style="color:white";>CONTRASEÑA</a><br />
 
    <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
    <br />
    <asp:Button ID="Button4" runat="server" Text="Ingresar" />
    <br />
</asp:Content>
