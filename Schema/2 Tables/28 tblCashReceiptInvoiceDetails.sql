IF OBJECT_ID('tblCashReceiptInvoiceDetails') IS NULL
	CREATE TABLE tblCashReceiptInvoiceDetails(
		Id INT IDENTITY(1, 1) NOT NULL,
		CashReceiptId INT NOT NULL,
		SourceId INT NOT NULL,
		AppliedAmount MONEY NOT NULL CONSTRAINT DF_tblCashReceiptInvoiceDetails_AppliedAmount DEFAULT 0,
	)
GO

IF OBJECT_ID('tblCashReceiptInvoiceDetails_PK') IS NOT NULL
	ALTER TABLE tblCashReceiptInvoiceDetails DROP CONSTRAINT tblCashReceiptInvoiceDetails_PK
GO

ALTER TABLE tblCashReceiptInvoiceDetails ADD CONSTRAINT tblCashReceiptInvoiceDetails_PK PRIMARY KEY(Id)
GO

