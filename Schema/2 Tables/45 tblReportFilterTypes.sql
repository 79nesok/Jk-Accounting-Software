IF OBJECT_ID('tblReportFilterTypes') IS NULL
	CREATE TABLE tblReportFilterTypes(
		Id INT IDENTITY(1, 1) NOT NULL,
		Code VARCHAR(50) NOT NULL,
		Name VARCHAR(100) NULL,
		Active BIT NOT NULL CONSTRAINT DF_tblReportFilterTypes_Active DEFAULT 1,
		TypeId INT NOT NULL,
		Subsidiary BIT NOT NULL CONSTRAINT DF_tblReportFilterTypes_Subsidiary DEFAULT 0,
		Account BIT NOT NULL CONSTRAINT DF_tblReportFilterTypes_Account DEFAULT 0,
	)
GO

IF OBJECT_ID('tblReportFilterTypes_PK') IS NOT NULL
	ALTER TABLE tblReportFilterTypes DROP CONSTRAINT tblReportFilterTypes_PK
GO

ALTER TABLE tblReportFilterTypes ADD CONSTRAINT tblReportFilterTypes_PK PRIMARY KEY(Id)
GO

