IF OBJECT_ID('uspUpdateJournals') IS NOT NULL
	DROP PROCEDURE uspUpdateJournals
GO

CREATE PROCEDURE uspUpdateJournals(@JournalTypeId INT, @Id INT, @IsPost BIT)
AS
SET NOCOUNT ON

DECLARE @JournalId INT
DECLARE @TransactionNo VARCHAR(50)
DECLARE @Code VARCHAR(50)
DECLARE @CompanyId INT
DECLARE @IsNew BIT = 0

DECLARE @InputVATAccountId INT
DECLARE @PayableAccountId INT
DECLARE @OutputVATAccountId INT
DECLARE @ReceivableAccountId INT
DECLARE @CustomerOverPaymentAccountId INT
DECLARE @PaymentMethodName VARCHAR(100)
DECLARE @WithholdingTaxAccountId INT
DECLARE @HasSourceTransaction BIT

SELECT @Code = Code
FROM tblJournalTypes
WHERE Id = @JournalTypeId

IF @JournalTypeId = 1
	SELECT @JournalId = JournalId,
		@CompanyId = CompanyId
	FROM tblJournalVouchers
	WHERE Id = @Id
ELSE IF @JournalTypeId = 2
	SELECT @JournalId = JournalId,
		@CompanyId = CompanyId
	FROM tblBills
	WHERE Id = @Id
ELSE IF @JournalTypeId = 3
	SELECT @JournalId = JournalId,
		@CompanyId = CompanyId
	FROM tblSalesInvoices
	WHERE Id = @Id
ELSE IF @JournalTypeId = 4
	SELECT @JournalId = cr.JournalId,
		@CompanyId = cr.CompanyId,
		@HasSourceTransaction = pt.HasSourceTransaction
	FROM tblCashReceipts cr
		INNER JOIN tblPaymentTypes pt ON pt.Id = cr.PaymentTypeId
	WHERE cr.Id = @Id
ELSE IF @JournalTypeId = 5
	SELECT @JournalId = bp.JournalId,
		@CompanyId = bp.CompanyId,
		@HasSourceTransaction = pt.HasSourceTransaction
	FROM tblBillsPayment bp
		INNER JOIN tblPaymentTypes pt ON pt.Id = bp.PaymentTypeId
	WHERE bp.Id = @Id

SELECT @InputVATAccountId = a.Id
FROM tblAccounts a
	INNER JOIN tblSystemAccountCodes ac ON ac.Id = a.SystemAccountCodeId
WHERE a.CompanyId = @CompanyId
	AND ac.Name = 'INPUT VAT'

SELECT @PayableAccountId = a.Id
FROM tblAccounts a
	INNER JOIN tblSystemAccountCodes ac ON ac.Id = a.SystemAccountCodeId
WHERE a.CompanyId = @CompanyId
	AND ac.Name = 'ACCOUNTS PAYABLE'

SELECT @OutputVATAccountId = a.Id
FROM tblAccounts a
	INNER JOIN tblSystemAccountCodes ac ON ac.Id = a.SystemAccountCodeId
WHERE a.CompanyId = @CompanyId
	AND ac.Name = 'OUTPUT VAT'

SELECT @ReceivableAccountId = a.Id
FROM tblAccounts a
	INNER JOIN tblSystemAccountCodes ac ON ac.Id = a.SystemAccountCodeId
WHERE a.CompanyId = @CompanyId
	AND ac.Name = 'ACCOUNTS RECEIVABLE'

SELECT @CustomerOverPaymentAccountId = a.Id
FROM tblAccounts a
	INNER JOIN tblSystemAccountCodes ac ON ac.Id = a.SystemAccountCodeId
WHERE a.CompanyId = @CompanyId
	AND ac.Name = 'CUSTOMER OVERPAYMENT'

SELECT @WithholdingTaxAccountId = a.Id
FROM tblAccounts a
	INNER JOIN tblSystemAccountCodes ac ON ac.Id = a.SystemAccountCodeId
WHERE a.CompanyId = @CompanyId
	AND ac.Name = 'WITHHOLDING TAX PAYABLE'

