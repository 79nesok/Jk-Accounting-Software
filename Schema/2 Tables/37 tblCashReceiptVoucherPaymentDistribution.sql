IF OBJECT_ID('tblCashDisbursementVoucherPaymentDistribution') IS NULL
	CREATE TABLE tblCashDisbursementVoucherPaymentDistribution(
		Id INT IDENTITY(1, 1) NOT NULL,
		CashDisbursementVoucherId INT NOT NULL,
		CashDisbursementVoucherDetailId INT NOT NULL,
		BillId INT NOT NULL,
		Amount MONEY NOT NULL CONSTRAINT DF_tblCashDisbursementVoucherPaymentDistribution_Amount DEFAULT 0,
	)
GO

IF OBJECT_ID('tblCashDisbursementVoucherPaymentDistribution_PK') IS NOT NULL
	ALTER TABLE tblCashDisbursementVoucherPaymentDistribution DROP CONSTRAINT tblCashDisbursementVoucherPaymentDistribution_PK
GO

ALTER TABLE tblCashDisbursementVoucherPaymentDistribution ADD CONSTRAINT tblCashDisbursementVoucherPaymentDistribution_PK PRIMARY KEY(Id)
GO

