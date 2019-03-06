IF OBJECT_ID('uspUpdateInvoiceAmounts') IS NOT NULL
	DROP PROCEDURE uspUpdateInvoiceAmounts
GO

CREATE PROCEDURE uspUpdateInvoiceAmounts(@Id INT, @IsPost BIT)
AS
SET NOCOUNT ON

--Update Invoice amounts
UPDATE sv
SET sv.PaidAmount = sv.PaidAmount + (cid.AppliedAmount * CASE WHEN @IsPost = 1 THEN 1 ELSE -1 END)
FROM tblSalesVouchers sv
	INNER JOIN tblCashReceiptVoucherInvoiceDetails cid ON cid.SourceId = sv.Id
WHERE cid.CashReceiptVoucherId = @Id

--Generate payment distribution
IF @IsPost = 1
BEGIN
	DECLARE @PaymentDetails TABLE(Id INT, Amount MONEY PRIMARY KEY(Id))
	DECLARE @InvoiceDetails TABLE(InvoiceId INT, AppliedAmount MONEY PRIMARY KEY(InvoiceId))
	DECLARE @DetailId INT
	DECLARE @InvoiceId INT
	DECLARE @Amount INT
	DECLARE @AppliedAmount INT

	INSERT INTO @PaymentDetails(Id, Amount)
	SELECT Id, Amount
	FROM tblCashReceiptVoucherDetails
	WHERE CashReceiptVoucherId = @Id

	INSERT INTO @InvoiceDetails(InvoiceId, AppliedAmount)
	SELECT SourceId, AppliedAmount
	FROM tblCashReceiptVoucherInvoiceDetails
	WHERE CashReceiptVoucherId = @Id

	WHILE 1 = 1
	BEGIN
		SELECT TOP 1
			@DetailId = Id,
			@Amount = Amount
		FROM @PaymentDetails
		WHERE Amount > 0

		SELECT TOP 1
			@InvoiceId = InvoiceId,
			@AppliedAmount = AppliedAmount
		FROM @InvoiceDetails
		WHERE AppliedAmount > 0

		SET @Amount = CASE WHEN @AppliedAmount > @Amount THEN @Amount ELSE @AppliedAmount END

		INSERT INTO tblCashReceiptVoucherPaymentDistribution(CashReceiptVoucherId, CashReceiptVoucherDetailId, InvoiceId, Amount)
		SELECT @Id, @DetailId, @InvoiceId, @Amount

		UPDATE @PaymentDetails
		SET Amount = Amount - @Amount
		WHERE Id = @DetailId

		UPDATE @InvoiceDetails
		SET AppliedAmount = AppliedAmount - @Amount
		WHERE InvoiceId = @InvoiceId

		IF NOT EXISTS(SELECT * FROM @PaymentDetails WHERE Amount > 0)
			OR NOT EXISTS(SELECT * FROM @InvoiceDetails WHERE AppliedAmount > 0)
			BREAK
	END
END
ELSE
BEGIN
	DELETE pd
	FROM tblCashReceiptVoucherPaymentDistribution pd
	WHERE pd.CashReceiptVoucherId = @Id
END

--Create Customer Overpayment
IF EXISTS(
	SELECT cv.Id
	FROM tblCashReceiptVouchers cv
		INNER JOIN (
			SELECT cd.CashReceiptVoucherId, SUM(cd.Amount) AS Amount
			FROM tblCashReceiptVoucherDetails cd
			GROUP BY cd.CashReceiptVoucherId
		) cd ON cd.CashReceiptVoucherId = cv.Id
		INNER JOIN (
			SELECT cid.CashReceiptVoucherId, SUM(cid.AppliedAmount) AS AppliedAmount
			FROM tblCashReceiptVoucherInvoiceDetails cid
			GROUP BY cid.CashReceiptVoucherId
		) cid ON cid.CashReceiptVoucherId = cv.Id
	WHERE cv.Id = @Id
		AND cd.Amount <> cid.AppliedAmount
)
BEGIN
	IF NOT EXISTS(
		SELECT *
		FROM tblCustomerOverpayments
		WHERE SourceId = @Id
	)
	BEGIN
		DECLARE @TransactionNo VARCHAR(50)
		DECLARE @Remarks VARCHAR(1000)
		DECLARE @CompanyId INT

		SELECT @CompanyId = CompanyId
		FROM tblCashReceiptVouchers
		WHERE Id = @Id

		UPDATE tblSystemSeries
		SET @TransactionNo = NextSeries,
			NextNumber = NextNumber + 1
		WHERE CompanyId = @CompanyId
			AND Code = 'COP'

		SET @Remarks = 'System generated transaction for overpayment applied on Customer Payment number: ' + (SELECT TransactionNo FROM tblCashReceiptVouchers WHERE Id = @Id)

		INSERT INTO tblCustomerOverpayments(CompanyId, TransactionNo, [Date], ReferenceNo, ReferenceNo2,
			SubsidiaryId, Remarks, Amount, AmountApplied, SourceId, CreatedById,
			DateCreated, ModifiedById, DateModified)
		SELECT cv.CompanyId, @TransactionNo, cv.[Date], cv.TransactionNo, NULL,
			cv.SubsidiaryId, @Remarks, cd.Amount - cid.AppliedAmount, 0, cv.Id, cv.CreatedById,
			GETDATE(), cv.ModifiedById, GETDATE()
		FROM tblCashReceiptVouchers cv
			INNER JOIN (
				SELECT cd.CashReceiptVoucherId, SUM(cd.Amount) AS Amount
				FROM tblCashReceiptVoucherDetails cd
				GROUP BY cd.CashReceiptVoucherId
			) cd ON cd.CashReceiptVoucherId = cv.Id
			INNER JOIN (
				SELECT cid.CashReceiptVoucherId, SUM(cid.AppliedAmount) AS AppliedAmount
				FROM tblCashReceiptVoucherInvoiceDetails cid
				GROUP BY cid.CashReceiptVoucherId
			) cid ON cid.CashReceiptVoucherId = cv.Id
		WHERE cv.Id = @Id
	END
	ELSE
	BEGIN
		UPDATE co
		SET co.Amount = cv.Amount,
			co.SubsidiaryId = cv.SubsidiaryId,
			co.ModifiedById = cv.ModifiedById,
			co.DateModified = GETDATE()
		FROM tblCustomerOverpayments co
			INNER JOIN (
				SELECT cv.Id, cd.Amount - cid.AppliedAmount AS Amount,
					cv.SubsidiaryId, cv.ModifiedById
				FROM tblCashReceiptVouchers cv
				INNER JOIN (
					SELECT cd.CashReceiptVoucherId, SUM(cd.Amount) AS Amount
					FROM tblCashReceiptVoucherDetails cd
					GROUP BY cd.CashReceiptVoucherId
				) cd ON cd.CashReceiptVoucherId = cv.Id
				INNER JOIN (
					SELECT cid.CashReceiptVoucherId, SUM(cid.AppliedAmount) AS AppliedAmount
					FROM tblCashReceiptVoucherInvoiceDetails cid
					GROUP BY cid.CashReceiptVoucherId
				) cid ON cid.CashReceiptVoucherId = cv.Id
			) cv ON cv.Id = co.SourceId
		WHERE co.SourceId = @Id
	END
END
GO

