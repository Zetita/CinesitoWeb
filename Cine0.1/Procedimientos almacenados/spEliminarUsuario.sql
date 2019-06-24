USE CineFrenz
go

CREATE PROCEDURE spEliminarUsuario
(
@USUARIO char(40),
@ACTIVO bit
)
AS 
UPDATE Usuarios
SET Activo=@ACTIVO
WHERE Usuario=@USUARIO

RETURN