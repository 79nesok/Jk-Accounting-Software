IF OBJECT_ID('tblPurchaseVouchers') IS NULL
	CREATE TABLE tblPurchaseVouchers(
		Id INT IDENTITY(1, 1) NOT NULL,
		CompanyId INT NOT NULL,
		TransactionNo VARCHAR(50) NOT NULL,
		[Date] DATETIME NOT NULL,
		ReferenceNo VARCHAR(50) NOT NULL,
		ReferenceNo2 VARCHAR(50) NULL,
		SubsidiaryId INT NOT NULL,
		GrossAmount MONEY NOT NULL CONSTRAINT DF_tblPurchaseVouchers_GrossAmount DEFAULT 0,
		VATAmount MONEY NOT NULL CONSTRAINT DF_tblPurchaseVouchers_VATAmount DEFAULT 0,
		DiscountAmount MONEY NOT NULL CONSTRAINT DF_tblPurchaseVouchers_DiscountAmount DEFAULT 0,
		NetAmount MONEY NOT NULL CONSTRAINT DF_tblPurchaseVouchers_NetAmount DEFAULT 0,
		PaidAmount MONEY NOT NULL CONSTRAINT DF_tblPurchaseVouchers_PaidAmount DEFAULT 0,
		Balance AS (NetAmount - PaidAmount),
		Remarks VARCHAR(1000) NULL,
		JournalId INT NULL,
		Posted BIT NOT NULL CONSTRAINT DF_tblPurchaseVouchers_Posted DEFAULT 0,
		Voided BIT NOT NULL CONSTRAINT DF_tblPurchaseVouchers_Voided DEFAULT 0,
		VoidedById INT NULL,
		DateVoided DATETIME NULL,
		CreatedById INT NOT NULL,
		DateCreated DATETIME NOT NULL,
		ModifiedById INT NOT NULL,
		DateModified DATETIME NOT NULL,
	)
GO

IF OBJECT_ID('tblPurchaseVouchers_PK') IS NOT NULL
	ALTER TABLE tblPurchaseVouchers DROP CONSTRAINT tblPurchaseVouchers_PK
GO

ALTER TABLE tblPurchaseVouchers ADD CONSTRAINT tblPurchaseVouchers_PK PRIMARY KEY(Id)
GO

