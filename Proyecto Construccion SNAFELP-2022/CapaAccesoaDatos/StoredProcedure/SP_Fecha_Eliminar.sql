CREATE PROCEDURE SP_Fecha_Eliminar
@id_fecha int
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION
            Delete from Fecha where id_fecha = @id_fecha
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
    END CATCH
END;