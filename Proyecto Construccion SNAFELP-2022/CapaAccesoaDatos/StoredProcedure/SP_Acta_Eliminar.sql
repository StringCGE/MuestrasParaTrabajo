CREATE PROCEDURE SP_Acta_Eliminar
@id_acta int
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION
            Delete from Acta where id_acta = @id_acta
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
    END CATCH
END;