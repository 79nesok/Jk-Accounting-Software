IF OBJECT_ID('uspUpdateBillsAmounts') IS NOT NULL
	DROP PROCEDURE uspUpdateBillsAmounts
GO

CREATE PROCEDURE uspUpdateBillsAmounts(@Id INT, @IsPost BIT)
AS
SET NOCOUNT ON

--Update Invoice amounts
UPDATE pv
SET pv.PaidAmount = pv.PaidAmount + (cbd.AppliedAmount * CASE WHEN @IsPost = 1 THEN 1 ELSE -1 END)
FROM tblPurchaseVouchers pv
	INNER JOIN tblCashDisbursementVoucherBillsDetails cbd ON cbd.SourceId = pv.Id
WHERE cbd.CashDisbursementVoucherId = @Id

--Generate payment distribution
IF @IsPost = 1
BEGIN
	DECLARE @PaymentDetails TABLE(Id INT, Amount MONEY PRIMARY KEY(Id))
	DECLARE @BillsDetails TABLE(BillId INT, AppliedAmount MONEY PRIMARY KEY(BillId))
	DECLARE @DetailId INT
	DECLARE @BillId INT
	DECLARE @Amount INT
	DECLARE @AppliedAmount INT

	INSERT INTO @PaymentDetails(Id, Amount)
	SELECT Id, Amount
	FROM tblCashDisbursementVoucherDetails
	WHERE CashDisbursementVoucherId = @Id

	INSERT INTO @BillsDetails(BillId, AppliedAmount)
	SELECT SourceId, AppliedAmount
	FROM tblCashDisbursementVoucherBillsDetails
	WHERE CashDisbursementVoucherId = @Id

	WHILE 1 = 1
	BEGIN
		SELECT TOP 1
			@DetailId = Id,
			@Amount = Amount
		FROM @PaymentDetails
		WHERE Amount > 0

		SELECT TOP 1
			@BillId = BillId,
			@AppliedAmount = AppliedAmount
		FROM @BillsDetails
		WHERE AppliedAmount > 0

		SET @Amount = CASE WHEN @AppliedAmount > @Amount THEN @Amount ELSE @AppliedAmount END

		INSERT INTO tblCashDisbursementVoucherPaymentDistribution(CashDisbursementVoucherId, CashDisbursementVoucherDetailId, BillId, Amount)
		SELECT @Id, @DetailId, @BillId, @Amount

		UPDATE @PaymentDetails
		SET Amount = Amount - @Amount
		WHERE Id = @DetailId

		UPDATE @BillsDetails
		SET AppliedAmount = AppliedAmount - @Amount
		WHERE BillId = @BillId

		IF NOT EXISTS(SELECT * FROM @PaymentDetails WHERE Amount > 0)
			OR NOT EXISTS(SELECT * FROM @BillsDetails WHERE AppliedAmount > 0)
			BREAK
	END
END
ELSE
BEGIN
	DELETE pd
	FROM tblCashDisbursementVoucherPaymentDistribution pd
	WHERE pd.CashDisbursementVoucherId = @Id
END
GO

