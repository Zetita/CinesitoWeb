USE CineFrenz
GO

CREATE PROCEDURE spInsertarDetalleVenta
(
@ID_VENTA char(10),
@ID_FUNCION char(10),
@ID_BUTACA char(10),
@FILA_BUTACA char(20),
@BUTACA char(20),
@BEN_MENOROMAYOR bit,
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
Ben_MenorOMayor,
PrecioEntrada
)
VALUES
(
@ID_VENTA,
@ID_FUNCION,
@ID_BUTACA,
@FILA_BUTACA,
@BUTACA,
@BEN_MENOROMAYOR,
@PRECIO
)
RETURN