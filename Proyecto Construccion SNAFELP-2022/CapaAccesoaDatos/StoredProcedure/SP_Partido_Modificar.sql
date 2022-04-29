CREATE PROCEDURE SP_Partido_Modificar
    @id_partido INT,
    @id_fecha INT,
    @nombre VARCHAR (100),
    @equipo_a INT,
    @equipo_b INT,
    @marcador_partido INT,
    @arbitroprincipal INT
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION
            UPDATE Partido SET id_fecha = @id_fecha, nombre = @nombre, equipo_a = @equipo_a, equipo_b = @equipo_b, marcador_partido = @marcador_partido, arbitroprincipal = @arbitroprincipal WHERE id_partido = @id_partido
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
    END CATCH
END;