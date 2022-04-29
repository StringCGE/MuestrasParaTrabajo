create PROCEDURE SP_Campeonato_Insertar
    @nombre_campeonado VARCHAR (100)
AS
BEGIN
    BEGIN TRY
        DECLARE @tbl TABLE (ID INT);
        BEGIN TRANSACTION
            INSERT INTO Campeonato (nombre_campeonado)
                        OUTPUT inserted.id_campeonato INTO @tbl(ID) 
                        VALUES(@nombre_campeonado);
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