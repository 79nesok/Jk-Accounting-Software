IF OBJECT_ID('uspSubsidiaryLedgerReport') IS NOT NULL
	DROP PROCEDURE uspSubsidiaryLedgerReport
GO

CREATE PROCEDURE uspSubsidiaryLedgerReport(@CompanyId INT, @FromDate DATETIME, @ToDate DATETIME)
AS
SET NOCOUNT ON

DECLARE @tmp TABLE(Id INT IDENTITY(1, 1), SubsidiaryId INT, AccountId INT, [Date] DATETIME, Debit MONEY, Credit MONEY, RunningBalance MONEY PRIMARY KEY(Id))
DECLARE @beg TABLE(Id INT, SubsidiaryId INT, AccountId INT, Debit MONEY, Credit MONEY)
DECLARE @Balance MONEY = 0
DECLARE @OldSubsidiaryId INT
DECLARE @OldAccountId INT
DECLARE @MinDate DATETIME = '1/1/1899'

--actual data
INSERT INTO @tmp(SubsidiaryId, AccountId, [Date], Debit, Credit, RunningBalance)
SELECT sl.SubsidiaryId, sl.AccountId, sl.[Date], sl.Debit, sl.Credit, 0
FROM tblSubsidiaryLedger sl
WHERE sl.CompanyId = @CompanyId
	AND sl.[Date] BETWEEN @FromDate AND @ToDate
ORDER BY sl.SubsidiaryId, sl.AccountId, sl.[Date]

--beginning balance
INSERT INTO @beg(Id, SubsidiaryId, AccountId, Debit, Credit)
SELECT 0, sl.SubsidiaryId, sl.AccountId, CASE WHEN sl.Balance > 0 THEN sl.Balance ELSE 0 END, CASE WHEN sl.Balance < 0 THEN sl.Balance * -1 ELSE 0 END
FROM tblSubsidiaryLedger sl
WHERE sl.CompanyId = @CompanyId
	AND sl.[Date] = (
		SELECT MAX(sl2.[Date])
		FROM tblSubsidiaryLedger sl2
		WHERE sl2.CompanyId = @CompanyId
			AND sl2.SubsidiaryId = sl.SubsidiaryId
			AND sl2.AccountId = sl.AccountId
			AND sl2.[Date] < @FromDate
	)

INSERT INTO @beg(Id, SubsidiaryId, AccountId, Debit, Credit)
SELECT 0, t.SubsidiaryId,  t.AccountId, 0, 0
FROM (
	SELECT DISTINCT SubsidiaryId, AccountId
	FROM @tmp
) t
WHERE NOT EXISTS(
	SELECT *
	FROM @beg b
	WHERE b.SubsidiaryId = t.SubsidiaryId
		AND b.AccountId = t.AccountId
)

--update running balance
UPDATE t
SET @Balance = CASE WHEN @OldAccountId <> t.AccountId OR @OldSubsidiaryId <> t.SubsidiaryId THEN 0 ELSE @Balance END + (t.Debit - t.Credit),
	t.RunningBalance = CASE WHEN @OldAccountId <> t.AccountId OR @OldSubsidiaryId <> t.SubsidiaryId THEN 0 ELSE @Balance END,
	@OldAccountId = t.AccountId,
	@OldSubsidiaryId = t.SubsidiaryId
FROM @tmp t

--reupdate running balance
UPDATE t
SET t.RunningBalance = t.RunningBalance + b.Debit - b.Credit
FROM @tmp t
	INNER JOIN @beg b ON t.AccountId = b.AccountId
		AND t.SubsidiaryId = b.SubsidiaryId

SELECT s.Name AS Subsidiary, a.Name AS Account,
	CASE WHEN
		x.[Date] = @MinDate THEN '(Beginning Balance)'
	ELSE
		CAST(MONTH(x.[Date]) AS VARCHAR) + '/' + CAST(DAY(x.[Date]) AS VARCHAR) + '/' + CAST(YEAR(x.[Date]) AS VARCHAR)
	END AS [Date],
	x.Debit, x.Credit, x.RunningBalance
FROM (
	SELECT t.Id, t.SubsidiaryId, t.AccountId, t.[Date], t.Debit, t.Credit, t.RunningBalance
	FROM @tmp t

	UNION ALL

	SELECT b.Id, b.SubsidiaryId, b.AccountId, @MinDate, b.Debit, b.Credit, b.Debit - b.Credit
	FROM @beg b
) x
	INNER JOIN tblSubsidiaries s ON s.Id = x.SubsidiaryId
	INNER JOIN tblAccounts a ON a.Id = x.AccountId
ORDER BY s.Name, a.Name, x.Id, x.[Date]
GO

