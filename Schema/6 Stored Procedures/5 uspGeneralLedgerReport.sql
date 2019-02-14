IF OBJECT_ID('uspGeneralLedgerReport') IS NOT NULL
	DROP PROCEDURE uspGeneralLedgerReport
GO

CREATE PROCEDURE uspGeneralLedgerReport(@CompanyId INT, @AccountId INT, @Date DATETIME)
AS
SET NOCOUNT ON

DECLARE @tmp TABLE(Id INT IDENTITY(1, 1), AccountId INT, [Date] DATETIME, Debit MONEY, Credit MONEY, RunningBalance MONEY PRIMARY KEY(Id))
DECLARE @Balance MONEY = 0
DECLARE @OldAccountId INT

INSERT INTO @tmp(AccountId, [Date], Debit, Credit, RunningBalance)
SELECT gl.AccountId, gl.[Date], gl.Debit, gl.Credit, 0
FROM tblGeneralLedger gl
WHERE gl.CompanyId = @CompanyId
	AND @AccountId IN (0, gl.AccountId)
	AND gl.[Date] <= @Date
ORDER BY gl.AccountId, gl.[Date]

UPDATE t
SET @Balance = CASE WHEN @OldAccountId <> t.AccountId THEN 0 ELSE @Balance END + (t.Debit - t.Credit),
	t.RunningBalance = CASE WHEN @OldAccountId <> t.AccountId THEN 0 ELSE @Balance END,
	@OldAccountId = t.AccountId
FROM @tmp t

SELECT a.Name AS Account, t.[Date], t.Debit, t.Credit, t.RunningBalance
FROM @tmp t
	INNER JOIN tblAccounts a ON a.Id = t.AccountId
ORDER BY t.Id, a.Name, t.[Date]
GO

