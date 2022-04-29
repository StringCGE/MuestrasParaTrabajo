CREATE PROCEDURE SP_Persona_EliminacionLogica
@id_persona int
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION
            UPDATE Persona SET eliminado = 1 WHERE id_persona = @id_persona
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
    END CATCH
END;