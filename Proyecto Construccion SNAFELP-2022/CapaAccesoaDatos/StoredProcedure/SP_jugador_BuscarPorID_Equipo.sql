Alter PROCEDURE SP_Jugador_BuscarPorID_Equipo
@id_equipo int
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION
            SELECT id_persona, nombres, apellidos, cedula, fechanacimiento, telefono, nacionalidad, foto, numero, id_equipo From Jugador WHERE eliminado = 0 And id_equipo = @id_equipo;
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
    END CATCH
END;