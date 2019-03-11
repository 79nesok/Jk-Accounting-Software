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
	SELECT cid.SourceId, si.TransactionNo, si.[Date],
		si.ReferenceNo, si.ReferenceNo2, si.NetAmount,
		si.Balance, cid.AppliedAmount, 0 AS AmountToApply,
		si.Balance AS OldBalance
	FROM tblCashReceiptVoucherInvoiceDetails cid
		INNER JOIN tblSalesInvoices si ON si.Id = cid.SourceId
	WHERE cid.CashReceiptVoucherId = @Id
GO

