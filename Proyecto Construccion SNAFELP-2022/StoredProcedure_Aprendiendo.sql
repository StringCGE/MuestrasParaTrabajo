

ALTER PROCEDURE probando
	@valorA int,
	@valorB int
AS
BEGIN
    SELECT 
        @valorA + @valorB;
	declare @retorna int;
    SET @retorna = @valorA + @valorB;
	Return @retorna;
END;