CREATE PROCEDURE SP_Partido_Eliminar
@id_partido int
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION
            Delete from Partido where id_partido = @id_partido
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
    END CATCH
END;