IF @IsPost = 1
BEGIN
	IF @JournalTypeId = 1
	BEGIN
		IF @JournalId IS NULL
		BEGIN
			INSERT INTO tblJournals(CompanyId, JournalTypeId, TransactionNo, [Date],
				ReferenceNo, ReferenceNo2, Remarks, SourceId, SourceTransactionNo,
				CreatedById, DateCreated, ModifiedById, DateModified)
			SELECT CompanyId, @JournalTypeId, TransactionNo, [Date],
				ReferenceNo, ReferenceNo2, Remarks, Id, TransactionNo,
				CreatedById, DateCreated, ModifiedById, DateModified
			FROM tblJournalVouchers
			WHERE Id = @Id
				AND @JournalTypeId = 1
	
			SET @JournalId = SCOPE_IDENTITY()

			UPDATE tblJournalVouchers
			SET JournalId = @JournalId
			WHERE Id = @Id

			SET @IsNew = 1
		END
		ELSE
		BEGIN
			UPDATE j
			SET j.[Date] = jv.[Date],
				j.ReferenceNo = jv.ReferenceNo,
				j.ReferenceNo2 = jv.ReferenceNo2,
				j.Remarks = jv.Remarks,
				j.ModifiedById = jv.ModifiedById,
				j.DateModified = jv.DateModified
			FROM tblJournals j
				INNER JOIN tblJournalVouchers jv ON jv.JournalId = j.Id
			WHERE j.Id = @JournalId
				AND @JournalTypeId = 1
		END
	
		INSERT INTO tblJournalDetails(JournalId, AccountId, SubsidiaryId, Debit, Credit, Remarks)
		SELECT @JournalId, AccountId, SubsidiaryId, Debit, Credit, Remarks
		FROM tblJournalVoucherDetails
		WHERE JournalVoucherId = @Id
	END
	ELSE IF @JournalTypeId = 2
	BEGIN
		IF @JournalId IS NULL
		BEGIN
			INSERT INTO tblJournals(CompanyId, JournalTypeId, TransactionNo, [Date],
				ReferenceNo, ReferenceNo2, Remarks, SourceId, SourceTransactionNo,
				CreatedById, DateCreated, ModifiedById, DateModified)
			SELECT CompanyId, @JournalTypeId, TransactionNo, [Date],
				ReferenceNo, ReferenceNo2, Remarks, Id, TransactionNo,
				CreatedById, DateCreated, ModifiedById, DateModified
			FROM tblBills
			WHERE Id = @Id
				AND @JournalTypeId = 2
	
			SET @JournalId = SCOPE_IDENTITY()

			UPDATE tblBills
			SET JournalId = @JournalId
			WHERE Id = @Id

			SET @IsNew = 1
		END
		ELSE
		BEGIN
			UPDATE j
			SET j.[Date] = pv.[Date],
				j.ReferenceNo = pv.ReferenceNo,
				j.ReferenceNo2 = pv.ReferenceNo2,
				j.Remarks = pv.Remarks,
				j.ModifiedById = pv.ModifiedById,
				j.DateModified = pv.DateModified
			FROM tblJournals j
				INNER JOIN tblBills pv ON pv.JournalId = j.Id
			WHERE j.Id = @JournalId
				AND @JournalTypeId = 2
		END
	
		--Purchases
		INSERT INTO tblJournalDetails(JournalId, AccountId, SubsidiaryId, Debit, Credit, Remarks)
		SELECT @JournalId, AccountId, SubsidiaryId, SUM(GrossAmount), 0, Remarks
		FROM tblBillDetails
		WHERE BillId = @Id
		GROUP BY AccountId, SubsidiaryId, Remarks

		--Input VAT
		IF EXISTS(
			SELECT *
			FROM tblBills
			WHERE Id = @Id
				AND VATAmount > 0
		)
		AND @InputVATAccountId IS NULL
		BEGIN
			RAISERROR('No Input VAT Account has been set-up.', 11, 1)
			RETURN
		END

		INSERT INTO tblJournalDetails(JournalId, AccountId, SubsidiaryId, Debit, Credit, Remarks)
		SELECT @JournalId, @InputVATAccountId, SubsidiaryId, SUM(VATAmount), 0, Remarks
		FROM tblBillDetails
		WHERE BillId = @Id
		GROUP BY SubsidiaryId, Remarks
		HAVING SUM(VATAmount) > 0

		--Payable
		IF @PayableAccountId IS NULL
		BEGIN
			RAISERROR('No Payable Account has been set-up.', 11, 1)
			RETURN
		END

		INSERT INTO tblJournalDetails(JournalId, AccountId, SubsidiaryId, Debit, Credit, Remarks)
		SELECT @JournalId, @PayableAccountId, SubsidiaryId, 0, NetAmount, Remarks
		FROM tblBills
		WHERE Id = @Id
	END
	ELSE IF @JournalTypeId = 3
	BEGIN
		IF @JournalId IS NULL
		BEGIN
			INSERT INTO tblJournals(CompanyId, JournalTypeId, TransactionNo, [Date],
				ReferenceNo, ReferenceNo2, Remarks, SourceId, SourceTransactionNo,
				CreatedById, DateCreated, ModifiedById, DateModified)
			SELECT CompanyId, @JournalTypeId, TransactionNo, [Date],
				ReferenceNo, ReferenceNo2, Remarks, Id, TransactionNo,
				CreatedById, DateCreated, ModifiedById, DateModified
			FROM tblSalesInvoices
			WHERE Id = @Id
				AND @JournalTypeId = 3
	
			SET @JournalId = SCOPE_IDENTITY()

			UPDATE tblSalesInvoices
			SET JournalId = @JournalId
			WHERE Id = @Id

			SET @IsNew = 1
		END
		ELSE
		BEGIN
			UPDATE j
			SET j.[Date] = si.[Date],
				j.ReferenceNo = si.ReferenceNo,
				j.ReferenceNo2 = si.ReferenceNo2,
				j.Remarks = si.Remarks,
				j.ModifiedById = si.ModifiedById,
				j.DateModified = si.DateModified
			FROM tblJournals j
				INNER JOIN tblSalesInvoices si ON si.JournalId = j.Id
			WHERE j.Id = @JournalId
				AND @JournalTypeId = 3
		END

		IF @ReceivableAccountId IS NULL
		BEGIN
			RAISERROR('No Receivable Account has been set-up.', 11, 1)
			RETURN
		END
	
		--Receivable
		INSERT INTO tblJournalDetails(JournalId, AccountId, SubsidiaryId, Debit, Credit, Remarks)
		SELECT @JournalId, @ReceivableAccountId, SubsidiaryId, NetAmount, 0, Remarks
		FROM tblSalesInvoices
		WHERE Id = @Id

		--Sales
		INSERT INTO tblJournalDetails(JournalId, AccountId, SubsidiaryId, Debit, Credit, Remarks)
		SELECT @JournalId, AccountId, SubsidiaryId, 0, SUM(GrossAmount), Remarks
		FROM tblSalesInvoiceDetails
		WHERE SalesInvoiceId = @Id
		GROUP BY AccountId, SubsidiaryId, Remarks

		--Output VAT
		IF EXISTS(
			SELECT *
			FROM tblSalesInvoices
			WHERE Id = @Id
				AND VATAmount > 0
		)
		AND @OutputVATAccountId IS NULL
		BEGIN
			RAISERROR('No Output VAT Account has been set-up.', 11, 1)
			RETURN
		END

		INSERT INTO tblJournalDetails(JournalId, AccountId, SubsidiaryId, Debit, Credit, Remarks)
		SELECT @JournalId, @OutputVATAccountId, SubsidiaryId, 0, SUM(VATAmount), Remarks
		FROM tblSalesInvoiceDetails
		WHERE SalesInvoiceId = @Id
		GROUP BY SubsidiaryId, Remarks
		HAVING SUM(VATAmount) > 0
	END
	ELSE IF @JournalTypeId = 4
	BEGIN
		IF @HasSourceTransaction = 1
			--Post payment to invoice
			EXEC uspUpdateInvoiceAmounts @Id, @IsPost

		IF @JournalId IS NULL
		BEGIN
			INSERT INTO tblJournals(CompanyId, JournalTypeId, TransactionNo, [Date],
				ReferenceNo, ReferenceNo2, Remarks, SourceId, SourceTransactionNo,
				CreatedById, DateCreated, ModifiedById, DateModified)
			SELECT CompanyId, @JournalTypeId, TransactionNo, [Date],
				ReferenceNo, ReferenceNo2, Remarks, Id, TransactionNo,
				CreatedById, DateCreated, ModifiedById, DateModified
			FROM tblCashReceipts
			WHERE Id = @Id
				AND @JournalTypeId = 4
	
			SET @JournalId = SCOPE_IDENTITY()

			UPDATE tblCashReceipts
			SET JournalId = @JournalId
			WHERE Id = @Id

			SET @IsNew = 1
		END
		ELSE
		BEGIN
			UPDATE j
			SET j.[Date] = cr.[Date],
				j.ReferenceNo = cr.ReferenceNo,
				j.ReferenceNo2 = cr.ReferenceNo2,
				j.Remarks = cr.Remarks,
				j.ModifiedById = cr.ModifiedById,
				j.DateModified = cr.DateModified
			FROM tblJournals j
				INNER JOIN tblCashReceipts cr ON cr.JournalId = j.Id
			WHERE j.Id = @JournalId
				AND @JournalTypeId = 4
		END

		SELECT @PaymentMethodName = pm.Name
		FROM tblCashReceiptDetails crd
			INNER JOIN tblPaymentMethods pm ON pm.Id = crd.PaymentMethodId
		WHERE crd.CashReceiptId = @Id
			AND pm.AccountId IS NULL

		IF NULLIF(@PaymentMethodName, '') IS NOT NULL
		BEGIN
			RAISERROR('Please set-up account for this Payment Method: %s', 11, 1, @PaymentMethodName)
			RETURN
		END

		--Payment
		INSERT INTO tblJournalDetails(JournalId, AccountId, Debit, Credit)
		SELECT @JournalId, pm.AccountId, SUM(crd.Amount), 0
		FROM tblCashReceiptDetails crd
			INNER JOIN tblPaymentMethods pm ON pm.Id = crd.PaymentMethodId
		WHERE crd.CashReceiptId = @Id
		GROUP BY pm.AccountId

		IF @HasSourceTransaction = 1
		BEGIN
			--Receivable
			IF @ReceivableAccountId IS NULL
			BEGIN
				RAISERROR('No Receivable Account has been set-up.', 11, 1)
				RETURN
			END

			INSERT INTO tblJournalDetails(JournalId, AccountId, SubsidiaryId, Debit, Credit)
			SELECT @JournalId, @ReceivableAccountId, cr.SubsidiaryId, 0, SUM(crid.AppliedAmount)
			FROM tblCashReceiptInvoiceDetails crid
				INNER JOIN tblCashReceipts cr ON cr.Id = crid.CashReceiptId
			WHERE crid.CashReceiptId = @Id
			GROUP BY cr.SubsidiaryId

			--Overpayment
			IF @CustomerOverPaymentAccountId IS NULL
				AND EXISTS(
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
						) cid ON cid.CashReceiptId = cr.Id
					WHERE cr.Id = @Id
						AND cd.Amount <> cid.AppliedAmount
				)
			BEGIN
				RAISERROR('No Customer Overpayment Account has been set-up.', 11, 1)
				RETURN
			END

			INSERT INTO tblJournalDetails(JournalId, AccountId, SubsidiaryId, Debit, Credit)
			SELECT @JournalId, @CustomerOverPaymentAccountId, cr.SubsidiaryId, 0, cd.Amount - cid.AppliedAmount
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
				) cid ON cid.CashReceiptId = cr.Id
			WHERE cr.Id = @Id
				AND cd.Amount > cid.AppliedAmount
		END
		ELSE
		BEGIN
			INSERT INTO tblJournalDetails(JournalId, AccountId, SubsidiaryId, Debit, Credit, Remarks)
			SELECT @JournalId, AccountId, SubsidiaryId, Debit, Credit, Remarks
			FROM tblCashReceiptAccountDetails
			WHERE CashReceiptId = @Id
		END
	END
	ELSE IF @JournalTypeId = 5
	BEGIN
		--Post payment to bills
		IF @HasSourceTransaction = 1
			EXEC uspUpdateBillsAmounts @Id, @IsPost

		IF @JournalId IS NULL
		BEGIN
			INSERT INTO tblJournals(CompanyId, JournalTypeId, TransactionNo, [Date],
				ReferenceNo, ReferenceNo2, Remarks, SourceId, SourceTransactionNo,
				CreatedById, DateCreated, ModifiedById, DateModified)
			SELECT CompanyId, @JournalTypeId, TransactionNo, [Date],
				ReferenceNo, ReferenceNo2, Remarks, Id, TransactionNo,
				CreatedById, DateCreated, ModifiedById, DateModified
			FROM tblBillsPayment
			WHERE Id = @Id
				AND @JournalTypeId = 5
	
			SET @JournalId = SCOPE_IDENTITY()

			UPDATE tblBillsPayment
			SET JournalId = @JournalId
			WHERE Id = @Id

			SET @IsNew = 1
		END
		ELSE
		BEGIN
			UPDATE j
			SET j.[Date] = bp.[Date],
				j.ReferenceNo = bp.ReferenceNo,
				j.ReferenceNo2 = bp.ReferenceNo2,
				j.Remarks = bp.Remarks,
				j.ModifiedById = bp.ModifiedById,
				j.DateModified = bp.DateModified
			FROM tblJournals j
				INNER JOIN tblBillsPayment bp ON bp.JournalId = j.Id
			WHERE j.Id = @JournalId
				AND @JournalTypeId = 5
		END

		IF @HasSourceTransaction = 1
		BEGIN
			--Payable
			IF @PayableAccountId IS NULL
			BEGIN
				RAISERROR('No Payable Account has been set-up.', 11, 1)
				RETURN
			END

			INSERT INTO tblJournalDetails(JournalId, AccountId, SubsidiaryId, Debit, Credit)
			SELECT @JournalId, @PayableAccountId, bp.SubsidiaryId, SUM(bpbd.AppliedAmount), 0
			FROM tblBillsPaymentBillDetails bpbd
				INNER JOIN tblBillsPayment bp ON bp.Id = bpbd.BillsPaymentId
			WHERE bpbd.BillsPaymentId = @Id
			GROUP BY bp.SubsidiaryId
		END
		ELSE
		BEGIN
			INSERT INTO tblJournalDetails(JournalId, AccountId, SubsidiaryId, Debit, Credit)
			SELECT @JournalId, AccountId, SubsidiaryId, Debit, Credit
			FROM tblBillsPaymentAccountDetails
			WHERE BillsPaymentId = @Id
		END

		SELECT @PaymentMethodName = pm.Name
		FROM tblBillsPaymentDetails bpd
			INNER JOIN tblPaymentMethods pm ON pm.Id = bpd.PaymentMethodId
		WHERE bpd.BillsPaymentId = @Id
			AND pm.AccountId IS NULL

		IF NULLIF(@PaymentMethodName, '') IS NOT NULL
		BEGIN
			RAISERROR('Please set-up account for this Payment Method: %s', 11, 1, @PaymentMethodName)
			RETURN
		END

		--Payment
		INSERT INTO tblJournalDetails(JournalId, AccountId, Debit, Credit)
		SELECT @JournalId, pm.AccountId, 0, SUM(bpd.Amount)
		FROM tblBillsPaymentDetails bpd
			INNER JOIN tblPaymentMethods pm ON pm.Id = bpd.PaymentMethodId
		WHERE bpd.BillsPaymentId = @Id
		GROUP BY pm.AccountId
	END
	
	EXEC uspUpdateLedgers @JournalId, 1

	--Assign correct TransactionNo
	IF @IsNew = 1
	BEGIN
		UPDATE tblSystemSeries
		SET @TransactionNo = NextSeries,
			NextNumber = NextNumber + 1
		WHERE CompanyId = @CompanyId
			AND Code = @Code

		UPDATE tblJournals
		SET TransactionNo = @TransactionNo
		WHERE Id = @JournalId
	END
END
ELSE
BEGIN
	EXEC uspUpdateLedgers @JournalId, 0
	
	DELETE
	FROM tblJournalDetails
	WHERE JournalId = @JournalId

	--if Cash Receipt Voucher, unpost payment to invoice
	IF @JournalTypeId = 4
	BEGIN
		EXEC uspUpdateInvoiceAmounts @Id, @IsPost
	END

	--if Cash Disbursement Voucher, unpost payment to bills
	ELSE IF @JournalTypeId = 5
	BEGIN
		EXEC uspUpdateBillsAmounts @Id, @IsPost
	END
END
GO

