IF OBJECT_ID('tblJournalVouchers') IS NULL
	CREATE TABLE tblJournalVouchers(
		Id INT IDENTITY(1, 1) NOT NULL,
		CompanyId INT NOT NULL,
		TransactionNo VARCHAR(50) NOT NULL,
		[Date] DATETIME NOT NULL,
		ReferenceNo VARCHAR(50) NOT NULL,
		ReferenceNo2 VARCHAR(50) NULL,
		Remarks VARCHAR(1000) NULL,
		JournalId INT NULL,
		Posted BIT NOT NULL CONSTRAINT DF_tblJournalVouchers_Posted DEFAULT 0,
		Voided BIT NOT NULL CONSTRAINT DF_tblJournalVouchers_Voided DEFAULT 0,
		VoidedById INT NULL,
		DateVoided DATETIME NULL,
		CreatedById INT NOT NULL,
		DateCreated DATETIME NOT NULL,
		ModifiedById INT NOT NULL,
		DateModified DATETIME NOT NULL,
	)
GO

IF OBJECT_ID('tblJournalVouchers_PK') IS NOT NULL
	ALTER TABLE tblJournalVouchers DROP CONSTRAINT tblJournalVouchers_PK
GO

ALTER TABLE tblJournalVouchers ADD CONSTRAINT tblJournalVouchers_PK PRIMARY KEY(Id)
GO

