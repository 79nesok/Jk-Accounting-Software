IF OBJECT_ID('tblSubsidiaryLedger') IS NULL
	CREATE TABLE tblSubsidiaryLedger(
		CompanyId INT NOT NULL,
		SubsidiaryId INT NOT NULL,
		AccountId INT NOT NULL,
		[Date] DATETIME NOT NULL,
		Debit MONEY NOT NULL CONSTRAINT DF_tblSubsidiaryLedger_Debit DEFAULT 0,
		Credit MONEY NOT NULL CONSTRAINT DF_tblSubsidiaryLedger_Credit DEFAULT 0,
		Balance MONEY NOT NULL CONSTRAINT DF_tblSubsidiaryLedger_Balance DEFAULT 0,
	)
GO

IF OBJECT_ID('tblSubsidiaryLedger_PK') IS NOT NULL
	ALTER TABLE tblSubsidiaryLedger DROP CONSTRAINT tblSubsidiaryLedger_PK
GO

ALTER TABLE tblSubsidiaryLedger ADD CONSTRAINT tblSubsidiaryLedger_PK PRIMARY KEY(CompanyId, SubsidiaryId, AccountId, [Date])
GO

