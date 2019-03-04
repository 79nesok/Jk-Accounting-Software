IF OBJECT_ID('tblCashDisbursementVoucherBillsDetails') IS NULL
	CREATE TABLE tblCashDisbursementVoucherBillsDetails(
		Id INT IDENTITY(1, 1) NOT NULL,
		CashDisbursementVoucherId INT NOT NULL,
		SourceId INT NOT NULL,
		AppliedAmount MONEY NOT NULL CONSTRAINT DF_tblCashDisbursementVoucherBillsDetails_AppliedAmount DEFAULT 0,
	)
GO

IF OBJECT_ID('tblCashDisbursementVoucherBillsDetails_PK') IS NOT NULL
	ALTER TABLE tblCashDisbursementVoucherBillsDetails DROP CONSTRAINT tblCashDisbursementVoucherBillsDetails_PK
GO

ALTER TABLE tblCashDisbursementVoucherBillsDetails ADD CONSTRAINT tblCashDisbursementVoucherBillsDetails_PK PRIMARY KEY(Id)
GO

