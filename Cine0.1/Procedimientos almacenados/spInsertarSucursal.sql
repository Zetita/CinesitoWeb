USE CineFrenz
GO

CREATE PROCEDURE spInsertarSucursales
(
@ID_SUCURSAL char(6),
@NOMBRE varchar(20),
@DIRECCION varchar(60),
@LOCALIDAD varchar(40),
@PROVINCIA varchar(40),
@DIRECCIONURL text
)
AS
INSERT INTO Sucursales
(
ID_Sucursal,
Nombre_Sucursal,
Direccion_Sucursal,
Localidad_Sucursal,
Provincia_Sucursal,
DireccionURL
)
SELECT
@ID_SUCURSAL,
@NOMBRE,
@DIRECCION,
@LOCALIDAD,
@PROVINCIA,
@DIRECCIONURL
RETURN