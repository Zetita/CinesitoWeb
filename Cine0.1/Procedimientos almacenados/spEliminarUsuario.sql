USE CineFrenz
go

CREATE PROCEDURE spEliminarUsuario
(
@ID int,
@ACTIVO bit
)
AS 
UPDATE Usuarios
SET Activo=@ACTIVO
WHERE ID_Usuario=@ID

RETURN