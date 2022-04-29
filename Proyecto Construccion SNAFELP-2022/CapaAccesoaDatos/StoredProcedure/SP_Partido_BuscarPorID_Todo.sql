Alter PROCEDURE SP_Partido_BuscarPorID_Todo
@id_partido int
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION
            SELECT * From Partido WHERE eliminado = 0 And id_partido = @id_partido;
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
    END CATCH
END;