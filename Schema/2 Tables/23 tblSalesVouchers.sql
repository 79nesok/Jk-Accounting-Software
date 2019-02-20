IF OBJECT_ID('tblSalesVouchers') IS NULL
	CREATE TABLE tblSalesVouchers(
		Id INT IDENTITY(1, 1) NOT NULL,
		CompanyId INT NOT NULL,
		TransactionNo VARCHAR(50) NOT NULL,
		[Date] DATETIME NOT NULL,
		ReferenceNo VARCHAR(50) NOT NULL,
		ReferenceNo2 VARCHAR(50) NULL,
		SubsidiaryId INT NOT NULL,
		GrossAmount MONEY NOT NULL CONSTRAINT DF_tblSalesVouchers_GrossAmount DEFAULT 0,
		VATAmount MONEY NOT NULL CONSTRAINT DF_tblSalesVouchers_VATAmount DEFAULT 0,
		DiscountAmount MONEY NOT NULL CONSTRAINT DF_tblSalesVouchers_DiscountAmount DEFAULT 0,
		NetAmount MONEY NOT NULL CONSTRAINT DF_tblSalesVouchers_NetAmount DEFAULT 0,
		PaidAmount MONEY NOT NULL CONSTRAINT DF_tblSalesVouchers_PaidAmount DEFAULT 0,
		Balance AS (NetAmount - PaidAmount),
		Remarks VARCHAR(1000) NULL,
		JournalId INT NULL,
		Posted BIT NOT NULL CONSTRAINT DF_tblSalesVouchers_Posted DEFAULT 0,
		Voided BIT NOT NULL CONSTRAINT DF_tblSalesVouchers_Voided DEFAULT 0,
		VoidedById INT NULL,
		DateVoided DATETIME NULL,
		CreatedById INT NOT NULL,
		DateCreated DATETIME NOT NULL,
		ModifiedById INT NOT NULL,
		DateModified DATETIME NOT NULL,
	)
GO

IF OBJECT_ID('tblSalesVouchers_PK') IS NOT NULL
	ALTER TABLE tblSalesVouchers DROP CONSTRAINT tblSalesVouchers_PK
GO

ALTER TABLE tblSalesVouchers ADD CONSTRAINT tblSalesVouchers_PK PRIMARY KEY(Id)
GO

