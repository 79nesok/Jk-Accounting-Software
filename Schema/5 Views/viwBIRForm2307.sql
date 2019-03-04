IF OBJECT_ID('viwBIRForm2307') IS NOT NULL
	DROP VIEW viwBIRForm2307
GO

CREATE VIEW viwBIRForm2307
AS

SELECT pv.Id,
	RIGHT('0' + CAST(MONTH(pv.[Date]) AS VARCHAR), 2) AS [Month],
	RIGHT('0' + CAST(DAY(pv.[Date]) AS VARCHAR), 2) AS [Day],
	RIGHT(CAST(YEAR(pv.[Date]) AS VARCHAR), 2) AS [Year],

	--Payee
	SUBSTRING(s.TIN, 1, 3) AS PayeesTINFirst,
	SUBSTRING(s.TIN, 4, 3) AS PayeesTINSecond,
	SUBSTRING(s.TIN, 7, 3) AS PayeesTINThird,
	SUBSTRING(s.TIN, 10, 3) AS PayeesTINFourth,
	s.Name AS PayeesName,
	s.[Address] AS PayeesRegisteredAddress,
	s.ZIPCode AS PayeesZIPCode,

	--Payor
	SUBSTRING(c.TIN, 1, 3) AS PayorsTINFirst,
	SUBSTRING(c.TIN, 4, 3) AS PayorsTINSecond,
	SUBSTRING(c.TIN, 7, 3) AS PayorsTINThird,
	SUBSTRING(c.TIN, 10, 3) AS PayorsTINFourth,
	c.Name AS PayorsName,
	c.[Address] AS PayorsRegisteredAddress,
	c.ZIPCode AS PayorsZIPCode,

	--Details
	i.Name AS IncomePaymentsSubjToWTAX,
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
GO

