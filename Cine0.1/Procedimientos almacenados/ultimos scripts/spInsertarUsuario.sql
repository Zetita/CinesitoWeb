USE CineFrenz
GO

CREATE PROCEDURE spInsertarUsuario
(
@USUARIO varchar(40),
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
INSERT INTO Usuarios
(
Usuario,
Contrasenia,
Email_Usuario,
Apellidos_Usuario,
Nombres_Usuario,
DNI_Usuario,
Telefono_Usuario,
FechaNac_Usuario,
Administrador,
Activo
)
SELECT
@USUARIO,
@CONTRASENIA,
@EMAIL,
@APELLIDOS,
@NOMBRES,
@DNI,
@TELEFONO,
@FECHANAC,
@ADMINISTRADOR,
@ACTIVO
RETURN
