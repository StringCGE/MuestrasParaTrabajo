CREATE PROCEDURE SP_Acta_Insertar
    @nombre VARCHAR (100),
    @fecha INT,
    @partido INT,
    @marcador_acta INT,
    @equipoa_acta INT,
    @equipob_acta INT
AS
BEGIN
    BEGIN TRY
        DECLARE @tbl TABLE (ID INT);
        BEGIN TRANSACTION
            INSERT INTO Acta (nombre, fecha, partido, marcador_acta, equipoa_acta, equipob_acta, eliminado)
                        OUTPUT inserted.id_acta INTO @tbl(ID) 
                        VALUES(@nombre, @fecha, @partido, @marcador_acta, @equipoa_acta, @equipob_acta, 0);
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