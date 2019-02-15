IF OBJECT_ID('uspGeneralLedgerReport') IS NOT NULL
	DROP PROCEDURE uspGeneralLedgerReport
GO

CREATE PROCEDURE uspGeneralLedgerReport(@CompanyId INT, @FromDate DATETIME, @ToDate DATETIME)
AS
SET NOCOUNT ON

DECLARE @tmp TABLE(Id INT IDENTITY(1, 1), AccountId INT, [Date] DATETIME, Debit MONEY, Credit MONEY, RunningBalance MONEY PRIMARY KEY(Id))
DECLARE @beg TABLE(Id INT, AccountId INT, Debit MONEY, Credit MONEY)
DECLARE @Balance MONEY = 0
DECLARE @OldAccountId INT
DECLARE @MinDate DATETIME = '1/1/1899'

--actual data
INSERT INTO @tmp(AccountId, [Date], Debit, Credit, RunningBalance)
SELECT gl.AccountId, gl.[Date], gl.Debit, gl.Credit, 0
FROM tblGeneralLedger gl
WHERE gl.CompanyId = @CompanyId
	AND gl.[Date] BETWEEN @FromDate AND @ToDate
ORDER BY gl.AccountId, gl.[Date]

--beginning balance
INSERT INTO @beg(Id, AccountId, Debit, Credit)
SELECT 0, gl.AccountId, CASE WHEN gl.Balance > 0 THEN gl.Balance ELSE 0 END, CASE WHEN gl.Balance < 0 THEN gl.Balance * -1 ELSE 0 END
FROM tblGeneralLedger gl
WHERE gl.CompanyId = @CompanyId
	AND gl.[Date] = (
		SELECT MAX(gl2.[Date])
		FROM tblGeneralLedger gl2
		WHERE gl2.CompanyId = @CompanyId
			AND gl2.AccountId = gl.AccountId
			AND gl2.[Date] < @FromDate
	)

INSERT INTO @beg(Id, AccountId, Debit, Credit)
SELECT 0, t.AccountId, 0, 0
FROM (
	SELECT DISTINCT AccountId
	FROM @tmp
) t
WHERE NOT EXISTS(
	SELECT *
	FROM @beg b
	WHERE b.AccountId = t.AccountId
)

--update running balance
UPDATE t
SET @Balance = CASE WHEN @OldAccountId <> t.AccountId THEN 0 ELSE @Balance END + (t.Debit - t.Credit),
	t.RunningBalance = CASE WHEN @OldAccountId <> t.AccountId THEN 0 ELSE @Balance END,
	@OldAccountId = t.AccountId
FROM @tmp t

--reupdate running balance
UPDATE t
SET t.RunningBalance = t.RunningBalance + b.Debit - b.Credit
FROM @tmp t
	INNER JOIN @beg b ON t.AccountId = b.AccountId

SELECT a.Name AS Account,
	CASE WHEN
		x.[Date] = @MinDate THEN '(Beginning Balance)'
	ELSE
		CAST(MONTH(x.[Date]) AS VARCHAR) + '/' + CAST(DAY(x.[Date]) AS VARCHAR) + '/' + CAST(YEAR(x.[Date]) AS VARCHAR)
	END AS [Date],
	x.Debit, x.Credit, x.RunningBalance
FROM (
	SELECT t.Id, t.AccountId, t.[Date], t.Debit, t.Credit, t.RunningBalance
	FROM @tmp t

	UNION ALL

	SELECT b.Id, b.AccountId, @MinDate, b.Debit, b.Credit, b.Debit - b.Credit
	FROM @beg b
) x
	INNER JOIN tblAccounts a ON a.Id = x.AccountId
ORDER BY a.Name, x.Id, x.[Date]
GO

