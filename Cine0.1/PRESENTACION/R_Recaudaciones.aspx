<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="R_Recaudaciones.aspx.cs" Inherits="PRESENTACION.R_Recaudaciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<style>
body {font-family: "Lato", sans-serif;}

.sidebar {
  height: 30%;
  width: 190px;
  position: fixed;
  z-index: 1;
  top: 90px;
  left: 10x;
  background-color: #111;
  overflow-x: hidden;
  padding-top: 16px;
}

.sidebar a {
  padding: 6px 8px 6px 16px;
  text-transform:uppercase;
  text-decoration: none;
  font-size: 20px;
  color: #818181;
  display: block;
}

.sidebar a:hover {
  color: #f1f1f1;
}

.main {
  margin-top:10px;
  margin-left: 190px; 
  padding: 0px 10px;
}

@media screen and (max-height: 450px) {
  .sidebar {padding-top: 15px;}
  .sidebar a {font-size: 18px;}
}
</style>

<div class="sidebar">
  <a href=" R_Recaudaciones.aspx">Recaudaciones</a>
  <a href="#services">Peliculas</a>
</div>
<div class="main">

<asp:Label ID="Label1" runat="server" Text="Recaudaciones"></asp:Label>



    <br />

    <asp:GridView ID="grdRecaudaciones" runat="server"></asp:GridView>

</div>



</asp:Content>
