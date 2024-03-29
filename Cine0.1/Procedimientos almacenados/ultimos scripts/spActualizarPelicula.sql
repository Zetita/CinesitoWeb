USE [CineFrenz]
GO

CREATE PROCEDURE spActualizarPelicula
(
@ID_PELICULA char(6),
@TITULO varchar(40),
@GENERO TEXT,
@CLASIFICACION varchar(10),
@FECHAESTRENO DATE,
@DIRECTOR varchar(40),
@SINOPSIS TEXT,
@IMAGENURL TEXT,
@DURACION TIME(7),
@TRAILERURL TEXT,
@ESTADO bit
)
AS
UPDATE Peliculas
SET
Titulo_Pelicula=@TITULO,
Genero_Pelicula=@GENERO,
Clasificacion_Pelicula=@CLASIFICACION,
FechaEstreno_Pelicula=@FECHAESTRENO,
Director_Pelicula=@DIRECTOR,
Sinopsis_Pelicula=@SINOPSIS,
ImagenURL=@IMAGENURL,
Duracion=@DURACION,
TrailerUrl=@TRAILERURL,
Estado=@ESTADO
WHERE ID_Pelicula=@ID_PELICULA

RETURN