Alter PROCEDURE SP_Partido_BuscarPorID_Fecha
@id_fecha int
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION
            SELECT * From Partido WHERE eliminado = 0 And id_fecha = @id_fecha;
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
    END CATCH
END;