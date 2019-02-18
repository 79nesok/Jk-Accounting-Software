IF OBJECT_ID('tblAccounts') IS NULL
	CREATE TABLE tblAccounts(
		Id INT IDENTITY(1, 1) NOT NULL,
		CompanyId INT NOT NULL,
		AccountTypeId INT NOT NULL,
		SystemAccountCodeId INT NULL,
		Code VARCHAR(50) NOT NULL,
		Name VARCHAR(100) NULL,
		Remarks VARCHAR(1000) NULL,
		Active BIT NOT NULL CONSTRAINT DEF_tblAccounts_Active DEFAULT 1,
		CreatedById INT NOT NULL,
		DateCreated DATETIME NOT NULL,
		ModifiedById INT NOT NULL,
		DateModified DATETIME NOT NULL,
	)
GO

IF OBJECT_ID('tblAccounts_PK') IS NOT NULL
	ALTER TABLE tblAccounts DROP CONSTRAINT tblAccounts_PK
GO

ALTER TABLE tblAccounts ADD CONSTRAINT tblAccounts_PK PRIMARY KEY(Id)
GO

