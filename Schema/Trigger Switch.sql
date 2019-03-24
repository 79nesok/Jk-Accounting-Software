DECLARE @Disable BIT = 0

DECLARE @tmp TABLE(TriggerName VARCHAR(100), TableName VARCHAR(100))
DECLARE @TriggerName VARCHAR(100)
DECLARE @TableName VARCHAR(100)

INSERT INTO @tmp(TriggerName, TableName)
SELECT st.name AS TriggerName, t.Name AS TableName
FROM sys.triggers st
	INNER JOIN sys.tables t ON t.object_id = st.parent_id

WHILE 1 = 1
BEGIN
	SELECT TOP 1
		@TriggerName = TriggerName,
		@TableName = TableName
	FROM @tmp

	IF @Disable = 1
		EXEC('DISABLE TRIGGER ' + @TriggerName + ' ON ' + @TableName)
	ELSE
		EXEC('ENABLE TRIGGER ' + @TriggerName + ' ON ' + @TableName)

	DELETE
	FROM @tmp
	WHERE TableName = @TableName

	IF NOT EXISTS(SELECT * FROM @tmp)
		BREAK
END
GO

