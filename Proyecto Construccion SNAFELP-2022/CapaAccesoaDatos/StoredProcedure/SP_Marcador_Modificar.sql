CREATE PROCEDURE SP_Marcador_Modificar
    @id_marcador INT,
    @goleaequipoa SMALLINT,
    @golesequipob SMALLINT
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION
            UPDATE Marcador SET goleaequipoa = @goleaequipoa, golesequipob = @golesequipob WHERE id_marcador = @id_marcador
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
    END CATCH
END;