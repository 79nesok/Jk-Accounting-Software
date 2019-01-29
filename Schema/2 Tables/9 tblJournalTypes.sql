IF OBJECT_ID('tblJournalTypes') IS NULL
	CREATE TABLE tblJournalTypes(
		Id INT IDENTITY(1, 1) NOT NULL,
		Code VARCHAR(50) NOT NULL,
		Name VARCHAR(100) NULL,
	)
GO

IF OBJECT_ID('tblJournalTypes_PK') IS NOT NULL
	ALTER TABLE tblJournalTypes DROP CONSTRAINT tblJournalTypes_PK
GO

ALTER TABLE tblJournalTypes ADD CONSTRAINT tblJournalTypes_PK PRIMARY KEY(Id)
GO

