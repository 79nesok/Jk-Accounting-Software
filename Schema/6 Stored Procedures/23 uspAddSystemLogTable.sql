IF OBJECT_ID('uspAddSystemLogTable') IS NOT NULL
	DROP PROCEDURE uspAddSystemLogTable
GO

CREATE PROCEDURE uspAddSystemLogTable(@TableName VARCHAR(100), @Caption VARCHAR(100), @Track BIT, @Enable BIT, @SeparatorColumnName VARCHAR(100) = NULL, @SeparatorColumnId INT = NULL)
AS
SET NOCOUNT ON

IF NOT EXISTS(
	SELECT *
	FROM sys.tables
	WHERE name = @TableName
)
BEGIN
	RAISERROR('No table found named: ''%s''', 11, 1, @TableName)
	RETURN
END

IF NOT EXISTS(
	SELECT *
	FROM sys.tables t
		INNER JOIN sys.columns c ON c.object_id = t.object_id
	WHERE t.name = @TableName
		AND c.name = @SeparatorColumnName
)
AND NULLIF(@SeparatorColumnName, '') IS NOT NULL
BEGIN
	RAISERROR('No separator column named: ''%s'' on table: ''%s''', 11, 1, @TableName, @SeparatorColumnName)
	RETURN
END

IF NOT EXISTS(SELECT * FROM tblSystemLogTableConfig WHERE TableName = @TableName AND Caption = @Caption)
	INSERT INTO tblSystemLogTableConfig(TableName, Caption, SeparatorColumnName, SeparatorColumnId, Track, [Enable])
	SELECT @TableName, @Caption, @SeparatorColumnName, @SeparatorColumnId, @Track, @Enable
ELSE
	UPDATE tblSystemLogTableConfig
	SET Caption = @Caption,
		SeparatorColumnName = @SeparatorColumnName,
		SeparatorColumnId = @SeparatorColumnId,
		Track = @Track,
		[Enable] = @Enable
	WHERE TableName = @TableName
		AND Caption = @Caption
GO

