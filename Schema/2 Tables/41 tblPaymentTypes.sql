IF OBJECT_ID('tblPaymentTypes') IS NULL
	CREATE TABLE tblPaymentTypes(
		Id INT IDENTITY(1, 1) NOT NULL,
		Code VARCHAR(50) NOT NULL,
		Name VARCHAR(100) NULL,
		HasSourceTransaction BIT NOT NULL CONSTRAINT DF_tblPaymentTypes_HasSourceTransaction DEFAULT 0,
	)
GO

IF OBJECT_ID('tblPaymentTypes_PK') IS NOT NULL
	ALTER TABLE tblPaymentTypes DROP CONSTRAINT tblPaymentTypes_PK
GO

ALTER TABLE tblPaymentTypes ADD CONSTRAINT tblPaymentTypes_PK PRIMARY KEY(Id)
GO

