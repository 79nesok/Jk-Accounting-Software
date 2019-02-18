IF OBJECT_ID('tblSystemAccountCodes') IS NULL
	CREATE TABLE tblSystemAccountCodes(
		Id INT IDENTITY(1, 1) NOT NULL,
		Code VARCHAR(50) NOT NULL,
		Name VARCHAR(100) NULL,
		Active BIT NOT NULL CONSTRAINT DF_tblSystemAccountCodes_Active DEFAULT 1,
	)
GO

IF OBJECT_ID('tblSystemAccountCodes_PK') IS NOT NULL
	ALTER TABLE tblSystemAccountCodes DROP CONSTRAINT tblSystemAccountCodes_PK
GO

ALTER TABLE tblSystemAccountCodes ADD CONSTRAINT tblSystemAccountCodes_PK PRIMARY KEY(Id)
GO

