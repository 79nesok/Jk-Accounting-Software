IF OBJECT_ID('uspRepostLedgers') IS NOT NULL
	DROP PROCEDURE uspRepostLedgers
GO

CREATE PROCEDURE uspRepostLedgers
AS
SET NOCOUNT ON

DECLARE @OldSubsidiaryId INT = 0
DECLARE @OldAccountId INT = 0
DECLARE @Balance MONEY = 0
DECLARE @MinInt INT = 0
DECLARE @MaxInt INT = 2147483647
DECLARE @MinDate DATETIME = '1/1/1899'
DECLARE @MaxDate DATETIME = '12/31/9999'

--clear tables
TRUNCATE TABLE tblGeneralLedger
TRUNCATE TABLE tblSubsidiaryLedger

--re-insert data
INSERT INTO tblGeneralLedger(CompanyId, [Date], AccountId, Debit, Credit, Balance)
SELECT j.CompanyId, j.[Date], jd.AccountId, SUM(jd.Debit), SUM(jd.Credit), 0
FROM tblJournals j
	INNER JOIN tblJournalDetails jd ON jd.JournalId = j.Id
WHERE j.Voided = 0
GROUP BY j.CompanyId, j.[Date], jd.AccountId

INSERT INTO  tblSubsidiaryLedger(CompanyId, SubsidiaryId, AccountId, [Date], Debit, Credit, Balance)
SELECT tmp.CompanyId, tmp.SubsidiaryId, tmp.AccountId, tmp.[Date], SUM(tmp.Debit), SUM(tmp.Credit), 0
FROM (
	SELECT j.CompanyId, jd.SubsidiaryId, jd.AccountId, j.[Date], jd.Debit, jd.Credit
	FROM tblJournals j
		INNER JOIN tblJournalDetails jd ON jd.JournalId = j.Id
	WHERE j.Voided = 0
		AND jd.SubsidiaryId IS NOT NULL
) tmp
GROUP BY tmp.CompanyId, tmp.SubsidiaryId, tmp.AccountId, tmp.[Date]

--recompute balance
UPDATE gl
SET @Balance = CASE WHEN @OldAccountId <> gl.AccountId THEN 0 ELSE @Balance END + (gl.Debit - gl.Credit),
	gl.Balance = CASE WHEN @OldAccountId <> gl.AccountId THEN 0 ELSE @Balance END,
	@OldAccountId = gl.AccountId
FROM tblGeneralLedger gl
WHERE gl.CompanyId BETWEEN @MinInt AND @MaxInt
	AND gl.[Date] BETWEEN @MinDate AND @MaxDate
	AND gl.[AccountId] BETWEEN @MinInt AND @MaxInt

UPDATE sl
SET @Balance = CASE WHEN @OldAccountId <> sl.AccountId OR @OldSubsidiaryId <> sl.SubsidiaryId THEN 0 ELSE @Balance END + (sl.Debit - sl.Credit),
	sl.Balance = CASE WHEN @OldAccountId <> sl.AccountId OR @OldSubsidiaryId <> sl.SubsidiaryId THEN 0 ELSE @Balance END,
	@OldAccountId = sl.AccountId,
	@OldSubsidiaryId = sl.SubsidiaryId
FROM tblSubsidiaryLedger sl
WHERE sl.CompanyId BETWEEN @MinInt AND @MaxInt
	AND sl.SubsidiaryId BETWEEN @MinInt AND @MaxInt
	AND sl.AccountId BETWEEN @MinInt AND @MaxInt
	AND sl.[Date] BETWEEN @MinDate AND @MaxDate
GO

