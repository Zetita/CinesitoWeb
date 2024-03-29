USE [CineFrenz]
GO

CREATE PROCEDURE spInsertarFuncion
(
@ID_FUNCION char(6),
@ID_PELICULA char(6),
@ID_FORMATO char(6),
@ID_SALA char(6),
@ID_SUCURSAL char(6),
@FECHA_HORA datetime,
@ESTADO bit
)
AS
INSERT INTO Funciones
(
ID_Funcion,
ID_Pelicula,
ID_Formato,
ID_Sala,
ID_Sucursal,
FechaHora_Funcion,
Estado
)
SELECT
@ID_FUNCION,
@ID_PELICULA,
@ID_FORMATO,
@ID_SALA,
@ID_SUCURSAL,
@FECHA_HORA,
@ESTADO
RETURN