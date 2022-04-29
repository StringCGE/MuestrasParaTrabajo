CREATE PROCEDURE SP_Marcador_Eliminar
@id_marcador int
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION
            Delete from Marcador where id_marcador = @id_marcador
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
    END CATCH
END;