IF OBJECT_ID('tblReportFilter') IS NULL
	CREATE TABLE tblReportFilter(
		Id INT IDENTITY(1, 1) NOT NULL,
		SystemUserId INT NOT NULL,
		ReportFilterTypeId INT NOT NULL,
		SelectionId INT NOT NULL,
	)
GO

IF OBJECT_ID('tblReportFilter_PK') IS NOT NULL
	ALTER TABLE tblReportFilter DROP CONSTRAINT tblReportFilter_PK
GO

ALTER TABLE tblReportFilter ADD CONSTRAINT tblReportFilter_PK PRIMARY KEY(Id)
GO

