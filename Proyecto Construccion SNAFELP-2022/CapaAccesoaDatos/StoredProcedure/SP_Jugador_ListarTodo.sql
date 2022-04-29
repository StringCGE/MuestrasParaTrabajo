Alter PROCEDURE SP_Jugador_ListarTodo
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION
            SELECT id_persona, nombres, apellidos, cedula, fechanacimiento, telefono, nacionalidad, foto, numero, id_equipo From Jugador WHERE eliminado = 0;
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
    END CATCH
END;