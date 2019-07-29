USE CineFrenz
GO

CREATE PROCEDURE spInsertarVenta
(
@IDVENTA char(6),
@IDUSUARIO int,
@USUARIO varchar(40),
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
SELECT
@IDVENTA,
@IDUSUARIO,
@USUARIO,
@FECHA_HORA,
@CANT_ENTRADAS,
@PRECIO_FINAL
RETURN