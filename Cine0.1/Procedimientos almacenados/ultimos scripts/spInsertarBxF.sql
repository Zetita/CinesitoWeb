USE CineFrenz
GO

CREATE PROCEDURE spInsertarBxF
(
@ID_BUTACA char(6),
@ID_FUNCION char(6),
@FILA varchar(20),
@BUTACA varchar(20)
)
AS
INSERT INTO ButacaXFunciones
(
ID_Butaca,
ID_Funcion,
Fila_Butaca,
Butaca
)
SELECT
@ID_BUTACA,
@ID_FUNCION,
@FILA,
@BUTACA
RETURN