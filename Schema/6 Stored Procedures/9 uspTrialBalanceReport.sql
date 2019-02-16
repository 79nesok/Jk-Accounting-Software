IF OBJECT_ID('uspTrialBalanceReport') IS NOT NULL
	DROP PROCEDURE uspTrialBalanceReport
GO

CREATE PROCEDURE uspTrialBalanceReport(@CompanyId INT, @FromDate DATETIME, @ToDate DATETIME, @ShowZeroBalance BIT)
AS
SET NOCOUNT ON

SELECT Account, Debit, Credit
FROM (
	SELECT a.Name AS Account, SUM(gl.Debit - gl.Credit) AS Debit, 0 AS Credit
	FROM tblGeneralLedger gl
		INNER JOIN tblAccounts a ON a.Id = gl.AccountId
	WHERE gl.CompanyId = @CompanyId
		AND gl.[Date] BETWEEN @FromDate AND @ToDate
		AND a.AccountTypeId IN (1, 5)
	GROUP BY a.Name

	UNION ALL

	SELECT a.Name AS Account, 0 AS Debit, SUM(gl.Credit - gl.Debit) AS Credit
	FROM tblGeneralLedger gl
		INNER JOIN tblAccounts a ON a.Id = gl.AccountId
	WHERE gl.CompanyId = @CompanyId
		AND gl.[Date] BETWEEN @FromDate AND @ToDate
		AND a.AccountTypeId IN (2, 3, 4)
	GROUP BY a.Name
)tmp
WHERE ((Debit + Credit) > 0 AND @ShowZeroBalance = 0)
	OR @ShowZeroBalance = 1
GO

