USE CineFrenz
GO

CREATE PROCEDURE spInsertarSala
(
@ID_SALA char(10),
@ID_SUCURSAL char(10),
@SALA char(20),
@BUTACAS Int
)
AS
INSERT INTO Salas
(
ID_Sala,
ID_Sucursal,
Sala,
Butacas_Sala
)
VALUES
(
@ID_SALA,
@ID_SUCURSAL,
@SALA,
@BUTACAS
)
RETURN