USE CineFrenz
GO

CREATE PROCEDURE spActualizarSala(
@ID_SALA char(6),
@ID_SUCURSAL char(6),
@SALA varchar(20),
@BUTACAS int
)
AS

UPDATE Salas
SET
Sala=@SALA,
Butacas_Sala=@BUTACAS
WHERE ID_Sala=@ID_SALA and ID_Sucursal=@ID_SUCURSAL

RETURN