USE CineFrenz
GO

CREATE PROCEDURE spInsertarPelicula
(
@ID_PELICULA char(6),
@TITULO varchar(40),
@GENERO text,
@CLASIFICACION varchar(10),
@FECHAESTRENO date,
@DIRECTOR varchar(40),
@SINOPSIS text,
@IMAGENURL text,
@DURACION time(7),
@TRAILERURL text,
@ESTADO bit
)
AS
INSERT INTO Peliculas
(
Titulo_Pelicula,
Genero_Pelicula,
Clasificacion_Pelicula,
FechaEstreno_Pelicula,
Director_Pelicula,
Sinopsis_Pelicula,
ImagenURL,
Duracion,
TrailerURL,
Estado
)
SELECT
@TITULO,
@GENERO,
@CLASIFICACION,
@FECHAESTRENO,
@DIRECTOR,
@SINOPSIS,
@IMAGENURL,
@DURACION,
@TRAILERURL,
@ESTADO
RETURN
