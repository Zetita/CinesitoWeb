USE CineFrenz
GO

CREATE PROCEDURE spInsertarSucursales
(
@ID_SUCURSAL char(10),
@NOMBRE char(20),
@DIRECCION char(60),
@LOCALIDAD char(40),
@PROVINCIA char(40),
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
VALUES
(
@ID_SUCURSAL,
@NOMBRE,
@DIRECCION,
@LOCALIDAD,
@PROVINCIA,
@DIRECCIONURL
)
RETURN