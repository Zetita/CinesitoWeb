USE CineFrenz
GO

CREATE PROCEDURE spActualizarUsuario
(
@USUARIO char(40),
@CONTRASENIA varchar(16),
@EMAIL varchar(40),
@APELLIDOS varchar(40),
@NOMBRES varchar(40),
@DNI varchar(8),
@TELEFONO varchar(15),
@FECHANAC date,
@ADMINISTRADOR bit,
@ACTIVO bit
)
AS
UPDATE Usuarios
SET
Contrasenia=@CONTRASENIA,
Email_Usuario=@EMAIL,
Apellidos_Usuario=@APELLIDOS,
Nombres_Usuario=@NOMBRES,
DNI_Usuario=@DNI,
Telefono_Usuario=@TELEFONO,
FechaNac_Usuario=@FECHANAC,
Administrador=@ADMINISTRADOR
WHERE Usuario=@USUARIO
RETURN
