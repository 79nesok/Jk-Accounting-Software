IF OBJECT_ID('uspGetUnpaidInvoice') IS NOT NULL
	DROP PROCEDURE uspGetUnpaidInvoice
GO

CREATE PROCEDURE uspGetUnpaidInvoice(@Id INT, @SubsidiaryId INT)
AS
SET NOCOUNT ON

IF NULLIF(@Id, 0) IS NULL
	SELECT si.Id AS SourceId, si.TransactionNo, si.[Date],
		si.ReferenceNo, si.ReferenceNo2, si.NetAmount,
		si.Balance, 0 AS AppliedAmount, 0 AS AmountToApply,
		si.Balance AS OldBalance
	FROM tblSalesInvoices si
	WHERE si.SubsidiaryId = @SubsidiaryId
		AND si.Balance > 0
ELSE
	SELECT crid.SourceId, si.TransactionNo, si.[Date],
		si.ReferenceNo, si.ReferenceNo2, si.NetAmount,
		si.Balance, crid.AppliedAmount, 0 AS AmountToApply,
		si.Balance + tmp.Applied AS OldBalance
	FROM tblCashReceiptInvoiceDetails crid
		INNER JOIN tblSalesInvoices si ON si.Id = crid.SourceId
		INNER JOIN (
			SELECT InvoiceId, SUM(Amount) AS Applied
			FROM tblCashReceiptPaymentDistribution
			WHERE CashReceiptId = @Id
			GROUP BY InvoiceId
		) tmp ON tmp.InvoiceId = crid.SourceId
	WHERE crid.CashReceiptId = @Id
GO

