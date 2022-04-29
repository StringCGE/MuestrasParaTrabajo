CREATE PROCEDURE SP_Arbitro_Eliminar
@id_persona int
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION
            Delete from Arbitro where id_persona = @id_persona
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
    END CATCH
END;