IF OBJECT_ID('uspAgingOfReceivables') IS NOT NULL
	DROP PROCEDURE uspAgingOfReceivables
GO

CREATE PROCEDURE uspAgingOfReceivables(@CompanyId INT)
AS
SET NOCOUNT ON

SELECT *
FROM (
	SELECT si.Id, si.TransactionNo, si.[Date], si.ReferenceNo, si.ReferenceNo2,
		s.Name AS Customer, si.Balance, DATEDIFF(DAY, si.[Date], GETDATE()) AS Age
	FROM tblSalesInvoices si
		INNER JOIN tblSubsidiaries s ON s.Id = si.SubsidiaryId
	WHERE si.CompanyId = @CompanyId
		AND si.Balance > 0
) tmp
ORDER BY tmp.Age DESC, tmp.Customer
GO

