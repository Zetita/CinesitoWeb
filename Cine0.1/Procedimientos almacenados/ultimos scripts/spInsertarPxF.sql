USE CineFrenz
GO

CREATE PROCEDURE spInsertarPXF
(
@ID_PELICULA char(6),
@ID_FORMATO char(6)
)
AS
INSERT INTO PeliculasXFormatos
(
ID_Pelicula,
ID_Formato
)
SELECT
@ID_PELICULA,
@ID_FORMATO
RETURN