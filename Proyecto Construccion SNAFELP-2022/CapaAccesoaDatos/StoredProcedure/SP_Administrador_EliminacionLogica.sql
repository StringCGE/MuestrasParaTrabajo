CREATE PROCEDURE SP_Administrador_EliminacionLogica
@id_persona int
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION
            UPDATE Administrador SET eliminado = 1 WHERE id_persona = @id_persona
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
    END CATCH
END;