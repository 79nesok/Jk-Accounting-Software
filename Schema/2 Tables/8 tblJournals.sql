IF OBJECT_ID('tblJournals') IS NULL
	CREATE TABLE tblJournals(
		Id INT IDENTITY(1, 1) NOT NULL,
		CompanyId INT NOT NULL,
		JournalTypeId INT NOT NULL,
		TransactionNo VARCHAR(50) NOT NULL,
		ReferenceNo VARCHAR(50) NOT NULL,
		[Date] DATETIME NOT NULL,
		SubsidiaryId INT NULL,
		Remarks VARCHAR(1000) NULL,
		Posted BIT NOT NULL CONSTRAINT DF_tblJournals_Posted DEFAULT 0,
		Voided BIT NOT NULL CONSTRAINT DF_tblJournals_Voided DEFAULT 0,
		VoidedById INT NULL,
		DateVoided DATETIME NULL,
		CreatedById INT NOT NULL,
		DateCreated DATETIME NOT NULL,
		ModifiedById INT NOT NULL,
		DateModified DATETIME NOT NULL,
	)
GO

IF OBJECT_ID('tblJournals_PK') IS NOT NULL
	ALTER TABLE tblJournals DROP CONSTRAINT tblJournals_PK
GO

ALTER TABLE tblJournals ADD CONSTRAINT tblJournals_PK PRIMARY KEY(Id)
GO

