IF OBJECT_ID('fnNumberToWords') IS NOT NULL
	DROP FUNCTION fnNumberToWords
GO

CREATE FUNCTION fnNumberToWords(@Number AS INT)
RETURNS VARCHAR(1024)
AS
BEGIN
	DECLARE @Below20 TABLE (Id INT IDENTITY(0, 1), Word VARCHAR(32))
	DECLARE @Below100 TABLE (Id INT IDENTITY(2, 1), Word VARCHAR(32))

	INSERT @Below20(Word)
	VALUES
		('Zero'), ('One'), ('Two'), ('Three'),
		('Four'), ('Five'), ('Six'), ('Seven'),
		('Eight'), ('Nine'), ('Ten'), ('Eleven'),
		('Twelve'), ('Thirteen'), ('Fourteen'),
		('Fifteen'), ('Sixteen'), ('Seventeen'),
		('Eighteen'), ('Nineteen')

	INSERT @Below100
	VALUES
		('Twenty'), ('Thirty'), ('Forty'), ('Fifty'),
		('Sixty'), ('Seventy'), ('Eighty'), ('Ninety')

DECLARE @English varchar(1024) =
	(
	SELECT
	CASE
		WHEN @Number = 0
			THEN ''
		WHEN @Number BETWEEN 1 AND 19
			THEN (SELECT Word FROM @Below20 WHERE Id = @Number)
		WHEN @Number BETWEEN 20 AND 99
			THEN (SELECT Word FROM @Below100 WHERE Id = @Number / 10) + ' ' + dbo.fnNumberToWords(@Number % 10)
		WHEN @Number BETWEEN 100 AND 999
			THEN (dbo.fnNumberToWords(@Number / 100)) + ' Hundred ' + dbo.fnNumberToWords(@Number % 100)
		WHEN @Number BETWEEN 1000 AND 999999
			THEN (dbo.fnNumberToWords(@Number / 1000)) + ' Thousand ' + dbo.fnNumberToWords(@Number % 1000)
		WHEN @Number BETWEEN 1000000 AND 999999999
			THEN (dbo.fnNumberToWords(@Number / 1000000)) + ' Million ' + dbo.fnNumberToWords(@Number % 1000000)
	END
	)

SELECT @English = RTRIM(@English)

RETURN (@English)

END
GO

