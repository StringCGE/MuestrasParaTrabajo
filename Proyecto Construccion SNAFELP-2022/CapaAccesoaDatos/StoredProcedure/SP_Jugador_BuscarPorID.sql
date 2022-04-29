Alter PROCEDURE SP_Jugador_BuscarPorID
@id_persona int
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION
            SELECT id_persona, nombres, apellidos, cedula, fechanacimiento, telefono, nacionalidad, foto, numero, id_equipo From Jugador WHERE eliminado = 0 And id_persona = @id_persona;
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
    END CATCH
END;