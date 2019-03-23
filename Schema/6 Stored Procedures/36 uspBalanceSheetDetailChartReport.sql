IF OBJECT_ID('uspBalanceSheetDetailChartReport') IS NOT NULL
	DROP PROCEDURE uspBalanceSheetDetailChartReport
GO

CREATE PROCEDURE uspBalanceSheetDetailChartReport(@CompanyId INT, @Date DATETIME)
AS
SET NOCOUNT ON

SELECT a.Name + ' - ' + at.Name AS Account, SUM(gl.Balance * CASE WHEN a.AccountTypeId = 1 THEN 1 ELSE -1 END) AS Balance
FROM tblGeneralLedger gl
	INNER JOIN tblAccounts a ON a.Id = gl.AccountId
	INNER JOIN tblAccountTypes at ON at.Id = a.AccountTypeId
WHERE gl.CompanyId = @CompanyId
	AND gl.[Date] = (
		SELECT MAX(gl2.[Date])
		FROM tblGeneralLedger gl2
		WHERE gl2.CompanyId = @CompanyId
			AND gl2.AccountId = gl.AccountId
			AND gl2.[Date] <= @Date
	)
	AND a.AccountTypeId IN (1, 2, 3)
GROUP BY at.Id, a.Name, at.Name
ORDER BY at.Id
GO

