IF OBJECT_ID('tblBillsPaymentAccountDetails') IS NULL
	CREATE TABLE tblBillsPaymentAccountDetails(
		Id INT IDENTITY(1, 1) NOT NULL,
		BillsPaymentId INT NOT NULL,
		AccountId INT NOT NULL,
		SubsidiaryId INT NULL,
		Debit MONEY NOT NULL CONSTRAINT DF_tblBillsPaymentAccountDetails_Debit DEFAULT 0,
		Credit MONEY NOT NULL CONSTRAINT DF_tblBillsPaymentAccountDetails_Credit DEFAULT 0,
		Remarks VARCHAR(1000) NULL,
	)
GO

IF OBJECT_ID('tblBillsPaymentAccountDetails_PK') IS NOT NULL
	ALTER TABLE tblBillsPaymentAccountDetails DROP CONSTRAINT tblBillsPaymentAccountDetails_PK
GO

ALTER TABLE tblBillsPaymentAccountDetails ADD CONSTRAINT tblBillsPaymentAccountDetails_PK PRIMARY KEY(Id)
GO

