CREATE PROCEDURE SP_Arbitro_EliminacionLogica
@id_persona int
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION
            UPDATE Arbitro SET eliminado = 1 WHERE id_persona = @id_persona
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
    END CATCH
END;