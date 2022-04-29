CREATE PROCEDURE SP_Equipo_Insertar
    @nombre VARCHAR (100),
    @escudo IMAGE
AS
BEGIN
    BEGIN TRY
        DECLARE @tbl TABLE (ID INT);
        BEGIN TRANSACTION
            INSERT INTO Equipo (nombre, escudo)
                        OUTPUT inserted.id_equipo INTO @tbl(ID) 
                        VALUES(@nombre, @escudo);
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