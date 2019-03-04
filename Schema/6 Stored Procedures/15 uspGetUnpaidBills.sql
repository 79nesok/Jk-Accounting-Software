IF OBJECT_ID('uspGetUnpaidBills') IS NOT NULL
	DROP PROCEDURE uspGetUnpaidBills
GO

CREATE PROCEDURE uspGetUnpaidBills(@Id INT, @SubsidiaryId INT)
AS
SET NOCOUNT ON

IF NULLIF(@Id, 0) IS NULL
	SELECT pv.Id AS SourceId, pv.TransactionNo, pv.[Date],
		pv.ReferenceNo, pv.ReferenceNo2, pv.NetAmount,
		pv.Balance, 0 AS AppliedAmount, 0 AS AmountToApply,
		pv.Balance AS OldBalance
	FROM tblPurchaseVouchers pv
	WHERE pv.SubsidiaryId = @SubsidiaryId
		AND pv.Balance > 0
ELSE
	SELECT did.SourceId, pv.TransactionNo, pv.[Date],
		pv.ReferenceNo, pv.ReferenceNo2, pv.NetAmount,
		pv.Balance, did.AppliedAmount, 0 AS AmountToApply,
		pv.Balance AS OldBalance
	FROM tblCashDisbursementVoucherBillsDetails did
		INNER JOIN tblPurchaseVouchers pv ON pv.Id = did.SourceId
	WHERE did.CashDisbursementVoucherId = @Id
GO

