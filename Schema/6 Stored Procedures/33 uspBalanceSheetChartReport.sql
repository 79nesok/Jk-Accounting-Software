IF OBJECT_ID('uspBalanceSheetChartReport') IS NOT NULL
	DROP PROCEDURE uspBalanceSheetChartReport
GO

CREATE PROCEDURE uspBalanceSheetChartReport(@CompanyId INT, @Date DATETIME)
AS
SET NOCOUNT ON

SELECT at.Name AS AccountType, SUM(gl.Balance * CASE WHEN a.AccountTypeId = 1 THEN 1 ELSE -1 END) AS Balance
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
GROUP BY at.Id, at.Name
GO

