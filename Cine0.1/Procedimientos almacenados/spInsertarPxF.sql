USE CineFrenz
GO

CREATE PROCEDURE spInsertarPXF
(
@ID_PXF char(6),
@ID_PELICULA char(6),
@ID_FORMATO char(6)
)
AS
INSERT INTO PeliculasXFormatos
(
ID_PxF,
ID_Pelicula,
ID_Formato
)
SELECT
@ID_PXF,
@ID_PELICULA,
@ID_FORMATO
RETURN