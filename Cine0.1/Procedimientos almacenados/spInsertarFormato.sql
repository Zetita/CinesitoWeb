USE CineFrenz
GO

CREATE PROCEDURE spInsertarFormato
(
@ID_FORMATO char(10),
@NOMBRE char(20),
@IDIOMA char(40),
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
VALUES
(
@ID_FORMATO,
@NOMBRE,
@IDIOMA,
@SUBTITULOS,
@PRECIO
)
RETURN