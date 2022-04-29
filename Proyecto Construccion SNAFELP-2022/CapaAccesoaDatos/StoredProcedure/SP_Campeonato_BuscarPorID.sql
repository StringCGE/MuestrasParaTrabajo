Alter PROCEDURE SP_Campeonato_BuscarPorID
@id_campeonato int
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION
            SELECT id_campeonato, nombre_campeonado From Campeonato WHERE eliminado = 0 And id_campeonato = @id_campeonato;
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
    END CATCH
END;