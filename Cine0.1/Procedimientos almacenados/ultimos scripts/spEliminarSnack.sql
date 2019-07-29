USE CineFrenz
go

CREATE PROCEDURE spEliminarSnack
(
@ID_SNACK char(6),
@ESTADO bit
)
AS 
UPDATE Snacks
SET Estado_Snack=@ESTADO
WHERE ID_Snack=@ID_SNACK

RETURN