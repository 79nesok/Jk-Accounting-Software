IF OBJECT_ID('tblSystemSubCategories') IS NULL
	CREATE TABLE tblSystemSubCategories(
		Id INT IDENTITY(1, 1) NOT NULL,
		CategoryId INT NOT NULL,
		Parent VARCHAR(100) NULL,
		Structure VARCHAR(500) NULL,
		Name VARCHAR(100) NULL,
		ListForm VARCHAR(100) NULL,
		MasterForm VARCHAR(100) NULL,
		[Index] INT NOT NULL,
	)
GO

IF OBJECT_ID('tblSystemSubCategories_PK') IS NOT NULL
	ALTER TABLE tblSystemSubCategories DROP CONSTRAINT tblSystemSubCategories_PK
GO

ALTER TABLE tblSystemSubCategories ADD CONSTRAINT tblSystemSubCategories_PK PRIMARY KEY(Id)
GO

