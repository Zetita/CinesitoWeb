USE CineFrenz
GO

CREATE PROCEDURE spActualizarSucursal(
@ID_SUCURSAL char(6),
@NOMBRE varchar(20),
@DIRECCION varchar(60),
@LOCALIDAD varchar(40),
@PROVINCIA varchar(40),
@DIRECCIONURL text
)
AS

UPDATE Sucursales
SET 
Nombre_Sucursal=@NOMBRE,
Direccion_Sucursal=@DIRECCION,
Localidad_Sucursal=@LOCALIDAD,
Provincia_Sucursal=@PROVINCIA,
DireccionURL=@DIRECCIONURL
WHERE ID_Sucursal=@ID_SUCURSAL

RETURN