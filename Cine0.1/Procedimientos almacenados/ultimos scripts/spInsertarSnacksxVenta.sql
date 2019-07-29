USE CineFrenz
GO

CREATE PROCEDURE spInsertarSnacksxVenta
(
@ID_VENTA char(6),
@ID_SNACK char(6),
@NOMBRE varchar(30),
@PRECIO smallmoney,
@CANTIDAD int
)
AS
INSERT INTO SnacksXVentas
(
ID_Venta,
ID_Snack,
Nombre_Snack,
Precio_Snack,
Cantidad_Snack
)
SELECT
@ID_VENTA,
@ID_SNACK,
@NOMBRE,
@PRECIO,
@CANTIDAD
RETURN