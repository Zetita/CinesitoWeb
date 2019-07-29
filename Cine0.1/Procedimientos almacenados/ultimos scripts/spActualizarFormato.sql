USE CineFrenz
GO

CREATE PROCEDURE spActualizarFormato
(
@ID_FORMATO char(6),
@NOMBRE varchar(20),
@IDIOMA varchar(40),
@SUBTITULOS bit,
@PRECIO float
)
AS
UPDATE Formatos
SET
Nombre_Formato=@NOMBRE,
Idioma_Formato=@IDIOMA,
Subtitulos_Formato=@SUBTITULOS,
Precio_Formato=@PRECIO
WHERE ID_Formato=@ID_FORMATO

RETURN