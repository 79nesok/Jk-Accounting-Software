IF OBJECT_ID('uspAddSystemCategory') IS NOT NULL
	DROP PROCEDURE uspAddSystemCategory
GO

CREATE PROCEDURE uspAddSystemCategory(@Name AS VARCHAR(50), @Index AS INT)
AS
SET NOCOUNT ON

IF NOT EXISTS(SELECT * FROM tblSystemCategories WHERE Name = @Name)
	INSERT INTO tblSystemCategories(Name, [Index])
	SELECT @Name, @Index
GO

