Alter PROCEDURE SP_Administrador_Psw_By_User
@user VARCHAR (100),
@psw VARCHAR (100)
AS
BEGIN
    BEGIN TRY
		DECLARE @id INT;
		Declare @ret INT;
		DECLARE @tbl_1 TABLE (RET INT);
		DECLARE @tbl_2 TABLE (RET INT);
        BEGIN TRANSACTION
            Insert Into @tbl_1 SELECT id_persona From Administrador WHERE usuario = @user;
			Set @id = (Select RET FROM @tbl_1);
			Insert Into @tbl_2 SELECT COUNT(id_persona) From Administrador WHERE eliminado = 0 And id_persona = @id And psw = @psw;
			Set @ret = (Select RET FROM @tbl_2);
        COMMIT TRANSACTION
		Return @ret;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
    END CATCH
END;