IF OBJECT_ID('tblAlphaNumericTaxCodes') IS NULL
	CREATE TABLE tblAlphaNumericTaxCodes(
		Id INT IDENTITY(1, 1) NOT NULL,
		Code VARCHAR(50) NOT NULL,
		NatureOfIncomePayment VARCHAR(1000) NULL,
		OldRate MONEY NOT NULL CONSTRAINT DF_tblAlphaNumericTaxCodes_OldRate DEFAULT 0,
		NewRate MONEY NOT NULL CONSTRAINT DF_tblAlphaNumericTaxCodes_NewRate DEFAULT 0,
		Remarks VARCHAR(1000) NULL,
		Active BIT NOT NULL CONSTRAINT DF_tblAlphaNumericTaxCodes_Active DEFAULT 1,
		Name AS (Code + '-' + CAST(NewRate AS VARCHAR) + '%'),
	)
GO

IF OBJECT_ID('tblAlphaNumericTaxCodes_PK') IS NOT NULL
	ALTER TABLE tblAlphaNumericTaxCodes DROP CONSTRAINT tblAlphaNumericTaxCodes_PK
GO

ALTER TABLE tblAlphaNumericTaxCodes ADD CONSTRAINT tblAlphaNumericTaxCodes_PK PRIMARY KEY(Id)
GO

