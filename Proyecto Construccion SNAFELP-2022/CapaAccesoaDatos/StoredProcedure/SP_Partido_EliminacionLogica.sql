CREATE PROCEDURE SP_Partido_EliminacionLogica
@id_partido int
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION
            UPDATE Partido SET eliminado = 1 WHERE id_partido = @id_partido
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
    END CATCH
END;