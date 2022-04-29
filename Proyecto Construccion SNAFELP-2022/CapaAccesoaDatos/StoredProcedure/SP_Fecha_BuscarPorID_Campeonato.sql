Alter PROCEDURE SP_Fecha_BuscarPorID_Campeonato
@id_campeonato int
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION
            SELECT id_fecha, id_campeonato, nombre, numero_fecha, fechainicio, fechafin From Fecha WHERE eliminado = 0 And id_campeonato = @id_campeonato;
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
    END CATCH
END;