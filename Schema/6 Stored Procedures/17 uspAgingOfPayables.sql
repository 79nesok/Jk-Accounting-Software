IF OBJECT_ID('uspAgingOfPayables') IS NOT NULL
	DROP PROCEDURE uspAgingOfPayables
GO

CREATE PROCEDURE uspAgingOfPayables(@CompanyId INT)
AS
SET NOCOUNT ON

SELECT *
FROM (
	SELECT b.Id, b.TransactionNo, b.[Date], b.ReferenceNo, b.ReferenceNo2,
		s.Name AS Supplier, b.Balance, DATEDIFF(DAY, b.[Date], GETDATE()) AS Age
	FROM tblBills b
		INNER JOIN tblSubsidiaries s ON s.Id = b.SubsidiaryId
	WHERE b.CompanyId = @CompanyId
		AND b.Balance > 0
) tmp
ORDER BY tmp.Age DESC, tmp.Supplier
GO

