USE CineFrenz
GO

CREATE PROCEDURE spInsertarPXF
(
@ID_PXF char(10),
@ID_PELICULA char(10),
@ID_FORMATO char(10)

)
AS
INSERT INTO PeliculasXFormatos
(
ID_PxF,
ID_Pelicula,
ID_Formato
)
VALUES
(
@ID_PXF,
@ID_PELICULA,
@ID_FORMATO
)
RETURN