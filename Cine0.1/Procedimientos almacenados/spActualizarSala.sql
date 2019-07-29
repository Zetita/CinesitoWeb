USE CineFrenz
go
create procedure spActualizarSala
(
@ID_Sala char(6),
@ID_Sucursal char(6),
@SALA varchar(20),
@BUTACAS int
)
AS
UPDATE Salas
SET
ID_Sucursal=@ID_Sucursal,
Sala=@SALA,
Butacas_Sala=@BUTACAS
WHERE ID_Sala=@ID_Sala
RETURN
go
