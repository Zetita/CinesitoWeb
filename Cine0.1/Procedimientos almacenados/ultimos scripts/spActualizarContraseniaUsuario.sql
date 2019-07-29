USE CineFrenz
GO

CREATE PROCEDURE spActualizarContraseniaUsuario
(
@USUARIO varchar(40),
@CONTRASENIA varchar(16)
)
AS
UPDATE Usuarios
SET Contrasenia=@CONTRASENIA
WHERE Usuario=@USUARIO
RETURN
