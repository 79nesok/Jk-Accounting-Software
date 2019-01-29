IF OBJECT_ID('tblSecurityUsers') IS NULL
	CREATE TABLE tblSecurityUsers(
		Id INT IDENTITY(1, 1) NOT NULL,
		UserName VARCHAR(100) NOT NULL,
		[Password] VARCHAR(100) NOT NULL,
		FirstName VARCHAR(100) NOT NULL,
		MiddleName VARCHAR(100) NULL,
		LastName VARCHAR(100) NOT NULL,
		FormalName AS (FirstName + ' ' + CASE WHEN NULLIF(LTRIM(RTRIM(MiddleName)), '') <> NULL THEN LEFT(MiddleName, 1) + '. ' ELSE '' END + LastName),
		Remarks VARCHAR(1000) NULL,
		Active BIT NOT NULL CONSTRAINT DEF_tblSecurityUsers_Active DEFAULT 1,
		CreatedById INT NOT NULL,
		DateCreated DATETIME NOT NULL,
		ModifiedById INT NOT NULL,
		DateModified DATETIME NOT NULL,
	)
GO

IF OBJECT_ID('tblSecurityUsers_PK') IS NOT NULL
	ALTER TABLE tblSecurityUsers DROP CONSTRAINT tblSecurityUsers_PK
GO

ALTER TABLE tblSecurityUsers ADD CONSTRAINT tblSecurityUsers_PK PRIMARY KEY(Id)
GO

