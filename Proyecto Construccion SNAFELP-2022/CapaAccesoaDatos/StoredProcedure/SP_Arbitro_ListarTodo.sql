Alter PROCEDURE SP_Arbitro_ListarTodo
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION
            SELECT usuario, psw, puesto, id_persona, nombres, apellidos, cedula, fechanacimiento, telefono, nacionalidad, foto, licencia From Arbitro WHERE eliminado = 0;
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
    END CATCH
END;