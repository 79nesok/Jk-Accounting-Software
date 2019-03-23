IF OBJECT_ID('uspIncomeStatementChartReport') IS NOT NULL
	DROP PROCEDURE uspIncomeStatementChartReport
GO

CREATE PROCEDURE uspIncomeStatementChartReport(@CompanyId INT, @FromDate DATETIME, @ToDate DATETIME)
AS
SET NOCOUNT ON

SELECT at.Name AS AccountType,
	CASE WHEN a.AccountTypeId = 4 THEN SUM(gl.Credit - gl.Debit) ELSE SUM(gl.Debit - gl.Credit) END AS Balance
FROM tblGeneralLedger gl
	INNER JOIN tblAccounts a ON a.Id = gl.AccountId
		AND a.AccountTypeId IN (4, 5)
	INNER JOIN tblAccountTypes at ON at.Id = a.AccountTypeId
WHERE gl.CompanyId = @CompanyId
	AND gl.[Date] BETWEEN @FromDate AND @ToDate
GROUP BY at.Name, a.AccountTypeId
GO

