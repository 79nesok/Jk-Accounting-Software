IF OBJECT_ID('uspGetUnpaidBills') IS NOT NULL
	DROP PROCEDURE uspGetUnpaidBills
GO

CREATE PROCEDURE uspGetUnpaidBills(@Id INT, @SubsidiaryId INT)
AS
SET NOCOUNT ON

IF NULLIF(@Id, 0) IS NULL
	SELECT b.Id AS SourceId, b.TransactionNo, b.[Date],
		b.ReferenceNo, b.ReferenceNo2, b.NetAmount,
		b.Balance, 0 AS AppliedAmount, 0 AS AmountToApply,
		b.Balance AS OldBalance
	FROM tblBills b
	WHERE b.SubsidiaryId = @SubsidiaryId
		AND b.Balance > 0
ELSE
	SELECT bpbd.SourceId, b.TransactionNo, b.[Date],
		b.ReferenceNo, b.ReferenceNo2, b.NetAmount,
		b.Balance, bpbd.AppliedAmount, 0 AS AmountToApply,
		b.Balance + tmp.Applied AS OldBalance
	FROM tblBillsPaymentBillDetails bpbd
		INNER JOIN tblBills b ON b.Id = bpbd.SourceId
		INNER JOIN (
			SELECT BillId, SUM(Amount) AS Applied
			FROM tblBillsPaymentPaymentDisbtribution
			WHERE BillsPaymentId = @Id
			GROUP BY BillId
		) tmp ON bpbd.SourceId = tmp.BillId
	WHERE bpbd.BillsPaymentId = @Id
GO

