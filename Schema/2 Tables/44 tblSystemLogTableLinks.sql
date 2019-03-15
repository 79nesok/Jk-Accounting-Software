IF OBJECT_ID('tblSystemLogTableLinks') IS NULL
	CREATE TABLE tblSystemLogTableLinks(
		Id INT IDENTITY(1, 1) NOT NULL,
		TableId INT NOT NULL,
		ChildTableId INT NOT NULL,
	)
GO

IF OBJECT_ID('tblSystemLogTableLinks_PK') IS NOT NULL
	ALTER TABLE tblSystemLogTableLinks DROP CONSTRAINT tblSystemLogTableLinks_PK
GO

ALTER TABLE tblSystemLogTableLinks ADD CONSTRAINT tblSystemLogTableLinks_PK PRIMARY KEY(Id)
GO

