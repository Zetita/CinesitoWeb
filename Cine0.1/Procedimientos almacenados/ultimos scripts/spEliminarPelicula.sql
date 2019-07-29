USE CineFrenz
go

CREATE PROCEDURE spEliminarPelicula
(
@ID_PELICULA char(6),
@ESTADO bit
)
AS 
UPDATE Peliculas
SET Estado=@ESTADO
WHERE ID_Pelicula=@ID_PELICULA

RETURN