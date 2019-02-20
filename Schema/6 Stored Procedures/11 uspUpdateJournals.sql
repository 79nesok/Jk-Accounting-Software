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
	FROM tblPurchaseVouchers
	WHERE Id = @Id
ELSE IF @JournalTypeId = 3
	SELECT @JournalId = JournalId,
		@CompanyId = CompanyId
	FROM tblSalesVouchers
	WHERE Id = @Id

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
			FROM tblPurchaseVouchers
			WHERE Id = @Id
				AND @JournalTypeId = 2
	
			SET @JournalId = SCOPE_IDENTITY()

			UPDATE tblPurchaseVouchers
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
				j.ModifiedById = pv.ModifiedById,
				j.DateModified = pv.DateModified
			FROM tblJournals j
				INNER JOIN tblPurchaseVouchers pv ON pv.JournalId = j.Id
			WHERE j.Id = @JournalId
				AND @JournalTypeId = 2
		END
	
		--Purchases
		INSERT INTO tblJournalDetails(JournalId, AccountId, SubsidiaryId, Debit, Credit, Remarks)
		SELECT @JournalId, AccountId, SubsidiaryId, SUM(GrossAmount), 0, Remarks
		FROM tblPurchaseVoucherDetails
		WHERE PurchaseVoucherId = @Id
		GROUP BY AccountId, SubsidiaryId, Remarks

		--Input VAT
		IF EXISTS(
			SELECT *
			FROM tblPurchaseVouchers
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
		FROM tblPurchaseVoucherDetails
		WHERE PurchaseVoucherId = @Id
		GROUP BY SubsidiaryId, Remarks

		--Payable
		IF @PayableAccountId IS NULL
		BEGIN
			RAISERROR('No Payable Account has been set-up.', 11, 1)
			RETURN
		END

		INSERT INTO tblJournalDetails(JournalId, AccountId, SubsidiaryId, Debit, Credit, Remarks)
		SELECT @JournalId, @PayableAccountId, SubsidiaryId, 0, NetAmount, Remarks
		FROM tblPurchaseVouchers
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
			FROM tblSalesVouchers
			WHERE Id = @Id
				AND @JournalTypeId = 3
	
			SET @JournalId = SCOPE_IDENTITY()

			UPDATE tblSalesVouchers
			SET JournalId = @JournalId
			WHERE Id = @Id

			SET @IsNew = 1
		END
		ELSE
		BEGIN
			UPDATE j
			SET j.[Date] = sv.[Date],
				j.ReferenceNo = sv.ReferenceNo,
				j.ReferenceNo2 = sv.ReferenceNo2,
				j.ModifiedById = sv.ModifiedById,
				j.DateModified = sv.DateModified
			FROM tblJournals j
				INNER JOIN tblSalesVouchers sv ON sv.JournalId = j.Id
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
		FROM tblSalesVouchers
		WHERE Id = @Id

		--Sales
		INSERT INTO tblJournalDetails(JournalId, AccountId, SubsidiaryId, Debit, Credit, Remarks)
		SELECT @JournalId, AccountId, SubsidiaryId, 0, SUM(GrossAmount), Remarks
		FROM tblSalesVoucherDetails
		WHERE SalesVoucherId = @Id
		GROUP BY AccountId, SubsidiaryId, Remarks

		--Output VAT
		IF EXISTS(
			SELECT *
			FROM tblSalesVouchers
			WHERE Id = @Id
				AND VATAmount > 0
		)
		AND @OutputVATAccountId IS NULL
		BEGIN
			RAISERROR('No Output VAT Account has been set-up.', 11, 1)
			RETURN
		END

		INSERT INTO tblJournalDetails(JournalId, AccountId, SubsidiaryId, Debit, Credit, Remarks)
		SELECT @JournalId, @InputVATAccountId, SubsidiaryId, 0, SUM(VATAmount), Remarks
		FROM tblPurchaseVoucherDetails
		WHERE PurchaseVoucherId = @Id
		GROUP BY SubsidiaryId, Remarks
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
END
GO

