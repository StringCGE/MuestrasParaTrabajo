CREATE PROCEDURE SP_Fecha_Insertar
    @id_campeonato INT,
    @nombre VARCHAR (100),
    @partidos INT,
    @numero_fecha INT,
    @fechainicio DATETIME,
    @fechafin DATETIME
AS
BEGIN
    BEGIN TRY
        DECLARE @tbl TABLE (ID INT);
        BEGIN TRANSACTION
            INSERT INTO Fecha (id_campeonato, nombre, partidos, numero_fecha, fechainicio, fechafin)
                        OUTPUT inserted.id_fecha INTO @tbl(ID) 
                        VALUES(@id_campeonato, @nombre, @partidos, @numero_fecha, @fechainicio, @fechafin);
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