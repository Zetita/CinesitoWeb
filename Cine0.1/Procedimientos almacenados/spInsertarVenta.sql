USE CineFrenz
GO

CREATE PROCEDURE spInsertarVenta
(
@IDVENTA char(10),
@IDUSUARIO int,
@USUARIO char(40),
@FECHA_HORA datetime,
@CANT_ENTRADAS int, 
@PRECIO_FINAL smallmoney
)
AS
INSERT INTO Ventas
(
ID_Venta,
IDUsuario_Venta,
Usuario_Venta,
FechaHora_Venta,
CantEntradas_Venta,
PrecioFinal_Venta
)
VALUES
(
@IDVENTA,
@IDUSUARIO,
@USUARIO,
@FECHA_HORA,
@CANT_ENTRADAS,
@PRECIO_FINAL
)
RETURN