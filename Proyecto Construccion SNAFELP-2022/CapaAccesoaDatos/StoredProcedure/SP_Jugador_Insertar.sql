Alter PROCEDURE SP_Jugador_Insertar
    @nombres VARCHAR (100),
    @apellidos VARCHAR (100),
    @cedula VARCHAR (100),
    @fechanacimiento DATETIME,
    @telefono VARCHAR (100),
    @nacionalidad VARCHAR (100),
    @foto IMAGE,
    @numero INT,
    @id_equipo INT
AS
BEGIN
    BEGIN TRY
        DECLARE @tbl TABLE (ID INT);
        BEGIN TRANSACTION
            INSERT INTO Jugador (nombres, apellidos, cedula, fechanacimiento, telefono, nacionalidad, foto, numero, id_equipo)
                        OUTPUT inserted.id_persona INTO @tbl(ID) 
                        VALUES(@nombres, @apellidos, @cedula, @fechanacimiento, @telefono, @nacionalidad, @foto, @numero, @id_equipo);
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