USE CineFrenz
GO

CREATE PROCEDURE spActualizarSnack
(
@ID_SNACK char(10),
@NOMBRE char(30),
@TIPO char(20),
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
WHERE ID_Snack=@ID_SNACK

RETURN