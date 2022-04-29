Alter PROCEDURE SP_Fecha_Modificar
    @id_fecha INT,
    @id_campeonato INT,
    @nombre VARCHAR (100),
    @numero_fecha INT,
    @fechainicio DATETIME,
    @fechafin DATETIME
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION
            UPDATE Fecha SET id_campeonato = @id_campeonato, nombre = @nombre, numero_fecha = @numero_fecha, fechainicio = @fechainicio, fechafin = @fechafin WHERE id_fecha = @id_fecha
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
    END CATCH
END;