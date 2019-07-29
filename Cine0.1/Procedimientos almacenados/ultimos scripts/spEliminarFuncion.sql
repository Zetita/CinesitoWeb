USE CineFrenz
go

CREATE PROCEDURE spEliminarFuncion
(
@ID_FUNCION varchar(40),
@ESTADO bit
)
AS 
UPDATE Funciones
SET Estado=@ESTADO
WHERE ID_Funcion=@ID_FUNCION

RETURN