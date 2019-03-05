IF OBJECT_ID('uspBIRForm2307Details') IS NOT NULL
	DROP PROCEDURE uspBIRForm2307Details
GO

CREATE PROCEDURE uspBIRForm2307Details(@Id INT)
AS
SET NOCOUNT ON

SELECT i.Name AS IncomePaymentsSubjToWTAX,
	atc.Code AS ATC,
	CASE WHEN MONTH(pv.[Date]) % 3 = 1 THEN pvd.GrossAmount ELSE 0 END AS FirstMonth,
	CASE WHEN MONTH(pv.[Date]) % 3 = 2 THEN pvd.GrossAmount ELSE 0 END AS SecondMonth,
	CASE WHEN MONTH(pv.[Date]) % 3 = 0 THEN pvd.GrossAmount ELSE 0 END AS ThirdMonth,
	pvd.GrossAmount AS Total,
	pv.WithholdingTax AS TaxWithheld
FROM tblPurchaseVouchers pv
	INNER JOIN tblSubsidiaries s ON s.Id = pv.SubsidiaryId
	INNER JOIN tblCompanies c ON c.Id = pv.CompanyId
	INNER JOIN tblPurchaseVoucherDetails pvd ON pvd.PurchaseVoucherId = pv.Id
	INNER JOIN tblItems i ON i.Id = pvd.ItemId
		AND i.TypeId = 2
	LEFT OUTER JOIN tblAlphaNumericTaxCodes atc ON atc.Id = s.ATCId
WHERE pv.Id = @Id
GO

