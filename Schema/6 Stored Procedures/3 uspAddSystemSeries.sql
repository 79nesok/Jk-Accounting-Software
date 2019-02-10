IF OBJECT_ID('uspAddSystemSeries') IS NOT NULL
	DROP PROCEDURE uspAddSystemSeries
GO

CREATE PROCEDURE uspAddSystemSeries(@Code VARCHAR(50))
AS
SET NOCOUNT ON

IF NOT EXISTS(SELECT * FROM tblSystemSeries WHERE Code = @Code)
	INSERT INTO tblSystemSeries(CompanyId, Code, NextNumber)
	SELECT c.Id, @Code, 1
	FROM tblCompanies c
GO

