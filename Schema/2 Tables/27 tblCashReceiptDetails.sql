IF OBJECT_ID('tblCashReceiptDetails') IS NULL
	CREATE TABLE tblCashReceiptDetails(
		Id INT IDENTITY(1, 1) NOT NULL,
		CashReceiptId INT NOT NULL,
		PaymentMethodId INT NOT NULL,
		Amount MONEY NOT NULL CONSTRAINT DF_tblCashReceiptDetails_Amount DEFAULT 0,
		CheckNo VARCHAR(50) NULL,
		CheckDate DATETIME NULL,
		Remarks VARCHAR(1000) NULL,
	)
GO

IF OBJECT_ID('tblCashReceiptDetails_PK') IS NOT NULL
	ALTER TABLE tblCashReceiptDetails DROP CONSTRAINT tblCashReceiptDetails_PK
GO

ALTER TABLE tblCashReceiptDetails ADD CONSTRAINT tblCashReceiptDetails_PK PRIMARY KEY(Id)
GO

