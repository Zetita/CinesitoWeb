USE CineFrenz
GO

CREATE PROCEDURE spInsertarFuncion
(
@ID_FUNCION char(10),
@ID_PXF char(10),
@ID_SALA char(10),
@ID_SUCURSAL char(10),
@FECHA_HORA datetime
)
AS
INSERT INTO Funciones
(
ID_Funcion,
ID_PxF,
ID_Sala,
ID_Sucursal,
FechaHora_Funcion
)
VALUES
(
@ID_FUNCION,
@ID_PXF,
@ID_SALA,
@ID_SUCURSAL,
@FECHA_HORA
)

RETURN