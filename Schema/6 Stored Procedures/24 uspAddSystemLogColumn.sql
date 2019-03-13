IF OBJECT_ID('uspAddSystemLogColumn') IS NOT NULL
	DROP PROCEDURE uspAddSystemLogColumn
GO

CREATE PROCEDURE uspAddSystemLogColumn(@TableName VARCHAR(100), @ColumnName VARCHAR(100), @Caption VARCHAR(100), @Index INT, @Track BIT, @TableSource VARCHAR(100))
AS
SET NOCOUNT ON

DECLARE @TableId INT
DECLARE @DataType VARCHAR(100)

SELECT @TableId = Id
FROM tblSystemLogTableConfig
WHERE TableName = @TableName

IF @TableId IS NULL
BEGIN
	RAISERROR('No table found named: ''%s''', 11, 1, @TableName)
	RETURN
END

IF NOT EXISTS(
	SELECT *
	FROM sys.tables t
		INNER JOIN sys.columns c ON c.object_id = t.object_id
	WHERE t.name = @TableName
		AND c.name = @ColumnName
)
BEGIN
	RAISERROR('No column found named: ''%s'' on table ''%s''', 11, 1, @ColumnName, @TableName)
	RETURN
END

IF NOT EXISTS(
	SELECT *
	FROM sys.tables t
	WHERE t.name = @TableSource
)
	AND NULLIF(@TableSource, '') IS NOT NULL
BEGIN
	RAISERROR('No tablesource found named: ''%s''', 11, 1, @TableSource)
	RETURN
END

SELECT @DataType = st.name
FROM sys.tables t
	INNER JOIN sys.columns c ON c.object_id = t.object_id
	INNER JOIN sys.types st ON st.system_type_id = c.system_type_id
WHERE t.name = @TableName
	AND c.name = @ColumnName

IF NOT EXISTS(SELECT * FROM tblSystemLogColumnConfig WHERE TableId = @TableId AND ColumnName = @ColumnName)
	INSERT INTO tblSystemLogColumnConfig(TableId, ColumnName, Caption, DataType, [Index], Track, TableSource)
	SELECT Id, @ColumnName, @Caption, @DataType, @Index, @Track, @TableSource
	FROM tblSystemLogTableConfig
	WHERE TableName = @TableName
ELSE
	UPDATE c
	SET c.Caption = @Caption,
		c.DataType = @DataType,
		c.[Index] = @Index,
		c.Track = @Track,
		c.TableSource = @TableSource
	FROM tblSystemLogColumnConfig c
		INNER JOIN tblSystemLogTableConfig t ON t.Id = c.TableId
	WHERE c.ColumnName = @ColumnName
		AND t.TableName = @TableName
GO

