CREATE PROCEDURE SP_Administrador_Modificar
    @id_persona INT,
    @nombres VARCHAR (100),
    @apellidos VARCHAR (100),
    @cedula VARCHAR (100),
    @fechanacimiento DATETIME,
    @telefono VARCHAR (100),
    @nacionalidad VARCHAR (100),
    @foto IMAGE,
    @usuario VARCHAR (100),
    @psw VARCHAR (100),
    @puesto VARCHAR (100)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION
            UPDATE Administrador SET nombres = @nombres, apellidos = @apellidos, cedula = @cedula, fechanacimiento = @fechanacimiento, telefono = @telefono, nacionalidad = @nacionalidad, foto = @foto, usuario = @usuario, psw = @psw, puesto = @puesto WHERE id_persona = @id_persona
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
    END CATCH
END;