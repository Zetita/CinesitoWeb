USE CineFrenz
GO

CREATE PROCEDURE spInsertarSnack
(
@ID_SNACK char(10),
@NOMBRE char(30),
@TIPO char(20),
@PRECIO smallmoney,
@IMAGENURL text,
@ESTADO bit
)
AS
INSERT INTO Snacks
(
ID_Snack,
Nombre_Snack,
Tipo_Snack,
Precio_Snack,
URLImagen_Snack,
Estado_Snack
)
VALUES
(
@ID_SNACK,
@NOMBRE,
@TIPO,
@PRECIO,
@IMAGENURL,
@ESTADO
)
RETURN