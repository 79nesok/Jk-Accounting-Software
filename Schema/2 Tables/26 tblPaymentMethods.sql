IF OBJECT_ID('tblPaymentMethods') IS NULL
	CREATE TABLE tblPaymentMethods(
		Id INT IDENTITY(1, 1) NOT NULL,
		CompanyId INT NOT NULL,
		Code VARCHAR(50) NOT NULL,
		Name VARCHAR(100) NULL,
		AccountId INT NOT NULL,
		ForClearing BIT NOT NULL CONSTRAINT DF_tblPaymentMethods_ForClearing DEFAULT 0,
		Remarks VARCHAR(1000) NULL,
		Active BIT NOT NULL CONSTRAINT DEF_tblPaymentMethods_Active DEFAULT 1,
		CreatedById INT NOT NULL,
		DateCreated DATETIME NOT NULL,
		ModifiedById INT NOT NULL,
		DateModified DATETIME NOT NULL,
	)
GO

IF OBJECT_ID('tblPaymentMethods_PK') IS NOT NULL
	ALTER TABLE tblPaymentMethods DROP CONSTRAINT tblPaymentMethods_PK
GO

ALTER TABLE tblPaymentMethods ADD CONSTRAINT tblPaymentMethods_PK PRIMARY KEY(Id)
GO

