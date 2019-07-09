 <%@ Page Title="" Language="C#" MasterPageFile="~/Visual.Master" AutoEventWireup="true" CodeBehind="Butacas.aspx.cs" Inherits="PRESENTACION.Butacas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >

    <!-- FILA F-->
    <asp:Label ID="lblF" runat="server" Text="F" style="position:absolute;color:white;top:183px;left:250px;font-family:Calibri" Font-Bold="true"></asp:Label>
    <asp:ImageButton ImageURL="~/Recursos/Asiento-Libre.png" ID="btn1" runat="server" Height="29px" Text="1" Width="30px" style="position:absolute; top: 180px; left: 266px; right: 455px;" OnClick="Colorear2" />
    <asp:ImageButton ImageURL="~/Recursos/Asiento-Libre.png" ID="btn2" runat="server" Height="29px" Text="2" Width="30px" style="position:absolute; top: 180px; left: 303px; right: 418px;" OnClick="Colorear2" />
    <asp:ImageButton ImageURL="~/Recursos/Asiento-Libre.png" ID="btn3" runat="server" Height="29px" Text="3" Width="30px" style="position:absolute; top: 180px; left: 379px; right: 341px;" OnClick="Colorear2" />
    <asp:ImageButton ImageURL="~/Recursos/Asiento-Libre.png" ID="btn4" runat="server" Height="29px" Text="4" Width="30px" style="position:absolute; top: 180px; left: 415px; right: 306px;" OnClick="Colorear2" />
    <asp:ImageButton ImageURL="~/Recursos/Asiento-Libre.png" ID="btn5" runat="server" Height="29px" Text="5" Width="30px" style="position:absolute; top: 180px; left: 452px; right: 269px;" OnClick="Colorear2" />
    <asp:ImageButton ImageURL="~/Recursos/Asiento-Libre.png" ID="btn6" runat="server" Height="29px" Text="6" Width="30px" style="position:absolute; top: 180px; left: 527px; right: 194px;" OnClick="Colorear2" />
    <asp:ImageButton ImageURL="~/Recursos/Asiento-Libre.png" ID="btn7" runat="server" Height="29px" Text="7" Width="30px" style="position:absolute; top: 180px; left: 566px; right: 155px;" OnClick="Colorear2" />

    <!-- FILA E-->
    <asp:Label ID="lblE" runat="server" Text="E" style="position:absolute;color:white;top:219px;left:250px;font-family:Calibri" Font-Bold="true"></asp:Label>
    <asp:ImageButton ImageURL="~/Recursos/Asiento-Libre.png" ID="btn8" runat="server" Height="29px" Text="1" Width="30px" style="position:absolute; top: 215px; left: 266px; right: 455px;" OnClick="Colorear2" />
    <asp:ImageButton ImageURL="~/Recursos/Asiento-Libre.png" ID="btn9" runat="server" Height="29px" Text="2" Width="30px" style="position:absolute; top: 215px; left: 303px; right: 418px;" OnClick="Colorear2" />
    <asp:ImageButton ImageURL="~/Recursos/Asiento-Libre.png" ID="btn10" runat="server" Height="29px" Text="3" Width="30px" style="position:absolute; top: 215px; left: 379px; right: 342px;" OnClick="Colorear2" />
    <asp:ImageButton ImageURL="~/Recursos/Asiento-Libre.png" ID="btn11" runat="server" Height="29px" Text="4" Width="30px" style="position:absolute; top: 215px; left: 415px; right: 306px;" OnClick="Colorear2" />
    <asp:ImageButton ImageURL="~/Recursos/Asiento-Libre.png" ID="btn12" runat="server" Height="29px" Text="5" Width="30px" style="position:absolute; top: 215px; left: 452px; right: 269px;" OnClick="Colorear2" />
    <asp:ImageButton ImageURL="~/Recursos/Asiento-Libre.png" ID="btn13" runat="server" Height="29px" Text="6" Width="30px" style="position:absolute; top: 215px; left: 527px; right: 194px;" OnClick="Colorear2" />
    <asp:ImageButton ImageURL="~/Recursos/Asiento-Libre.png" ID="btn14" runat="server" Height="29px" Text="7" Width="30px" style="position:absolute; top: 215px; left: 566px; right: 155px;" OnClick="Colorear2" />

    <!-- FILA D-->
    <asp:Label ID="lblD" runat="server" Text="D" style="position:absolute;color:white;top:244px;left:250px;font-family:Calibri" Font-Bold="true"></asp:Label>
    <asp:ImageButton ImageURL="~/Recursos/Asiento-Libre.png" ID="btn15" runat="server" Height="29px" Text="1" Width="30px" style="position:absolute; top: 249px; left: 266px; right: 455px;" OnClick="Colorear2" />
    <asp:ImageButton ImageURL="~/Recursos/Asiento-Libre.png" ID="btn16" runat="server" Height="29px" Text="2" Width="30px" style="position:absolute; top: 249px; left: 303px; right: 418px;" OnClick="Colorear2" />
    <asp:ImageButton ImageURL="~/Recursos/Asiento-Libre.png" ID="btn17" runat="server" Height="29px" Text="3" Width="30px" style="position:absolute; top: 249px; left: 379px; right: 342px;" OnClick="Colorear2" />
    <asp:ImageButton ImageURL="~/Recursos/Asiento-Libre.png" ID="btn18" runat="server" Height="29px" Text="4" Width="30px" style="position:absolute; top: 249px; left: 414px; right: 307px;" OnClick="Colorear2" />
    <asp:ImageButton ImageURL="~/Recursos/Asiento-Libre.png" ID="btn19" runat="server" Height="29px" Text="5" Width="30px" style="position:absolute; top: 249px; left: 452px; right: 269px;" OnClick="Colorear2" />
    <asp:ImageButton ImageURL="~/Recursos/Asiento-Libre.png" ID="btn20" runat="server" Height="29px" Text="6" Width="30px" style="position:absolute; top: 24px; left: 527px; right: 194px;" OnClick="Colorear2" />
    <asp:ImageButton ImageURL="~/Recursos/Asiento-Libre.png" ID="btn21" runat="server" Height="29px" Text="7" Width="30px" style="position:absolute; top: 249px; left: 566px; right: 155px;" OnClick="Colorear2" />

    <!-- FILA C-->
    <asp:Label ID="lblC" runat="server" Text="C" style="position:absolute;color:white;top:288px;left:250px;font-family:Calibri" Font-Bold="true"></asp:Label>
    <asp:ImageButton ImageURL="~/Recursos/Asiento-Libre.png" ID="btn22" runat="server" Height="29px" Text="1" Width="30px" style="position:absolute; top: 284px; left: 266px; right: 455px;" OnClick="Colorear2" />
    <asp:ImageButton ImageURL="~/Recursos/Asiento-Libre.png" ID="btn23" runat="server" Height="29px" Text="2" Width="30px" style="position:absolute; top: 284px; left: 303px; right: 418px;" OnClick="Colorear2" />
    <asp:ImageButton ImageURL="~/Recursos/Asiento-Libre.png" ID="btn24" runat="server" Height="29px" Text="3" Width="30px" style="position:absolute; top: 284px; left: 379px; right: 342px;" OnClick="Colorear2" />
    <asp:ImageButton ImageURL="~/Recursos/Asiento-Libre.png" ID="btn25" runat="server" Height="29px" Text="4" Width="30px" style="position:absolute; top: 284px; left: 415px; right: 306px;" OnClick="Colorear2" />
    <asp:ImageButton ImageURL="~/Recursos/Asiento-Libre.png" ID="btn26" runat="server" Height="29px" Text="5" Width="30px" style="position:absolute; top: 284px; left: 451px; right: 270px;" OnClick="Colorear2" />
    <asp:ImageButton ImageURL="~/Recursos/Asiento-Libre.png" ID="btn27" runat="server" Height="29px" Text="6" Width="30px" style="position:absolute; top: 284px; left: 527px; right: 194px;" OnClick="Colorear2" />
    <asp:ImageButton ImageURL="~/Recursos/Asiento-Libre.png" ID="btn28" runat="server" Height="29px" Text="7" Width="30px" style="position:absolute; top: 284px; left: 566px; right: 127px;" OnClick="Colorear2" />

    <!-- FILA B-->
    <asp:Label ID="lblB" runat="server" Text="B" style="position:absolute;color:white;top:313px;left:250px;font-family:Calibri" Font-Bold="true"></asp:Label>
    <asp:ImageButton ImageURL="~/Recursos/Asiento-Libre.png" ID="btn29" runat="server" Height="29px" Text="1" Width="30px" style="position:absolute; top: 319px; left: 266px; right: 455px;" OnClick="Colorear2" />
    <asp:ImageButton ImageURL="~/Recursos/Asiento-Libre.png" ID="btn30" runat="server" Height="29px" Text="2" Width="30px" style="position:absolute; top: 319px; left: 303px; right: 418px;" OnClick="Colorear2" />
    <asp:ImageButton ImageURL="~/Recursos/Asiento-Libre.png" ID="btn31" runat="server" Height="29px" Text="3" Width="30px" style="position:absolute; top: 319px; left: 379px; right: 342px;" OnClick="Colorear2" />
    <asp:ImageButton ImageURL="~/Recursos/Asiento-Libre.png" ID="btn32" runat="server" Height="29px" Text="4" Width="30px" style="position:absolute; top: 319px; left: 415px; right: 306px;" OnClick="Colorear2" />
    <asp:ImageButton ImageURL="~/Recursos/Asiento-Libre.png" ID="btn33" runat="server" Height="29px" Text="5" Width="30px" style="position:absolute; top: 319px; left: 451px; right: 270px;" OnClick="Colorear2" />
    <asp:ImageButton ImageURL="~/Recursos/Asiento-Libre.png" ID="btn34" runat="server" Height="29px" Text="6" Width="30px" style="position:absolute; top: 319px; left: 526px; right: 195px;" OnClick="Colorear2" />
    <asp:ImageButton ImageURL="~/Recursos/Asiento-Libre.png" ID="btn35" runat="server" Height="29px" Text="7" Width="30px" style="position:absolute; top: 319px; left: 566px; right: 155px;" OnClick="Colorear2" />

    <!-- FILA A-->
    <asp:Label ID="lblA" runat="server" Text="A" style="position:absolute;color:white;top:357px;left:250px;font-family:Calibri" Font-Bold="true"></asp:Label>
    <asp:ImageButton ImageURL="~/Recursos/Asiento-Libre.png" ID="btn36" runat="server" Height="29px" Text="1" Width="30px" style="position:absolute; top: 353px; left: 266px; right: 455px;" OnClick="Colorear2" />
    <asp:ImageButton ImageURL="~/Recursos/Asiento-Libre.png" ID="btn37" runat="server" Height="29px" Text="2" Width="30px" style="position:absolute; top: 353px; left: 303px; right: 418px;" OnClick="Colorear2" />
    <asp:ImageButton ImageURL="~/Recursos/Asiento-Libre.png" ID="btn38" runat="server" Height="29px" Text="3" Width="30px" style="position:absolute; top: 353px; left: 341px; right: 380px;" OnClick="Colorear2" />
    <asp:ImageButton ImageURL="~/Recursos/Asiento-Libre.png" ID="btn39" runat="server" Height="29px" Text="4" Width="30px" style="position:absolute; top: 353px; left: 378px; right: 343px;" OnClick="Colorear2" />
    <asp:ImageButton ImageURL="~/Recursos/Asiento-Libre.png" ID="btn40" runat="server" Height="29px" Text="5" Width="30px" style="position:absolute; top: 353px; left: 414px; right: 307px;" OnClick="Colorear2" />
    <asp:ImageButton ImageURL="~/Recursos/Asiento-Libre.png" ID="btn41" runat="server" Height="29px" Text="6" Width="30px" style="position:absolute; top: 353px; left: 452px; right: 269px;" OnClick="Colorear2" />
    <asp:ImageButton ImageURL="~/Recursos/Asiento-Libre.png" ID="btn42" runat="server" Height="29px" Text="7" Width="30px" style="position:absolute; top: 353px; left: 489px; right: 232px;" OnClick="Colorear2" />
    <asp:ImageButton ImageURL="~/Recursos/Asiento-Libre.png" ID="btn43" runat="server" Height="29px" Text="8" Width="30px" style="position:absolute; top: 353px; left: 526px; right: 195px;" OnClick="Colorear2" />
    <asp:ImageButton ImageURL="~/Recursos/Asiento-Libre.png" ID="btn44" runat="server" Height="29px" Text="9" Width="30px" style="position:absolute; top: 353px; left: 564px; right: 157px;" OnClick="Colorear2" />

    <!-- PANTALLA -->
    <asp:Image ID="imgPantalla" style="position:absolute; top: 333px; left: 216px; height: 235px; width: 412px;" runat="server" ImageUrl="~/Recursos/linea.png" />
    <asp:Label ID="lblPantalla" runat="server" style="position:absolute;color:white;font-family:Calibri;font-size:x-large; top: 410px; left: 370px;" Text="PANTALLA" Font-Bold="True"></asp:Label>
    
    <!-- INFO ENTRADA -->
    <asp:Label ID="lblFormato" runat="server"  style="position:absolute;font-family:Calibri;color:white; top: 187px; left: 905px; font-size:x-large" Font-Bold="False"></asp:Label>
    <asp:Label ID="lblFecha" runat="server" Text="Jueves 13 de Junio - 15:30" style="position:absolute;font-family:Calibri;color:white;font-size:x-large; top: 329px; left: 905px"></asp:Label>
    <asp:Label ID="lblEntrada" runat="server"  style="position:absolute;font-family:Calibri;color:white;font-size:x-large;top: 384px; left: 696px"></asp:Label>
    <asp:Label ID="lblPrecio" runat="server" style="position:absolute;font-family:Calibri;color:white;font-size:x-large;top: 384px; left: 1080px"></asp:Label>
    <asp:Label ID="lblPrecioFinal" runat="server" style="position:absolute;font-family:Calibri;color:white;font-size:x-large;top: 428px; left: 1080px" Font-Bold="True"></asp:Label>
    <asp:Label ID="lblTotal" runat="server" style="position:absolute;font-family:Calibri;color:white;font-size:xx-large; top: 428px; left: 696px" Font-Bold="True"></asp:Label>

    <!-- INFO LUGAR -->
    <asp:Label ID="lblSucursal" runat="server" style="position:absolute;font-family:Calibri;color:white; top: 227px; left: 905px; font-size:x-large" Font-Bold="true"></asp:Label>
    <asp:Label ID="lblDireccion" runat="server"  style="position:absolute;font-family:Calibri;color:white;font-size:x-large; top: 267px; left: 905px; margin-right:200px"></asp:Label>

    <!-- PELICULA -->
    <asp:Image ID="imgPelicula" runat="server" style="position:absolute; top: 86px; left: 696px; height: 272px; width: 196px;" />
    <asp:Label ID="lblNombre" runat="server" style="position:absolute;font-family:Calibri;color:white; top: 86px; left: 905px; margin-right:1000px;font-size:x-large" Font-Bold="True"></asp:Label>
    
    <!-- BOLUDECES-->
    <asp:Label ID="lblLinea" runat="server" Text="________________________________________" style="position:absolute;font-family:Calibri;color:white;font-size:x-large; top: 337px; left: 696px"></asp:Label>

    <!-- BOTONES -->
    <asp:Button ID="btnVolver" runat="server" Height="26px" Text="VOLVER" style="background-color:#003d66;position:absolute;width:500px;top:527px;left:170px;height:30px" OnClick="btnVolver_Click" />
    <asp:Button ID="btnSiguiente" runat="server" Text="SIGUIENTE" style="background-color:#003d66;position:absolute;top:527px;width:500px;left:680px ;height:30px" Font-Bold="true" OnClick="btnSiguiente_Click" Enabled="False"/>
    <asp:Button ID="btnConfirmar" runat="server" Text="CONFIRMAR SELECCIÓN" style="background-color:#003d66;position:absolute;top:490px; width:500px;left:680px;height:30px" Font-Bold="true" OnClick="btnConfirmar_Click"/>
    
</asp:Content>
