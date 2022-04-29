CREATE PROCEDURE SP_Jugador_Eliminar
@id_persona int
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION
            Delete from Jugador where id_persona = @id_persona
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
    END CATCH
END;