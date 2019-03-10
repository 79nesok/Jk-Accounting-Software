IF OBJECT_ID('tblBillsPaymentBillDetails') IS NULL
	CREATE TABLE tblBillsPaymentBillDetails(
		Id INT IDENTITY(1, 1) NOT NULL,
		BillsPaymentId INT NOT NULL,
		SourceId INT NOT NULL,
		AppliedAmount MONEY NOT NULL CONSTRAINT DF_tblBillsPaymentBillDetails_AppliedAmount DEFAULT 0,
	)
GO

IF OBJECT_ID('tblBillsPaymentBillDetails_PK') IS NOT NULL
	ALTER TABLE tblBillsPaymentBillDetails DROP CONSTRAINT tblBillsPaymentBillDetails_PK
GO

ALTER TABLE tblBillsPaymentBillDetails ADD CONSTRAINT tblBillsPaymentBillDetails_PK PRIMARY KEY(Id)
GO

