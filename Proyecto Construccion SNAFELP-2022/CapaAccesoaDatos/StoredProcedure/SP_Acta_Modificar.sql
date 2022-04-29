CREATE PROCEDURE SP_Acta_Modificar
    @id_acta INT,
    @nombre VARCHAR (100),
    @fecha INT,
    @partido INT,
    @marcador_acta INT,
    @equipoa_acta INT,
    @equipob_acta INT
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION
            UPDATE Acta SET nombre = @nombre, fecha = @fecha, partido = @partido, marcador_acta = @marcador_acta, equipoa_acta = @equipoa_acta, equipob_acta = @equipob_acta WHERE id_acta = @id_acta
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
    END CATCH
END;