Alter PROCEDURE SP_Fecha_BuscarPorID
@id_fecha int
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION
            SELECT id_fecha, id_campeonato, nombre, numero_fecha, fechainicio, fechafin From Fecha WHERE eliminado = 0 And id_fecha = @id_fecha;
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
    END CATCH
END;