IF OBJECT_ID('uspIncomeStatementReport') IS NOT NULL
	DROP PROCEDURE uspIncomeStatementReport
GO

CREATE PROCEDURE uspIncomeStatementReport(@CompanyId INT, @FromDate DATETIME, @ToDate DATETIME, @AccountTypeId INT)
AS
SET NOCOUNT ON

SELECT a.Name AS Account, CASE WHEN @AccountTypeId = 4 THEN SUM(gl.Credit - gl.Debit) ELSE SUM(gl.Debit - gl.Credit) END AS Balance
FROM tblGeneralLedger gl
	INNER JOIN tblAccounts a ON a.Id = gl.AccountId
		AND a.AccountTypeId = @AccountTypeId
WHERE gl.CompanyId = @CompanyId
	AND gl.[Date] BETWEEN @FromDate AND @ToDate
GROUP BY a.Name
ORDER BY a.Name
GO

