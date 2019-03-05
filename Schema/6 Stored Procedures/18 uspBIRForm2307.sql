IF OBJECT_ID('uspBIRForm2307') IS NOT NULL
	DROP PROCEDURE uspBIRForm2307
GO

CREATE PROCEDURE uspBIRForm2307(@Id INT)
AS
SET NOCOUNT ON

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
	SUBSTRING(s.TIN, 1, 3) + '-' + SUBSTRING(s.TIN, 4, 3) + '-' + SUBSTRING(s.TIN, 7, 3) + '-' + SUBSTRING(s.TIN, 10, 3) AS PayeesFullTIN,

	--Payor
	SUBSTRING(c.TIN, 1, 3) AS PayorsTINFirst,
	SUBSTRING(c.TIN, 4, 3) AS PayorsTINSecond,
	SUBSTRING(c.TIN, 7, 3) AS PayorsTINThird,
	SUBSTRING(c.TIN, 10, 3) AS PayorsTINFourth,
	c.Name AS PayorsName,
	c.[Address] AS PayorsRegisteredAddress,
	c.ZIPCode AS PayorsZIPCode,
	SUBSTRING(c.TIN, 1, 3) + '-' + SUBSTRING(c.TIN, 4, 3) + '-' + SUBSTRING(c.TIN, 7, 3) + '-' + SUBSTRING(c.TIN, 10, 3) AS PayorsFullTIN

FROM tblPurchaseVouchers pv
	INNER JOIN tblSubsidiaries s ON s.Id = pv.SubsidiaryId
	INNER JOIN tblCompanies c ON c.Id = pv.CompanyId
WHERE pv.Id = @Id
GO

