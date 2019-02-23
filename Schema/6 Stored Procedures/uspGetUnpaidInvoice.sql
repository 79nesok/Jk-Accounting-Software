IF OBJECT_ID('uspGetUnpaidInvoice') IS NOT NULL
	DROP PROCEDURE uspGetUnpaidInvoice
GO

CREATE PROCEDURE uspGetUnpaidInvoice(@Id INT, @SubsidiaryId INT)
AS
SET NOCOUNT ON

SELECT sv.Id AS SourceId, sv.TransactionNo, sv.[Date],
	sv.ReferenceNo, sv.ReferenceNo2, sv.NetAmount,
	sv.Balance, ISNULL(cid.AppliedAmount, 0) AS AppliedAmount
FROM tblSalesVouchers sv
	LEFT OUTER JOIN tblCashReceiptVoucherInvoiceDetails cid ON cid.SourceId = sv.Id
		AND cid.CashReceiptVoucherId = @Id
WHERE sv.SubsidiaryId = @SubsidiaryId
	AND sv.Balance > 0
GO

