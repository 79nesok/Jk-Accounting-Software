IF OBJECT_ID('uspGetUnpaidInvoice') IS NOT NULL
	DROP PROCEDURE uspGetUnpaidInvoice
GO

CREATE PROCEDURE uspGetUnpaidInvoice(@Id INT, @SubsidiaryId INT)
AS
SET NOCOUNT ON

IF NULLIF(@Id, 0) IS NULL
	SELECT sv.Id AS SourceId, sv.TransactionNo, sv.[Date],
		sv.ReferenceNo, sv.ReferenceNo2, sv.NetAmount,
		sv.Balance, 0 AS AppliedAmount, 0 AS AmountToApply,
		sv.Balance AS OldBalance
	FROM tblSalesVouchers sv
	WHERE sv.SubsidiaryId = @SubsidiaryId
		AND sv.Balance > 0
ELSE
	SELECT cid.SourceId, sv.TransactionNo, sv.[Date],
		sv.ReferenceNo, sv.ReferenceNo2, sv.NetAmount,
		sv.Balance, cid.AppliedAmount, 0 AS AmountToApply,
		sv.Balance AS OldBalance
	FROM tblCashReceiptVoucherInvoiceDetails cid
		INNER JOIN tblSalesVouchers sv ON sv.Id = cid.SourceId
	WHERE cid.CashReceiptVoucherId = @Id
GO

