IF OBJECT_ID('tblCashReceiptVoucherDetails') IS NULL
	CREATE TABLE tblCashReceiptVoucherDetails(
		Id INT IDENTITY(1, 1) NOT NULL,
		CashReceiptVoucherId INT NOT NULL,
		PaymentMethodId INT NOT NULL,
		ReferenceNo VARCHAR(50) NULL,
		Amount MONEY NOT NULL CONSTRAINT DF_tblCashReceiptVoucherDetails_Amount DEFAULT 0,
		Remarks VARCHAR(1000) NULL,
	)
GO

IF OBJECT_ID('tblCashReceiptVoucherDetails_PK') IS NOT NULL
	ALTER TABLE tblCashReceiptVoucherDetails DROP CONSTRAINT tblCashReceiptVoucherDetails_PK
GO

ALTER TABLE tblCashReceiptVoucherDetails ADD CONSTRAINT tblCashReceiptVoucherDetails_PK PRIMARY KEY(Id)
GO

