--Insert System Log Items
DECLARE @tmp TABLE(Id INT IDENTITY(1, 1), Caption VARCHAR(100) PRIMARY KEY(Id))
DECLARE @Id INT
DECLARE @Caption VARCHAR(100)
DECLARE @LastIndex INT

INSERT INTO @tmp(Caption)
SELECT sltc.Caption
FROM tblSystemLogTableConfig sltc
WHERE sltc.Track = 1
	AND NOT EXISTS(
		SELECT *
		FROM tblSystemLogTableLinks sltl
		WHERE sltl.ChildTableId = sltc.Id
	)
ORDER BY sltc.Caption

SELECT @LastIndex = [Index]
FROM tblSystemSubCategories
WHERE Name = 'System Logs'

WHILE 1 = 1
BEGIN
	SELECT TOP 1
		@Id = Id,
		@Caption = Caption
	FROM @tmp

	SET @LastIndex = @LastIndex + 1

	EXEC uspAddSystemSubCategory @Category = 'Report', @Parent = 'System Logs', @Name = @Caption, @ListForm = 'ESystemLogsReportForm', @MasterForm = NULL, @Index = @LastIndex

	DELETE
	FROM @tmp
	WHERE Id = @Id

	IF NOT EXISTS(SELECT * FROM @tmp)
		BREAK
END

--Create all triggers
DECLARE @table TABLE(TableId INT)
DECLARE @TableId INT

INSERT INTO @table(TableId)
SELECT Id
FROM tblSystemLogTableConfig sltc
WHERE Track = 1

WHILE 1 = 1
BEGIN
	SELECT TOP 1
		@TableId = TableId
	FROM @table

	EXEC uspCreateTrigger @TableId

	UPDATE tblSystemLogTableConfig
	SET [Enable] = 1
	WHERE Id = @TableId

	DELETE
	FROM @table
	WHERE TableId = @TableId

	IF NOT EXISTS(SELECT * FROM @table)
		BREAK
END
GO

