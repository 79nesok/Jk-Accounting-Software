IF OBJECT_ID('tblSystemLogTableConfig') IS NULL
	CREATE TABLE tblSystemLogTableConfig(
		Id INT IDENTITY(1, 1) NOT NULL,
		TableName VARCHAR(100) NOT NULL,
		Caption VARCHAR(100) NULL,
		SeparatorColumnName VARCHAR(100) NULL,
		SeparatorColumnId INT NULL,
		Track BIT NOT NULL CONSTRAINT DF_tblSystemLogTableConfig_Track DEFAULT 0,
		[Enable] BIT NOT NULL CONSTRAINT DF_tblSystemLogTableConfig_Enable DEFAULT 0,
		TriggerName VARCHAR(100) NULL,
	)
GO

IF OBJECT_ID('tblSystemLogTableConfig_PK') IS NOT NULL
	ALTER TABLE tblSystemLogTableConfig DROP CONSTRAINT tblSystemLogTableConfig_PK
GO

ALTER TABLE tblSystemLogTableConfig ADD CONSTRAINT tblSystemLogTableConfig_PK PRIMARY KEY(Id)
GO

