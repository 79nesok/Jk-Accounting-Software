IF OBJECT_ID('tblSalesInvoiceDetails') IS NULL
	CREATE TABLE tblSalesInvoiceDetails(
		Id INT IDENTITY(1, 1) NOT NULL,
		SalesInvoiceId INT NOT NULL,
		ItemId INT NULL,
		AccountId INT NOT NULL,
		SubsidiaryId INT NULL,
		Amount MONEY NOT NULL CONSTRAINT DF_tblSalesInvoiceDetails_Amount DEFAULT 0,
		VATTypeId INT NOT NULL,
		VATRate MONEY NOT NULL,
		VATAmount MONEY NOT NULL CONSTRAINT DF_tblSalesInvoiceDetails_VATAmount DEFAULT 0,
		GrossAmount MONEY NOT NULL CONSTRAINT DF_tblSalesInvoiceDetails_GrossAmount DEFAULT 0,
		DiscountAmount MONEY NOT NULL CONSTRAINT DF_tblSalesInvoiceDetails_DiscountAmount DEFAULT 0,
		Total MONEY NOT NULL CONSTRAINT DF_tblSalesInvoiceDetails_Total DEFAULT 0,
		Remarks VARCHAR(1000) NULL,
	)
GO

IF OBJECT_ID('tblSalesInvoiceDetails_PK') IS NOT NULL
	ALTER TABLE tblSalesInvoiceDetails DROP CONSTRAINT tblSalesInvoiceDetails_PK
GO

ALTER TABLE tblSalesInvoiceDetails ADD CONSTRAINT tblSalesInvoiceDetails_PK PRIMARY KEY(Id)
GO

