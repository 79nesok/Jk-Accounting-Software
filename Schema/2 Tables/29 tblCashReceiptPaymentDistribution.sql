IF OBJECT_ID('tblCashReceiptPaymentDistribution') IS NULL
	CREATE TABLE tblCashReceiptPaymentDistribution(
		Id INT IDENTITY(1, 1) NOT NULL,
		CashReceiptId INT NOT NULL,
		CashReceiptDetailId INT NOT NULL,
		InvoiceId INT NOT NULL,
		Amount MONEY NOT NULL CONSTRAINT DF_tblCashReceiptPaymentDistribution_Amount DEFAULT 0,
	)
GO

IF OBJECT_ID('tblCashReceiptPaymentDistribution_PK') IS NOT NULL
	ALTER TABLE tblCashReceiptPaymentDistribution DROP CONSTRAINT tblCashReceiptPaymentDistribution_PK
GO

ALTER TABLE tblCashReceiptPaymentDistribution ADD CONSTRAINT tblCashReceiptPaymentDistribution_PK PRIMARY KEY(Id)
GO

