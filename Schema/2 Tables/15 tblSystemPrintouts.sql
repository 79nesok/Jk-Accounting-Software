IF OBJECT_ID('tblSystemPrintouts') IS NULL
	CREATE TABLE tblSystemPrintouts(
		Id INT IDENTITY(1, 1) NOT NULL,
		FormCaption VARCHAR(100) NOT NULL,
		Report VARCHAR(100) NOT NULL,
		PrintoutFormName VARCHAR(100) NOT NULL,
		[Index] INT NOT NULL CONSTRAINT DF_tblSystemPrintouts_Index DEFAULT 0,
		Active BIT NOT NULL CONSTRAINT DF_tblSystemPrintouts_Active DEFAULT 1,
	)
GO

IF OBJECT_ID('tblSystemPrintouts_PK') IS NOT NULL
	ALTER TABLE tblSystemPrintouts DROP CONSTRAINT tblSystemPrintouts_PK
GO

ALTER TABLE tblSystemPrintouts ADD CONSTRAINT tblSystemPrintouts_PK PRIMARY KEY(Id)
GO

