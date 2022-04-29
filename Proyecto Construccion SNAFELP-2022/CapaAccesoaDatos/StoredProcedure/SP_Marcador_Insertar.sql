Alter PROCEDURE SP_Marcador_Insertar
    @goleaequipoa SMALLINT,
    @golesequipob SMALLINT
AS
BEGIN
    BEGIN TRY
        DECLARE @tbl TABLE (ID INT);
        BEGIN TRANSACTION
            INSERT INTO Marcador (goleaequipoa, golesequipob)
                        OUTPUT inserted.id_marcador INTO @tbl(ID) 
                        VALUES(@goleaequipoa, @golesequipob);
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