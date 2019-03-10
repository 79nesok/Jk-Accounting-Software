IF OBJECT_ID('tblBillsPaymentPaymentDisbtribution') IS NULL
	CREATE TABLE tblBillsPaymentPaymentDisbtribution(
		Id INT IDENTITY(1, 1) NOT NULL,
		BillsPaymentId INT NOT NULL,
		BillsPaymentDetailId INT NOT NULL,
		BillId INT NOT NULL,
		Amount MONEY NOT NULL CONSTRAINT DF_tblBillsPaymentPaymentDisbtribution_Amount DEFAULT 0,
	)
GO

IF OBJECT_ID('tblBillsPaymentPaymentDisbtribution_PK') IS NOT NULL
	ALTER TABLE tblBillsPaymentPaymentDisbtribution DROP CONSTRAINT tblBillsPaymentPaymentDisbtribution_PK
GO

ALTER TABLE tblBillsPaymentPaymentDisbtribution ADD CONSTRAINT tblBillsPaymentPaymentDisbtribution_PK PRIMARY KEY(Id)
GO

