IF OBJECT_ID('uspAddSystemLogTable') IS NOT NULL
	DROP PROCEDURE uspAddSystemLogTable
GO

CREATE PROCEDURE uspAddSystemLogTable(@TableName VARCHAR(100), @Caption VARCHAR(100), @Track BIT, @Enable BIT)
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

IF NOT EXISTS(SELECT * FROM tblSystemLogTableConfig WHERE TableName = @TableName AND Caption = @Caption)
	INSERT INTO tblSystemLogTableConfig(TableName, Caption, Track, [Enable])
	SELECT @TableName, @Caption, @Track, @Enable
ELSE
	UPDATE tblSystemLogTableConfig
	SET Caption = @Caption,
		Track = @Track,
		[Enable] = @Enable
	WHERE TableName = @TableName
		AND Caption = @Caption
GO

