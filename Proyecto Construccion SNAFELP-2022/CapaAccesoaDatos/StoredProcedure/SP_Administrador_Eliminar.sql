CREATE PROCEDURE SP_Administrador_Eliminar
@id_persona int
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION
            Delete from Administrador where id_persona = @id_persona
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
    END CATCH
END;