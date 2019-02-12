IF OBJECT_ID('tblJournalDetails') IS NULL
	CREATE TABLE tblJournalDetails(
		Id INT IDENTITY(1, 1) NOT NULL,
		JournalId INT NOT NULL,
		AccountId INT NOT NULL,
		SubsidiaryId INT NULL,
		Debit MONEY NOT NULL CONSTRAINT DF_tblJournalDetails_Debit DEFAULT 0,
		Credit MONEY NOT NULL CONSTRAINT DF_tblJournalDetails_Credit DEFAULT 0,
		Remarks VARCHAR(1000) NULL,
	)
GO

IF OBJECT_ID('tblJournalDetails_PK') IS NOT NULL
	ALTER TABLE tblJournalDetails DROP CONSTRAINT tblJournalDetails_PK
GO

ALTER TABLE tblJournalDetails ADD CONSTRAINT tblJournalDetails_PK PRIMARY KEY(Id)
GO

