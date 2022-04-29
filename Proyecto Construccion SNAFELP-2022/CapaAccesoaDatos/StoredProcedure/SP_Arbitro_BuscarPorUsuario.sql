Alter PROCEDURE SP_Arbitro_BuscarPorUsuario
@usuario VARCHAR (100)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION
            SELECT usuario, psw, puesto, id_persona, nombres, apellidos, cedula, fechanacimiento, telefono, nacionalidad, foto, licencia From Arbitro WHERE eliminado = 0 And usuario = @usuario;
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
    END CATCH
END;