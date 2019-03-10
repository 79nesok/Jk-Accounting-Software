IF OBJECT_ID('tblBillsPayment') IS NULL
	CREATE TABLE tblBillsPayment(
		Id INT IDENTITY(1, 1) NOT NULL,
		CompanyId INT NOT NULL,
		TransactionNo VARCHAR(50) NOT NULL,
		[Date] DATETIME NOT NULL,
		ReferenceNo VARCHAR(50) NOT NULL,
		ReferenceNo2 VARCHAR(50) NULL,
		SubsidiaryId INT NOT NULL,
		Remarks VARCHAR(1000) NULL,
		AmountPaid MONEY NOT NULL CONSTRAINT DF_tblBillsPayment_AmountPaid DEFAULT 0,
		AmountApplied MONEY NOT NULL CONSTRAINT DF_tblBillsPayment_AmountApplied DEFAULT 0,
		Balance AS (AmountPaid - AmountApplied),
		JournalId INT NULL,
		Posted BIT NOT NULL CONSTRAINT DF_tblBillsPayment_Posted DEFAULT 0,
		Voided BIT NOT NULL CONSTRAINT DF_tblBillsPayment_Voided DEFAULT 0,
		VoidedById INT NULL,
		DateVoided DATETIME NULL,
		CreatedById INT NOT NULL,
		DateCreated DATETIME NOT NULL,
		ModifiedById INT NOT NULL,
		DateModified DATETIME NOT NULL,
	)
GO

IF OBJECT_ID('tblBillsPayment_PK') IS NOT NULL
	ALTER TABLE tblBillsPayment DROP CONSTRAINT tblBillsPayment_PK
GO

ALTER TABLE tblBillsPayment ADD CONSTRAINT tblBillsPayment_PK PRIMARY KEY(Id)
GO

