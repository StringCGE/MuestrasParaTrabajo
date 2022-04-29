Alter PROCEDURE SP_Partido_Insertar
    @id_fecha INT,
    @nombre VARCHAR (100),
    @equipo_a INT,
    @equipo_b INT,
    @marcador_partido INT,
    @arbitroprincipal INT
AS
BEGIN
    BEGIN TRY
        DECLARE @tbl TABLE (ID INT);
		DECLARE @idMarcador INT;
        BEGIN TRANSACTION
			EXECUTE @idMarcador = SP_Marcador_Insertar 0, 0;

            INSERT INTO Partido (id_fecha, nombre, equipo_a, equipo_b, marcador_partido, arbitroprincipal)
                        OUTPUT inserted.id_partido INTO @tbl(ID) 
                        VALUES(@id_fecha, @nombre, @equipo_a, @equipo_b, @idMarcador, @arbitroprincipal);
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