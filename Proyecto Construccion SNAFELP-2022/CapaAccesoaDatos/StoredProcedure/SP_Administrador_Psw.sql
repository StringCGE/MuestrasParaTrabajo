Alter PROCEDURE SP_Administrador_Psw
@id_persona INT,
@psw VARCHAR (100)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION
			DECLARE @tbl TABLE (RET INT);
            Insert Into @tbl SELECT COUNT(id_persona) From Administrador WHERE eliminado = 0 And id_persona = @id_persona And psw = @psw;
        COMMIT TRANSACTION
		Select RET FROM @tbl;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
    END CATCH
END;