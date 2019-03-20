IF OBJECT_ID('uspAddSystemPrintout') IS NOT NULL
	DROP PROCEDURE uspAddSystemPrintout
GO

CREATE PROCEDURE uspAddSystemPrintout(@FormCaption VARCHAR(100), @Report VARCHAR(100), @PrintoutFormName VARCHAR(100), @Index INT, @Active BIT = 1)
AS
SET NOCOUNT ON

IF NOT EXISTS(SELECT * FROM tblSystemPrintouts WHERE Report = @Report AND FormCaption = @FormCaption)
	INSERT INTO tblSystemPrintouts(FormCaption, Report, PrintoutFormName, [Index], Active)
	SELECT @FormCaption, @Report, @PrintoutFormName, @Index, @Active
ELSE
	UPDATE tblSystemPrintouts
	SET PrintoutFormName = @PrintoutFormName,
		[Index] = @Index,
		Active = @Active
	WHERE Report = @Report
		AND FormCaption = @FormCaption
GO

