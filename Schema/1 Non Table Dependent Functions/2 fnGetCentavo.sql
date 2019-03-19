IF OBJECT_ID('fnGetCenvato') IS NOT NULL
	DROP FUNCTION fnGetCenvato
GO

CREATE FUNCTION fnGetCenvato(@Number AS NUMERIC(19, 2))
RETURNS VARCHAR(10)
AS
BEGIN
	DECLARE @Result VARCHAR(10)

	SET @Result =
		CASE
			WHEN @Number - CAST(@Number AS INT) <> 0
				THEN ' ' + CAST(CAST((@Number - CAST(@Number AS INT)) * 100 AS INT) AS VARCHAR) + '/100'
			ELSE
				''
		END

	RETURN @Result
END
GO

