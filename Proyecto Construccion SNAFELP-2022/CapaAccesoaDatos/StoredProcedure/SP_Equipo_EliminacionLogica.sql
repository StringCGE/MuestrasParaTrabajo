CREATE PROCEDURE SP_Equipo_EliminacionLogica
@id_equipo int
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION
            UPDATE Equipo SET eliminado = 1 WHERE id_equipo = @id_equipo
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
    END CATCH
END;