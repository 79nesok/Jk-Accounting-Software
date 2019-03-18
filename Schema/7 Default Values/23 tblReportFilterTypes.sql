TRUNCATE TABLE tblReportFilterTypes

INSERT INTO tblReportFilterTypes(Code, Name, Active, TypeId, Subsidiary, Account)
SELECT Name, Name, 1, Id, 1, 0
FROM tblSubsidiaryTypes

UNION ALL

SELECT Name, Name, 1, Id, 0, 1
FROM tblAccountTypes
GO

