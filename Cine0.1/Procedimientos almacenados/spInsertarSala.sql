USE CineFrenz
GO

CREATE PROCEDURE spInsertarSala
(
@ID_SALA char(6),
@ID_SUCURSAL char(6),
@SALA varchar(20),
@BUTACAS int
)
AS
INSERT INTO Salas
(
ID_Sala,
ID_Sucursal,
Sala,
Butacas_Sala
)
SELECT
@ID_SALA,
@ID_SUCURSAL,
@SALA,
@BUTACAS
RETURN