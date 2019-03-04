IF OBJECT_ID('uspAgingOfPayables') IS NOT NULL
	DROP PROCEDURE uspAgingOfPayables
GO

CREATE PROCEDURE uspAgingOfPayables(@CompanyId INT)
AS
SET NOCOUNT ON

SELECT *
FROM (
	SELECT pv.Id, pv.TransactionNo, pv.[Date], pv.ReferenceNo, pv.ReferenceNo2,
		s.Name AS Supplier, pv.Balance, DATEDIFF(DAY, pv.[Date], GETDATE()) AS Age
	FROM tblPurchaseVouchers pv
		INNER JOIN tblSubsidiaries s ON s.Id = pv.SubsidiaryId
	WHERE pv.CompanyId = @CompanyId
) tmp
ORDER BY tmp.Age DESC, tmp.Supplier
GO

