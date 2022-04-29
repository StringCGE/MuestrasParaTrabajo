Alter PROCEDURE SP_Equipo_BuscarPorID
@id_equipo int
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION
            SELECT id_equipo, nombre, escudo From Equipo WHERE eliminado = 0 And id_equipo = @id_equipo;
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
    END CATCH
END;