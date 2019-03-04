IF OBJECT_ID('tblCompanies') IS NULL
	CREATE TABLE tblCompanies(
		Id INT IDENTITY(1, 1) NOT NULL,
		Code VARCHAR(50) NOT NULL,
		Name VARCHAR(100) NULL,
		[Address] VARCHAR(250) NULL,
		Logo IMAGE NULL,
		TIN VARCHAR(12) NULL,
		ZIPCode VARCHAR(4) NULL,
		ATCId INT NULL,
		Remarks VARCHAR(1000) NULL,
		Active BIT NOT NULL CONSTRAINT DEF_tblCompanies_Active DEFAULT 1,
		CreatedById INT NOT NULL,
		DateCreated DATETIME NOT NULL,
		ModifiedById INT NOT NULL,
		DateModified DATETIME NOT NULL,
	)
GO

IF OBJECT_ID('tblCompanies_PK') IS NOT NULL
	ALTER TABLE tblCompanies DROP CONSTRAINT tblCompanies_PK
GO

ALTER TABLE tblCompanies ADD CONSTRAINT tblCompanies_PK PRIMARY KEY(Id)
GO

