CREATE PROCEDURE SP_Campeonato_EliminacionLogica
@id_campeonato int
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION
            UPDATE Campeonato SET eliminado = 1 WHERE id_campeonato = @id_campeonato
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
    END CATCH
END;