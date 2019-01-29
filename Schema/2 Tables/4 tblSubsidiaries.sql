IF OBJECT_ID('tblSubsidiaries') IS NULL
	CREATE TABLE tblSubsidiaries(
		Id INT IDENTITY(1, 1) NOT NULL,
		CompanyId INT NOT NULL,
		SubsidiaryTypeId INT NOT NULL,
		Code VARCHAR(50) NOT NULL,
		Name VARCHAR(100) NULL,
		[Address] VARCHAR(250) NULL,
		Remarks VARCHAR(1000) NULL,
		Active BIT NOT NULL CONSTRAINT DEF_tblSubsidiaries_Active DEFAULT 1,
		CreatedById INT NOT NULL,
		DateCreated DATETIME NOT NULL,
		ModifiedById INT NOT NULL,
		DateModified DATETIME NOT NULL,
	)
GO

IF OBJECT_ID('tblSubsidiaries_PK') IS NOT NULL
	ALTER TABLE tblSubsidiaries DROP CONSTRAINT tblSubsidiaries_PK
GO

ALTER TABLE tblSubsidiaries ADD CONSTRAINT tblSubsidiaries_PK PRIMARY KEY(Id)
GO

