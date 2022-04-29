CREATE PROCEDURE SP_Persona_Modificar
    @id_persona INT,
    @nombres VARCHAR (100),
    @apellidos VARCHAR (100),
    @cedula VARCHAR (100),
    @fechanacimiento DATETIME,
    @telefono VARCHAR (100),
    @nacionalidad VARCHAR (100),
    @foto IMAGE
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION
            UPDATE Persona SET nombres = @nombres, apellidos = @apellidos, cedula = @cedula, fechanacimiento = @fechanacimiento, telefono = @telefono, nacionalidad = @nacionalidad, foto = @foto WHERE id_persona = @id_persona
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
    END CATCH
END;