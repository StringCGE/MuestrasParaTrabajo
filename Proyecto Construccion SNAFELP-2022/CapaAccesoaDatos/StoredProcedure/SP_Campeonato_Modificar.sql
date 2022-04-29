CREATE PROCEDURE SP_Campeonato_Modificar
    @id_campeonato INT,
    @nombre_campeonado VARCHAR (100)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION
            UPDATE Campeonato SET nombre_campeonado = @nombre_campeonado WHERE id_campeonato = @id_campeonato
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
    END CATCH
END;