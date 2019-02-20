IF OBJECT_ID('tblPurchaseVoucherDetails') IS NULL
	CREATE TABLE tblPurchaseVoucherDetails(
		Id INT IDENTITY(1, 1) NOT NULL,
		PurchaseVoucherId INT NOT NULL,
		AccountId INT NOT NULL,
		SubsidiaryId INT NULL,
		Amount MONEY NOT NULL CONSTRAINT DF_tblPurchaseVoucherDetails_Amount DEFAULT 0,
		VATTypeId INT NOT NULL,
		VATRate MONEY NOT NULL,
		VATAmount MONEY NOT NULL CONSTRAINT DF_tblPurchaseVoucherDetails_VATAmount DEFAULT 0,
		GrossAmount MONEY NOT NULL CONSTRAINT DF_tblPurchaseVoucherDetails_GrossAmount DEFAULT 0,
		DiscountAmount MONEY NOT NULL CONSTRAINT DF_tblPurchaseVoucherDetails_DiscountAmount DEFAULT 0,
		Total MONEY NOT NULL CONSTRAINT DF_tblPurchaseVoucherDetails_Total DEFAULT 0,
		Remarks VARCHAR(1000) NULL,
	)
GO

IF OBJECT_ID('tblPurchaseVoucherDetails_PK') IS NOT NULL
	ALTER TABLE tblPurchaseVoucherDetails DROP CONSTRAINT tblPurchaseVoucherDetails_PK
GO

ALTER TABLE tblPurchaseVoucherDetails ADD CONSTRAINT tblPurchaseVoucherDetails_PK PRIMARY KEY(Id)
GO

