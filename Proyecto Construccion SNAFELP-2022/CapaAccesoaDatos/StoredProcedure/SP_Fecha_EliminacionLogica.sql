CREATE PROCEDURE SP_Fecha_EliminacionLogica
@id_fecha int
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION
            UPDATE Fecha SET eliminado = 1 WHERE id_fecha = @id_fecha
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
    END CATCH
END;