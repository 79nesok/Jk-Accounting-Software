IF OBJECT_ID('tblGeneralLedger') IS NULL
	CREATE TABLE tblGeneralLedger(
		CompanyId INT NOT NULL,
		[Date] DATETIME NOT NULL,
		AccountId INT NOT NULL,
		Debit MONEY NOT NULL CONSTRAINT DF_tblGeneralLedger_Debit DEFAULT 0,
		Credit MONEY NOT NULL CONSTRAINT DF_tblGeneralLedger_Credit DEFAULT 0,
	)
GO

IF OBJECT_ID('tblGeneralLedger_PK') IS NOT NULL
	ALTER TABLE tblGeneralLedger DROP CONSTRAINT tblGeneralLedger_PK
GO

ALTER TABLE tblGeneralLedger ADD CONSTRAINT tblGeneralLedger_PK PRIMARY KEY(CompanyId, [Date], AccountId)
GO

