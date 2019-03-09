IF OBJECT_ID('uspUpdateLedgers') IS NOT NULL
	DROP PROCEDURE uspUpdateLedgers
GO

CREATE PROCEDURE uspUpdateLedgers(@Id INT, @IsPost BIT)
AS
SET NOCOUNT ON

DECLARE @CompanyId INT
DECLARE @Date DATETIME
DECLARE @tmp TABLE(AccountId INT, Debit MONEY, Credit MONEY PRIMARY KEY(AccountId))
DECLARE @tmp2 TABLE(SubsidiaryId  INT, AccountId INT, Debit MONEY, Credit MONEY PRIMARY KEY(SubsidiaryId, AccountId))

SELECT @CompanyId = j.CompanyId,
	@Date = j.[Date]
FROM tblJournals j
WHERE j.Id = @Id

INSERT INTO @tmp(AccountId, Debit, Credit)
SELECT jd.AccountId, SUM(jd.Debit), SUM(jd.Credit)
FROM tblJournalDetails jd
WHERE jd.JournalId = @Id
GROUP BY jd.AccountId

INSERT INTO @tmp2(SubsidiaryId, AccountId, Debit, Credit)
SELECT jd.SubsidiaryId, jd.AccountId, SUM(jd.Debit), SUM(jd.Credit)
FROM tblJournalDetails jd
WHERE jd.JournalId = @Id
	AND  jd.SubsidiaryId IS NOT NULL
GROUP BY jd.SubsidiaryId, jd.AccountId

IF @IsPost = 1
BEGIN
	--General Ledger
	UPDATE gl
	SET	gl.Debit = gl.Debit + CASE WHEN gl.[Date] = @Date THEN t.Debit ELSE 0 END,
		gl.Credit = gl.Credit + CASE WHEN gl.[Date] = @Date THEN t.Credit ELSE 0 END,
		gl.Balance = gl.Balance + (t.Debit - t.Credit)
	FROM tblGeneralLedger gl
		INNER JOIN @tmp t ON gl.AccountId = t.AccountId
	WHERE gl.CompanyId = @CompanyId
		AND gl.[Date] >= @Date

	INSERT INTO tblGeneralLedger(CompanyId, [Date], AccountId, Debit, Credit, Balance)
	SELECT @CompanyId, @Date, t.AccountId, t.Debit, t.Credit, ISNULL((
		SELECT gl2.Balance
		FROM tblGeneralLedger gl2
		WHERE gl2.CompanyId = @CompanyId
			AND gl2.AccountId = t.AccountId
			AND gl2.[Date] = (
				SELECT MAX(gl3.[Date])
				FROM tblGeneralLedger gl3
				WHERE gl3.CompanyId = @CompanyId
					AND gl3.AccountId = gl2.AccountId
					AND gl3.[Date] < @Date
			)
		), 0) + (t.Debit - t.Credit)
	FROM @tmp t
	WHERE NOT EXISTS(
		SELECT *
		FROM tblGeneralLedger gl
		WHERE gl.CompanyId = @CompanyId
			AND gl.[Date] = @Date
			AND gl.AccountId = t.AccountId
	)

	--Subsidiary Ledger
	UPDATE sl
	SET	sl.Debit = sl.Debit + CASE WHEN sl.[Date] = @Date THEN t.Debit ELSE 0 END,
		sl.Credit = sl.Credit + CASE WHEN sl.[Date] = @Date THEN t.Credit ELSE 0 END,
		sl.Balance = sl.Balance + (t.Debit - t.Credit)
	FROM tblSubsidiaryLedger sl
		INNER JOIN @tmp2 t ON sl.SubsidiaryId = t.SubsidiaryId
			AND sl.AccountId = t.AccountId
	WHERE sl.CompanyId = @CompanyId
		AND sl.[Date] >= @Date

	INSERT INTO tblSubsidiaryLedger(CompanyId, SubsidiaryId, AccountId, [Date], Debit, Credit, Balance)
	SELECT @CompanyId, t.SubsidiaryId, t.AccountId, @Date, t.Debit, t.Credit, ISNULL((
		SELECT sl2.Balance
		FROM tblSubsidiaryLedger sl2
		WHERE sl2.CompanyId = @CompanyId
			AND sl2.SubsidiaryId = t.SubsidiaryId
			AND sl2.AccountId = t.AccountId
			AND sl2.[Date] = (
				SELECT MAX(sl3.[Date])
				FROM tblSubsidiaryLedger sl3
				WHERE sl3.CompanyId = @CompanyId
					AND sl3.SubsidiaryId = sl2.SubsidiaryId
					AND sl3.AccountId = sl2.AccountId
					AND sl3.[Date] < @Date
			)
	), 0) + (t.Debit - t.Credit)
	FROM @tmp2 t
	WHERE NOT EXISTS(
		SELECT *
		FROM tblSubsidiaryLedger sl
		WHERE sl.CompanyId = @CompanyId
			AND sl.SubsidiaryId = t.SubsidiaryId
			AND sl.AccountId = t.AccountId
			AND sl.[Date] = @Date
	)
