IF OBJECT_ID('tblSystemLogColumnConfig') IS NULL
	CREATE TABLE tblSystemLogColumnConfig(
		Id INT IDENTITY(1, 1) NOT NULL,
		TableId INT NOT NULL,
		ColumnName VARCHAR(100) NOT NULL,
		Caption VARCHAR(100) NULL,
		DataType VARCHAR(100) NOT NULL,
		[Index] INT NOT NULL CONSTRAINT DF_tblSystemLogColumnConfig_Index DEFAULT 0,
		Track BIT NOT NULL CONSTRAINT DF_tblSystemLogColumnConfig_Track DEFAULT 0,
		TableSource VARCHAR(100) NULL,
	)
GO

IF OBJECT_ID('tblSystemLogColumnConfig_PK') IS NOT NULL
	ALTER TABLE tblSystemLogColumnConfig DROP CONSTRAINT tblSystemLogColumnConfig_PK
GO

ALTER TABLE tblSystemLogColumnConfig ADD CONSTRAINT tblSystemLogColumnConfig_PK PRIMARY KEY(Id)
GO

