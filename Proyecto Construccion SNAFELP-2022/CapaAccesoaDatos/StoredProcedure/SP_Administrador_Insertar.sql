CREATE PROCEDURE SP_Administrador_Insertar
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
        DECLARE @tbl TABLE (ID INT);
        BEGIN TRANSACTION
            INSERT INTO Administrador (nombres, apellidos, cedula, fechanacimiento, telefono, nacionalidad, foto, usuario, psw, puesto)
                        OUTPUT inserted.id_persona INTO @tbl(ID) 
                        VALUES(@nombres, @apellidos, @cedula, @fechanacimiento, @telefono, @nacionalidad, @foto, @usuario, @psw, @puesto);
        COMMIT TRANSACTION
        Declare @id int;
        Set @id = (Select ID FROM @tbl);
        /*
        * @@IDENTITY
        * SCOPE_IDENTITY()
        * IDENT_CURRENT('nombre_tabla')
        * OUTPUT de la orden INSERT
        */
        Return @id;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
    END CATCH
END;