END
ELSE IF @IsPost = 0
BEGIN
	--General Ledger
	UPDATE gl
	SET	gl.Debit = gl.Debit - CASE WHEN gl.[Date] = @Date THEN t.Debit ELSE 0 END,
		gl.Credit = gl.Credit - CASE WHEN gl.[Date] = @Date THEN t.Credit ELSE 0 END,
		gl.Balance = gl.Balance - (t.Debit - t.Credit)
	FROM tblGeneralLedger gl
		INNER JOIN @tmp t ON gl.AccountId = t.AccountId
	WHERE gl.CompanyId = @CompanyId
		AND gl.[Date] >= @Date

	DELETE gl
	FROM tblGeneralLedger gl
		INNER JOIN @tmp t ON t.AccountId = gl.AccountId
	WHERE gl.CompanyId = @CompanyId
		AND gl.[Date] = @Date
		AND gl.Balance = 0

	DELETE gl
	FROM tblGeneralLedger gl
		INNER JOIN @tmp t ON t.AccountId = gl.AccountId
	WHERE gl.CompanyId = @CompanyId
		AND gl.[Date] = @Date
		AND gl.Debit = 0
		AND gl.Credit = 0

	--Subsidiary Ledger
	UPDATE sl
	SET	sl.Debit = sl.Debit - CASE WHEN sl.[Date] = @Date THEN t.Debit ELSE 0 END,
		sl.Credit = sl.Credit - CASE WHEN sl.[Date] = @Date THEN t.Credit ELSE 0 END,
		sl.Balance = sl.Balance - (t.Debit - t.Credit)
	FROM tblSubsidiaryLedger sl
		INNER JOIN @tmp2 t ON sl.SubsidiaryId = t.SubsidiaryId
			AND sl.AccountId = t.AccountId
	WHERE sl.CompanyId = @CompanyId
		AND sl.[Date] >= @Date

	DELETE sl
	FROM tblSubsidiaryLedger sl
		INNER JOIN @tmp2 t ON t.SubsidiaryId = sl.SubsidiaryId
			AND t.AccountId = sl.AccountId
	WHERE sl.CompanyId = @CompanyId
		AND sl.[Date] = @Date
		AND sl.Balance = 0

	DELETE sl
	FROM tblSubsidiaryLedger sl
		INNER JOIN @tmp2 t ON t.SubsidiaryId = sl.SubsidiaryId
			AND t.AccountId = sl.AccountId
	WHERE sl.CompanyId = @CompanyId
		AND sl.[Date] = @Date
		AND sl.Debit = 0
		AND sl.Credit = 0
END

UPDATE j
	SET j.Posted = @IsPost
	FROM tblJournals j
	WHERE j.Id = @Id
GO

