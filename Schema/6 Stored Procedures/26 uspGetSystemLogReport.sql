IF OBJECT_ID('uspGetSystemLogReport') IS NOT NULL
	DROP PROCEDURE uspGetSystemLogReport
GO

CREATE PROCEDURE uspGetSystemLogReport(@CompanyId INT, @SubCategory VARCHAR(100))
AS
SET NOCOUNT ON

DECLARE @CommandText VARCHAR(MAX)
DECLARE @TableName VARCHAR(100)
DECLARE @IdentifierColumnName VARCHAR(100)

SELECT @TableName = TableName,
	@IdentifierColumnName = IdentifierColumnName
FROM tblSystemLogTableConfig
WHERE Caption = @SubCategory

SET @CommandText =
	'
	SELECT tn.' + @IdentifierColumnName + ' AS Code,
		CASE
			WHEN sl.New = 1 THEN ''New''
			WHEN sl.Edit = 1 THEN ''Edit''
			WHEN sl.[Delete] = 1 THEN ''Delete''
		END AS Mode,
		slcc.Caption AS [Column], sl.OldValue, sl.NewValue,
		su.FormalName AS [User], sl.[DateTime]
	FROM tblSystemLogs sl
		INNER JOIN tblSystemLogTableConfig sltc ON sltc.Id = sl.TableId
		INNER JOIN tblSystemLogColumnConfig slcc ON slcc.TableId = sltc.Id
			AND slcc.Id = sl.ColumnId
		INNER JOIN tblSystemUsers su ON su.Id = sl.SystemUserId
		INNER JOIN ' + @TableName + ' tn ON tn.Id = sl.MasterId
	WHERE sl.CompanyId = ' + CAST(@CompanyId AS VARCHAR) + '
		AND sltc.Caption = '''+ @SubCategory + '''
	ORDER BY sl.[DateTime], slcc.[Index]
	'

EXEC(@CommandText)
GO

