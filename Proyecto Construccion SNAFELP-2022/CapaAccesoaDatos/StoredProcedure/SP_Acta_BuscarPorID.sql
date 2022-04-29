Alter PROCEDURE SP_Acta_BuscarPorID
@id_acta int
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION
            SELECT id_acta, nombre From Acta WHERE eliminado = 0 And id_acta = @id_acta;
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
    END CATCH
END;