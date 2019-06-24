USE CineFrenz
GO

CREATE PROCEDURE spInsertarBxF
(
@ID_BUTACA char(10),
@ID_FUNCION char(10),
@FILA char(20),
@BUTACA char(20)
)
AS
INSERT INTO ButacaXFunciones
(
ID_Butaca,
ID_Funcion,
Fila_Butaca,
Butaca
)
VALUES
(
@ID_BUTACA,
@ID_FUNCION,
@FILA,
@BUTACA
)
RETURN