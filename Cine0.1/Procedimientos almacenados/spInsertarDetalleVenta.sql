USE CineFrenz
GO

CREATE PROCEDURE spInsertarDetalleVenta
(
@ID_VENTA char(6),
@ID_FUNCION char(6),
@ID_BUTACA char(6),
@FILA_BUTACA varchar(20),
@BUTACA varchar(20),
@PRECIO smallmoney
)
AS
INSERT INTO DetalleVentas
(
ID_Venta,
ID_Funcion,
ID_Butaca,
Fila_Butaca,
Butaca,
PrecioEntrada
)
SELECT
@ID_VENTA,
@ID_FUNCION,
@ID_BUTACA,
@FILA_BUTACA,
@BUTACA,
@PRECIO

RETURN