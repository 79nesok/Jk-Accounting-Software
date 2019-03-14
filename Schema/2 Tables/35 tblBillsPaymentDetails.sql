IF OBJECT_ID('tblBillsPaymentDetails') IS NULL
	CREATE TABLE tblBillsPaymentDetails(
		Id INT IDENTITY(1, 1) NOT NULL,
		BillsPaymentId INT NOT NULL,
		PaymentMethodId INT NOT NULL,
		Amount MONEY NOT NULL CONSTRAINT DF_tblBillsPaymentDetails_Amount DEFAULT 0,
		CheckNo VARCHAR(50) NULL,
		CheckDate DATETIME NULL,
		Remarks VARCHAR(1000) NULL,
	)
GO

IF OBJECT_ID('tblBillsPaymentDetails_PK') IS NOT NULL
	ALTER TABLE tblBillsPaymentDetails DROP CONSTRAINT tblBillsPaymentDetails_PK
GO

ALTER TABLE tblBillsPaymentDetails ADD CONSTRAINT tblBillsPaymentDetails_PK PRIMARY KEY(Id)
GO

