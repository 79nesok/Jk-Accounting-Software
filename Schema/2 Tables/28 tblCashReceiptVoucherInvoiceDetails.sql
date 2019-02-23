IF OBJECT_ID('tblCashReceiptVoucherInvoiceDetails') IS NULL
	CREATE TABLE tblCashReceiptVoucherInvoiceDetails(
		Id INT IDENTITY(1, 1) NOT NULL,
		CashReceiptVoucherId INT NOT NULL,
		SourceId INT NOT NULL,
		AppliedAmount MONEY NOT NULL CONSTRAINT DF_tblCashReceiptVoucherInvoiceDetails_AppliedAmount DEFAULT 0,
	)
GO

IF OBJECT_ID('tblCashReceiptVoucherInvoiceDetails_PK') IS NOT NULL
	ALTER TABLE tblCashReceiptVoucherInvoiceDetails DROP CONSTRAINT tblCashReceiptVoucherInvoiceDetails_PK
GO

ALTER TABLE tblCashReceiptVoucherInvoiceDetails ADD CONSTRAINT tblCashReceiptVoucherInvoiceDetails_PK PRIMARY KEY(Id)
GO

