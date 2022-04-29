CREATE PROCEDURE SP_Equipo_Modificar
    @id_equipo INT,
    @nombre VARCHAR (100),
    @escudo IMAGE
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION
            UPDATE Equipo SET nombre = @nombre, escudo = @escudo WHERE id_equipo = @id_equipo
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
    END CATCH
END;