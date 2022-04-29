CREATE PROCEDURE SP_Marcador_EliminacionLogica
@id_marcador int
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION
            UPDATE Marcador SET eliminado = 1 WHERE id_marcador = @id_marcador
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
    END CATCH
END;