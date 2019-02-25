IF OBJECT_ID('uspAgingOfReceivables') IS NOT NULL
	DROP PROCEDURE uspAgingOfReceivables
GO

CREATE PROCEDURE uspAgingOfReceivables(@CompanyId INT)
AS
SET NOCOUNT ON

SELECT *
FROM (
	SELECT sv.Id, sv.TransactionNo, sv.[Date], sv.ReferenceNo, sv.ReferenceNo2,
		s.Name AS Customer, sv.Balance, DATEDIFF(DAY, sv.[Date], GETDATE()) AS Age
	FROM tblSalesVouchers sv
		INNER JOIN tblSubsidiaries s ON s.Id = sv.SubsidiaryId
	WHERE sv.CompanyId = @CompanyId
) tmp
ORDER BY tmp.Age DESC, tmp.Customer
GO

