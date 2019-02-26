IF OBJECT_ID('tblSalesVoucherDetails') IS NULL
	CREATE TABLE tblSalesVoucherDetails(
		Id INT IDENTITY(1, 1) NOT NULL,
		SalesVoucherId INT NOT NULL,
		ItemId INT NULL,
		AccountId INT NOT NULL,
		SubsidiaryId INT NULL,
		Amount MONEY NOT NULL CONSTRAINT DF_tblSalesVoucherDetails_Amount DEFAULT 0,
		VATTypeId INT NOT NULL,
		VATRate MONEY NOT NULL,
		VATAmount MONEY NOT NULL CONSTRAINT DF_tblSalesVoucherDetails_VATAmount DEFAULT 0,
		GrossAmount MONEY NOT NULL CONSTRAINT DF_tblSalesVoucherDetails_GrossAmount DEFAULT 0,
		DiscountAmount MONEY NOT NULL CONSTRAINT DF_tblSalesVoucherDetails_DiscountAmount DEFAULT 0,
		Total MONEY NOT NULL CONSTRAINT DF_tblSalesVoucherDetails_Total DEFAULT 0,
		Remarks VARCHAR(1000) NULL,
	)
GO

IF OBJECT_ID('tblSalesVoucherDetails_PK') IS NOT NULL
	ALTER TABLE tblSalesVoucherDetails DROP CONSTRAINT tblSalesVoucherDetails_PK
GO

ALTER TABLE tblSalesVoucherDetails ADD CONSTRAINT tblSalesVoucherDetails_PK PRIMARY KEY(Id)
GO

