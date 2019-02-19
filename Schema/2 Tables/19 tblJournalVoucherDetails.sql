IF OBJECT_ID('tblJournalVoucherDetails') IS NULL
	CREATE TABLE tblJournalVoucherDetails(
		Id INT IDENTITY(1, 1) NOT NULL,
		JournalVoucherId INT NOT NULL,
		AccountId INT NOT NULL,
		SubsidiaryId INT NULL,
		Debit MONEY NOT NULL CONSTRAINT DF_tblJournalVoucherDetails_Debit DEFAULT 0,
		Credit MONEY NOT NULL CONSTRAINT DF_tblJournalVoucherDetails_Credit DEFAULT 0,
		Remarks VARCHAR(1000) NULL,
	)
GO

IF OBJECT_ID('tblJournalVoucherDetails_PK') IS NOT NULL
	ALTER TABLE tblJournalVoucherDetails DROP CONSTRAINT tblJournalVoucherDetails_PK
GO

ALTER TABLE tblJournalVoucherDetails ADD CONSTRAINT tblJournalVoucherDetails_PK PRIMARY KEY(Id)
GO

