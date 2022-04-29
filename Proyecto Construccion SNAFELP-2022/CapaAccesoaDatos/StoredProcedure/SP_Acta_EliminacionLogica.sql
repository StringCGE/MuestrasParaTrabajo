CREATE PROCEDURE SP_Acta_EliminacionLogica
@id_acta int
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION
            UPDATE Acta SET eliminado = 1 WHERE id_acta = @id_acta

        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
    END CATCH
END;