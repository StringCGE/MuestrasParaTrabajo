CREATE PROCEDURE SP_Arbitro_Insertar
    @usuario VARCHAR (100),
    @psw VARCHAR (100),
    @puesto VARCHAR (100),
    @nombres VARCHAR (100),
    @apellidos VARCHAR (100),
    @cedula VARCHAR (100),
    @fechanacimiento DATETIME,
    @telefono VARCHAR (100),
    @nacionalidad VARCHAR (100),
    @foto IMAGE,
    @licencia VARCHAR (100)
AS
BEGIN
    BEGIN TRY
        DECLARE @tbl TABLE (ID INT);
        BEGIN TRANSACTION
            INSERT INTO Arbitro (usuario, psw, puesto, nombres, apellidos, cedula, fechanacimiento, telefono, nacionalidad, foto, licencia)
                        OUTPUT inserted.id_persona INTO @tbl(ID) 
                        VALUES(@usuario, @psw, @puesto, @nombres, @apellidos, @cedula, @fechanacimiento, @telefono, @nacionalidad, @foto, @licencia);
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