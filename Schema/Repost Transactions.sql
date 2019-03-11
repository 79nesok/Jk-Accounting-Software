BEGIN TRAN

TRUNCATE TABLE tblJournals
TRUNCATE TABLE tblJournalDetails
TRUNCATE TABLE tblGeneralLedger
TRUNCATE TABLE tblSubsidiaryLedger
TRUNCATE TABLE tblCashReceiptPaymentDistribution
TRUNCATE TABLE tblBillsPaymentPaymentDisbtribution

UPDATE tblSystemSeries
SET NextNumber = 1
WHERE Code IN ('GJ', 'PJ', 'CDJ', 'SJ', 'CRJ')

UPDATE tblJournalVouchers
SET JournalId = NULL

UPDATE tblBills
SET JournalId = NULL

UPDATE tblSalesInvoices
SET JournalId = NULL

UPDATE tblCashReceipts
SET JournalId = NULL

UPDATE tblBillsPayment
SET JournalId = NULL

DECLARE @Id INT
DECLARE @JournalTypeId INT
DECLARE @tmp TABLE(Id INT, JournalTypeId INT)

--Journal Voucher
INSERT INTO @tmp(Id, JournalTypeId)
SELECT Id, 1
FROM tblJournalVouchers

	UNION ALL

--Bills
SELECT Id, 2
FROM tblBills

	UNION ALL

--Sales Invoice
SELECT Id, 3
FROM tblSalesInvoices

	UNION ALL

--Cash Receipt
SELECT Id, 4
FROM tblCashReceipts

	UNION ALL

--Bills Payment
SELECT Id, 5
FROM tblBillsPayment


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
UPDATE si
SET si.PaidAmount = ISNULL(tmp.Amount, 0)
FROM tblSalesInvoices si
	LEFT OUTER JOIN (
		SELECT crpd.InvoiceId, SUM(crpd.Amount) AS Amount
		FROM tblCashReceipts cr
			INNER JOIN tblCashReceiptPaymentDistribution crpd ON crpd.CashReceiptId = cr.Id
		WHERE cr.Voided = 0
		GROUP BY crpd.InvoiceId
	) tmp ON tmp.InvoiceId = si.Id
WHERE si.Voided = 0

UPDATE b
SET b.PaidAmount = ISNULL(tmp.Amount, 0)
FROM tblBills b
	LEFT OUTER JOIN (
		SELECT bppd.BillId, SUM(bppd.Amount) AS Amount
		FROM tblBillsPayment bp
			INNER JOIN tblBillsPaymentPaymentDisbtribution bppd ON bppd.BillsPaymentId = bp.Id
		WHERE bp.Voided = 0
		GROUP BY bppd.BillId
	) tmp ON tmp.BillId = b.Id
WHERE b.Voided = 0

ROLLBACK