IF OBJECT_ID('tblSystemConfiguration') IS NULL
	CREATE TABLE tblSystemConfiguration(
		Id INT IDENTITY(1, 1) NOT NULL,
		ProductName VARCHAR(100) NULL,
		ProductVersion VARCHAR(100) NULL,
	)
GO

IF OBJECT_ID('tblSystemConfiguration_PK') IS NOT NULL
	ALTER TABLE tblSystemConfiguration DROP CONSTRAINT tblSystemConfiguration_PK
GO

ALTER TABLE tblSystemConfiguration ADD CONSTRAINT tblSystemConfiguration_PK PRIMARY KEY(Id)
GO

