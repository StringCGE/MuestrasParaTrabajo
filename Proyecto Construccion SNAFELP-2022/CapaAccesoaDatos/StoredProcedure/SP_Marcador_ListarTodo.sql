Alter PROCEDURE SP_Marcador_ListarTodo
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION
            SELECT id_marcador, goleaequipoa, golesequipob From Marcador WHERE eliminado = 0;
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
    END CATCH
END;