CREATE PROCEDURE SP_Acta_ListarTodo
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION
            SELECT id_acta, nombre From Acta WHERE eliminado = 0;
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
    END CATCH
END;