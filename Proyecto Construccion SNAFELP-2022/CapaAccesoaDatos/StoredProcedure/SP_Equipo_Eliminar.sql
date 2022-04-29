CREATE PROCEDURE SP_Equipo_Eliminar
@id_equipo int
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION
            Delete from Equipo where id_equipo = @id_equipo
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
    END CATCH
END;