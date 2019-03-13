IF OBJECT_ID('uspAddSystemSubCategory') IS NOT NULL
	DROP PROCEDURE uspAddSystemSubCategory
GO

CREATE PROCEDURE uspAddSystemSubCategory(@Category AS VARCHAR(100), @Parent AS VARCHAR(100), @Name AS VARCHAR(100), @ListForm VARCHAR(100) = NULL, @MasterForm VARCHAR(100) = NULL, @Index AS INT)
AS
SET NOCOUNT ON

DECLARE @CategoryId INT
DECLARE @Structure VARCHAR(500)

SELECT @CategoryId = Id
FROM tblSystemCategories
WHERE Name = @Category

IF @CategoryId IS NULL
	RAISERROR('Error on adding Subcategory: %s. No Category found named: %s', 16, 1, @Name, @Category)

SET @Structure = @Category + '.' + CASE WHEN NULLIF(@Parent, '') IS NULL THEN '' ELSE @Parent + '.' END + @Name

IF NOT EXISTS(SELECT * FROM tblSystemSubCategories WHERE Name = @Name AND CategoryId = @CategoryId)
	INSERT INTO tblSystemSubCategories(CategoryId, Parent, Structure, Name, ListForm, MasterForm,[Index])
	SELECT @CategoryId, @Parent, @Structure, @Name, @ListForm, @MasterForm, @Index
ELSE
	UPDATE tblSystemSubCategories
	SET ListForm = @ListForm,
		MasterForm = @MasterForm,
		[Index] = @Index
	WHERE Name = @Name
		AND CategoryId = @CategoryId
GO

