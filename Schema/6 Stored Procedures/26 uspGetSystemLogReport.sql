IF OBJECT_ID('uspGetSystemLogReport') IS NOT NULL
	DROP PROCEDURE uspGetSystemLogReport
GO

CREATE PROCEDURE uspGetSystemLogReport(@CompanyId INT, @FromDate DATETIME, @ToDate DATETIME, @SubCategory VARCHAR(100))
AS
SET NOCOUNT ON

--Temporary query to provide result on DataSet.xsd, since command is in dynamic query
IF @CompanyId IS NULL
BEGIN
	DECLARE @tmp TABLE([DateTime] DATETIME, [User] VARCHAR(100), Mode VARCHAR(10), Code VARCHAR(50),
		[Column] VARCHAR(100), OldValue VARCHAR(MAX), NewValue VARCHAR(MAX))

	SELECT *
	FROM @tmp

	RETURN
END

DECLARE @CommandText VARCHAR(MAX)
DECLARE @TableName VARCHAR(100)
DECLARE @IdentifierColumnName VARCHAR(100)

SELECT @TableName = TableName,
	@IdentifierColumnName = IdentifierColumnName
FROM tblSystemLogTableConfig
WHERE Caption = @SubCategory

SET @CommandText =
	'
	DECLARE @CompanyId INT
	DECLARE @FromDate DATETIME
	DECLARE @ToDate DATETIME
	DECLARE @SubCategory VARCHAR(100)

	SET @CompanyId = ' + CAST(@CompanyId AS VARCHAR) + '
	SET @FromDate = ''' + CAST(@FromDate AS VARCHAR) + '''
	SET @ToDate = ''' + CAST(@ToDate AS VARCHAR) + '''
	SET @SubCategory = ''' + @SubCategory + '''

	SELECT sl.[DateTime], su.FormalName AS [User],
		CASE
			WHEN sl.New = 1 THEN ''New''
			WHEN sl.Edit = 1 THEN ''Edit''
			WHEN sl.[Delete] = 1 THEN ''Delete''
		END AS Mode,
		tn.' + @IdentifierColumnName + ' AS Code,
		slcc.Caption AS [Column], sl.OldValue, sl.NewValue
	FROM (
		SELECT sl.Id, sl.TableId, sl.ColumnId, sl.CompanyId, sl.MasterId, sl.OldValue,
			sl.NewValue, sl.New, sl.Edit, sl.[Delete], sl.SystemUserId, sl.[DateTime]
		FROM tblSystemLogs sl
			INNER JOIN tblSystemLogTableConfig sltc ON sltc.Id = sl.TableId
		WHERE sl.CompanyId = @CompanyId
			AND CAST(sl.[DateTime] AS DATE) BETWEEN @FromDate AND @ToDate
			AND sltc.Caption = @SubCategory

		UNION ALL

		SELECT sl.Id, sl.TableId, sl.ColumnId, sl.CompanyId, sl.MasterId, sl.OldValue,
			sl.NewValue, sl.New, sl.Edit, sl.[Delete], sl.SystemUserId, sl.[DateTime]
		FROM tblSystemLogs sl
			INNER JOIN tblSystemLogTableLinks sltl ON sltl.ChildTableId = sl.TableId
			INNER JOIN tblSystemLogTableConfig sltc ON sltc.Id = sltl.TableId
		WHERE sl.CompanyId = @CompanyId
			AND CAST(sl.[DateTime] AS DATE) BETWEEN @FromDate AND @ToDate
			AND sltc.Caption = @SubCategory
	) sl
		INNER JOIN tblSystemLogTableConfig sltc ON sltc.Id = sl.TableId
		INNER JOIN tblSystemLogColumnConfig slcc ON slcc.TableId = sltc.Id
			AND slcc.Id = sl.ColumnId
		INNER JOIN tblSystemUsers su ON su.Id = sl.SystemUserId
		INNER JOIN ' + @TableName + ' tn ON tn.Id = sl.MasterId
	ORDER BY sl.Id
	'

EXEC(@CommandText)
GO

