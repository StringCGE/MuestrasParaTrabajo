Alter PROCEDURE SP_Marcador_BuscarPorID
@id_marcador int
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION
            SELECT id_marcador, goleaequipoa, golesequipob From Marcador WHERE eliminado = 0 And id_marcador = @id_marcador;
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
    END CATCH
END;