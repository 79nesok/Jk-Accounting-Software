IF OBJECT_ID('uspUpdateInvoiceAmounts') IS NOT NULL
	DROP PROCEDURE uspUpdateInvoiceAmounts
GO

CREATE PROCEDURE uspUpdateInvoiceAmounts(@Id INT, @IsPost BIT)
AS
SET NOCOUNT ON

--Update Invoice amounts
UPDATE si
SET si.PaidAmount = si.PaidAmount + (crid.AppliedAmount * CASE WHEN @IsPost = 1 THEN 1 ELSE -1 END)
FROM tblSalesInvoices si
	INNER JOIN tblCashReceiptInvoiceDetails crid ON crid.SourceId = si.Id
WHERE crid.CashReceiptId = @Id

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
	FROM tblCashReceiptDetails
	WHERE CashReceiptId = @Id

	INSERT INTO @InvoiceDetails(InvoiceId, AppliedAmount)
	SELECT SourceId, AppliedAmount
	FROM tblCashReceiptInvoiceDetails
	WHERE CashReceiptId = @Id

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

		INSERT INTO tblCashReceiptPaymentDistribution(CashReceiptId, CashReceiptDetailId, InvoiceId, Amount)
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
	DELETE crpd
	FROM tblCashReceiptPaymentDistribution crpd
	WHERE crpd.CashReceiptId = @Id
END

--Create Customer Overpayment
IF EXISTS(
	SELECT cr.Id
	FROM tblCashReceipts cr
		INNER JOIN (
			SELECT crd.CashReceiptId, SUM(crd.Amount) AS Amount
			FROM tblCashReceiptDetails crd
			GROUP BY crd.CashReceiptId
		) cd ON cd.CashReceiptId = cr.Id
		INNER JOIN (
			SELECT crid.CashReceiptId, SUM(crid.AppliedAmount) AS AppliedAmount
			FROM tblCashReceiptInvoiceDetails crid
			GROUP BY crid.CashReceiptId
		) crid ON crid.CashReceiptId = cr.Id
	WHERE cr.Id = @Id
		AND cd.Amount <> crid.AppliedAmount
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
		SELECT cr.CompanyId, @TransactionNo, cr.[Date], cr.TransactionNo, NULL,
			cr.SubsidiaryId, @Remarks, cd.Amount - crid.AppliedAmount, 0, cr.Id, cr.CreatedById,
			GETDATE(), cr.ModifiedById, GETDATE()
		FROM tblCashReceipts cr
			INNER JOIN (
				SELECT crd.CashReceiptId, SUM(crd.Amount) AS Amount
				FROM tblCashReceiptDetails crd
				GROUP BY crd.CashReceiptId
			) cd ON cd.CashReceiptId = cr.Id
			INNER JOIN (
				SELECT crid.CashReceiptId, SUM(crid.AppliedAmount) AS AppliedAmount
				FROM tblCashReceiptInvoiceDetails crid
				GROUP BY crid.CashReceiptId
			) crid ON crid.CashReceiptId = cr.Id
		WHERE cr.Id = @Id
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
				SELECT cr.Id, cd.Amount - crid.AppliedAmount AS Amount,
					cr.SubsidiaryId, cr.ModifiedById
				FROM tblCashReceipts cr
				INNER JOIN (
					SELECT crd.CashReceiptId, SUM(crd.Amount) AS Amount
					FROM tblCashReceiptDetails crd
					GROUP BY crd.CashReceiptId
				) cd ON cd.CashReceiptId = cr.Id
				INNER JOIN (
					SELECT crid.CashReceiptId, SUM(crid.AppliedAmount) AS AppliedAmount
					FROM tblCashReceiptInvoiceDetails crid
					GROUP BY crid.CashReceiptId
				) crid ON crid.CashReceiptId = cr.Id
			) cv ON cv.Id = co.SourceId
		WHERE co.SourceId = @Id
	END
END
GO

