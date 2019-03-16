IF OBJECT_ID('uspGetJournalPrintout') IS NOT NULL
	DROP PROCEDURE uspGetJournalPrintout
GO

CREATE PROCEDURE uspGetJournalPrintout(@Id INT, @Caption VARCHAR(100))
AS
SET NOCOUNT ON

--Temporary query for Dataset.xsd
IF @Id IS NULL
BEGIN
	DECLARE @tmp TABLE(TransactionNo VARCHAR(50), [Date] DATETIME, ReferenceNo VARCHAR(50),
		ReferenceNo2 VARCHAR(50), Subsidiary VARCHAR(100), Remarks VARCHAR(1000))

	SELECT TransactionNo, [Date], ReferenceNo, ReferenceNo2, Subsidiary, Remarks
	FROM @tmp
END

IF @Caption = 'Journal Voucher'
	SELECT TransactionNo, [Date], ReferenceNo, ReferenceNo2, NULL AS Subsidiary, Remarks
	FROM tblJournalVouchers
	WHERE Id = @Id
ELSE IF @Caption = 'Bill' --Purchase Journal
	SELECT j.TransactionNo, j.[Date], j.ReferenceNo, j.ReferenceNo2, s.Name AS Subsidiary, j.Remarks
	FROM tblJournals j
		INNER JOIN tblBills b ON b.JournalId = j.Id
		INNER JOIN tblSubsidiaries s ON s.Id = j.SubsidiaryId
	WHERE b.Id = @Id
ELSE IF @Caption = 'Check Voucher'
	SELECT bp.TransactionNo, bp.[Date], bp.ReferenceNo, bp.ReferenceNo2, s.Name AS Subsidiary, bp.Remarks
	FROM tblBillsPayment bp
		INNER JOIN tblSubsidiaries s ON s.Id = bp.SubsidiaryId
	WHERE bp.Id = @Id
ELSE IF @Caption = 'Sales Invoice' --Sales Journal
	SELECT j.TransactionNo, j.[Date], j.ReferenceNo, j.ReferenceNo2, s.Name AS Subsidiary, j.Remarks
	FROM tblJournals j
		INNER JOIN tblSalesInvoices si ON si.JournalId = j.Id
		INNER JOIN tblSubsidiaries s ON s.Id = j.SubsidiaryId
	WHERE si.Id = @Id
ELSE IF @Caption = 'Cash Receipt' --Cash Receipt Journal
	SELECT j.TransactionNo, j.[Date], j.ReferenceNo, j.ReferenceNo2, s.Name AS Subsidiary, j.Remarks
	FROM tblJournals j
		INNER JOIN tblCashReceipts cr ON cr.JournalId = j.Id
		INNER JOIN tblSubsidiaries s ON s.Id = j.SubsidiaryId
	WHERE cr.Id = @Id
ELSE IF @Caption = 'Cash Receipt Voucher'
	SELECT cr.TransactionNo, cr.[Date], cr.ReferenceNo, cr.ReferenceNo2, s.Name AS Subsidiary, cr.Remarks
	FROM tblCashReceipts cr
		INNER JOIN tblSubsidiaries s ON s.Id = cr.SubsidiaryId
	WHERE cr.Id = @Id
GO

