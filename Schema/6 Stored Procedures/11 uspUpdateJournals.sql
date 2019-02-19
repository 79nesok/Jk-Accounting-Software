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

SELECT @Code = Code
FROM tblJournalTypes
WHERE Id = @JournalTypeId

IF @JournalTypeId = 1
	SELECT @JournalId = JournalId,
		@CompanyId = CompanyId
	FROM tblJournalVouchers
	WHERE Id = @Id

IF @IsPost = 1
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

