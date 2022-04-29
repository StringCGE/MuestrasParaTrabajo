CREATE PROCEDURE SP_Campeonato_Eliminar
@id_campeonato int
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION
            Delete from Campeonato where id_campeonato = @id_campeonato
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
    END CATCH
END;