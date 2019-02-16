IF OBJECT_ID('uspRepostLedgers') IS NOT NULL
	DROP PROCEDURE uspRepostLedgers
GO

CREATE PROCEDURE uspRepostLedgers
AS
SET NOCOUNT ON

DECLARE @OldAccountId INT = 0
DECLARE @Balance MONEY = 0
DECLARE @MinInt INT = 0
DECLARE @MaxInt INT = 2147483647
DECLARE @MinDate DATETIME = '1/1/1899'
DECLARE @MaxDate DATETIME = '12/31/9999'

--clear tables
TRUNCATE TABLE tblGeneralLedger

--re-insert data
INSERT INTO tblGeneralLedger(CompanyId, [Date], AccountId, Debit, Credit, Balance)
SELECT j.CompanyId, j.[Date], jd.AccountId, SUM(jd.Debit), SUM(jd.Credit), 0
FROM tblJournals j
	INNER JOIN tblJournalDetails jd ON jd.JournalId = j.Id
WHERE j.Voided = 0
GROUP BY j.CompanyId, j.[Date], jd.AccountId

--recompute balance
UPDATE gl
SET @Balance = CASE WHEN @OldAccountId <> gl.AccountId THEN 0 ELSE @Balance END + (gl.Debit - gl.Credit),
	gl.Balance = CASE WHEN @OldAccountId <> gl.AccountId THEN 0 ELSE @Balance END,
	@OldAccountId = gl.AccountId
FROM tblGeneralLedger gl
WHERE gl.CompanyId BETWEEN @MinInt AND @MaxInt
	AND gl.[Date] BETWEEN @MinDate AND @MaxDate
	AND gl.[AccountId] BETWEEN @MinInt AND @MaxInt
GO

