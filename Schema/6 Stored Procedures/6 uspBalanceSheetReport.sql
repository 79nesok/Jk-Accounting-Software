IF OBJECT_ID('uspBalanceSheetReport') IS NOT NULL
	DROP PROCEDURE uspBalanceSheetReport
GO

CREATE PROCEDURE uspBalanceSheetReport(@CompanyId INT, @Date DATETIME, @AccountTypeId INT)
AS
SET NOCOUNT ON

SELECT a.Name AS Account, gl.Balance * CASE WHEN @AccountTypeId = 1 THEN 1 ELSE -1 END AS Balance
FROM tblGeneralLedger gl
	INNER JOIN tblAccounts a ON a.Id = gl.AccountId
		AND a.AccountTypeId = @AccountTypeId
WHERE gl.CompanyId = @CompanyId
	AND gl.[Date] = (
		SELECT MAX(gl2.[Date])
		FROM tblGeneralLedger gl2
		WHERE gl2.CompanyId = @CompanyId
			AND gl2.AccountId = gl.AccountId
			AND gl2.[Date] <= @Date
	)
ORDER BY a.Name
GO

