BEGIN TRAN

TRUNCATE TABLE tblJournals
TRUNCATE TABLE tblJournalDetails
TRUNCATE TABLE tblGeneralLedger
TRUNCATE TABLE tblSubsidiaryLedger
TRUNCATE TABLE tblCashReceiptVoucherPaymentDistribution
TRUNCATE TABLE tblCashDisbursementVoucherPaymentDistribution

UPDATE tblSystemSeries
SET NextNumber = 1
WHERE Code IN ('GJ', 'PJ', 'CDJ', 'SJ', 'CRJ')

UPDATE tblJournalVouchers
SET JournalId = NULL

UPDATE tblPurchaseVouchers
SET JournalId = NULL

UPDATE tblSalesVouchers
SET JournalId = NULL

UPDATE tblCashReceiptVouchers
SET JournalId = NULL

UPDATE tblCashDisbursementVouchers
SET JournalId = NULL

DECLARE @Id INT
DECLARE @JournalTypeId INT
DECLARE @tmp TABLE(Id INT, JournalTypeId INT)

--Journal Voucher
INSERT INTO @tmp(Id, JournalTypeId)
SELECT Id, 1
FROM tblJournalVouchers

	UNION ALL

--Purchase Voucher
SELECT Id, 2
FROM tblPurchaseVouchers

	UNION ALL

--Sales Voucher
SELECT Id, 3
FROM tblSalesVouchers

	UNION ALL

--Customer Payment
SELECT Id, 4
FROM tblCashReceiptVouchers

	UNION ALL

--Supplier Payment
SELECT Id, 5
FROM tblCashDisbursementVouchers


WHILE 1 = 1
BEGIN
	SELECT TOP 1
		@Id = Id,
		@JournalTypeId = JournalTypeId
	FROM @tmp

	EXEC uspUpdateJournals @JournalTypeId, @Id, 1

	DELETE
	FROM @tmp
	WHERE Id = @Id
		AND JournalTypeId = @JournalTypeId

	IF NOT EXISTS(SELECT * FROM @tmp)
		BREAK
END

--Update Paid Amount
UPDATE sv
SET sv.PaidAmount = ISNULL(tmp.Amount, 0)
FROM tblSalesVouchers sv
	LEFT OUTER JOIN (
		SELECT cpd.InvoiceId, SUM(cpd.Amount) AS Amount
		FROM tblCashReceiptVouchers cv
			INNER JOIN tblCashReceiptVoucherPaymentDistribution cpd ON cpd.CashReceiptVoucherId = cv.Id
		WHERE cv.Voided = 0
		GROUP BY cpd.InvoiceId
	) tmp ON tmp.InvoiceId = sv.Id
WHERE sv.Voided = 0

UPDATE pv
SET pv.PaidAmount = pv.WithholdingTax + ISNULL(tmp.Amount, 0)
FROM tblPurchaseVouchers pv
	LEFT OUTER JOIN (
		SELECT cpd.BillId, SUM(cpd.Amount) AS Amount
		FROM tblCashDisbursementVouchers cdv
			INNER JOIN tblCashDisbursementVoucherPaymentDistribution cpd ON cpd.CashDisbursementVoucherId = cdv.Id
		WHERE cdv.Voided = 0
		GROUP BY cpd.BillId
	) tmp ON tmp.BillId = pv.Id
WHERE pv.Voided = 0

--Temporary for the bug in posting to GL
EXEC uspRepostLedgers

ROLLBACK