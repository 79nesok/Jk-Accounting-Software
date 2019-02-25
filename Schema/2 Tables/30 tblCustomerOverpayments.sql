IF OBJECT_ID('tblCustomerOverpayments') IS NULL
	CREATE TABLE tblCustomerOverpayments(
		Id INT IDENTITY(1, 1) NOT NULL,
		CompanyId INT NOT NULL,
		TransactionNo VARCHAR(50) NOT NULL,
		[Date] DATETIME NOT NULL,
		ReferenceNo VARCHAR(50) NOT NULL,
		ReferenceNo2 VARCHAR(50) NULL,
		SubsidiaryId INT NOT NULL,
		Remarks VARCHAR(1000) NULL,
		Amount MONEY NOT NULL CONSTRAINT DF_tblCustomerOverpayments_Amount DEFAULT 0,
		AmountApplied MONEY NOT NULL CONSTRAINT DF_tblCustomerOverpayments_AmountApplied DEFAULT 0,
		Balance AS (Amount - AmountApplied),
		SourceId INT NOT NULL,
		Posted BIT NOT NULL CONSTRAINT DF_tblCustomerOverpayments_Posted DEFAULT 0,
		Voided BIT NOT NULL CONSTRAINT DF_tblCustomerOverpayments_Voided DEFAULT 0,
		VoidedById INT NULL,
		DateVoided DATETIME NULL,
		CreatedById INT NOT NULL,
		DateCreated DATETIME NOT NULL,
		ModifiedById INT NOT NULL,
		DateModified DATETIME NOT NULL,
	)
GO

IF OBJECT_ID('tblCustomerOverpayments_PK') IS NOT NULL
	ALTER TABLE tblCustomerOverpayments DROP CONSTRAINT tblCustomerOverpayments_PK
GO

ALTER TABLE tblCustomerOverpayments ADD CONSTRAINT tblCustomerOverpayments_PK PRIMARY KEY(Id)
GO

