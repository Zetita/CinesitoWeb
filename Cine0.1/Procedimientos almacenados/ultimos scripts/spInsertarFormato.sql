USE CineFrenz
GO

CREATE PROCEDURE spInsertarFormato
(
@ID_FORMATO char(6),
@NOMBRE varchar(20),
@IDIOMA varchar(40),
@SUBTITULOS bit,
@PRECIO float
)
AS
INSERT INTO Formatos
(
ID_Formato,
Nombre_Formato,
Idioma_Formato,
Subtitulos_Formato,
Precio_Formato
)
SELECT
@ID_FORMATO,
@NOMBRE,
@IDIOMA,
@SUBTITULOS,
@PRECIO
RETURN