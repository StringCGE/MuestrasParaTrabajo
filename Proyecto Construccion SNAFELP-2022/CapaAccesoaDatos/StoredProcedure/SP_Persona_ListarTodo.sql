CREATE PROCEDURE SP_Persona_ListarTodo
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION
            SELECT id_persona, nombres, apellidos, cedula, fechanacimiento, telefono, nacionalidad, foto From Persona WHERE eliminado = 0;
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
    END CATCH
END;