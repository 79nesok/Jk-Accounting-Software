IF OBJECT_ID('tblSystemCategories') IS NULL
	CREATE TABLE tblSystemCategories(
		Id INT IDENTITY(1, 1) NOT NULL,
		Name VARCHAR(100) NULL,
		[Index] INT NOT NULL,
	)
GO

IF OBJECT_ID('tblSystemCategories_PK') IS NOT NULL
	ALTER TABLE tblSystemCategories DROP CONSTRAINT tblSystemCategories_PK
GO

ALTER TABLE tblSystemCategories ADD CONSTRAINT tblSystemCategories_PK PRIMARY KEY(Id)
GO

