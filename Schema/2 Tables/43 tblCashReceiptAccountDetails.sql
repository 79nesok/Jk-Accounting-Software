IF OBJECT_ID('tblCashReceiptAccountDetails') IS NULL
	CREATE TABLE tblCashReceiptAccountDetails(
		Id INT IDENTITY(1, 1) NOT NULL,
		CashReceiptId INT NOT NULL,
		AccountId INT NOT NULL,
		SubsidiaryId INT NULL,
		Debit MONEY NOT NULL CONSTRAINT DF_tblCashReceiptAccountDetails_Debit DEFAULT 0,
		Credit MONEY NOT NULL CONSTRAINT DF_tblCashReceiptAccountDetails_Credit DEFAULT 0,
		Remarks VARCHAR(1000) NULL,
	)
GO

IF OBJECT_ID('tblCashReceiptAccountDetails_PK') IS NOT NULL
	ALTER TABLE tblCashReceiptAccountDetails DROP CONSTRAINT tblCashReceiptAccountDetails_PK
GO

ALTER TABLE tblCashReceiptAccountDetails ADD CONSTRAINT tblCashReceiptAccountDetails_PK PRIMARY KEY(Id)
GO

