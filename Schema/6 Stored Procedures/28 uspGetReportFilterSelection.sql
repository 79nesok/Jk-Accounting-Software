IF OBJECT_ID('uspGetReportFilterSelection') IS NOT NULL
	DROP PROCEDURE uspGetReportFilterSelection
GO

CREATE PROCEDURE uspGetReportFilterSelection(@CompanyId INT, @SystemUserId INT, @Subsidiary BIT, @TypeId INT)
AS
SET NOCOUNT ON

--Temporary query for be able to load the columns in designtime
IF @CompanyId = 0
BEGIN
	DECLARE @tmp TABLE(Selected BIT, [Type] VARCHAR(100), SelectionId INT,
		Code VARCHAR(50), Name VARCHAR(100), Active BIT, ReportFilterTypeId INT)

	SELECT Selected, [Type], SelectionId, Code, Name, Active, ReportFilterTypeId
	FROM @tmp

	RETURN
END

IF @Subsidiary = 1
BEGIN
	SELECT CAST(CASE WHEN rf.Id IS NULL THEN 0 ELSE 1 END AS BIT) AS Selected,
		st.Name AS [Type], s.Id AS SelectionId, s.Code, s.Name, s.Active,
		rft.Id AS ReportFilterTypeId
	FROM tblSubsidiaries s
		INNER JOIN tblSubsidiaryTypes st ON st.Id = s.SubsidiaryTypeId
		INNER JOIN tblReportFilterTypes rft ON rft.TypeId = s.SubsidiaryTypeId
			AND rft.Subsidiary = 1
		LEFT OUTER JOIN tblReportFilter rf ON rf.ReportFilterTypeId = rft.Id
			AND rf.SystemUserId = @SystemUserId
			AND rf.SelectionId = s.Id
	WHERE s.CompanyId = @CompanyId
		AND @TypeId IN (0, s.SubsidiaryTypeId)
	ORDER BY st.Name, s.Name
END
ELSE
BEGIN
	SELECT CAST(CASE WHEN rf.Id IS NULL THEN 0 ELSE 1 END AS BIT) AS Selected,
		at.Name AS [Type], a.Id AS SelectionId, a.Code, a.Name, a.Active,
		rft.Id AS ReportFilterTypeId
	FROM tblAccounts a
		INNER JOIN tblAccountTypes at ON at.Id = a.AccountTypeId
		INNER JOIN tblReportFilterTypes rft ON rft.TypeId = a.AccountTypeId
			AND rft.Subsidiary = 0
		LEFT OUTER JOIN tblReportFilter rf ON rf.ReportFilterTypeId = rft.Id
			AND rf.SystemUserId = @SystemUserId
			AND rf.SelectionId = a.Id
	WHERE a.CompanyId = @CompanyId
		AND @TypeId IN (0, a.AccountTypeId)
	ORDER BY at.Name, a.Name
END
GO

