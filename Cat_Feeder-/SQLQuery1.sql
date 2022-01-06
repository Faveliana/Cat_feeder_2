
GO
CREATE PROCEDURE SP_Authorize @login NVARCHAR(MAX), @password NVARCHAR(MAX)
AS
BEGIN
	DECLARE @id INT
	SELECT @id=[ID USERS] FROM Users WHERE [login]=@login AND [password]=@password
	IF @id IS NOT NULL
		RETURN @id
	ELSE
		RETURN -1
END