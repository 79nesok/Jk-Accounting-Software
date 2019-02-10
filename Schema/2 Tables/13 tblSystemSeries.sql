IF OBJECT_ID('tblSystemSeries') IS NULL
	CREATE TABLE tblSystemSeries(
		CompanyId INT NOT NULL,
		Code VARCHAR(50) NOT NULL,
		NextNumber INT NOT NULL,
	)
GO

IF OBJECT_ID('tblSystemSeries_PK') IS NOT NULL
	ALTER TABLE tblSystemSeries DROP CONSTRAINT tblSystemSeries_PK
GO

ALTER TABLE tblSystemSeries ADD CONSTRAINT tblSystemSeries_PK PRIMARY KEY(CompanyId, Code)
GO

