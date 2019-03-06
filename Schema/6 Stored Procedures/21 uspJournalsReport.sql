IF OBJECT_ID('uspJournalsReport') IS NOT NULL
	DROP PROCEDURE uspJournalsReport
GO

CREATE PROCEDURE uspJournalsReport(@CompanyId INT, @FromDate DATETIME, @ToDate DATETIME, @JournalTypeId INT)
AS
SET NOCOUNT ON

SELECT j.TransactionNo, j.[Date], j.ReferenceNo, j.ReferenceNo2, j.Remarks,
	j.SourceTransactionNo, a.Name AS Account, s.Name AS Subsidiary,
	jd.Debit, jd.Credit
FROM tblJournals j
	INNER JOIN tblJournalDetails jd ON j.Id = jd.JournalId
	INNER JOIN tblAccounts a ON a.Id = jd.AccountId
	LEFT OUTER JOIN tblSubsidiaries s ON s.Id = jd.SubsidiaryId
WHERE j.CompanyId = @CompanyId
	AND j.[Date] BETWEEN @FromDate AND @ToDate
	AND j.JournalTypeId = @JournalTypeId
	AND j.Voided = 0
ORDER BY j.[Date]
GO

