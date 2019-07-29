USE CineFrenz
go
create procedure spActualizarFuncion
(
@ID_Funcion char(6),
@ID_Pelicula char(6),
@ID_Formato char(6),
@ID_Sala char(6),
@ID_Sucursal char(6),
@FECHA_HORA datetime
)
as
update Funciones
set

ID_Pelicula = @ID_Pelicula,
ID_Formato = @ID_Formato,
ID_Sala = @ID_Sala,
ID_Sucursal = @ID_Sucursal,
FechaHora_Funcion= @FECHA_HORA
Where ID_Funcion = @ID_Funcion
return
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

create procedure 