
<%@ Page Title="" Language="C#" MasterPageFile="~/Visual.Master" AutoEventWireup="true" CodeBehind="Peliculas.aspx.cs" Inherits="PRESENTACION.Peliculas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <title></title>
    <style>
		body{background-color: black;padding: 0px;font-family: Arial;}
		
		#menu{
			background-color: white;
            
		}
		#menu ul{
			list-style: none;
			margin: 0;
			padding: 0;
		}
		#menu ul li{
			display: inline-block;
		}
		#menu ul li a{
			color: white;
			display: block;
			padding: 20px 20px;
			text-decoration: none;
		}
		#menu ul li a:hover{
			background-color: white;
		}
		
	</style>
</head>
<body >
    
        
</div>
        <asp:Image ID="imgPortada" runat="server" ImageUrl="~/Recursos/1.jpg" style="position:absolute;top:155px;left:75px; height: 387px; width: 256px;"/>
        <b><asp:Label ID="lblNombre" runat="server" style="position:absolute;text-transform:uppercase; top: 150px; left: 346px; margin-right:700px" Font-Size="XX-Large"></asp:Label></b>
        <asp:Label ID="lblSinopsis" runat="server" style="position:absolute; top:250px;left:346px; text-align:justify; margin-right:700px"></asp:Label>
        <asp:Label ID="lblGenero" runat="server" style="position:absolute; top:400px; left:346px"></asp:Label>
        <asp:Label ID="lblDuracion" runat="server" style="position:absolute; top:425px; left:346px"></asp:Label>
        <asp:Label ID="lblTrailer" runat="server" Text="TRAILER" style="position:absolute;top:150px;left:800px;font-size:xx-large" Font-Bold="True"></asp:Label>
        <asp:Label ID="lbl_Sucursal" runat="server" Text="Sucursal: " style="position:absolute;top:525px;left:346px"></asp:Label>
        <b><asp:Label ID="lblVenta" runat="server" Text="VENTA DE ENTRADAS" style="position:absolute;top:500px;left: 346px" Font-Underline="True"></asp:Label></b>
        <asp:Label ID="lblDirector" runat="server" style="position:absolute; top:450px; left:346px"></asp:Label>
        <asp:DropDownList ID="ddlCine" runat="server" style="position:absolute; top:524px;left:425px">
            <asp:ListItem Value="0">Unicenter</asp:ListItem>
            <asp:ListItem Value="1">DOT</asp:ListItem>
            <asp:ListItem Value="2">Soleil</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="btnSeleccionar" runat="server" Font-Bold="True" Text="Seleccionar butacas" style="background-color:#b30000;position:absolute;top:565px;left:346px;width:776px;height:30px " />
        <iframe src="https://www.youtube.com/embed/9CHmEHBKuyE" frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" allowfullscreen style="position:absolute;top:200px;left:800px;height: 275px; width: 437px"></iframe>
        <asp:Label ID="lblFormato" runat="server" Text="Formato:" style="position:absolute;top:525px;left:525px"></asp:Label>
        <asp:Label ID="lblDía" runat="server" Text="Día:" style="position:absolute;top:525px;left:780px"></asp:Label>
        <asp:DropDownList ID="ddlDía" runat="server" style="position:absolute;top:524px;left:822px">
            <asp:ListItem Value="0">Jueves, 13 de Mayo</asp:ListItem>
            <asp:ListItem>Viernes, 14 de Mayo</asp:ListItem>
            <asp:ListItem Value="1">Sabado, 15 de Mayo</asp:ListItem>
        </asp:DropDownList>
        <asp:DropDownList ID="ddlFormato" runat="server" style="position:absolute;top:524px;left:602px">
            <asp:ListItem Value="0">3D - Audio Español</asp:ListItem>
            <asp:ListItem Value="1">2D - Subtitulos Español</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="lblHorario" runat="server" Text="Horario:" style="position:absolute;top:525px;left:985px"></asp:Label>
        <asp:DropDownList ID="ddlHorario" runat="server" style="position:absolute;top:524px;left:1057px">
            <asp:ListItem Value="0">15:30</asp:ListItem>
            <asp:ListItem Value="1">18:30</asp:ListItem>
            <asp:ListItem Value="2">19:30</asp:ListItem>
        </asp:DropDownList>
   
            
    
</body>
</html>
</asp:Content>
