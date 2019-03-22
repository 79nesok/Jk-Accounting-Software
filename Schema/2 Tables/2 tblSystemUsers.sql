IF OBJECT_ID('tblSystemUsers') IS NULL
	CREATE TABLE tblSystemUsers(
		Id INT IDENTITY(1, 1) NOT NULL,
		UserName VARCHAR(100) NOT NULL,
		[Password] VARCHAR(100) NOT NULL,
		FirstName VARCHAR(100) NOT NULL,
		MiddleName VARCHAR(100) NULL,
		LastName VARCHAR(100) NOT NULL,
		FormalName AS (FirstName + ' ' + CASE WHEN NULLIF(LTRIM(RTRIM(MiddleName)), '') IS NOT NULL THEN LEFT(MiddleName, 1) + '. ' ELSE '' END + LastName),
		Remarks VARCHAR(1000) NULL,
		Active BIT NOT NULL CONSTRAINT DF_tblSystemUsers_Active DEFAULT 1,
		CreatedById INT NOT NULL,
		DateCreated DATETIME NOT NULL,
		ModifiedById INT NOT NULL,
		DateModified DATETIME NOT NULL,
	)
GO

IF OBJECT_ID('tblSystemUsers_PK') IS NOT NULL
	ALTER TABLE tblSystemUsers DROP CONSTRAINT tblSystemUsers_PK
GO

ALTER TABLE tblSystemUsers ADD CONSTRAINT tblSystemUsers_PK PRIMARY KEY(Id)
GO

