<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Admin_Ventas.aspx.cs" Inherits="PRESENTACION.Admin_Ventas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
        <!-- FILA F-->
    <asp:Label ID="lblF" runat="server" Text="F" style="position:absolute;color:white;top: 195px;left:250px;font-family:Calibri" Font-Bold="true"></asp:Label>
    <asp:Button ID="btn1" runat="server" Height="29px" Text="1" Width="30px" style="position:absolute; top: 195px; left: 266px; right: 455px;" OnClick="Colorear2" CommandName="F-1" />
    <asp:Button ID="btn2" runat="server" Height="29px" Text="2" Width="30px" style="position:absolute; top: 195px; left: 303px; right: 418px;" OnClick="Colorear2" CommandName="F-2" />
    <asp:Button ID="btn3" runat="server" Height="29px" Text="3" Width="30px" style="position:absolute; top: 195px; left: 341px; right: 380px;" OnClick="Colorear2" CommandName="F-3" />
    <asp:Button ID="btn4" runat="server" Height="29px" Text="4" Width="30px" style="position:absolute; top: 195px; left: 379px; right: 341px;" OnClick="Colorear2" CommandName="F-4" />
    <asp:Button ID="btn5" runat="server" Height="29px" Text="5" Width="30px" style="position:absolute; top: 195px; left: 415px; right: 306px;" OnClick="Colorear2" CommandName="F-5" />
    <asp:Button ID="btn6" runat="server" Height="29px" Text="6" Width="30px" style="position:absolute; top: 195px; left: 452px; right: 269px;" OnClick="Colorear2" CommandName="F-6" />
    <asp:Button ID="btn7" runat="server" Height="29px" Text="7" Width="30px" style="position:absolute; top: 195px; left: 489px; right: 194px;" OnClick="Colorear2" CommandName="F-7" />
    <asp:Button ID="btn8" runat="server" Height="29px" Text="8" Width="30px" style="position:absolute; top: 195px; left: 527px; right: 232px;" OnClick="Colorear2" CommandName="F-8" />
    <asp:Button ID="btn9" runat="server" Height="29px" Text="9" Width="30px" style="position:absolute; top: 195px; left: 566px; right: 155px;" OnClick="Colorear2" CommandName="F-9" />

    <!-- FILA E-->
    <asp:Label ID="lblE" runat="server" Text="E" style="position:absolute;color:white;top:230px;left:250px;font-family:Calibri" Font-Bold="true"></asp:Label>
    <asp:Button ID="btn10" runat="server" Height="29px" Text="1" Width="30px" style="position:absolute; top: 230px; left: 266px; right: 455px;" OnClick="Colorear2" CommandName="E-1" />
    <asp:Button ID="btn11" runat="server" Height="29px" Text="2" Width="30px" style="position:absolute; top: 230px; left: 303px; right: 418px;" OnClick="Colorear2" CommandName="E-2" />
    <asp:Button ID="btn12" runat="server" Height="29px" Text="4" Width="30px" style="position:absolute; top: 230px; left: 379px; right: 342px;" OnClick="Colorear2" CommandName="E-4" />
    <asp:Button ID="btn13" runat="server" Height="29px" Text="5" Width="30px" style="position:absolute; top: 230px; left: 415px; right: 306px;" OnClick="Colorear2" CommandName="E-5" />
    <asp:Button ID="btn14" runat="server" Height="29px" Text="6" Width="30px" style="position:absolute; top: 230px; left: 452px; right: 269px;" OnClick="Colorear2" CommandName="E-6" />
    <asp:Button ID="btn15" runat="server" Height="29px" Text="8" Width="30px" style="position:absolute; top: 230px; left: 527px; right: 194px;" OnClick="Colorear2" CommandName="E-8" />
    <asp:Button ID="btn16" runat="server" Height="29px" Text="9" Width="30px" style="position:absolute; top: 230px; left: 566px; right: 155px;" OnClick="Colorear2" CommandName="E-9" />

    <!-- FILA D-->
    <asp:Label ID="lblD" runat="server" Text="D" style="position:absolute;color:white;top:265px;left:250px;font-family:Calibri" Font-Bold="true"></asp:Label>
    <asp:Button ID="btn17" runat="server" Height="29px" Text="1" Width="30px" style="position:absolute; top: 265px; left: 266px; right: 455px;" OnClick="Colorear2" CommandName="D-1" />
    <asp:Button ID="btn18" runat="server" Height="29px" Text="2" Width="30px" style="position:absolute; top: 265px; left: 303px; right: 418px;" OnClick="Colorear2" CommandName="D-2" />
    <asp:Button ID="btn19" runat="server" Height="29px" Text="4" Width="30px" style="position:absolute; top: 265px; left: 379px; right: 342px;" OnClick="Colorear2" CommandName="D-4" />
    <asp:Button ID="btn20" runat="server" Height="29px" Text="5" Width="30px" style="position:absolute; top: 265px; left: 414px; right: 307px;" OnClick="Colorear2" CommandName="D-5" />
    <asp:Button ID="btn21" runat="server" Height="29px" Text="6" Width="30px" style="position:absolute; top: 265px; left: 452px; right: 269px;" OnClick="Colorear2" CommandName="D-6" />
    <asp:Button ID="btn22" runat="server" Height="29px" Text="8" Width="30px" style="position:absolute; top: 265px; left: 527px; right: 194px;" OnClick="Colorear2" CommandName="D-8" />
    <asp:Button ID="btn23" runat="server" Height="29px" Text="9" Width="30px" style="position:absolute; top: 265px; left: 566px; right: 155px;" OnClick="Colorear2" CommandName="D-9" />

    <!-- FILA C-->
    <asp:Label ID="lblC" runat="server" Text="C" style="position:absolute;color:white;top:300px;left:250px;font-family:Calibri" Font-Bold="true"></asp:Label>
    <asp:Button ID="btn24" runat="server" Height="29px" Text="1" Width="30px" style="position:absolute; top: 300px; left: 266px; right: 455px;" OnClick="Colorear2" CommandName="C-1" />
    <asp:Button ID="btn25" runat="server" Height="29px" Text="2" Width="30px" style="position:absolute; top: 300px; left: 303px; right: 418px;" OnClick="Colorear2" CommandName="C-2" />
    <asp:Button ID="btn26" runat="server" Height="29px" Text="4" Width="30px" style="position:absolute; top: 300px; left: 379px; right: 342px;" OnClick="Colorear2" CommandName="C-4" />
    <asp:Button ID="btn27" runat="server" Height="29px" Text="5" Width="30px" style="position:absolute; top: 300px; left: 415px; right: 306px;" OnClick="Colorear2" CommandName="C-5" />
    <asp:Button ID="btn28" runat="server" Height="29px" Text="6" Width="30px" style="position:absolute; top: 300px; left: 451px; right: 270px;" OnClick="Colorear2" CommandName="C-6" />
    <asp:Button ID="btn29" runat="server" Height="29px" Text="8" Width="30px" style="position:absolute; top: 300px; left: 527px; right: 194px;" OnClick="Colorear2" CommandName="C-8" />
    <asp:Button ID="btn30" runat="server" Height="29px" Text="9" Width="30px" style="position:absolute; top: 300px; left: 566px; right: 127px;" OnClick="Colorear2" CommandName="C-9" />

    <!-- FILA B-->
    <asp:Label ID="lblB" runat="server" Text="B" style="position:absolute;color:white;top:335px;left:250px;font-family:Calibri" Font-Bold="true"></asp:Label>
    <asp:Button ID="btn31" runat="server" Height="29px" Text="1" Width="30px" style="position:absolute; top: 335px; left: 266px; right: 455px;" OnClick="Colorear2" CommandName="B-1" />
    <asp:Button ID="btn32" runat="server" Height="29px" Text="2" Width="30px" style="position:absolute; top: 335px; left: 303px; right: 418px;" OnClick="Colorear2" CommandName="B-2" />
    <asp:Button ID="btn33" runat="server" Height="29px" Text="4" Width="30px" style="position:absolute; top: 335px; left: 379px; right: 342px;" OnClick="Colorear2" CommandName="B-4" />
    <asp:Button ID="btn34" runat="server" Height="29px" Text="5" Width="30px" style="position:absolute; top: 335px; left: 415px; right: 306px;" OnClick="Colorear2" CommandName="B-5" />
    <asp:Button ID="btn35" runat="server" Height="29px" Text="6" Width="30px" style="position:absolute; top: 335px; left: 451px; right: 270px;" OnClick="Colorear2" CommandName="B-6" />
    <asp:Button ID="btn36" runat="server" Height="29px" Text="8" Width="30px" style="position:absolute; top: 335px; left: 526px; right: 195px;" OnClick="Colorear2" CommandName="B-8" />
    <asp:Button ID="btn37" runat="server" Height="29px" Text="9" Width="30px" style="position:absolute; top: 335px; left: 566px; right: 155px;" OnClick="Colorear2" CommandName="B-9" />
    
    <!-- FILA A-->
    <asp:Label ID="lblA" runat="server" Text="A" style="position:absolute;color:white;top:370px;left:250px;font-family:Calibri" Font-Bold="true"></asp:Label>
    <asp:Button ID="btn38" runat="server" Height="29px" Text="1" Width="30px" style="position:absolute; top: 370px; left: 266px; right: 455px;" OnClick="Colorear2" CommandName="A-1" />
    <asp:Button ID="btn39" runat="server" Height="29px" Text="2" Width="30px" style="position:absolute; top: 370px; left: 303px; right: 418px;" OnClick="Colorear2" CommandName="A-2" />
    <asp:Button ID="btn40" runat="server" Height="29px" Text="4" Width="30px" style="position:absolute; top: 370px; left: 378px; right: 343px;" OnClick="Colorear2" CommandName="A-4" />
    <asp:Button ID="btn41" runat="server" Height="29px" Text="5" Width="30px" style="position:absolute; top: 370px; left: 414px; right: 307px;" OnClick="Colorear2" CommandName="A-5" />
    <asp:Button ID="btn42" runat="server" Height="29px" Text="6" Width="30px" style="position:absolute; top: 370px; left: 452px; right: 269px;" OnClick="Colorear2" CommandName="A-6" />
    <asp:Button ID="btn43" runat="server" Height="29px" Text="8" Width="30px" style="position:absolute; top: 370px; left: 526px; right: 195px;" OnClick="Colorear2" CommandName="A-8" />
    <asp:Button ID="btn44" runat="server" Height="29px" Text="9" Width="30px" style="position:absolute; top: 370px; left: 564px; right: 157px;" OnClick="Colorear2" CommandName="A-9" />

    <!-- PANTALLA -->
    <asp:Image ID="imgPantalla" style="position:absolute; top: 475px; left: 216px; width: 412px;" runat="server" ImageUrl="~/Recursos/linea.png" />
    <asp:Label ID="lblPantalla" runat="server" style="position:absolute;color:white;font-family:Calibri;font-size:x-large; top: 450px; left: 370px;" Text="PANTALLA" Font-Bold="True"></asp:Label>

    <asp:Label ID="lblPelicula" runat="server" Text="Pelicula"  style="position:absolute; top:170px; "></asp:Label>
    <asp:DropDownList ID="ddlPelicula" runat="server" style="position:absolute; top:170px; left:800px; " AutoPostBack="True" OnSelectedIndexChanged="ddlPelicula_SelectedIndexChanged">
        <asp:ListItem Value="-1">-</asp:ListItem>
        </asp:DropDownList>

    <asp:Label ID="lblSucursal" runat="server" Text="Sucursal"  style="position:absolute; top:240px;"></asp:Label>
    <asp:DropDownList ID="ddlSucursal" runat="server" style="position:absolute; top:240px; left:800px; " AutoPostBack="True" Enabled="False" OnSelectedIndexChanged="ddlSucursal_SelectedIndexChanged">
        <asp:ListItem Value="-1">-</asp:ListItem>
        </asp:DropDownList>

    <asp:Label ID="lblFormato" runat="server" Text="Formato"  style="position:absolute; top:310px;"></asp:Label>
    <asp:DropDownList ID="ddlFormato" runat="server" style="position:absolute; top:310px; left:800px; " AutoPostBack="True" Enabled="False" OnSelectedIndexChanged="ddlFormato_SelectedIndexChanged">
        <asp:ListItem Value="-1">-</asp:ListItem>
        </asp:DropDownList>

    <asp:Label ID="lblDia" runat="server" Text="Fecha" style="position:absolute; top:380px;"></asp:Label>
    <asp:DropDownList ID="ddlDia" runat="server" style="position:absolute; top:380px; left:800px;" AutoPostBack="True" Enabled="False" OnSelectedIndexChanged="ddlDia_SelectedIndexChanged">
        <asp:ListItem Value="-1">-</asp:ListItem>
        </asp:DropDownList>

    <asp:Label ID="lblHorario" runat="server" Text="Horario" style="position:absolute; top:450px;"></asp:Label>
    <asp:DropDownList ID="ddlHorario" runat="server" style="position:absolute; top:450px; left:800px;" AutoPostBack="True" Enabled="False" OnSelectedIndexChanged="ddlHorario_SelectedIndexChanged">
        <asp:ListItem Value="-1">-</asp:ListItem>
        </asp:DropDownList>

    <asp:Button ID="btnAgregar" runat="server" Text="Complete los datos."  style="position:absolute; top:540px; width:400px" Enabled="False" OnClick="btnAgregar_Click"/>
</asp:Content>
