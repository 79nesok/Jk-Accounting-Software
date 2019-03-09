IF OBJECT_ID('tblBillDetails') IS NULL
	CREATE TABLE tblBillDetails(
		Id INT IDENTITY(1, 1) NOT NULL,
		BillId INT NOT NULL,
		ItemId INT NULL,
		AccountId INT NOT NULL,
		SubsidiaryId INT NULL,
		Amount MONEY NOT NULL CONSTRAINT DF_tblBillDetails_Amount DEFAULT 0,
		VATTypeId INT NOT NULL,
		VATRate MONEY NOT NULL,
		VATAmount MONEY NOT NULL CONSTRAINT DF_tblBillDetails_VATAmount DEFAULT 0,
		GrossAmount MONEY NOT NULL CONSTRAINT DF_tblBillDetails_GrossAmount DEFAULT 0,
		ATCId INT NULL,
		WithholdingTax MONEY NOT NULL CONSTRAINT DF_tblBillDetails_WithholdingTax DEFAULT 0,
		DiscountAmount MONEY NOT NULL CONSTRAINT DF_tblBillDetails_DiscountAmount DEFAULT 0,
		Total MONEY NOT NULL CONSTRAINT DF_tblBillDetails_Total DEFAULT 0,
		Remarks VARCHAR(1000) NULL,
	)
GO

IF OBJECT_ID('tblBillDetails_PK') IS NOT NULL
	ALTER TABLE tblBillDetails DROP CONSTRAINT tblBillDetails_PK
GO

ALTER TABLE tblBillDetails ADD CONSTRAINT tblBillDetails_PK PRIMARY KEY(Id)
GO

