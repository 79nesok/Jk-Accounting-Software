IF OBJECT_ID('uspGetJournalDetailPrintout') IS NOT NULL
	DROP PROCEDURE uspGetJournalDetailPrintout
GO

CREATE PROCEDURE uspGetJournalDetailPrintout(@Id INT, @Caption VARCHAR(100))
AS
SET NOCOUNT ON

--Temporary query for Dataset.xsd
IF @Id IS NULL
BEGIN
	DECLARE @tmp TABLE(Account VARCHAR(100), Subsidiary VARCHAR(100), Debit MONEY, Credit MONEY, Remarks VARCHAR(1000))

	SELECT Account, Subsidiary, Debit, Credit, Remarks
	FROM @tmp
END

IF @Caption = 'Journal Voucher'
	SELECT a.Name AS Account, s.Name AS Subsidiary, jvd.Debit, jvd.Credit, jvd.Remarks
	FROM tblJournalVoucherDetails jvd
		INNER JOIN tblAccounts a ON a.Id = jvd.AccountId
		LEFT OUTER JOIN tblSubsidiaries s ON s.Id = jvd.SubsidiaryId
	WHERE jvd.JournalVoucherId = @Id
ELSE IF @Caption = 'Bill' --Purchase Journal
	SELECT a.Name AS Account, s.Name AS Subsidiary, jd.Debit, jd.Credit, jd.Remarks
	FROM tblJournalDetails jd
		INNER JOIN tblBills b ON b.JournalId = jd.JournalId
		INNER JOIN tblAccounts a ON a.Id = jd.AccountId
		LEFT OUTER JOIN tblSubsidiaries s ON s.Id = jd.SubsidiaryId
	WHERE b.Id = @Id
ELSE IF @Caption = 'Bills Payment' --Cash Disbursement Journal
	SELECT a.Name AS Account, s.Name AS Subsidiary, jd.Debit, jd.Credit, jd.Remarks
	FROM tblJournalDetails jd
		INNER JOIN tblBillsPayment bp ON bp.JournalId = jd.JournalId
		INNER JOIN tblAccounts a ON a.Id = jd.AccountId
		LEFT OUTER JOIN tblSubsidiaries s ON s.Id = jd.SubsidiaryId
	WHERE bp.Id = @Id
ELSE IF @Caption = 'Check Voucher'
	SELECT a.Name AS Account, s.Name AS Subsidiary, jd.Debit, jd.Credit, jd.Remarks
	FROM tblJournalDetails jd
		INNER JOIN tblBillsPayment bp ON bp.JournalId = jd.JournalId
		INNER JOIN tblAccounts a ON a.Id = jd.AccountId
		LEFT OUTER JOIN tblSubsidiaries s ON s.Id = jd.SubsidiaryId
	WHERE bp.Id = @Id
ELSE IF @Caption = 'Sales Invoice' --Sales Journal
	SELECT a.Name AS Account, s.Name AS Subsidiary, jd.Debit, jd.Credit, jd.Remarks
	FROM tblJournalDetails jd
		INNER JOIN tblSalesInvoices si ON si.JournalId = jd.JournalId
		INNER JOIN tblAccounts a ON a.Id = jd.AccountId
		LEFT OUTER JOIN tblSubsidiaries s ON s.Id = jd.SubsidiaryId
	WHERE si.Id = @Id
ELSE IF @Caption = 'Cash Receipt' --Cash Receipt Journal
	SELECT a.Name AS Account, s.Name AS Subsidiary, jd.Debit, jd.Credit, jd.Remarks
	FROM tblJournalDetails jd
		INNER JOIN tblCashReceipts cr ON cr.JournalId = jd.JournalId
		INNER JOIN tblAccounts a ON a.Id = jd.AccountId
		LEFT OUTER JOIN tblSubsidiaries s ON s.Id = jd.SubsidiaryId
	WHERE cr.Id = @Id
ELSE IF @Caption = 'Cash Receipt Voucher'
	SELECT a.Name AS Account, s.Name AS Subsidiary, jd.Debit, jd.Credit, jd.Remarks
	FROM tblJournalDetails jd
		INNER JOIN tblCashReceipts cr ON cr.JournalId = jd.JournalId
		INNER JOIN tblAccounts a ON a.Id = jd.AccountId
		LEFT OUTER JOIN tblSubsidiaries s ON s.Id = jd.SubsidiaryId
	WHERE cr.Id = @Id
GO

