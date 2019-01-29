IF OBJECT_ID('tblSubsidiaryTypes') IS NULL
	CREATE TABLE tblSubsidiaryTypes(
		Id INT IDENTITY(1, 1) NOT NULL,
		Name VARCHAR(100) NULL,
	)
GO

IF OBJECT_ID('tblSubsidiaryTypes_PK') IS NOT NULL
	ALTER TABLE tblSubsidiaryTypes DROP CONSTRAINT tblSubsidiaryTypes_PK
GO

ALTER TABLE tblSubsidiaryTypes ADD CONSTRAINT tblSubsidiaryTypes_PK PRIMARY KEY(Id)
GO

