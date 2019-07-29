USE CineFrenz
GO

CREATE PROCEDURE spActualizarSnack
(
@ID_SNACK char(6),
@NOMBRE varchar(30),
@TIPO varchar(20),
@PRECIO smallmoney,
@IMAGENURL text,
@ESTADO bit
)
AS

UPDATE Snacks
SET
Nombre_Snack=@NOMBRE,
Tipo_Snack=@TIPO,
Precio_Snack=@PRECIO,
Estado_Snack=@ESTADO
URLImagen_Snack = @IMAGENURL
WHERE ID_Snack=@ID_SNACK

RETURN
