IF OBJECT_ID('tblCashReceiptVoucherPaymentDistribution') IS NULL
	CREATE TABLE tblCashReceiptVoucherPaymentDistribution(
		Id INT IDENTITY(1, 1) NOT NULL,
		CashReceiptVoucherId INT NOT NULL,
		CashReceiptVoucherDetailId INT NOT NULL,
		InvoiceId INT NOT NULL,
		Amount MONEY NOT NULL CONSTRAINT DF_tblCashReceiptVoucherPaymentDistribution_Amount DEFAULT 0,
	)
GO

IF OBJECT_ID('tblCashReceiptVoucherPaymentDistribution_PK') IS NOT NULL
	ALTER TABLE tblCashReceiptVoucherPaymentDistribution DROP CONSTRAINT tblCashReceiptVoucherPaymentDistribution_PK
GO

ALTER TABLE tblCashReceiptVoucherPaymentDistribution ADD CONSTRAINT tblCashReceiptVoucherPaymentDistribution_PK PRIMARY KEY(Id)
GO

