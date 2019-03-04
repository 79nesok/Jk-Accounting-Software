IF OBJECT_ID('tblCashDisbursementVoucherDetails') IS NULL
	CREATE TABLE tblCashDisbursementVoucherDetails(
		Id INT IDENTITY(1, 1) NOT NULL,
		CashDisbursementVoucherId INT NOT NULL,
		PaymentMethodId INT NOT NULL,
		ReferenceNo VARCHAR(50) NULL,
		Amount MONEY NOT NULL CONSTRAINT DF_tblCashDisbursementVoucherDetails_Amount DEFAULT 0,
		Remarks VARCHAR(1000) NULL,
	)
GO

IF OBJECT_ID('tblCashDisbursementVoucherDetails_PK') IS NOT NULL
	ALTER TABLE tblCashDisbursementVoucherDetails DROP CONSTRAINT tblCashDisbursementVoucherDetails_PK
GO

ALTER TABLE tblCashDisbursementVoucherDetails ADD CONSTRAINT tblCashDisbursementVoucherDetails_PK PRIMARY KEY(Id)
GO

